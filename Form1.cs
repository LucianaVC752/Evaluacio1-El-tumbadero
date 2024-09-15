using System;
using System.Drawing.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Evaluacion1
{
    public partial class Form1 : Form
    {
        int indice = -1;
        static List<Tuple<string, double, int>> listProduct = new List<Tuple<string, double, int>>()
            {
           new Tuple<string, double, int>("Manzanas", 1.50, 10),
           new Tuple<string, double, int>("Pan", 0.90, 20),
           new Tuple<string, double, int>("Leche", 1.20, 15),
           new Tuple<string, double, int>("Huevos", 2.50, 12),
           new Tuple<string, double, int>("Arroz", 3.00, 8)
            };
        int[] cantidadVendida = new int[listProduct.Count];
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            cblistProducts.Items.Clear();

            foreach (var product in listProduct)
            {
                cblistProducts.Items.Add(product.Item1);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(products.Text) ||
                string.IsNullOrEmpty(price.Text) ||
                string.IsNullOrEmpty(quantify.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }
            else
            {
                cblistProducts.Items.Add(products.Text);
                double priceValue = Convert.ToDouble(price.Text);
                int quantifY = int.Parse(quantify.Text);
                listProduct.Add(new Tuple<string, double, int>(products.Text, priceValue, quantifY));
                products.Clear();
                price.Clear();
                quantify.Clear();
            }
        }

        private void AddShop_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(quantify.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            int indice = cblistProducts.SelectedIndex;
            if (indice == -1)
            {
                MessageBox.Show("Por favor, selecciona un producto.");
                return;
            }

            var productoSeleccionado = listProduct[indice];
            int cantidadDisponible = productoSeleccionado.Item3;
            int quantifyShop = int.Parse(quantify.Text);

            if (cantidadDisponible > 0)
            {
                if (quantifyShop > cantidadDisponible)
                {
                    MessageBox.Show("No hay suficiente stock disponible.");
                    CleanComboBox();
                }
                else
                {
                    string nameProduct = productoSeleccionado.Item1;
                    double priceProduct = productoSeleccionado.Item2;
                    listProduct[indice] = new Tuple<string, double, int>(nameProduct, priceProduct, cantidadDisponible - quantifyShop);

                    ListViewItem item = new ListViewItem(nameProduct);
                    item.SubItems.Add(quantifyShop.ToString());
                    item.SubItems.Add(priceProduct.ToString("F2"));
                    listView1.Items.Add(item);

                    if (indice < cantidadVendida.Length)
                    {
                        cantidadVendida[indice] += quantifyShop;
                    }
                    else
                    {
                        Array.Resize(ref cantidadVendida, indice + 1);
                        cantidadVendida[indice] = quantifyShop;
                    }

                    price.Clear();
                    quantify.Clear();
                    products.Focus();
                    CleanComboBox();
                }
            }
            else
            {
                cblistProducts.Items.RemoveAt(indice);
                CleanComboBox();
            }
   
        }

        private void deleteProduct_Click(object sender, EventArgs e)
        {
            int index = cblistProducts.SelectedIndex;
            bool isValorListView = listView1.SelectedItems.Count > 0;
            if (index != -1 && isValorListView)
            {
                MessageBox.Show("Solo puedes eliminar un producto o una venta a la vez.");
                return;
            }
            if (index == -1 && !isValorListView)
            {
                MessageBox.Show("Por favor, selecciona un producto o una venta para eliminar.");
                return;
            }
            if (index != -1)
            {
                UpdateListView(index);
                listProduct.Remove(listProduct[index]);
                cantidadVendida = cantidadVendida.Where((val, i) => i != index).ToArray();
                cblistProducts.Items.RemoveAt(index);
                MessageBox.Show("Producto eliminado con éxito.");
                CleanComboBox();
            }

            else if (isValorListView)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
                MessageBox.Show("Venta eliminada correctamente.");
            }

        }

        private void CleanComboBox()
        {
            cblistProducts.SelectedIndex = -1;
        }


        private void button5_Click(object sender, EventArgs e)
        {

            int maxIndex = 0;
            int contador = cantidadVendida.Length;
            for (int i = 1; i < contador; i++)
            {
                if (cantidadVendida[i] > cantidadVendida[maxIndex])
                {
                    maxIndex = i;
                }
            }
            moreSold.Text = ($"El producto más vendido es: {listProduct[maxIndex].Item1} con {cantidadVendida[maxIndex]} unidades.");


        }

        private void button4_Click(object sender, EventArgs e)
        {
            int minIndex = 0;
            int contador = cantidadVendida.Length;

            for (int i = 1; i < contador; i++)
            {
                if (cantidadVendida[i] < cantidadVendida[minIndex])
                {
                    minIndex = i;
                }
            }
            lessSold.Text = ($"El producto menos vendido es: {listProduct[minIndex].Item1} con {cantidadVendida[minIndex]} unidades.");
        }
        private void UpdateListView(int _index)
        {       
            var itemToRemove = listProduct[_index].Item1;

            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Text == itemToRemove)
                {
                    listView1.Items.Remove(item);
                    break; 
                }
            }

        }

    }
}
