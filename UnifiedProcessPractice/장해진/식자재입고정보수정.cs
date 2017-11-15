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
    public partial class 식자재입고정보수정 : UserControl
    {
        public 식자재입고정보수정()
        {
            InitializeComponent();
        }

        private void warehousingInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.warehousingInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }
/*
작성일시 : 2017-11-07
설계자 : 장해진
목적 : 데이터 테이블을 통해 콤보박스에 데이터를 채운다.
*/ 
        private void 식자재입고정보수정_Load(object sender, EventArgs e)
        {
            DataTable b = warehousingInfoTableAdapter.GetData();
            for (int j = 0; j < b.Rows.Count; j++)
            {
                sARNumberComboBox.Items.Add(b.Rows[j][0]);
            }

        }
 /*
작성일시 : 2017-11-07
설계자 : 장해진
목적 : 식자재 입고 정보 수정을 위한 쿼리를 호출 후 정보를 수정한다.
*/         
        private void button1_Click(object sender, EventArgs e)
        {
            int success = 0;
            if (amountTextBox.Text.Length == 0 || supplyCompanyTextBox.Text.Length == 0)
            {
                MessageBox.Show("모든 필수 정보를 입력해야 합니다.");
            }
            else if (amountTextBox.Text.Length > 20 || amountTextBox.Text.Length == 0)
            {
                MessageBox.Show("수량은 1~20자만 입력 가능합니다.");
            }
            else if (supplyCompanyTextBox.Text.Length > 20 || supplyCompanyTextBox.Text.Length == 0)
            {
                MessageBox.Show("공급업체 명은 1~20자만 입력 가능합니다.");
            }
            else if (significantThingTextBox.Text.Length > 100)
            {
                MessageBox.Show("특이사항은 100자 미만만 입력 가능합니다.");
            }

            else
            {
                int num = int.Parse(sARNumberComboBox.Text);
                sARTableAdapter.UpdateQuery(amountTextBox.Text, significantThingTextBox.Text, sARNumberComboBox.Text);

                MessageBox.Show("수정에 성공하였습니다.");
                success++;
            }
            if (success == 0) { MessageBox.Show("수정에 실패하였습니다."); }
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }
 /*
작성일시 : 2017-11-07
설계자 : 장해진
목적 : 상세 조회를 위한 쿼리를 호출 후 정보를 출력한다.
*/        
        private void sARNumberComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num = int.Parse(sARNumberComboBox.Text);
            DataTable a = sARTableAdapter.GetData();
            DataTable b = warehousingInfoTableAdapter.GetData();

            ingredientNameTextBox.Text = a.Rows[num - 1][1].ToString();
            ingredientNumberTextBox.Text = a.Rows[num - 1][4].ToString();
            amountTextBox.Text = a.Rows[num - 1][2].ToString();
            supplyCompanyTextBox.Text = b.Rows[num - 1][2].ToString();
            significantThingTextBox.Text = a.Rows[num - 1][3].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
/*
작성일시 : 2017-11-07
설계자 : 장해진
목적 : 식자재 입고 정보 삭제를 위한 쿼리를 호출 후 삭제를 수행한다.
*/ 
        private void button3_Click_1(object sender, EventArgs e)
        {
            int success = 0;
            warehousingInfoTableAdapter.DeleteW(sARNumberComboBox.Text);
            sARTableAdapter.DeleteSAR(sARNumberComboBox.Text);

            MessageBox.Show("삭제에 성공하였습니다.");
            success++;
            if (success ==1)
            {
                MessageBox.Show("삭제에 실패하였습니다.");
            }
        }
        
    }
}
