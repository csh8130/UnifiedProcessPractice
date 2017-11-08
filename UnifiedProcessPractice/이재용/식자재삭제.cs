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
    public partial class 식자재삭제 : UserControl
    {
        public 식자재삭제()
        {
            InitializeComponent();
        }

        private void ingredientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ingredientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        /*
        작성일시 : 2017-11-08
        설계자 : 이재용
        목적 : 식자재 정보를 삭제하기위한 쿼리를 호출 후 출력한다.
        */
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ingredientTableAdapter.DeleteQuery(nameTextBox.Text);
                MessageBox.Show("삭제되었습니다.");
            }

            catch(Exception )
            {
                MessageBox.Show("사용중인 식자재 입니다. \r사용중인 메뉴를 먼저 삭제하세요.");
            }
        }

        /*
        작성일시 : 2017-11-08
        설계자 : 이재용
        목적 : 콤보박스의 식별자번호를 선택 시 식자재 정보를 출력한다.
        */

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = comboBox1.Items[comboBox1.SelectedIndex].ToString();
            ingredientTableAdapter.FillByID(databaseDataSet.Ingredient, id);
            
        }

        /*
        작성일시 : 2017-11-08
        설계자 : 이재용
        목적 : 식자재삭제 화면으로 넘어 올 시 콤보박스에 식자재의 식별번호를 입력한다.
        */

        private void 식자재삭제_Load(object sender, EventArgs e)
        {
            DataTable t = ingredientTableAdapter.GetData();

            for (int i = 0; i < t.Rows.Count; i++)
            {
                comboBox1.Items.Add(t.Rows[i][0].ToString());

            }
        }
    }
}
