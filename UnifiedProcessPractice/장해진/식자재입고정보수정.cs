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

        private void 식자재입고정보수정_Load(object sender, EventArgs e)
        {
            DataTable b = warehousingInfoTableAdapter.GetData();
            for (int j = 0; j < b.Rows.Count; j++)
            {
                sARNumberComboBox.Items.Add(b.Rows[j][0]);
            }

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(sARNumberComboBox.Text);
            sARTableAdapter.UpdateQuery(amountTextBox.Text, significantThingTextBox.Text, sARNumberComboBox.Text);

            MessageBox.Show("수정이 완료되었습니다.");

        }


        private void button2_Click(object sender, EventArgs e)
        {

        }
        
        private void sARNumberComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //조회 버튼을 누르면 수정 화면에서 입고 정보 조회가 이루어짐
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            warehousingInfoTableAdapter.DeleteW(sARNumberComboBox.Text);
            sARTableAdapter.DeleteSAR(sARNumberComboBox.Text);

            MessageBox.Show("삭제가 완료되었습니다.");
        }
        
    }
}
