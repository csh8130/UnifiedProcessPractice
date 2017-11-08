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
        수정일시 : -
        수정내용 : -
        */
        public void insertMember()
        {
            //회원 등록 정보 회원번호의 경우에는 static 변수를 사용하여 1씩증가하도록 하고 
            //비밀번호는 휴대폰번호 뒤4자리, 포인트는 0 ,등록일은 오늘날짜로 자동으로 입력된다. 

            string memberNum = "m" + num.ToString();
            string memberId = memberIDTextBox.Text;
            string memberPw = phonNum2.Text.ToString();
            string point = "0";
            string phonNum = phonNum0.Text.ToString() + phonNum1.Text.ToString() + phonNum2.Text.ToString();
            string address = addressTextBox.Text;
            string name = nameTextBox.Text;
            string birthDate = birtgDateTextBox.Text;
            string registDate = DateTime.Today.ToShortDateString();
            
            DataTable ta = memberTableAdapter.GetDataByName("");

            for (int i = 0; i < ta.Rows.Count; i++)
            {
                if (phonNum.Equals(ta.Rows[i][4]))
                {
                    MessageBox.Show("이미등록된 전화번호입니다!!");
                    return;
                }
            }


            memberTableAdapter.Insert(memberNum, memberId, memberPw, point, phonNum, address, name, birthDate, registDate);
            MessageBox.Show("회원 등록이 완료되었습니다!! \n회원번호 : " + memberNum + "PW : " + memberPw);

            num++;
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

    }
}
