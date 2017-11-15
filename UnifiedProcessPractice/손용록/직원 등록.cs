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
        수정일시 : 2017-11-15
        수정내용 : 예외처리를 적용하였다.
        */
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (employeeNumberTextBox.Text.Length > 20 || employeeNumberTextBox.Text.Length ==0 ||
                iDTextBox.Text.Length > 20 || iDTextBox.Text.Length == 0 ||
                passwordTextBox.Text.Length > 20 || passwordTextBox.Text.Length == 0 ||
                positionTextBox.Text.Length > 20 || positionTextBox.Text.Length == 0 ||
                nameTextBox.Text.Length > 8 || nameTextBox.Text.Length == 0 ||
                ageTextBox.Text.Length > 3 || ageTextBox.Text.Length == 0 ||
                addressTextBox.Text.Length > 50 || addressTextBox.Text.Length == 0 ||
                homePhoneNumTextBox.Text.Length > 15 || homePhoneNumTextBox.Text.Length == 0 ||
                cellPhoneNumTextBox.Text.Length > 15 || cellPhoneNumTextBox.Text.Length == 0 ||
                eMailTextBox.Text.Length > 30 || eMailTextBox.Text.Length == 0 )
            {
                MessageBox.Show("양식에 오류가있습니다. 다시시도해주세요");
            }
            else
            {
                employeeTableAdapter.InsertQueryEmployee(employeeNumberTextBox.Text, iDTextBox.Text, passwordTextBox.Text, positionTextBox.Text, nameTextBox.Text, int.Parse(ageTextBox.Text), addressTextBox.Text, int.Parse(homePhoneNumTextBox.Text), int.Parse(cellPhoneNumTextBox.Text), eMailTextBox.Text);
                MessageBox.Show("등록되었습니다!!");
            }
        }
        
    }
}
