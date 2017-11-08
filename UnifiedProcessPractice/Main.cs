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

        private void button10_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            식자재등록 control = new 식자재등록();
            splitContainer1.Panel2.Controls.Add(control);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            식자재수정 control = new 식자재수정();
            splitContainer1.Panel2.Controls.Add(control);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            식자재삭제 control = new 식자재삭제();
            splitContainer1.Panel2.Controls.Add(control);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            식자재조회 control = new 식자재조회();
            splitContainer1.Panel2.Controls.Add(control);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            식자재재고조사등록 control = new 식자재재고조사등록();
            splitContainer1.Panel2.Controls.Add(control);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            예약정보등록 control = new 예약정보등록();
            splitContainer1.Panel2.Controls.Add(control);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            예약정보조회 control = new 예약정보조회();
            splitContainer1.Panel2.Controls.Add(control);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            주문정보조회 control = new 주문정보조회();
            splitContainer1.Panel2.Controls.Add(control);

        }

        private void button18_Click(object sender, EventArgs e)
        {
            예약정보출력 a = new 예약정보출력();
            a.ShowDialog();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            주문현황정보출력 a = new 주문현황정보출력();
            a.ShowDialog();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            직원_등록 control = new 직원_등록();
            splitContainer1.Panel2.Controls.Add(control);

        }

        private void button21_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            직원_삭제 control = new 직원_삭제();
            splitContainer1.Panel2.Controls.Add(control);

        }

        private void button22_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            직원_수정 control = new 직원_수정();
            splitContainer1.Panel2.Controls.Add(control);

        }

        private void button23_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            직원_조회 control = new 직원_조회();
            splitContainer1.Panel2.Controls.Add(control);

        }

        private void button24_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            회원_포인트_잔액_정보_조회 control = new 회원_포인트_잔액_정보_조회();
            splitContainer1.Panel2.Controls.Add(control);

        }

        private void button25_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            식자재입출고대장조회 form = new 식자재입출고대장조회();
            splitContainer1.Panel2.Controls.Add(form);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            식자재입고정보등록 form = new 식자재입고정보등록();
            splitContainer1.Panel2.Controls.Add(form);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            식자재입고정보수정 form = new 식자재입고정보수정();
            splitContainer1.Panel2.Controls.Add(form);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            식자재출고정보등록 form = new 식자재출고정보등록();
            splitContainer1.Panel2.Controls.Add(form);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            식자재출고정보수정 form = new 식자재출고정보수정();
            splitContainer1.Panel2.Controls.Add(form);
        }
    }
}
