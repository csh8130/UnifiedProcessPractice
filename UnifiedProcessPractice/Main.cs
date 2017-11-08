using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnifiedProcessPractice
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            식자재_발주_조회 control = new 식자재_발주_조회();
            splitContainer1.Panel2.Controls.Add(control);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            회원정보등록 control = new 회원정보등록();
            splitContainer1.Panel2.Controls.Add(control);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            회원정보삭제 control = new 회원정보삭제();
            splitContainer1.Panel2.Controls.Add(control);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            회원정보수정 control = new 회원정보수정();
            splitContainer1.Panel2.Controls.Add(control);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            회원정보조회 control = new 회원정보조회();
            splitContainer1.Panel2.Controls.Add(control);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            공급업체등록 control = new 공급업체등록();
            splitContainer1.Panel2.Controls.Add(control);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            공급업체삭제 control = new 공급업체삭제();
            splitContainer1.Panel2.Controls.Add(control);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            공급업체수정 control = new 공급업체수정();
            splitContainer1.Panel2.Controls.Add(control);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            공급업체조회 control = new 공급업체조회();
            splitContainer1.Panel2.Controls.Add(control);
        }
    }
}
