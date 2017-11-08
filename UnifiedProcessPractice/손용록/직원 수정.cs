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
    public partial class 직원_수정 : UserControl
    {
        public 직원_수정()
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

            foreach (Control c in Controls)
            {

                if (c is TextBox)
                {
                    ((TextBox)c).ReadOnly = false;
                }

            }

        }

        /*
        작성일시 : 2017-11-08
        설계자 : 손용록
        목적 : 최초 직원 수정 버튼을 클릭하였을때 직원 테이블에서 ID값들을 가져와 comboBox1에 추가한다.
        -----------------
        */
        private void 직원_수정_Load(object sender, EventArgs e)
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
        목적 : 수정 버튼을 클릭하면 선택된 ID와 같은 직원 정보를, 입력된 직원 정보들과 같이 수정하고 수정완료 메시지를 출력한다.
        -----------------
        */

        private void button1_Click(object sender, EventArgs e)
        {
            int temp = comboBox1.SelectedIndex;
            employeeTableAdapter.UpdateQueryByID(passwordTextBox.Text,positionTextBox.Text,nameTextBox.Text,int.Parse(ageTextBox.Text),addressTextBox.Text,int.Parse(homePhoneNumTextBox.Text),int.Parse(cellPhoneNumTextBox.Text),eMailTextBox.Text, comboBox1.Items[temp].ToString());
            MessageBox.Show("수정되었습니다!!");
        }
    }
}
