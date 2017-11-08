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
    public partial class 직원_등록 : UserControl
    {
        public 직원_등록()
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
        목적 : 직원 정보를 입력한후 등록버튼을 클릭하면 등록 한후 결과 메시지출력한다.
        -----------------
        */
        private void button1_Click(object sender, EventArgs e)
        {
            employeeTableAdapter.InsertQueryEmployee(employeeNumberTextBox.Text, iDTextBox.Text, passwordTextBox.Text, positionTextBox.Text, nameTextBox.Text, int.Parse(ageTextBox.Text), addressTextBox.Text, int.Parse(homePhoneNumTextBox.Text), int.Parse(cellPhoneNumTextBox.Text), eMailTextBox.Text);
            MessageBox.Show("등록되었습니다!!");

        }

     
    }
}
