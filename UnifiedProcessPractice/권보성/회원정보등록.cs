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
    

    public partial class 회원정보등록 : UserControl
    {
        private static int num = 10;

        public 회원정보등록()
        {
            InitializeComponent();
        }

        private void menuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.menuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }



        private void button1_Click(object sender, EventArgs e)
        {
            insertMember();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearTextBox();
        }



        /*
        작성일시 : 2017-11-08
        설계자 : 권보성
        목적 : Member테이블에 등록할 회원의 정보를 텍스트박스를 통해 입력받고 전화번호의 중복검사를 한 후에 등록한다.
        중복일 경우 메시지박스를 통해 중복여부를 알려주고 정상등록되었을 경우에도 메시지박스를 통해 알려준다.

        -----------------
        수정일시 : 2017-11-15
        수정내용 : 입력받은 값의 범위가 정상범위를 벗어나면 메시지박스를 통해 알려주고 등록되지않도록 수정
        */
        public void insertMember()
        {
            //회원 등록 정보 회원번호의 경우에는 static 변수를 사용하여 1씩증가하도록 하고 
            //비밀번호는 휴대폰번호 뒤4자리, 포인트는 0 ,등록일은 오늘날짜로 자동으로 입력된다. 
            bool chk = true;
            string memberNum = "m" + num.ToString();
            string memberId = memberIDTextBox.Text;
            string memberPw = phonNum2.Text.ToString();
            string point = "0";
            string phonNum = phonNum0.Text.ToString() + phonNum1.Text.ToString() + phonNum2.Text.ToString();
            string address = addressTextBox.Text;
            string name = nameTextBox.Text;
            string birthDate = birtgDateTextBox.Text;
            string registDate = DateTime.Today.ToShortDateString();


            int idLen = memberId.Length;
            int nameLen = name.Length;
            int phonLen = phonNum.Length;
            int addLen = address.Length;
            int birthLen = birtgDateTextBox.Text.Length;
            if (idLen == 0)
            {
                MessageBox.Show("ID는 1~20자만 입력 가능합니다.");
                memberIDTextBox.Focus();
                chk = false;
            }
            else if (nameLen == 0)
            {
                MessageBox.Show("성명은 1~10자만 입력 가능합니다.");
                nameTextBox.Focus();
                chk = false;
            }
            else if (phonLen != 11)
            {
                MessageBox.Show("전화번호는 11자만 입력 가능합니다.");
                phonNum0.Focus();
                chk = false;
            }
            else if (addLen == 0)
            {
                MessageBox.Show("주소는 1~100자만 입력 가능합니다.");
                addressTextBox.Focus();
                chk = false;
            }
            else if (birthLen < 6)
            {
                MessageBox.Show("생년월일은 6~20자만 입력 가능합니다.");
                birtgDateTextBox.Focus();
                chk = false;
            }


            else if (chk)
            {
                DataTable ta = memberTableAdapter.GetDataByName("");

                for (int i = 0; i < ta.Rows.Count; i++)
                {
                    if (phonNum.Equals(ta.Rows[i][4]))
                    {
                        MessageBox.Show("등록에 실패하였습니다.(전화번호 중복)");
                        return;
                    }
                }

                memberTableAdapter.Insert(memberNum, memberId, memberPw, point, phonNum, address, name, birthDate, registDate);
                MessageBox.Show("등록에 성공하였습니다. \n회원번호 : " + memberNum + "  PW : " + memberPw);

                num++;
            }

            else
            {
                MessageBox.Show("등록에 실패하였습니다.");
            }
           
        }


        /*
        작성일시 : 2017-11-08
        설계자 : 권보성
        목적 : 화면에 있는 텍스트박스의 내용을 공백으로 초기화한다.
        -----------------
        수정일시 : -
        수정내용 : -
        */
        public void clearTextBox()
        {
            memberIDTextBox.Text = "";
            nameTextBox.Text = "";
            phonNum1.Text = "";
            phonNum2.Text = "";
            addressTextBox.Text = "";
            birtgDateTextBox.Text = "";
        }


         /*
        작성일시 : 2017-11-15
        설계자 : 권보성
        목적 : 사용자로부터 입력받는 정보의 길이를 체크하여 범위를 벗어나면 알려준다.
        */
        private void memberIDTextBox_TextChanged(object sender, EventArgs e)
        {
            int len = memberIDTextBox.Text.Length;
            if(len>20)
            {
                MessageBox.Show("ID는 1~20자만 입력 가능합니다.");
                memberIDTextBox.Clear();
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            int len = nameTextBox.Text.Length;
            if (len > 10)
            {
                MessageBox.Show("이름은 1~10자만 입력 가능합니다.");
                nameTextBox.Clear();
            }
        }

        private void phonNum2_TextChanged(object sender, EventArgs e)
        {
            int len = phonNum0.Text.Length + phonNum1.Text.Length + phonNum2.Text.Length;
            if (len > 11)
            {
                MessageBox.Show("전화번호는 11자만 입력 가능합니다.");
                phonNum1.Clear();
                phonNum2.Clear();
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

        private void birtgDateTextBox_TextChanged(object sender, EventArgs e)
        {
            int len = birtgDateTextBox.Text.Length;
            if (len > 20 )
            {
                MessageBox.Show("생년월일은 6~20자만 입력 가능합니다.");
                birtgDateTextBox.Clear();
            }
        }


    }
}
