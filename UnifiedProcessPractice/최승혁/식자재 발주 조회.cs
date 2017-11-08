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

        private void purchaseOrderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.purchaseOrderBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

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
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            purchaseOrderTableAdapter.FillByCompanyName(databaseDataSet.PurchaseOrder, companyNameTextbox.Text);
        }
    }
}
