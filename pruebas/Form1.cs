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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            vm1();
            test3();
            
        }

        Random rnd = new Random();
        List<VM_M> Vm = new List<VM_M>();
        List<decimal> Vv;// = new List<decimal>();
        int v1;
        int v2;
        Decimal Vr;// = 0;
        string Sv;

        public class VM_M
        {
            public int p { get; set; }
            public string s { get; set; }
        }

        public void vm1()
        {
            Vm.Add(new VM_M { p = 0, s = "+" });
            Vm.Add(new VM_M { p = 1, s = "-" });
            Vm.Add(new VM_M { p = 2, s = "X" });
            Vm.Add(new VM_M { p = 3, s = "%" });
        }

        public void vv_m(int vf)
        {
            for (int i = 0; i < 4; i++){
                Vv.Add(Convert.ToDecimal((Convert.ToDecimal(rnd.Next(1, vf)) + Convert.ToDecimal(rnd.NextDouble())).ToString("0.00")));
            }
        }


        public void t1()
        {
            Vv = new List<decimal>();
            v1 = rnd.Next(1, 100);
            v2 = rnd.Next(1, 100);
            Vr = 0;
            

            /*generate random result LIST
            var result = Vm.OrderBy(item => rnd.Next());
            */
            
            switch (rnd.Next(0,Vm.Count))
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
                    Sv = "*";
                    break;
                case 3:
                    Vr = Convert.ToDecimal((Convert.ToDecimal(v1) / Convert.ToDecimal(v2)).ToString("0.00"));
                    Sv = "/";
                    break;
            }

            if (Vr >= 0 && Vr <= 10){
                vv_m(10);
            }else if (Vr >= 11 && Vr <= 100){
                vv_m(100);
            }else if (Vr >= 101 && Vr <= 1000){
                vv_m(1000);
            }else if (Vr >= 1001 && Vr <= 10000){
                vv_m(10000);
            }

            Vv.Add(Vr);
            Vv = Vv.OrderBy(x => rnd.Next()).ToList();

            label1.Text = v1.ToString();
            label2.Text = Sv.ToString();
            label3.Text = v2.ToString();
            label4.Text = Vr.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t1();
            /*
                foreach ( Control aControl in this.Controls )
                {
                this.CheckedListBox1.Items.Add(aControl, false);
                }
             */
            var a = v1;
            var a1 = v2;
            var a3 = Vr;
            var a4 = Sv;
            var b = Vv;
            listBox1.Items.Clear();
            
            //foreach (var item in Vv)
            //{
            //    listBox1.Items.Add(item);
            //}
            //listBox1.DrawMode = DrawMode.OwnerDrawFixed;
            
        }

        int TamanioColumnasFilas = 4;
        public void test3()
        {
            
            var tablaPanel = new TableLayoutPanel();
            tablaPanel.RowCount = 5;
            tablaPanel.ColumnCount = 1;
            for (int i = 0; i < TamanioColumnasFilas; i++)
            {
                var Porcentaje = 150f / (float)TamanioColumnasFilas - 10;
                tablaPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, Porcentaje));
                tablaPanel.RowStyles.Add(new RowStyle(SizeType.Percent, Porcentaje));
            }
            int contadorFichas = 1;

            for (var i = 0; i < TamanioColumnasFilas; i++)
            {
                    var CartasJuego = new PictureBox();
                    CartasJuego.Name = string.Format("{0}", contadorFichas);
                    CartasJuego.Dock = DockStyle.Fill;
                    CartasJuego.SizeMode = PictureBoxSizeMode.StretchImage;
                    CartasJuego.Image = Properties.Resources.Girada;
                    CartasJuego.Cursor = Cursors.Hand;
                    //CartasJuego.Click += btnCarta_Click;
                    tablaPanel.Controls.Add(CartasJuego, 0, i);
                    contadorFichas++;
            }
            tablaPanel.Dock = DockStyle.Fill;
            panel1.Controls.Add(tablaPanel);
        }



        public void test2()
        {
            
            // Set the view to show details.
            listView1.View = View.Details;
           

            // Create three items and three sets of subitems for each item.
            ListViewItem item1 = new ListViewItem("item1", 0);
            // Place a check mark next to the item.
         
            // Create columns for the items and subitems.
            // Width of -2 indicates auto-size.
            listView1.Columns.Add("Item Column", -2, HorizontalAlignment.Left);

            //Add the items to the ListView.
            listView1.Items.AddRange(new ListViewItem[] { item1});

            // Create two ImageList objects.
            ImageList imageListSmall = new ImageList();
            imageListSmall.ImageSize = new System.Drawing.Size(50, 50);

            // Initialize the ImageList objects with bitmaps.
            imageListSmall.Images.Add(Properties.Resources.Girada);

            //Assign the ImageList objects to the ListView.
            listView1.SmallImageList = imageListSmall;
        }

        

        public void test()
        {
            //ListView listView1 = new ListView();
            //listView1.Bounds = new Rectangle(new Point(10, 10), new Size(300, 200));

            // Set the view to show details.
            listView1.View = View.Details;
            // Allow the user to edit item text.
            listView1.LabelEdit = true;
            // Allow the user to rearrange columns.
            listView1.AllowColumnReorder = true;
            // Display check boxes.
            listView1.CheckBoxes = true;
            // Select the item and subitems when selection is made.
            listView1.FullRowSelect = true;
            // Display grid lines.
            listView1.GridLines = true;
            // Sort the items in the list in ascending order.
            listView1.Sorting = SortOrder.Ascending;

            // Create three items and three sets of subitems for each item.
            ListViewItem item1 = new ListViewItem("item1", 0);
            // Place a check mark next to the item.
            item1.Checked = true;
            item1.SubItems.Add("1");
            item1.SubItems.Add("2");
            item1.SubItems.Add("3");
            ListViewItem item2 = new ListViewItem("item2", 1);
            item2.SubItems.Add("4");
            item2.SubItems.Add("5");
            item2.SubItems.Add("6");
            ListViewItem item3 = new ListViewItem("item3", 0);
            // Place a check mark next to the item.
            item3.Checked = true;
            item3.SubItems.Add("7");
            item3.SubItems.Add("8");
            item3.SubItems.Add("9");

            // Create columns for the items and subitems.
            // Width of -2 indicates auto-size.
            listView1.Columns.Add("Item Column", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Column 2", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Column 3", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Column 4", -2, HorizontalAlignment.Center);

            //Add the items to the ListView.
            listView1.Items.AddRange(new ListViewItem[] { item1, item2, item3 });

            // Create two ImageList objects.
            ImageList imageListSmall = new ImageList();
            ImageList imageListLarge = new ImageList();
            imageListSmall.ImageSize = new System.Drawing.Size(50, 50);
            imageListLarge.ImageSize = new System.Drawing.Size(50, 50);


            // Initialize the ImageList objects with bitmaps.
            imageListSmall.Images.Add(Properties.Resources.Girada);
            imageListSmall.Images.Add(Properties.Resources.Girada);
            imageListSmall.Images.Add(Properties.Resources.Girada);
            imageListSmall.Images.Add(Properties.Resources.Girada);
                
            

            //Assign the ImageList objects to the ListView.
            listView1.LargeImageList = imageListLarge;
            listView1.SmallImageList = imageListSmall;

            // Add the ListView to the control collection.
            this.Controls.Add(listView1);
     

            
            
            
        }






        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox1.Items)
            {
                var a = item;
                
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
