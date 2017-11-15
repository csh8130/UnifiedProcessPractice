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
    public partial class 식자재수정 : UserControl
    {
        public 식자재수정()
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
        목적 : 식자재 정보를 수정하기위한 쿼리를 호출 후 출력한다.
        -----------------
        수정일시 : 2017-11-14
        수정내용 : 성공 / 실패 Message 내용 수정 + 문자열 길이 확인 추가
        */
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameTextBox.Text.Length == 0 || nameTextBox.Text.Length > 20 ||
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
                else
                {
                    ingredientTableAdapter.UpdateQueryID(nameTextBox.Text, dateDateTimePicker.Value.Date, originTextBox.Text, stateTextBox.Text, Convert.ToInt32(temperatureTextBox.Text), Convert.ToInt32(humidityTextBox.Text), Convert.ToInt32(countTextBox.Text), measureTextBox.Text, Convert.ToInt32(keepDateTextBox.Text), Convert.ToInt32(keepCountTextBox.Text), comboBox1.Text);
                    MessageBox.Show("해당 정보를 수정하였습니다.");
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("식자재 정보수정에 실패하였습니다.");
            }
        }

        /*
        작성일시 : 2017-11-08
        설계자 : 이재용
        목적 : 식자재수정 화면으로 넘어 올 시 콤보박스에 식자재의 식별번호를 입력한다.
        */
        private void 식자재수정_Load(object sender, EventArgs e)
        {
            DataTable t = ingredientTableAdapter.GetData();

            for(int i=0;i< t.Rows.Count;i++)
            {
                comboBox1.Items.Add(t.Rows[i][0].ToString());
            }
        }

        /*
        작성일시 : 2017-11-08
        설계자 : 이재용
        목적 : 콤보박스의 식별자번호를 선택 시 식자재 정보를 출력한다.
        */
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = comboBox1.Items[comboBox1.SelectedIndex].ToString();
            ingredientTableAdapter.FillByID(databaseDataSet.Ingredient, id);
        }
    }
}
