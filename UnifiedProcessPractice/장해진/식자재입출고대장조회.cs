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
    public partial class 식자재입출고대장조회 : UserControl
    {
        public 식자재입출고대장조회()
        {
            InitializeComponent();
        }

        private void sARBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sARBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void 식자재입출고대장조회_Load(object sender, EventArgs e)
        {

        }

        private void sARDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sARTableAdapter.FillByIngredientName(databaseDataSet.SAR, ingredientNameTextbox.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
