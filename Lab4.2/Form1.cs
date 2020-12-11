using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nUD_1_ValueChanged(object sender, EventArgs e)
        {
            pB_1.Value = Decimal.ToInt32(nUD_1.Value);
            TB_1.Text = (nUD_1.Value+1).ToString();
            tB_2.Value = Decimal.ToInt32(nUD_1.Value);
        }

        private void btn_Vivod_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nUD_1.Value.ToString());
        }

        private void TB_1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nUD_1.Value = Int32.Parse(TB_1.Text)-1;
                pB_1.Value = Int32.Parse(TB_1.Text);
                tB_2.Value = Int32.Parse(TB_1.Text);
            }
        }

        private void tB_2_Scroll(object sender, EventArgs e)
        {
            nUD_1.Value = Decimal.ToInt32(tB_2.Value);
            pB_1.Value = Decimal.ToInt32(tB_2.Value);
            TB_1.Text = (tB_2.Value+1).ToString();
        }
    }
}
