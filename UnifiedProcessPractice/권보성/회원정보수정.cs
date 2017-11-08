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
    public partial class 회원정보수정 : UserControl
    {
        public 회원정보수정()
        {
            InitializeComponent();
        }

        private void memberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.memberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            updateMember();
        }

        /*
        작성일시 : 2017-11-08
        설계자 : 권보성
        목적 : 텍스트박스를 통해 수정할 회원의 정보를 입력받고 회원의 번호가
        존재하지않을 경우에는 메시지박스를 통해 존재하지않는 번호임을 알려준다.
        수정정보로 입력한 전화번호가 기존테이블에 존재할 경우에도 중복여부를 메시지박스를 통해알려준다.
        수정할 회원의 번호가 존재하고 입력된 정보가 정상입력일 경우 업데이트쿼리를 실행한 후에
        메시지박스를 통해 정상수정 메시지를 출력한다.
        -----------------
        수정일시 : -
        수정내용 : -
        */
        public void updateMember()
        {
            string memberNum = memberNumberTextBox.Text;
            bool chk = false;  //수정할 회원의 번호가 존재하는지 체크


            string memberPw = memberPWTextBox.Text.ToString();
            string memberPwChk = textBox1.Text.ToString();
            string phonNum = phoneNoTextBox.Text;
            string address = addressTextBox.Text;
            string name = nameTextBox.Text;
            string birthDate = birtgDateTextBox.Text;

            if (!memberPw.Equals(memberPwChk))
            {
                MessageBox.Show("비밀번호를 확인해주세요");
                return;
            }

            DataTable ta = memberTableAdapter.GetDataByName("");

            for (int i = 0; i < ta.Rows.Count; i++)
            {
                if (phonNum.Equals(ta.Rows[i][4]))
                {
                    MessageBox.Show("이미등록된 전화번호입니다!!");
                    return;
                }
                if (memberNum.Equals(ta.Rows[i][0]))
                {
                    chk = true;
                }
            }
            if (!chk)
            {
                MessageBox.Show("존재하지않는 회원번호입니다!!");
                return;
            }
            else
            {
                memberTableAdapter.UpdateQuery(memberPw, phonNum, address, name, birthDate, memberNum);
                //                         수정할비밀번호,전화번호, 주소,  이름,   생일, 수정될 레코드의 회원번호
                MessageBox.Show("수정이 완료되었습니다!!");
            }
        }




    }
}
