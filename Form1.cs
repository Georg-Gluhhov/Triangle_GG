using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle_GG
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            try { 
            listView1.Items.Clear();
            double a, b, c;
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            c = Convert.ToDouble(txtC.Text);
            Triangle triangle = new Triangle(a, b, c);
            listView1.Items.Add("Сторона A");
            listView1.Items.Add("Сторона B");
            listView1.Items.Add("Сторона C");
            listView1.Items.Add("Периметр");
            listView1.Items.Add("Площадь");
            listView1.Items.Add("Существует?");
            listView1.Items.Add("Спецификатор");
            listView1.Items[0].SubItems.Add(triangle.outputA());
            listView1.Items[1].SubItems.Add(triangle.outputB());
            listView1.Items[2].SubItems.Add(triangle.outputC());
            listView1.Items[3].SubItems.Add(Convert.ToString(triangle.Perimeter()));
            listView1.Items[4].SubItems.Add(Convert.ToString(triangle.Surface()));
            if (triangle.ExistTriangle) { listView1.Items[5].SubItems.Add("Существует"); }
            else listView1.Items[5].SubItems.Add("Не существует");
            if (a == b && a == c)
            {
                listView1.Items[6].SubItems.Add("Равносторонний");
                TriangleImage.Image = Image.FromFile(@"..\..\img\RavnStorTriangle.png");
            }
            else if (a == b || a == c || b == c)
            {
                listView1.Items[6].SubItems.Add("Равнобедренный");
                TriangleImage.Image = Image.FromFile(@"..\..\img\RavnBedTriangle.png");
            }
            else
            {
                listView1.Items[6].SubItems.Add("Разносторонний");
                TriangleImage.Image = Image.FromFile(@"..\..\img\RaznStorTriangle.png");
            }
            }
            catch
            {
                listView1.Items.Add("Нужны данные");
            }
        }

        private void TriangleImage_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            form2 = null;
            Show();
        }
    }
}
