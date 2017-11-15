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
    public partial class 식자재조회 : UserControl
    {
        public 식자재조회()
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
        목적 : 식자재조회 화면으로 넘어 올 시 식자재 테이블의 전체내용을 출력한다.
        */
        private void 식자재조회_Load(object sender, EventArgs e)
        {
            ingredientTableAdapter.Fill(databaseDataSet.Ingredient);

        }

        /*
        작성일시 : 2017-11-08
        설계자 : 이재용
        목적 : 조회될 식자재정보의 Null값을 검사 후 식자재조회를 위한 쿼리를 호출 후 출력한다.
        */

        private void button1_Click(object sender, EventArgs e)
        {
                        
            try
            {                                
                int my_temp;
                int? input_tmep;
                if (int.TryParse(temperatureTextBox.Text, out my_temp))
                { input_tmep = my_temp; }
                else
                { input_tmep = null; }

                int my_hum;
                int? input_hum;
                if (int.TryParse(humidityTextBox.Text, out my_hum))
                { input_hum = my_hum; }

                else
                { input_hum = null; }
                

                int my_count;
                int? input_count;
                if (int.TryParse(countTextBox.Text, out my_count))
                { input_count = my_count; }
                else
                { input_count = null; }

                
                int my_kdate;
                int? input_kdate;
                if (int.TryParse(keepDateTextBox.Text, out my_kdate))
                { input_kdate = my_kdate; }
                else
                { input_kdate = null; }


                int my_kcount;
                int? input_kcount;
                if (int.TryParse(keepCountTextBox.Text, out my_kcount))
                { input_kcount = my_kcount; }
                else
                { input_kcount = null; }

                string my_name = nameTextBox.Text;
                if (my_name == "")
                    my_name = null;

                string my_origin = originTextBox.Text;
                if (my_origin == "")
                    my_origin = null;

                string my_state = stateTextBox.Text;
                if (my_state == "")
                    my_state = null;

                string my_meas = measureTextBox.Text;
                if (my_meas == "")
                    my_meas = null;

                ingredientTableAdapter.FillByDate(databaseDataSet.Ingredient, my_name, dateDateTimePicker.Value.Date, my_origin, my_state, input_tmep, input_hum, input_count, my_meas, input_kdate, input_kcount);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }

    
        }
    }
}
