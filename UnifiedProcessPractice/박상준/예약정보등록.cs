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


        /*
            작성일시 : 2017-11-08
            설계자   : 박상준
            목적     : 등록버튼으로 입력된 예약정보를 DB에 추가하는 기능이다.
            -----------------
            수정일시 : 2017-11-15
            수정내용 : 테이블이 예약가능한지 확인해주는 기능과 메시지 박스를 추가하고 등록성공시 textbox를 초기화 시키도록했다.
        */
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime frontTime = dateDateTimePicker.Value.AddHours(-1);
            DateTime nearTime = dateDateTimePicker.Value.AddHours(+1);

            if(reservationTableAdapter.FindReservationByDate(frontTime, nearTime, textBox1.Text)==null)
            {
                if ((int)memberTableAdapter1.CountMemberNumber(nameTextBox.Text, phoneNumTextBox.Text) == 1)
                {
                    String result = reservationTableAdapter.GetAllReservationNumber().Rows[(int)reservationTableAdapter.GetReservationIndex() - 1][0].ToString();
                    result = result.Substring(1, 4);
                    result = (Int32.Parse(result) + 1).ToString();
                    for (int i = 0; i < 4 - (Int32.Parse(result) + 1).ToString().Length; i++)
                    {
                        result = "0" + result;
                    }
                    reservationTableAdapter.Insert("R" + result, dateDateTimePicker.Value, Int32.Parse(memberTextBox.Text), nameTextBox.Text, Int32.Parse(phoneNumTextBox.Text), textBox1.Text, memberTableAdapter1.GetMemberNumber(nameTextBox.Text).Rows[0][0].ToString());

                    memberTextBox.Text = "";
                    nameTextBox.Text = "";
                    phoneNumTextBox.Text = "";
                    textBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("존재하지 않는 회원입니다");
                }
            }
            else if (Int32.Parse(reservationTableAdapter.FindReservationByDate(frontTime, nearTime, textBox1.Text).ToString())>0)
            {
                MessageBox.Show("이미 예약된 테이블입니다");
            }
            
        }

        /*
        작성일시 : 2017-11-15
        설계자   : 박상준
        목적     : 첫번째 입력값으로 0을 받지 않게 하기위함
        */
        private void memberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (memberTextBox.Text.Equals("0"))
            {
                memberTextBox.Text = "";
            }
        }

        /*
            작성일시 : 2017-11-15
            설계자   : 박상준
            목적     : 인원수 textBox에 숫자만 입력받기 위한 기능이다
        */
        private void memberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }


        /*
            작성일시 : 2017-11-15
            설계자   : 박상준
            목적     :  입력받기 위한 기능이다
        */
        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
