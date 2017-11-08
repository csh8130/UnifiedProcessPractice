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
    public partial class 직원_삭제 : UserControl
    {
        public 직원_삭제()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }
        /*
        작성일시 : 2017-11-08
        설계자 : 손용록
        목적 : ID를 선택하면 그에맞는 정보를 출력한다.
        -----------------
        */
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int temp = comboBox1.SelectedIndex;
            employeeTableAdapter.FillByID(databaseDataSet.Employee, comboBox1.Items[temp].ToString());

        }
        /*
        작성일시 : 2017-11-08
        설계자 : 손용록
        목적 : 최초 직원 삭제 버튼을 클릭하였을때 직원 테이블에서 ID값들을 가져와 comboBox1에 추가한다.
        -----------------
        */

        private void 직원_삭제_Load(object sender, EventArgs e)
        {

            DataTable EP = employeeTableAdapter.GetData();

            for (int i = 0; i < EP.Rows.Count; i++)
            {
                comboBox1.Items.Add(EP.Rows[i][1]);
            }
        }
        /*
        작성일시 : 2017-11-08
        설계자 : 손용록
        목적 : 삭제버튼을 누르면 현재 선택된 ID와 같은 직원 정보를 테이블에서 삭제한후 삭제완료 메시지를 출력한다.
        -----------------
        */

        private void button1_Click(object sender, EventArgs e)
        {
            int temp = comboBox1.SelectedIndex;
            employeeTableAdapter.DeleteQueryByID(comboBox1.Items[temp].ToString());
            MessageBox.Show("삭제되었습니다!!");
        }
    }
}
