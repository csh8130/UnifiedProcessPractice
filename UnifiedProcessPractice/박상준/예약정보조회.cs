using System;
using System.Windows.Forms;

namespace UnifiedProcessPractice
{
    public partial class 예약정보조회 : UserControl
    {
        public 예약정보조회()
        {
            InitializeComponent();
        }

        private void reservationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reservationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void reservationDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /*
            작성일시 : 2017-11-08
            설계자   : 박상준
            목적     : 삭제버튼으로 예약정보가 조회된 GridView에서 마우스로 클릭하여 선택한 행을 삭제하는 기능이다.
                       (선택한 행의 주문번호를 읽어와 삭제한다)
            -----------------
            수정일시 : 2017-11-15
            수정내용 : 메시지박스 추가
        */
        private void button1_Click(object sender, EventArgs e)
        {
            int rowIndex = reservationDataGridView.SelectedCells[0].RowIndex;
            String key = reservationDataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            reservationTableAdapter.DeleteReservation(key);

            reservationTableAdapter.Fill(databaseDataSet.Reservation);
            reservationDataGridView.DataSource = reservationTableAdapter.FindReservation("");
            MessageBox.Show("삭제되었습니다");
        }

        /*
           작성일시 : 2017-11-08
           설계자   : 박상준
           목적     : 검색버튼으로 textBox에 입력된 회원이름으로 예약정보를 검색하여 GridView에 정보를 출력한다
           -----------------
           수정일시 : 2017-11-15
           수정내용 : 예약일자로 검색하는 기능을 추가하였다
        */
        private void button2_Click(object sender, EventArgs e)
        {
           
            if (comboBox1.Text.Equals("회원이름"))
            {
                reservationDataGridView.DataSource = reservationTableAdapter.FindReservation(textBox1.Text);
            }
            else if (comboBox1.Text.Equals("예약일자"))
            {
                DateTime currentDate = dateTimePicker1.Value;
                DateTime nextDate=dateTimePicker1.Value.AddDays(+1);
                reservationDataGridView.DataSource = reservationTableAdapter.GetReservationByDate(currentDate, nextDate);
            }
        }

        /*
           작성일시 : 2017-11-08
           설계자   : 박상준
           목적     : 예약정보조회 화면이 나타날경우 화면의 GridView에 예약정보가 나타난다.
        */
        private void 예약정보조회_Load(object sender, EventArgs e)
        {
            reservationTableAdapter.Fill(databaseDataSet.Reservation);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /*
           작성일시 : 2017-11-15
           설계자   : 박상준
           목적     : comboBox에 선택한 입력방법만 화면에 출력되게 바꾸었다.
        */
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("회원이름"))
            {
                textBox1.Visible = true;
                dateTimePicker1.Visible = false;
                textBox1.Enabled = true;
            }
            else if (comboBox1.Text.Equals("예약일자"))
            {
                textBox1.Visible = false;
                dateTimePicker1.Visible = true;
            }
        }
    }
}
