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
    public partial class 공급업체수정 : UserControl
    {
        public 공급업체수정()
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
            updateBusinessCompany();
        }


        /*
       작성일시 : 2017-11-08
       설계자 : 권보성
       목적 : 텍스트박스를 통해 수정할 업체의 명과 사업자등록번호를 제외한 정보를 입력받아 업데이트 쿼리를 실행한다.
       수정이 정상적으로 될경우 메시지박스를 통해 알려주고
       업체명이 존재하지않을경우에도 메시지박스를 통해서 존재하지않는 업체명이라고 알려준다.
       -----------------
       수정일시 : -
       수정내용 : -
       */
        public void updateBusinessCompany()
        {
            string bName = businessNameTextBox.Text;
            string bPhoneNum = businessPhoneNoTextBox.Text;
            string address = addressTextBox.Text;
            string phoneNum = phoneNoTextBox.Text;
            string name = nameTextBox.Text;
            DateTime cDate = contractDateDateTimePicker.Value;
            DateTime eDate = expireDateDateTimePicker.Value;
            bool chk = false;

            DataTable ta = businessCompanyTableAdapter.GetDataByBusinessName("");


            for (int i = 0; i < ta.Rows.Count; i++)
            {
                if (bName.Equals(ta.Rows[i][0]))
                {
                    chk = true;
                    break;
                }
            }

            if (chk)
            {
                businessCompanyTableAdapter.UpdateQuery(bPhoneNum, address, phoneNum, name, cDate, eDate, bName);
                //연락처 ,주소, 담당자연락처, 담당자이름, 계약일, 만료일, 수정할 행의 공급업체명
                MessageBox.Show("수정이 완료되었습니다!!");
            }
            else
            {
                MessageBox.Show("존재하지않는 공급업체명입니다!!");
            }
        }

    }
}
