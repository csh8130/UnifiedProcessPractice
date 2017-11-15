using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnifiedProcessPractice
{
    public partial class 예약정보출력 : Form
    {
        public 예약정보출력()
        {
            InitializeComponent();
        }

        private void reservationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reservationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void 예약정보출력_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'databaseDataSet.Reservation' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.

        }

        private void memberLabel_Click(object sender, EventArgs e)
        {

        }

        private void memberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void tableNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateLabel_Click(object sender, EventArgs e)
        {

        }


        /*
            작성일시 : 2017-11-08
            설계자   : 박상준
            목적     : 검색버튼으로 예약정보를 출력할 테이블 번호를 입력하여 GridView에 예약정보를 출력한다.
        */
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(tableTableAdapter1.FindTable(textBox1.Text)[0][0].ToString()) == true)
            {
               label2.Text= reservationTableAdapter.FindReservationByTableNumber(textBox1.Text)[0][1].ToString();
               label3.Text = reservationTableAdapter.FindReservationByTableNumber(textBox1.Text)[0][5].ToString();
               label4.Text = reservationTableAdapter.FindReservationByTableNumber(textBox1.Text)[0][2].ToString();
               label5.Text = reservationTableAdapter.FindReservationByTableNumber(textBox1.Text)[0][3].ToString();
               label6.Text = reservationTableAdapter.FindReservationByTableNumber(textBox1.Text)[0][4].ToString();
            }
        }
        /*
        작성일시 : 2017-11-15
        설계자   : 박상준
        목적     : 테이블 번호를 숫자만 입력받게 하는 기능이다.
        */
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        /*
        작성일시 : 2017-11-15
        설계자   : 박상준
        목적     : 첫번째 입력값으로 0을 받지 않게 하기위함
        */
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.Equals("0"))
            {
                textBox1.Text = "";
            }
        }
    }
}
