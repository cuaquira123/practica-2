using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            LFec.Items.Add(Fec.Value);
            if (Op1.Checked)
                LRond.Items.Add(Op1.Text);
            else 
                if (Op2.Checked)
                LRond.Items.Add(Op2.Text);
            else
                if (Op3.Checked)
                LRond.Items.Add(Op3.Text);
            else
                LRond.Items.Add(Op4.Text);
           
            LEq1.Items.Add(Eq1.Text);
            LGol1.Items.Add(CanGol1.Value);
            LEq2.Items.Add(Eq2.Text);
            LGol2.Items.Add(CanGol2.Value);
            
            if (CanGol1.Value == CanGol2.Value)
            {
                LPun1.Items.Add(1);
                LPun2.Items.Add(1);
            }

            else 

            if (CanGol1.Value > CanGol2.Value)
            {
                LPun1.Items.Add(3);
                LPun2.Items.Add(0);
            }
            else
            {
                LPun1.Items.Add(0);
                LPun2.Items.Add(3);
            }


        }

        private void BtnInformacion_Click(object sender, EventArgs e)
        {
          /*  int Acu = 0;
            String CanPun;
            if (Eq1.SelectedItem)
            CanPun = Eq1.Text;
            for (int Vis = 0; Vis < LPun1.Items.Count; Vis++)
                if (LPun1.Items[Vis].ToString() == CanPun)
                    Acu += Convert.ToUInt32(LPun2.Items[Vis]);
            S.Text = Acu.ToString();

         /*   switch (Eq1.SelectedIndex)
            {
                case 0:
            }    
         */
        }
    }
}
