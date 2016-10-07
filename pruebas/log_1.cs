using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebas
{
    public partial class log_1 : Form
    {
        //variables
        Random rnd = new Random();
        //List<VM_M> Vm = new List<VM_M>();
        List<decimal> Vv;// = new List<decimal>();
        Decimal v1;
        Decimal v2;
        Decimal Vr;// = 0;
        string Sv;
        int aciertos = 0;
        int fallas = 0;
        //variables

        public log_1()
        {
            InitializeComponent();
            Juego_Logica();
        }

        public void Juego_Logica()
        {
            //Convert.ToDecimal((Convert.ToDecimal(rnd.Next(1, vf)) + Convert.ToDecimal(rnd.NextDouble())).ToString("0.00"))
            Vv = new List<decimal>();

            v1 = rnd.Next(1, 100);//Convert.ToDecimal((Convert.ToDecimal(rnd.Next(1, 100)) + Convert.ToDecimal(rnd.NextDouble())).ToString("0.00"));
            v2 = rnd.Next(1, 100);//Convert.ToDecimal((Convert.ToDecimal(rnd.Next(1, 100)) + Convert.ToDecimal(rnd.NextDouble())).ToString("0.00"));
            Vr = 0;

            switch (rnd.Next(0, 4))
            {
                case 0:
                    Vr = Convert.ToDecimal(v1) + Convert.ToDecimal(v2);
                    Sv = "+";
                    break;
                case 1:
                    Vr = Convert.ToDecimal(v1) - Convert.ToDecimal(v2);
                    Sv = "-";
                    break;
                case 2:
                    Vr = Convert.ToDecimal(v1) * Convert.ToDecimal(v2);
                    Sv = "x";
                    break;
                case 3:
                    Vr = Convert.ToDecimal((Convert.ToDecimal(v1) / Convert.ToDecimal(v2)).ToString("0.00"));
                    Sv = "/";
                    break;
            }

            if (Vr >= 0 && Vr <= 10)
            {
                vv_m(10);
            }
            else if (Vr >= 11 && Vr <= 100)
            {
                vv_m(100);
            }
            else if (Vr >= 101 && Vr <= 1000)
            {
                vv_m(1000);
            }
            else if (Vr >= 1001 && Vr <= 10000)
            {
                vv_m(10000);
            }

            Vv.Add(Vr);
            Vv = Vv.OrderBy(x => rnd.Next()).ToList();

            if (Vv.Count == 5)
            {
                panel_q2();
                panel_v();
            }
            else
            {
                Juego_Logica();
            }
            
        }

        public void vv_m(int vf)
        {
            for (int i = 0; i < 4; i++)
            {
                Vv.Add(Convert.ToDecimal((Convert.ToDecimal(rnd.Next(1, vf)) + Convert.ToDecimal(rnd.NextDouble())).ToString("0.00")));
            }
        }

        public void panel_q2()
        {
            Pnl_Q.Controls.Clear();
            Pnl_Eval.Controls.Clear();
            Button newButton = new Button();
            newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            newButton.Name = v1.ToString();
            newButton.Dock = DockStyle.Fill;
            newButton.Text = v1.ToString() + " " + Sv.ToString() + " " + v2.ToString() + " = " + Vr.ToString();

            newButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            newButton.UseVisualStyleBackColor = true;
            newButton.Enabled = false;
            Pnl_Q.Controls.Add(newButton);
        }

        public void panel_v()
        {
            var tablaPanel = new TableLayoutPanel();
            tablaPanel.RowCount = 5;
            tablaPanel.ColumnCount = 1;

            foreach (var item in Vv)
            {
                var Porcentaje = 150f / (float)Vv.Count - 10;
                tablaPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, Porcentaje));
                tablaPanel.RowStyles.Add(new RowStyle(SizeType.Percent, Porcentaje));
            }

            int z = 0;
            foreach (var item in Vv)
            {
                Button newButton = new Button();
                newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                newButton.Name = item.ToString();
                newButton.Size = new System.Drawing.Size(100, 100);
                newButton.Text = item.ToString();
                newButton.UseVisualStyleBackColor = true;
                newButton.Click += test0;
                tablaPanel.Controls.Add(newButton, 0, z);
                z++;
            }
            tablaPanel.Dock = DockStyle.Fill;
            Pnl_Eval.Controls.Add(tablaPanel);
        }

        public void panel_r()
        {
            Pnl_Res.Controls.Clear();
            Button newButton = new Button();
            newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            newButton.Dock = DockStyle.Fill;
            newButton.Text = "Correctos: " + aciertos.ToString() + " - Erroneos: " + fallas.ToString();

            newButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            newButton.UseVisualStyleBackColor = true;
            newButton.Enabled = false;
            Pnl_Res.Controls.Add(newButton);
        }

        private void test0(object sender, EventArgs e)
        {
            var result2 = sender.GetType().GetProperties().Single(x => x.Name == "Text").GetValue(sender, null);
            if (result2.ToString() == Vr.ToString())
            {
                aciertos++;
                Juego_Logica();
                panel_r();
            }
            else
            {
                fallas++;
                panel_r();
            }
            
        }



    }
}
