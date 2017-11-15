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
    public partial class 식자재재고조사등록 : UserControl
    {
        public 식자재재고조사등록()
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
        목적 : 식자재재고조사등록 화면으로 넘어 올 시 식자재테이블의 전체내용을 출력한다.
        */
        private void 식자재재고조사등록_Load(object sender, EventArgs e)
        {
            ingredientTableAdapter.Fill(databaseDataSet.Ingredient);

        }

        /*
        작성일시 : 2017-11-08
        설계자 : 이재용
        목적 : 식자재재고조사등록을 위한 쿼리를 호출한다.
        -----------------
        수정일시 : 2017-11-14
        수정내용 : count text box 입력값 확인, 문자열 길이 확인 및 등록결과 Message 추가
        */
        private void button1_Click(object sender, EventArgs e)
        {
            int check = 0;

            if(countTextBox.Text.Length > 3)
            {
                MessageBox.Show("정보가 잘못되었습니다. \r다시입력하세요");
            }
            else
            {
                if (int.TryParse(countTextBox.Text, out check))
                {
                    ingredientTableAdapter.UpdateQueryCount(nameTextBox.Text, Convert.ToInt32(countTextBox.Text), nameTextBox.Text);
                    MessageBox.Show("등록되었습니다.");
                }
                else
                {
                    MessageBox.Show("등록에 실패하였습니다.");
                }
            }
  
        }



    }
}
