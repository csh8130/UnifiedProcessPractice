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
    public partial class 회원정보삭제 : UserControl
    {
        public 회원정보삭제()
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
            deleteMember();
        }


        /*
       작성일시 : 2017-11-08
       설계자 : 권보성
       목적 : 텍스트박스를 통해 삭제할 회원의 번호와 비밀번호를 입력받고 회원의 비밀번호가
       입력받은 회원의 정보와 일치할 경우 member테이블에서 회원 정보를 삭제한 뒤 정상처리 메시지를 출력한다.
       일치하지않을 경우에는 비밀번호가 일치하지않는다는 메시지를 출려한다.
       입력받은 회원의 정보가 member테이블에 존재하지않을 경우 메시지박스를 통해 존재하지않는 번호라는 메시지를 출력한다.
       -----------------
       수정일시 : -
       수정내용 : -
       */
        public void deleteMember()
        {
            string memberNum = memberNumberTextBox.Text;
            bool chk = false;

            string memberPwChk = memberPWTextBox.Text.ToString();

            DataTable ta = memberTableAdapter.GetDataByName("");

            for (int i = 0; i < ta.Rows.Count; i++)
            {
                if (memberNum.Equals(ta.Rows[i][0]))
                {
                    chk = true;
                    if (memberPwChk.Equals(ta.Rows[i][2]))
                    {
                        memberTableAdapter.DeleteQuery(memberNum);
                        MessageBox.Show("성공적으로 삭제하였습니다!!");
                        break;
                    }
                    else
                    {
                        MessageBox.Show("비밀번호가 일치하지않습니다!!");
                        return;
                    }
                }
            }
            if (!chk)
            {
                MessageBox.Show("존재하지않는 회원번호 입니다!!");
            }
            else
            {
                memberNumberTextBox.Text = "";
                memberPWTextBox.Text = "";
            }
        }


    }
}
