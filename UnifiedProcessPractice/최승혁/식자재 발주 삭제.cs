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
    public partial class 식자재_발주_삭제 : UserControl
    {
        public 식자재_발주_삭제()
        {
            InitializeComponent();
        }

        /*
        작성일시 : 2017-11-09
        설계자 : 최승혁
        목적 : 기능 Load시 초기화를 위해 호출되는 기능들
        combobox에 항목을 미리 추가해 두기위한 코드가있다
        */

        private void 식자재_발주_삭제_Load(object sender, EventArgs e)
        {
            DataTable table = purchaseOrderTableAdapter.GetData(); //발주번호 combobox 추가
            for (int i = 0; i < table.Rows.Count; i++)
            {
                orderNumberCombobox.Items.Add(table.Rows[i][0].ToString());
            }
        }

        /*
        작성일시 : 2017-11-09
        설계자 : 최승혁
        목적 : 발주 삭제 쿼리 실행 (미완)
        */
        private void orderNumberCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            purchaseOrderTableAdapter.FillById(databaseDataSet.PurchaseOrder,orderNumberCombobox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            purchaseOrderTableAdapter.DeleteQueryById(orderNumberCombobox.Text);
            MessageBox.Show("삭제 완료");
        }
    }
}
