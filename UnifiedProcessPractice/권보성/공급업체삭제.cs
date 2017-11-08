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
    public partial class 공급업체삭제 : UserControl
    {
        public 공급업체삭제()
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
            deleteBusinessCompany();
        }


        /*
        작성일시 : 2017-11-08
        설계자 : 권보성
        목적 : 공급업체삭제화면이 로드될경우 공급업체명을 콤보박스에 저장하는 용도
        -----------------
        수정일시 : -
        수정내용 : -
        */
        private void 공급업체삭제_Load(object sender, EventArgs e)
        {
            DataTable t = businessCompanyTableAdapter.GetData();

            for(int i=0;i<t.Rows.Count;i++)
            {
                comboBox1.Items.Add( t.Rows[i][0]);
            }
        }

        /*
        작성일시 : 2017-11-08
        설계자 : 권보성
        목적 : 콤보박스에서 공급업체명을 선택할 경우 그공급업체의 사업자등록번호를 화면에 보여주는 용도
        -----------------
        수정일시 : -
        수정내용 : -
        */
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable t = businessCompanyTableAdapter.GetData();

            for (int i = 0; i < t.Rows.Count; i++)
            {
                string cName = comboBox1.Text;

                if (cName.Equals(t.Rows[i][0]))
                {
                    businessNumberTextBox.Text = t.Rows[i][3].ToString();
                }

            }
        }

        /*
        작성일시 : 2017-11-08
        설계자 : 권보성
        목적 : 콤보박스에서 선택한 공급업체의 이름으로 businessCompany테이블에 있는 공급업체를 삭제함.
        삭제가 정상적으로 될경우 메시지박스를 통해 알려준다.
        -----------------
        수정일시 : -
        수정내용 : -
        */
        public void deleteBusinessCompany()
        {
            string bName = comboBox1.Text;
            string bNum = businessNumberTextBox.Text;

            bool chk = false;


            DataTable ta = businessCompanyTableAdapter.GetDataByBusinessName(bName);
            //입력받은 공급업체명을 검색하여 일치하는 공급업체가 있다면 딜리트쿼리 실행

            try
            {
                for (int i = 0; i < ta.Rows.Count; i++)
                {
                    if (bName.Equals(ta.Rows[i][0]))
                    {
                        chk = true;
                        if (bNum.Equals(ta.Rows[i][3]))
                        {
                            businessCompanyTableAdapter.DeleteQuery(bName);
                            comboBox1.Items.Remove(bName);
                            MessageBox.Show("성공적으로 삭제하였습니다!!");
                            break;
                        }
                        else
                        {
                            MessageBox.Show("사업자등록번호가 일치하지않습니다!!");
                            return;
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("삭제불가!!");
                //다른 테이블에 저장되어있는경우 삭제불가
            }



            if (!chk)
            {
                MessageBox.Show("존재하지않는 공급업체 입니다!!");
            }
            else
            {
                businessNumberTextBox.Text = "";
            }

        }


    }
}
