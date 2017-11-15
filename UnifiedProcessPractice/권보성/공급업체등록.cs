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
    public partial class 공급업체등록 : UserControl
    {
        
        public 공급업체등록()
        {
            InitializeComponent();
        }

        


        private void businessCompanyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.businessCompanyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            insertBusinessCompany();
        }


        /*
       작성일시 : 2017-11-08
       설계자 : 권보성
       목적 : BusinessCompany테이블에 등록을 할 업체의 정보를 입력하여 업체명의 
       중복을 검사한후에 인서트쿼리를 실행하여 공급업체 정보를 등록한다.
       중복 발생시 메시지박스를 통해 중복임을 알려주고 정상등록이 되었을때에도 메시지박스로 
       정상처리 메시지를 출력한다.
       -----------------
       수정일시 : 2017-11-15
       수정내용 : 입력받은 값의 범위를 검사하여 범위를 벗어나면 메시지박스 출력
       */
        public void insertBusinessCompany()
        {
            string bName = businessNameTextBox.Text;
            string bPhoneNum = businessPhoneNoTextBox.Text;
            string address = addressTextBox.Text;
            string bNum = businessNumberTextBox.Text;
            string phoneNum = phoneNoTextBox.Text;
            string name = nameTextBox.Text;
            DateTime cDate = contractDateDateTimePicker.Value;
            DateTime eDate = expireDateDateTimePicker.Value;
            bool chk = true;

            DataTable ta = businessCompanyTableAdapter.GetDataByBusinessName("");

            int bNameLen = bName.Length;
            int bPhoneNumLen = bPhoneNum.Length;
            int addLen = address.Length;
            int bNumLen = bNum.Length;
            int phoneNumLen = phoneNum.Length;
            int nameLen = name.Length;

            if (bNameLen == 0)
            {
                MessageBox.Show("공급업체 명은 1~20자만 입력 가능합니다.");
                businessNameTextBox.Focus();
                chk = false;
            }
            else if (bPhoneNumLen == 0)
            {
                MessageBox.Show("연락처는 1~20자만 입력 가능합니다.");
                businessPhoneNoTextBox.Focus();
                chk = false;
            }
            else if (addLen == 0)
            {
                MessageBox.Show("주소는 1~100자만 입력 가능합니다.");
                addressTextBox.Focus();
                chk = false;
            }
            else if (bNumLen == 0)
            {
                MessageBox.Show("사업자등록번호는1~30자만 입력 가능합니다.");
                businessNumberTextBox.Focus();
                chk = false;
            }
            else if (phoneNumLen == 0)
            {
                MessageBox.Show("담당자연락처는 1~20자만 입력 가능합니다.");
                phoneNoTextBox.Focus();
                chk = false;
            }
            else if (nameLen == 0)
            {
                MessageBox.Show("담당자이름은 1~10자만 입력 가능합니다.");
                nameTextBox.Focus();
                chk = false;
            }

            else if (chk)
            {
                for (int i = 0; i < ta.Rows.Count; i++)
                {
                    if (bName.Equals(ta.Rows[i][0]))
                    {
                        MessageBox.Show("등록에 실패하였습니다. (이미등록된 공급업체)");
                        return;
                    }
                }

                businessCompanyTableAdapter.Insert(bName, bPhoneNum, address, bNum, phoneNum, name, cDate, eDate);
                MessageBox.Show("등록에 성공하였습니다.");
            }

            else
            {
                MessageBox.Show("등록에 실패하였습니다.");
            }
            
        }

        /*
        작성일시 : 2017-11-15
        설계자 : 권보성
        목적 : 사용자로부터 입력받는 정보의 길이를 체크하여 범위를 벗어나면 알려준다.
        */

        private void businessNameTextBox_TextChanged(object sender, EventArgs e)
        {
            int len = businessNameTextBox.Text.Length;
            if (len > 20)
            {
                MessageBox.Show("공급업체 명은 1~20자만 입력 가능합니다.");
                businessNameTextBox.Clear();
            }
        }

        private void businessPhoneNoTextBox_TextChanged(object sender, EventArgs e)
        {
            int len = businessPhoneNoTextBox.Text.Length;
            if (len > 20)
            {
                MessageBox.Show("연락처는 1~20자만 입력 가능합니다.");
                businessPhoneNoTextBox.Clear();
            }
        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {
            int len = addressTextBox.Text.Length;
            if (len > 100)
            {
                MessageBox.Show("주소는 1~100자만 입력 가능합니다.");
                addressTextBox.Clear();
            }
        }

        private void businessNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            int len = businessNumberTextBox.Text.Length;
            if (len > 30)
            {
                MessageBox.Show("사업자등록번호는1~30자만 입력 가능합니다.");
                businessNumberTextBox.Clear();
            }
        }

        private void phoneNoTextBox_TextChanged(object sender, EventArgs e)
        {
            int len = phoneNoTextBox.Text.Length;
            if (len > 20)
            {
                MessageBox.Show("담당자연락처는 1~20자만 입력 가능합니다.");
                phoneNoTextBox.Clear();
            }
            
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            int len = nameTextBox.Text.Length;
            if (len > 10)
            {
                MessageBox.Show("담당자이름은 1~10자만 입력 가능합니다.");
                nameTextBox.Clear();
            }
        }


    }
}
