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
    public partial class 공급업체등록 : UserControl
    {
        
        public 공급업체등록()
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
            insertBusinessCompany();
        }


        /*
       작성일시 : 2017-11-08
       설계자 : 권보성
       목적 : BusinessCompany테이블에 등록을 할 업체의 정보를 입력하여 업체명의 
       중복을 검사한후에 인서트쿼리를 실행하여 공급업체 정보를 등록한다.
       중복 발생시 메시지박스를 통해 중복임을 알려주고 정상등록이 되었을때에도 메시지박스로 
       정상처리 메시지를 출력한다.
       -----------------
       수정일시 : -
       수정내용 : -
       */
        public void insertBusinessCompany()
        {
            string bName = businessNameTextBox.Text;
            string bPhoneNum = businessPhoneNoTextBox.Text;
            string address = addressTextBox.Text;
            string bNum = businessNumberTextBox.Text;
            string phoneNum = phoneNoTextBox.Text;
            string name = nameTextBox.Text;
            DateTime cDate = contractDateDateTimePicker.Value;
            DateTime eDate = expireDateDateTimePicker.Value;


            DataTable ta = businessCompanyTableAdapter.GetDataByBusinessName("");
            

            for (int i = 0; i < ta.Rows.Count; i++)
            {
                if (bName.Equals(ta.Rows[i][0]))
                {
                    MessageBox.Show("이미등록된 공급업체입니다!!");
                    return;
                }
            }

            businessCompanyTableAdapter.Insert(bName, bPhoneNum, address, bNum, phoneNum, name, cDate, eDate);
            MessageBox.Show("공급업체가 등록되었습니다!!");
        }
    }
}
