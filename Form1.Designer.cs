namespace Evaluacion1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            products = new TextBox();
            quantify = new TextBox();
            price = new TextBox();
            addButton = new Button();
            deleteProduct = new Button();
            AddShop = new Button();
            button4 = new Button();
            button5 = new Button();
            listView1 = new ListView();
            prod = new ColumnHeader();
            quanti = new ColumnHeader();
            prices = new ColumnHeader();
            cblistProducts = new ComboBox();
            title = new Label();
            moreSold = new Label();
            label6 = new Label();
            lessSold = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 49);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 82);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 1;
            label2.Text = "Valor Unitario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 120);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 2;
            label3.Text = "Productos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 157);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 3;
            label4.Text = "Cantidad ";
            // 
            // products
            // 
            products.Location = new Point(163, 41);
            products.Name = "products";
            products.Size = new Size(253, 23);
            products.TabIndex = 5;
            // 
            // quantify
            // 
            quantify.Location = new Point(163, 160);
            quantify.Name = "quantify";
            quantify.Size = new Size(100, 23);
            quantify.TabIndex = 6;
            // 
            // price
            // 
            price.Location = new Point(163, 75);
            price.Name = "price";
            price.Size = new Size(100, 23);
            price.TabIndex = 7;
            // 
            // addButton
            // 
            addButton.Location = new Point(454, 45);
            addButton.Name = "addButton";
            addButton.Size = new Size(169, 23);
            addButton.TabIndex = 8;
            addButton.Text = "Agregar Producto";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // deleteProduct
            // 
            deleteProduct.Location = new Point(454, 112);
            deleteProduct.Name = "deleteProduct";
            deleteProduct.Size = new Size(75, 23);
            deleteProduct.TabIndex = 9;
            deleteProduct.Text = "Quitar";
            deleteProduct.UseVisualStyleBackColor = true;
            deleteProduct.Click += deleteProduct_Click;
            // 
            // AddShop
            // 
            AddShop.Location = new Point(454, 171);
            AddShop.Name = "AddShop";
            AddShop.Size = new Size(104, 23);
            AddShop.TabIndex = 10;
            AddShop.Text = "Agregar Venta";
            AddShop.UseVisualStyleBackColor = true;
            AddShop.Click += AddShop_Click;
            // 
            // button4
            // 
            button4.Location = new Point(91, 402);
            button4.Name = "button4";
            button4.Size = new Size(154, 23);
            button4.TabIndex = 11;
            button4.Text = "Producto menos vendido";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(88, 359);
            button5.Name = "button5";
            button5.Size = new Size(157, 23);
            button5.TabIndex = 12;
            button5.Text = "Producto mas vendido";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { prod, quanti, prices });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(150, 213);
            listView1.Name = "listView1";
            listView1.Size = new Size(505, 131);
            listView1.TabIndex = 13;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // prod
            // 
            prod.Text = "Productos";
            prod.Width = 200;
            // 
            // quanti
            // 
            quanti.Text = "Cantidad";
            quanti.Width = 150;
            // 
            // prices
            // 
            prices.Text = "Precio";
            prices.Width = 150;
            // 
            // cblistProducts
            // 
            cblistProducts.FormattingEnabled = true;
            cblistProducts.Location = new Point(163, 120);
            cblistProducts.Name = "cblistProducts";
            cblistProducts.Size = new Size(121, 23);
            cblistProducts.TabIndex = 14;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.Location = new Point(208, 1);
            title.Name = "title";
            title.Size = new Size(363, 37);
            title.TabIndex = 15;
            title.Text = "MERCADO EL TUMBADERO";
            // 
            // moreSold
            // 
            moreSold.AutoSize = true;
            moreSold.Location = new Point(296, 367);
            moreSold.Name = "moreSold";
            moreSold.Size = new Size(0, 15);
            moreSold.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(381, 218);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 17;
            // 
            // lessSold
            // 
            lessSold.AutoSize = true;
            lessSold.Location = new Point(296, 406);
            lessSold.Name = "lessSold";
            lessSold.Size = new Size(0, 15);
            lessSold.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lessSold);
            Controls.Add(label6);
            Controls.Add(moreSold);
            Controls.Add(title);
            Controls.Add(cblistProducts);
            Controls.Add(listView1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(AddShop);
            Controls.Add(deleteProduct);
            Controls.Add(addButton);
            Controls.Add(price);
            Controls.Add(quantify);
            Controls.Add(products);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox products;
        private TextBox quantify;
        private TextBox price;
        private Button addButton;
        private Button deleteProduct;
        private Button AddShop;
        private Button button4;
        private Button button5;
        private ListView listView1;
        private ComboBox cblistProducts;
        private ColumnHeader prod;
        private ColumnHeader quanti;
        private ColumnHeader prices;
        private Label title;
        private Label moreSold;
        private Label label6;
        private Label lessSold;
    }
}
