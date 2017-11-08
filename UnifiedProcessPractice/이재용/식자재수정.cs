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
        */
        private void button1_Click(object sender, EventArgs e)
        {
            try {
                ingredientTableAdapter.UpdateQueryID(nameTextBox.Text, dateDateTimePicker.Value.Date, originTextBox.Text, stateTextBox.Text, Convert.ToInt32(temperatureTextBox.Text), Convert.ToInt32(humidityTextBox.Text), Convert.ToInt32(countTextBox.Text), measureTextBox.Text, Convert.ToInt32(keepDateTextBox.Text), Convert.ToInt32(keepCountTextBox.Text), comboBox1.Text);

                MessageBox.Show("성공");
            }
            catch (Exception)
            {
                MessageBox.Show("실패");
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
