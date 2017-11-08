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
    public partial class 예약정보등록 : UserControl
    {
        public 예약정보등록()
        {
            InitializeComponent();
        }

        private void 예약정보등록_Load(object sender, EventArgs e)
        {
           
        }

        private void reservationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reservationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        /*
            작성일시 : 2017-11-08
            설계자   : 박상준
            목적     : 등록버튼으로 입력된 예약정보를 DB에 추가하는 기능이다.
        */
        private void button1_Click(object sender, EventArgs e)
        {

            if ((int)memberTableAdapter1.CountMemberNumber(nameTextBox.Text, phoneNumTextBox.Text)==1)
            {
                String result=reservationTableAdapter.GetAllReservationNumber().Rows[(int)reservationTableAdapter.GetReservationIndex() - 1][0].ToString();
                result= result.Substring(1, 4);
                result = (Int32.Parse(result) + 1).ToString();
               for (int i = 0;i<4-(Int32.Parse(result) + 1).ToString().Length;i++)
                {
                    result = "0"+result;
                }
                reservationTableAdapter.Insert("R"+result, dateDateTimePicker.Value, Int32.Parse(memberTextBox.Text), nameTextBox.Text, Int32.Parse(phoneNumTextBox.Text), textBox1.Text, memberTableAdapter1.GetMemberNumber(nameTextBox.Text).Rows[0][0].ToString());
            }
          
        }

        private void memberTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
