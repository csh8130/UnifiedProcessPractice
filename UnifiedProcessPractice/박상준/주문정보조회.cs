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
    public partial class 주문정보조회 : UserControl
    {
        //Dictionary<string, string> menuNameDict = new Dictionary<string, string>();

        public 주문정보조회()
        {
            InitializeComponent();
        }

        private void orderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        /*
            작성일시 : 2017-11-08
            설계자   : 박상준
            목적     : 주문정보조회화면이 나타나면 화면의 GridView에 주문정보가 나타난다.
        */
        private void 주문정보조회_Load(object sender, EventArgs e)
        {
            orderTableAdapter.Fill(databaseDataSet.Order);
            /*
            DataTable table = menuTableAdapter1.GetData();
            
            for(int i=0;i< table.Rows.Count;i++)
            {
                string menuNum = table.Rows[i][0].ToString();
                string menuName = table.Rows[i][1].ToString();
                menuNameDict.Add(menuNum, menuName);
            }

            DataTable viewTable = orderTableAdapter.GetData();
            for(int i=0;i<viewTable.Rows.Count;i++)
            {
                string menuNum = viewTable.Rows[i][1].ToString();
                string name = menuNameDict[menuNum].ToString();
                //viewTable.Rows[i][1] = name;
                orderDataGridView.Rows[i].Cells[1] = name.ToString();
            }
            */
        }

        /*
            작성일시 : 2017-11-08
            설계자   : 박상준
            목적     : 삭제버튼으로 주문정보가 조회된 GridView에서 마우스로 클릭하여 선택한 행을 삭제하는 기능이다.
                       (선택한 행의 테이블번호와 식단번호를 읽어와 삭제한다)
            -----------------
            수정일시 : 2017-11-15
            수정내용 : 메시지 박스를 추가했다.

        */
        private void button2_Click(object sender, EventArgs e)
        {
            int rowIndex = orderDataGridView.SelectedCells[0].RowIndex;
            String table   = orderDataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            String menu = orderDataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            orderTableAdapter.DeleteOrder(table, menu);

            orderTableAdapter.Fill(databaseDataSet.Order);
            MessageBox.Show("삭제되었습니다");
        }



        /*
            작성일시 : 2017-11-08
            설계자   : 박상준
            목적     : 검색버튼으로 tableNum.Text에 입력된 테이블번호로 주문정보를 검색하여 화면에있는 GridView에 출력한다.
        */
        private void button3_Click(object sender, EventArgs e)
        { 
            orderDataGridView.DataSource =orderTableAdapter.FindOrderByTableNumber(tableNum.Text);
        }

        /*
        작성일시 : 2017-11-15
        설계자   : 박상준
        목적     : 첫번째 입력값으로 0을 받지 않게 하기위함
        */
        private void tableNum_TextChanged(object sender, EventArgs e)
        {
            if (tableNum.Text.Equals("0"))
            {
                tableNum.Text = "";
            }
        }

        /*
        작성일시 : 2017-11-15
        설계자   : 박상준
        목적     :숫자만 입력받기 위함
        */
        private void tableNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;

            }
        }
    }
}
