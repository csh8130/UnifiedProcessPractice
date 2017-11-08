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
    public partial class 식자재_발주_등록 : UserControl
    {
        public 식자재_발주_등록()
        {
            InitializeComponent();
        }

        /*
        작성일시 : 2017-11-09
        설계자 : 최승혁
        목적 : 기능 Load시 초기화를 위해 호출되는 기능들
        combobox에 항목을 미리 추가해 두기위한 코드가있다
        */
        private void 식자재_발주_등록_Load(object sender, EventArgs e)
        {
            DataTable table = ingredientTableAdapter1.GetData();
            for(int i=0;i<table.Rows.Count;i++) //식자재 id combobox를 채운다
            {
                ingredientCombobox.Items.Add(table.Rows[i][0]);
            }

            table = businessCompanyTableAdapter1.GetData();
            for (int i = 0; i < table.Rows.Count; i++) //공급업체 name combobox를 채운다
            {
                businessNameCombobox.Items.Add(table.Rows[i][0]);
            }

            table = employeeTableAdapter1.GetData();
            for (int i = 0; i < table.Rows.Count; i++) //직원 번호 combobox를 채운다
            {
                employeeNumCombobox.Items.Add(table.Rows[i][0]);
            }

            //단위 combobox에 추가
            unitComboBox.Items.Add("L");
            unitComboBox.Items.Add("mL");
            unitComboBox.Items.Add("kg");
            unitComboBox.Items.Add("g");
            unitComboBox.Items.Add("t");
            unitComboBox.Items.Add("개");
            unitComboBox.Items.Add("포기");
            unitComboBox.Items.Add("포대");
            unitComboBox.Items.Add("cm");
            unitComboBox.Items.Add("m");
        }

        /*
        작성일시 : 2017-11-09
        설계자 : 최승혁
        목적 : 식자재 ID 콤보 박스에서 항목을 클릭했을때 호출 되는 기능
        식자재명을 사용자에게 TextBox로 보여준다
        */
        private void ingredientCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ingredientCombobox.SelectedIndex;
            String value = ingredientCombobox.Items[index].ToString();
            DataTable table = ingredientTableAdapter1.GetDataByID(value);
            ingredientNumberTextBox.Text = table.Rows[0][1].ToString();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = -1;

                DataTable table = purchaseOrderTableAdapter.GetData();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    String tempId = table.Rows[i][0].ToString();
                    int curruntNum = int.Parse(tempId.Substring(2)); //id값은 POxxxx 로 생겼다.. 앞의 PO를 제거한다.
                    if (id < curruntNum)
                        id = curruntNum;
                }
                id = id + 1; //기존의 id값에서 1증가시킨다
                string insertId = "PO" + 0 + 0 + id;

                purchaseOrderTableAdapter.Insert(insertId, ingredientCombobox.Text, orderDateDateTimePicker.Value, unitComboBox.Text, int.Parse(amountTextBox.Text), int.Parse(priceTextBox.Text), isEndedCheckBox.Checked, employeeNumCombobox.Text, businessNameCombobox.Text);

                MessageBox.Show("발주번호: " + insertId + '\n' + "등록 완료되었습니다");
            }
            catch (Exception ee)
            {
                MessageBox.Show("발주등록 실패 하였습니다"+ '\n' + "원인 : "+ ee.Message);
            }
        }
    }
}
