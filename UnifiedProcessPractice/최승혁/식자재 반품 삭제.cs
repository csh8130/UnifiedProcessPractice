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
    public partial class 식자재_반품_삭제 : UserControl
    {
        public 식자재_반품_삭제()
        {
            InitializeComponent();
        }

        private void returnBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.returnBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        /*
        작성일시 : 2017-11-09
        설계자 : 최승혁
        목적 : 기능 Load시 초기화를 위해 호출되는 기능들
        combobox에 항목을 미리 추가해 두기위한 코드가있다
        */
        private void 식자재_반품_삭제_Load(object sender, EventArgs e)
        {
            DataTable table = returnTableAdapter.GetData();
            for(int i=0;i< table.Rows.Count;i++) //반품 번호 콤보박스 추가
            {
                returnNumCombobox.Items.Add(table.Rows[i][0]);
            }
            
        }

        /*
        작성일시 : 2017-11-09
        설계자 : 최승혁
        목적 : 식자재 반품 번호 콤보박스 선택시 전체 정보 조회
        */
        private void returnNumCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = returnNumCombobox.SelectedIndex;
            string id = returnNumCombobox.Items[index].ToString();

            returnTableAdapter.FillById(databaseDataSet.Return,id);
        }

        /*
        작성일시 : 2017-11-09
        설계자 : 최승혁
        목적 : 반품 삭제 실행 쿼리 호출 (미완)
        */
        private void deleteButton_Click(object sender, EventArgs e)
        {
            returnTableAdapter.DeleteQueryById(returnNumCombobox.Text);
            MessageBox.Show("삭제 완료");
        }
    }
}
