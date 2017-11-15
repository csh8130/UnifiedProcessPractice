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
   
    public partial class 식자재입고정보등록 : UserControl
    {
        public 식자재입고정보등록()
        {
            InitializeComponent();
        }

        private void sARBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sARBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }
/*
작성일시 : 2017-11-07
설계자 : 장해진
목적 : 식자재 입고 정보 등록을 위한 쿼리를 호출 후 테이블에 정보를 등록한다.
*/
        private void button1_Click(object sender, EventArgs e)
        {
            int success = 0;
            if (ingredientNameTextBox.Text.Length == 0 || amountTextBox.Text.Length == 0 || supplyCompanyTextBox.Text.Length == 0)
            {
                MessageBox.Show("모든 필수 정보를 입력해야 합니다.");
            }
            else if (ingredientNameTextBox.Text.Length > 20 || ingredientNameTextBox.Text.Length == 0)
            {
                MessageBox.Show("식자재 이름은 1~20자만 입력 가능합니다.");
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
                int max = -1;
          
                DataTable t = sARTableAdapter.GetData();

                for (int i = 0; i < t.Rows.Count; i++)
                {

                    int temp = int.Parse(t.Rows[i][0].ToString());
                    if (max < temp)
                        max = temp;
                }

                string sARNumberString = "" + (max + 1);


                sARTableAdapter.Insert(sARNumberString, ingredientNameTextBox.Text, amountTextBox.Text, significantThingTextBox.Text, ingredientNumberComboBox.Text);
                warehousingInfoTableAdapter.Insert(sARNumberString, DateTime.Parse(warehousingDateDateTimePicker.Text), supplyCompanyTextBox.Text);

                MessageBox.Show("등록에 성공하였습니다.");
                success++;
            }
            if (success==0) { MessageBox.Show("등록에 실패하였습니다."); }
        }
/*
작성일시 : 2017-11-07
설계자 : 장해진
목적 : 데이터 테이블을 통해 콤보박스에 데이터를 채운다.
*/
        private void 식자재입고정보등록_Load(object sender, EventArgs e)
        {
            DataTable t = ingredientTableAdapter1.GetData();
            for(int i=0;i<t.Rows.Count;i++)
            {
                ingredientNumberComboBox.Items.Add(t.Rows[i][0]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void ingredientNumberComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
