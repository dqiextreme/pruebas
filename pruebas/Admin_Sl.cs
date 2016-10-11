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
    public partial class Admin_Sl : Form
    {
        public Admin_Sl()
        {
            InitializeComponent();
            pan22();
        }

        TextBox tb1;
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

        List<Grid_0> gr1 = new List<Grid_0>();
        List<Grid_0> gr2 = new List<Grid_0>();


        public class Grid_0
        {
            public int a { get; set; }
            public int b { get; set; }
            public string v { get; set; }
            public string r { get; set; }
        }

        public void t2()
        {
            gr1.Clear();
            gr1.Add(new Grid_0 { a = 0, b = 0, v = "A", r = "00" }); gr1.Add(new Grid_0 { a = 1, b = 0, v = "K", r = "10" }); gr1.Add(new Grid_0 { a = 2, b = 0, v = "U", r = "20" }); gr1.Add(new Grid_0 { a = 3, b = 0, v = "F", r = "30" }); gr1.Add(new Grid_0 { a = 4, b = 0, v = "P", r = "40" }); gr1.Add(new Grid_0 { a = 5, b = 0, v = "A", r = "50" }); gr1.Add(new Grid_0 { a = 6, b = 0, v = "K", r = "60" }); gr1.Add(new Grid_0 { a = 7, b = 0, v = "U", r = "70" }); gr1.Add(new Grid_0 { a = 8, b = 0, v = "F", r = "80" }); gr1.Add(new Grid_0 { a = 9, b = 0, v = "P", r = "90" });
            gr1.Add(new Grid_0 { a = 0, b = 1, v = "B", r = "01" }); gr1.Add(new Grid_0 { a = 1, b = 1, v = "L", r = "11" }); gr1.Add(new Grid_0 { a = 2, b = 1, v = "V", r = "21" }); gr1.Add(new Grid_0 { a = 3, b = 1, v = "G", r = "31" }); gr1.Add(new Grid_0 { a = 4, b = 1, v = "Q", r = "41" }); gr1.Add(new Grid_0 { a = 5, b = 1, v = "B", r = "51" }); gr1.Add(new Grid_0 { a = 6, b = 1, v = "L", r = "61" }); gr1.Add(new Grid_0 { a = 7, b = 1, v = "V", r = "71" }); gr1.Add(new Grid_0 { a = 8, b = 1, v = "G", r = "81" }); gr1.Add(new Grid_0 { a = 9, b = 1, v = "Q", r = "91" });
            gr1.Add(new Grid_0 { a = 0, b = 2, v = "C", r = "02" }); gr1.Add(new Grid_0 { a = 1, b = 2, v = "M", r = "12" }); gr1.Add(new Grid_0 { a = 2, b = 2, v = "W", r = "22" }); gr1.Add(new Grid_0 { a = 3, b = 2, v = "H", r = "32" }); gr1.Add(new Grid_0 { a = 4, b = 2, v = "R", r = "42" }); gr1.Add(new Grid_0 { a = 5, b = 2, v = "C", r = "52" }); gr1.Add(new Grid_0 { a = 6, b = 2, v = "M", r = "62" }); gr1.Add(new Grid_0 { a = 7, b = 2, v = "W", r = "72" }); gr1.Add(new Grid_0 { a = 8, b = 2, v = "H", r = "82" }); gr1.Add(new Grid_0 { a = 9, b = 2, v = "R", r = "92" });
            gr1.Add(new Grid_0 { a = 0, b = 3, v = "D", r = "03" }); gr1.Add(new Grid_0 { a = 1, b = 3, v = "N", r = "13" }); gr1.Add(new Grid_0 { a = 2, b = 3, v = "X", r = "23" }); gr1.Add(new Grid_0 { a = 3, b = 3, v = "I", r = "33" }); gr1.Add(new Grid_0 { a = 4, b = 3, v = "S", r = "43" }); gr1.Add(new Grid_0 { a = 5, b = 3, v = "D", r = "53" }); gr1.Add(new Grid_0 { a = 6, b = 3, v = "N", r = "63" }); gr1.Add(new Grid_0 { a = 7, b = 3, v = "X", r = "73" }); gr1.Add(new Grid_0 { a = 8, b = 3, v = "I", r = "83" }); gr1.Add(new Grid_0 { a = 9, b = 3, v = "S", r = "93" });
            gr1.Add(new Grid_0 { a = 0, b = 4, v = "E", r = "04" }); gr1.Add(new Grid_0 { a = 1, b = 4, v = "O", r = "14" }); gr1.Add(new Grid_0 { a = 2, b = 4, v = "Z", r = "24" }); gr1.Add(new Grid_0 { a = 3, b = 4, v = "J", r = "34" }); gr1.Add(new Grid_0 { a = 4, b = 4, v = "T", r = "44" }); gr1.Add(new Grid_0 { a = 5, b = 4, v = "E", r = "54" }); gr1.Add(new Grid_0 { a = 6, b = 4, v = "O", r = "64" }); gr1.Add(new Grid_0 { a = 7, b = 4, v = "Z", r = "74" }); gr1.Add(new Grid_0 { a = 8, b = 4, v = "J", r = "84" }); gr1.Add(new Grid_0 { a = 9, b = 4, v = "T", r = "94" });
            gr1.Add(new Grid_0 { a = 0, b = 5, v = "F", r = "05" }); gr1.Add(new Grid_0 { a = 1, b = 5, v = "P", r = "15" }); gr1.Add(new Grid_0 { a = 2, b = 5, v = "A", r = "25" }); gr1.Add(new Grid_0 { a = 3, b = 5, v = "K", r = "35" }); gr1.Add(new Grid_0 { a = 4, b = 5, v = "U", r = "45" }); gr1.Add(new Grid_0 { a = 5, b = 5, v = "F", r = "55" }); gr1.Add(new Grid_0 { a = 6, b = 5, v = "P", r = "65" }); gr1.Add(new Grid_0 { a = 7, b = 5, v = "A", r = "75" }); gr1.Add(new Grid_0 { a = 8, b = 5, v = "K", r = "85" }); gr1.Add(new Grid_0 { a = 9, b = 5, v = "U", r = "95" });
            gr1.Add(new Grid_0 { a = 0, b = 6, v = "G", r = "06" }); gr1.Add(new Grid_0 { a = 1, b = 6, v = "Q", r = "16" }); gr1.Add(new Grid_0 { a = 2, b = 6, v = "B", r = "26" }); gr1.Add(new Grid_0 { a = 3, b = 6, v = "L", r = "36" }); gr1.Add(new Grid_0 { a = 4, b = 6, v = "V", r = "46" }); gr1.Add(new Grid_0 { a = 5, b = 6, v = "G", r = "56" }); gr1.Add(new Grid_0 { a = 6, b = 6, v = "Q", r = "66" }); gr1.Add(new Grid_0 { a = 7, b = 6, v = "B", r = "76" }); gr1.Add(new Grid_0 { a = 8, b = 6, v = "L", r = "86" }); gr1.Add(new Grid_0 { a = 9, b = 6, v = "V", r = "96" });
            gr1.Add(new Grid_0 { a = 0, b = 7, v = "H", r = "07" }); gr1.Add(new Grid_0 { a = 1, b = 7, v = "R", r = "17" }); gr1.Add(new Grid_0 { a = 2, b = 7, v = "C", r = "27" }); gr1.Add(new Grid_0 { a = 3, b = 7, v = "M", r = "37" }); gr1.Add(new Grid_0 { a = 4, b = 7, v = "W", r = "47" }); gr1.Add(new Grid_0 { a = 5, b = 7, v = "H", r = "57" }); gr1.Add(new Grid_0 { a = 6, b = 7, v = "R", r = "67" }); gr1.Add(new Grid_0 { a = 7, b = 7, v = "C", r = "77" }); gr1.Add(new Grid_0 { a = 8, b = 7, v = "M", r = "87" }); gr1.Add(new Grid_0 { a = 9, b = 7, v = "W", r = "97" });
            gr1.Add(new Grid_0 { a = 0, b = 8, v = "I", r = "08" }); gr1.Add(new Grid_0 { a = 1, b = 8, v = "S", r = "18" }); gr1.Add(new Grid_0 { a = 2, b = 8, v = "D", r = "28" }); gr1.Add(new Grid_0 { a = 3, b = 8, v = "N", r = "38" }); gr1.Add(new Grid_0 { a = 4, b = 8, v = "X", r = "48" }); gr1.Add(new Grid_0 { a = 5, b = 8, v = "I", r = "58" }); gr1.Add(new Grid_0 { a = 6, b = 8, v = "S", r = "68" }); gr1.Add(new Grid_0 { a = 7, b = 8, v = "D", r = "78" }); gr1.Add(new Grid_0 { a = 8, b = 8, v = "N", r = "88" }); gr1.Add(new Grid_0 { a = 9, b = 8, v = "X", r = "98" });
            gr1.Add(new Grid_0 { a = 0, b = 9, v = "J", r = "09" }); gr1.Add(new Grid_0 { a = 1, b = 9, v = "T", r = "19" }); gr1.Add(new Grid_0 { a = 2, b = 9, v = "E", r = "29" }); gr1.Add(new Grid_0 { a = 3, b = 9, v = "O", r = "39" }); gr1.Add(new Grid_0 { a = 4, b = 9, v = "Z", r = "49" }); gr1.Add(new Grid_0 { a = 5, b = 9, v = "J", r = "59" }); gr1.Add(new Grid_0 { a = 6, b = 9, v = "T", r = "69" }); gr1.Add(new Grid_0 { a = 7, b = 9, v = "E", r = "79" }); gr1.Add(new Grid_0 { a = 8, b = 9, v = "O", r = "89" }); gr1.Add(new Grid_0 { a = 9, b = 9, v = "Z", r = "99" });
        }

        public void pan22()
        {
            t2();
            TableLayoutPanel tablaPanel = new TableLayoutPanel();
            tablaPanel.RowCount = 10;
            tablaPanel.ColumnCount = 10;
            for (int i = 0; i < 10; i++)
            {
                var Porcentaje = 150f / (float)10 - 10;
                tablaPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, Porcentaje));
                tablaPanel.RowStyles.Add(new RowStyle(SizeType.Percent, Porcentaje));
            }
            //----

            foreach (var item in gr1)
            {
                var tb1 = Txt_Box2();
                tb1.Name = item.r.ToString();
                tablaPanel.Controls.Add(tb1, item.a, item.b);
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
            panel1.Controls[0].Controls.OfType<TextBox>().ToList().Where(x => x.Text.Trim() != "").ToList().ForEach(y => {
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
        Random rnd = new Random();
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
            pan22();
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


        //-----------GENERICS
        
    }
}
