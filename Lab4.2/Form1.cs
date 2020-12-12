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
        Model model;
        public Form1()
        {
            InitializeComponent();

            model = new Model();
            model.observers += new System.EventHandler(this.UpdateFromModel);
        }

        private void nUD_1_ValueChanged(object sender, EventArgs e)
        {
            //pB_1.Value = Decimal.ToInt32(nUD_1.Value);
            //TB_1.Text = (nUD_1.Value+1).ToString();
            //tB_2.Value = Decimal.ToInt32(nUD_1.Value);
            model.setValue(Decimal.ToInt32(nUD_1.Value), 0);
        }

        private void btn_Vivod_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(nUD_1.Value.ToString());

            MessageBox.Show(model.getValue().ToString());
        }

        private void TB_1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //nUD_1.Value = Int32.Parse(TB_1.Text)-1;
                //pB_1.Value = Int32.Parse(TB_1.Text);
                //tB_2.Value = Int32.Parse(TB_1.Text);

                model.setValue(Int32.Parse(TB_1.Text),1);
            }
        }

        private void tB_2_Scroll(object sender, EventArgs e)
        {
            //nUD_1.Value = Decimal.ToInt32(tB_2.Value);
            //pB_1.Value = Decimal.ToInt32(tB_2.Value);
            //TB_1.Text = (tB_2.Value+1).ToString();

            model.setValue(tB_2.Value, 2);
        }

        private void UpdateFromModel(object sender, EventArgs e)
        {
            tB_2.Value = model.getValue();
            pB_1.Value = model.getValue();
            if (model.getCheck() == 0)
            {
                TB_1.Text = (model.getValue() + 1).ToString();
            }
            else if (model.getCheck() == 1)
            {
                TB_1.Text = model.getValue().ToString();
                nUD_1.Text = (model.getValue() - 1).ToString();
            }
            else
            {
                nUD_1.Text = model.getValue().ToString();
                TB_1.Text = (model.getValue() + 1).ToString();
            }
        }
    }

    public class Model
    {
        private int value;
        public int check;
        public System.EventHandler observers;

        public void setValue(int value, int check)
        {
            this.value = value;
            this.check = check;
            observers.Invoke(this, null);
        }
        public int getValue()
        {
            return value;
        }
        public int getCheck()
        {
            return check;
        }
    }
}
