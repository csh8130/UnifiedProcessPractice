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
    public partial class 공급업체조회 : UserControl
    {
        public 공급업체조회()
        {
            InitializeComponent();
        }

        private void businessCompanyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.businessCompanyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }



        /*
       작성일시 : 2017-11-08
       설계자 : 권보성
       목적 : 텍스트박스를 통해 입력받은 문자를 포함하는 공급업체명을 검색하여 테이블의 정보를 출력한다.
       공백으로 조회할 경우 모든 공급업체가 조회된다.
       -----------------
       수정일시 : -
       수정내용 : -
       */
        private void button1_Click(object sender, EventArgs e)
        {  
            
            businessCompanyTableAdapter.FillByBusinessName(databaseDataSet.BusinessCompany, textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int len = textBox1.Text.Length;
            if (len > 20)
            {
                MessageBox.Show("공급업체 명은 0~20자만 입력 가능합니다.");
                textBox1.Clear();
            }
        }
    }
}
