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
        -----------------
        수정일시 : 2017-11-14
        수정내용 : Message 내용 수정 / 문자열 길이 확인 추가
        */

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ingredientNumberTextBox.Text.Length == 0 || ingredientNumberTextBox.Text.Length > 20 ||
                    nameTextBox.Text.Length == 0 || nameTextBox.Text.Length > 20 ||
                      originTextBox.Text.Length == 0 || originTextBox.Text.Length > 20 ||
                      stateTextBox.Text.Length == 0 || stateTextBox.Text.Length > 20 ||
                      temperatureTextBox.Text.Length == 0 || temperatureTextBox.Text.Length > 3 ||
                      humidityTextBox.Text.Length == 0 || humidityTextBox.Text.Length > 3 ||
                      countTextBox.Text.Length == 0 || countTextBox.Text.Length > 3 ||
                      measureTextBox.Text.Length == 0 || measureTextBox.Text.Length > 20 ||
                      keepDateTextBox.Text.Length == 0 || keepDateTextBox.Text.Length > 10 ||
                      keepCountTextBox.Text.Length == 0 || keepCountTextBox.Text.Length > 3)
                {
                    MessageBox.Show("정보가 잘못되었습니다. \r다시입력하세요");
                }

                else { 
                    ingredientTableAdapter.InsertQuery(ingredientNumberTextBox.Text, nameTextBox.Text, Convert.ToDateTime(dateDateTimePicker.Text), 
                        originTextBox.Text, stateTextBox.Text, Convert.ToInt32(temperatureTextBox.Text), Convert.ToInt32(humidityTextBox.Text), 
                        Convert.ToInt32(countTextBox.Text), measureTextBox.Text, Convert.ToInt32(keepDateTextBox.Text), Convert.ToInt32(keepCountTextBox.Text));

                    MessageBox.Show("식자재가 등록되었습니다.");
                }
            }
            catch(Exception t )
            {
                MessageBox.Show("정보가 잘못되었습니다. \r다시입력하세요");
            }

        }

        private void ingredientNumberLabel_Click(object sender, EventArgs e)
        {

        }
    }


    
}
