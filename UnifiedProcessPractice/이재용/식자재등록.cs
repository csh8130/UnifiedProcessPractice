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
    public partial class 식자재등록 : UserControl
    {
        public 식자재등록()
        {
            InitializeComponent();
        }

        private void ingredientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ingredientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        /*
        작성일시 : 2017-11-08
        설계자 : 이재용
        목적 : 식자재 정보를 등록하기위한 쿼리를 호출 후 출력한다.
        */

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ingredientTableAdapter.InsertQuery(ingredientNumberTextBox.Text, nameTextBox.Text, Convert.ToDateTime(dateDateTimePicker.Text), originTextBox.Text, stateTextBox.Text, Convert.ToInt32(temperatureTextBox.Text), Convert.ToInt32(humidityTextBox.Text), Convert.ToInt32(countTextBox.Text), measureTextBox.Text, Convert.ToInt32(keepDateTextBox.Text), Convert.ToInt32(keepCountTextBox.Text));
                MessageBox.Show("등록되었습니다.");

            }
            catch(Exception )
            {
                MessageBox.Show("다시입력하시오");
            }

        }

        private void ingredientNumberLabel_Click(object sender, EventArgs e)
        {

        }
    }


    
}
