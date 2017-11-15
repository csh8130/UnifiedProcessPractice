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
    public partial class 회원_포인트_잔액_정보_조회 : UserControl
    {
        public 회원_포인트_잔액_정보_조회()
        {
            InitializeComponent();
        }

        private void memberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.memberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        /*
        작성일시 : 2017-11-08
        설계자 : 손용록
        목적 : 회원번호를 입력받고 조회버튼을 클릭하면 포인트 잔액 정보가 조회되어 출력된다.
        -----------------
        */
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = memberTableAdapter.GetDataByMemberNumber(memberNumberTextBox.Text);

                string point = dt.Rows[0][3].ToString();

                pointTextBox.Text = point;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("오류내용 : " + ex);
            }


        }
    }
}
