using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebas
{
    public partial class Admin_Sl_Con : UserControl
    {
        int tam = 11;
        List<Grid_0> gr2 = new List<Grid_0>();
        Random rnd = new Random();
        TextBox tb1;
        
        public Admin_Sl_Con()
        {
            InitializeComponent();
            Generar();
        }
        
        public TextBox Txt_Box2()
        {
            tb1 = new TextBox();
            tb1.Dock = DockStyle.Fill;
            tb1.MaxLength = 1;
            tb1.TextAlign = HorizontalAlignment.Center;
            tb1.BorderStyle = BorderStyle.None;
            tb1.Multiline = true;
            tb1.TextChanged += textBox1_TextChanged;
            tb1.Font = new Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold);
            return tb1;
        }

        public class Grid_0
        {
            public int a { get; set; }
            public int b { get; set; }
            public string v { get; set; }
            public string r { get; set; }
        }

        public void Generar()
        {
            TableLayoutPanel tablaPanel = new TableLayoutPanel();
            tablaPanel.RowCount = tam;
            tablaPanel.ColumnCount = tam;
            for (int i = 0; i < tam; i++)
            {
                var Porcentaje = 1;
                tablaPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, Porcentaje));
                tablaPanel.RowStyles.Add(new RowStyle(SizeType.Percent, Porcentaje));
            }


            for (int a = 0; a < tam; a++)
            {
                for (int b = 0; b < tam; b++)
                {
                    var tb1 = Txt_Box2();
                    tb1.Name = a.ToString() + b.ToString();   //item.r.ToString();
                    //tb1.Text = a.ToString() + b.ToString();
                    tablaPanel.Controls.Add(tb1, a, b);
                }
            }

            tablaPanel.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(tablaPanel);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = ((TextBox)sender).Text.ToUpper();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Ms = abc();
            gr2.Clear();

            //ingresado
            panel1.Controls[0].Controls.OfType<TextBox>().ToList().Where(x => x.Text.Trim() != "").ToList().ForEach(y =>
            {
                var pos1 = y.Name.ToArray();
                gr2.Add(new Grid_0
                {
                    a = Convert.ToInt16(pos1[0].ToString()),
                    b = Convert.ToInt16(pos1[1].ToString()),
                    v = y.Text.ToString(),
                    r = y.Name.ToString()
                });
            });

            ////aleatorio
            //panel1.Controls[0].Controls.OfType<TextBox>().ToList().Where(x => x.Text.Trim() == "").ToList().ForEach(y => {
            //    var pos1 = y.Name.ToArray();
            //    gr2.Add(new Grid_0
            //    {
            //        a = Convert.ToInt16(pos1[0].ToString()),
            //        b = Convert.ToInt16(pos1[1].ToString()),
            //        v = Ms[rnd.Next(0, Ms.Count)].ToString(),
            //        r = y.Name.ToString()
            //    });
            //});
        }
        
        public List<string> abc()
        {
            List<string> abc1 = new List<string>();
            abc1.Add("A");
            abc1.Add("B");
            abc1.Add("C");
            abc1.Add("D");
            abc1.Add("E");
            abc1.Add("F");
            abc1.Add("G");
            abc1.Add("H");
            abc1.Add("I");
            abc1.Add("J");
            abc1.Add("K");
            abc1.Add("L");
            abc1.Add("M");
            abc1.Add("N");
            abc1.Add("O");
            abc1.Add("P");
            abc1.Add("Q");
            abc1.Add("R");
            abc1.Add("S");
            abc1.Add("T");
            abc1.Add("U");
            abc1.Add("V");
            abc1.Add("W");
            abc1.Add("X");
            abc1.Add("Y");
            abc1.Add("z");
            return abc1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Generar();
            var Ms = abc();
            gr2.ForEach(x =>
            {
                panel1.Controls[0].Controls.OfType<TextBox>().ToList().Single(y => y.Name.ToString() == x.r.ToString()).Text = x.v.ToString();
            });

            //aleatorio
            panel1.Controls[0].Controls.OfType<TextBox>().ToList().Where(x => x.Text.Trim() == "").ToList().ForEach(y =>
            {
                y.Text = Ms[rnd.Next(0, Ms.Count)].ToString();
            });
        }

    }
}
