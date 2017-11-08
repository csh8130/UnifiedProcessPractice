using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnifiedProcessPractice
{
    public partial class 식자재_반품_등록 : UserControl
    {
        public 식자재_반품_등록()
        {
            InitializeComponent();
        }

        /*
        작성일시 : 2017-11-09
        설계자 : 최승혁
        목적 : 기능 Load시 초기화를 위해 호출되는 기능들
        combobox에 항목을 미리 추가해 두기위한 코드가있다
        */
        private void 식자재_반품_등록_Load(object sender, EventArgs e)
        {
            DataTable table = purchaseOrderTableAdapter1.GetData();
            for(int i=0;i<table.Rows.Count;i++)
            {
                orderNumberCombobox.Items.Add(table.Rows[i][0]); //발주번호 콤보박스에 추가
            }

            table = ingredientTableAdapter1.GetData();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                ingredNumCombobox.Items.Add(table.Rows[i][0]); //식자재번호 콤보박스에 추가
            }
        }

        /*
        작성일시 : 2017-11-09
        설계자 : 최승혁
        목적 : 반품 등록 기능
        */
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable table = returnTableAdapter1.GetData();

                int id = -1;
                string id_string;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    id_string = table.Rows[i][0].ToString();
                    int tempId = int.Parse(id_string.Substring(2)); // 반품번호는 RTxxxxx 로 되어있다
                    if (id < tempId)
                        id = tempId;
                }
                id_string = "RT" + 0 + 0 + (id + 1);

                returnTableAdapter1.Insert(id_string, ingredientNameTextbox.Text, dateTimePicker1.Value, reasonTextBox1.Text, DateTime.Today, false, orderNumberCombobox.Text, ingredNumCombobox.Text);
                MessageBox.Show("반품 등록 성공 : " + "\n반품번호 : " + id_string);
            }
            catch (Exception ee)
            {
                MessageBox.Show("반품 등록 실패 : " + "\n이유 : " + ee.Message);
            }
        }

        /*
        작성일시 : 2017-11-09
        설계자 : 최승혁
        목적 : 식자재 번호 콤보박스를 선택했을떄 조회되는 정보들 쿼리문 호출
        */
        private void ingredNumCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index =  ingredNumCombobox.SelectedIndex;
            string ingredientNum = ingredNumCombobox.Items[index].ToString();

            DataTable table = ingredientTableAdapter1.GetDataByID(ingredientNum);
            dateTimePicker1.Value = (DateTime)table.Rows[0][2];
            ingredientNameTextbox.Text = table.Rows[0][1].ToString();
        }
    }
}
