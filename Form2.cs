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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtC.Enabled = true;
            txtB.Enabled = true;
            if (comboBox1.SelectedItem.ToString() == "Равносторонний")
            {
                txtC.Enabled = false;
                txtB.Enabled = false;
                TriangleImage.Image = Image.FromFile(@"..\..\img\RavnStorTriangle.png");
            }
            else if (comboBox1.SelectedItem.ToString() == "Равнобедренный")
            {
                txtC.Enabled = false;
                TriangleImage.Image = Image.FromFile(@"..\..\img\RavnBedTriangle.png");
            }
            else if (comboBox1.SelectedItem.ToString() == "Разносторонний")
            {
                               TriangleImage.Image = Image.FromFile(@"..\..\img\RaznStorTriangle.png");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            listView1.Items.Clear();
            double a, b, c;
            a = Convert.ToDouble(txtA.Text);
            Triangle triangle = new Triangle(a, a, a);
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
            if (comboBox1.SelectedItem.ToString() == "Равносторонний")
            {
               triangle = new Triangle(a, a, a);
               listView1.Items[6].SubItems.Add("Равносторонний");
            }
            else if (comboBox1.SelectedItem.ToString() == "Равнобедренный")
            {
                b = Convert.ToDouble(txtB.Text);
                triangle = new Triangle(a, b, b);
                if (a == b)
                {
                    listView1.Items[6].SubItems.Add("Равносторонний");
                    TriangleImage.Image = Image.FromFile(@"..\..\img\RavnStorTriangle.png");
                }
                else if (a != b)
                {
                    listView1.Items[6].SubItems.Add("Равнобедренный");
                    TriangleImage.Image = Image.FromFile(@"..\..\img\RavnBedTriangle.png");
                }
            }           
            else if (comboBox1.SelectedItem.ToString() == "Разносторонний")
            {
                b = Convert.ToDouble(txtB.Text);
                c = Convert.ToDouble(txtC.Text);
                triangle = new Triangle(a, b, c);
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
            if (triangle.ExistTriangle) { listView1.Items[5].SubItems.Add("Существует"); }
            else listView1.Items[5].SubItems.Add("Не существует");



        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

    }

}
