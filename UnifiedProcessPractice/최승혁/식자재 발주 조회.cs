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
    public partial class 식자재_발주_조회 : UserControl
    {
        public 식자재_발주_조회()
        {
            InitializeComponent();
        }

        /*
        작성일시 : 2017-11-09
        설계자 : 최승혁
        목적 : 기능 Load시 초기화를 위해 호출되는 기능들
        combobox에 항목을 미리 추가해 두기위한 코드가있다
        */
        private void 식자재_발주_조회_Load(object sender, EventArgs e)
        {
            //처음 시작시 전체 내용 조회
            purchaseOrderTableAdapter.Fill(databaseDataSet.PurchaseOrder);

            //발주번호 콤보박스 전체 체워줌
            DataTable t = purchaseOrderTableAdapter.GetData();

            for(int i=0;i< t.Rows.Count;i++)
            {
                purchaseCombobox.Items.Add(t.Rows[i][0].ToString());
            }

            t = businessCompanyTableAdapter1.GetData();

            for (int i = 0; i < t.Rows.Count; i++)
            {
                businessNameCombobox.Items.Add(t.Rows[i][0].ToString());
            }
        }

        /*
        작성일시 : 2017-11-09
        설계자 : 최승혁
        목적 : 조회 버튼
        사용자의 입력값을 검사하여 유효한 값인지 검토후 유효한경우 조회 쿼리를 호출한다 (미완)
        ----------------------
        수정일시 : 2017-11-15
        검색 조건으로 날짜, 발주업체명, 발주번호가 제대로 동작안하는것을 제대로 동작되도록 쿼리 변경  
        */
        private void selectButton_Click(object sender, EventArgs e)
        {
            if(businessNameCombobox.Text == "" && purchaseCombobox.Text != "")
            {
                purchaseOrderTableAdapter.FillByInfoPurchaseNum(databaseDataSet.PurchaseOrder, dateTimePicker1.Value, dateTimePicker2.Value, purchaseCombobox.Text);
            }
            else if(purchaseCombobox.Text == "" && businessNameCombobox.Text !="")
            {
                purchaseOrderTableAdapter.FillByInfoBusinessName(databaseDataSet.PurchaseOrder, dateTimePicker1.Value, dateTimePicker2.Value, businessNameCombobox.Text);
            }
            else
            {
                purchaseOrderTableAdapter.FillByAll(databaseDataSet.PurchaseOrder, dateTimePicker1.Value, dateTimePicker2.Value, purchaseCombobox.Text, businessNameCombobox.Text);
            }

        }
    }
}
