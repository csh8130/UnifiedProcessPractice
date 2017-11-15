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
    public partial class 회원정보조회 : UserControl
    {
        public 회원정보조회()
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
        설계자 : 권보성
        목적 : 텍스트박스를 통해 입력받은 문자를 포함하는 회원명을 검색하여 테이블의 정보를 출력한다.
        공백으로 조회할 경우 모든 회원이 조회된다.
        -----------------
        수정일시 : -
        수정내용 : -
        */
        private void button1_Click(object sender, EventArgs e)
        {
            memberTableAdapter.FillByName(databaseDataSet.Member, textBox1.Text);
        }


        /*
        작성일시 : 2017-11-15
        설계자 : 권보성
        목적 : 사용자로부터 입력받은값의 유효 범위를 체크한다.
       
        */
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int len = textBox1.Text.Length;
            if (len > 10)
            {
                MessageBox.Show("성명은 0~10자만 입력 가능합니다.");
                textBox1.Clear();
            }
        }
    }
}
