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
    public partial class 식자재_반품_조회 : UserControl
    {
        public 식자재_반품_조회()
        {
            InitializeComponent();
        }

        /*
        작성일시 : 2017-11-09
        설계자 : 최승혁
        목적 : 기능 Load시 초기화를 위해 호출되는 기능들
        combobox에 항목을 미리 추가해 두기위한 코드가있다
        */
        private void 식자재_반품_조회_Load(object sender, EventArgs e)
        {
            returnTableAdapter.Fill(databaseDataSet.Return); //전체 조회

            DataTable table = returnTableAdapter.GetData();
            for(int i=0;i<table.Rows.Count;i++) //반품번호 콤보박스에 추가
            {
                returnNumberCombobox.Items.Add(table.Rows[i][0]);
            }

            table = purchaseOrderTableAdapter1.GetData();
            for (int i = 0; i < table.Rows.Count; i++) //발주번호 콤보박스에 추가
            {
                purchaseNumCombobox.Items.Add(table.Rows[i][0]);
            }
        }

        /*
        작성일시 : 2017-11-09
        설계자 : 최승혁
        목적 : 조회버튼 기능
        사용자 입력값이 유효한지 먼저확인후 조회한다 (미완)
        ------------------------------------------------------
        수정일시 : 2017-11-15
        반품번호, 발주번호, 반품일시를 가지고 조회를 하는기느이 정상동작하지않아
        정상 동작 하도록 쿼리문 수정
        */
        private void button1_Click(object sender, EventArgs e)
        {
            //returnTableAdapter.FillById(databaseDataSet.Return, returnNumberCombobox.Text);

            if (returnNumberCombobox.Text == "" && purchaseNumCombobox.Text != "")
                returnTableAdapter.FillByInfoPurchaseNum(databaseDataSet.Return, dateTimePicker1.Value, dateTimePicker2.Value, purchaseNumCombobox.Text);
            else if (returnNumberCombobox.Text != "" && purchaseNumCombobox.Text == "")
                returnTableAdapter.FillByInfoNum(databaseDataSet.Return, dateTimePicker1.Value, dateTimePicker2.Value, returnNumberCombobox.Text);
            else
                returnTableAdapter.FillByAll(databaseDataSet.Return, dateTimePicker1.Value, dateTimePicker2.Value, returnNumberCombobox.Text, purchaseNumCombobox.Text);
        }
    }
}
