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


       
        private void button1_Click(object sender, EventArgs e)
        {
            int max = -1;
            DataTable t = sARTableAdapter.GetData();

            for(int i=0;i<t.Rows.Count;i++)
            {
                
                int temp = int.Parse(t.Rows[i][0].ToString());
                if (max < temp)
                    max = temp;
            }

            string sARNumberString = ""+ (max+1);

            
            sARTableAdapter.Insert(sARNumberString, ingredientNameTextBox.Text, amountTextBox.Text, significantThingTextBox.Text, ingredientNumberComboBox.Text);
            warehousingInfoTableAdapter.Insert(sARNumberString, DateTime.Parse(warehousingDateDateTimePicker.Text), supplyCompanyTextBox.Text);
            
            MessageBox.Show("등록이 완료되었습니다.");
            
        }

        private void 식자재입고정보등록_Load(object sender, EventArgs e)
        {
            //콤보박스의 데이터를 채운다.
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
