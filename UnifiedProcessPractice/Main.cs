using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnifiedProcessPractice
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            식자재_발주_조회 control = new 식자재_발주_조회();
            splitContainer1.Panel2.Controls.Add(control);
        }
    }
}
