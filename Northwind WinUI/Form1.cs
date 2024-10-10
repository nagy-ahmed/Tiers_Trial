using BLL.Entities;
using BLL.EntityLists;
using BLL.EntityManager;
using System.Diagnostics;

namespace Northwind_WinUI
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }
        ProductList products;
        BindingSource bs ;
        int currentPage = -1;
        int pageCount = 10;
        int pageNum => (products.Count / pageCount);

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                products = ProductManager.SelectAllProducts();
                //var products = ProductManager.SelectAllProducts().Where(p=>p.UnitPrice>0).Take(10).ToList();
                //dataGridView1.DataSource = products;
                bs = new BindingSource();
                bs.DataSource = products;
                bs.AddingNew += (s, e) =>
                {
                    e.NewObject = new Product() { State=EntityState.Added};
                };
                dataGridView1.DataSource = bs;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error in loadToolStripMenuItem_Click");
                Debug.WriteLine(ex.Message);
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ProductManager.DeleteProductById(1);
            foreach (var item in products)
            {
                Trace.WriteLine($"{item.ProductID}  : {item.State}");
            }
        }
        public void DisplayPage(int current) =>
            dataGridView1.DataSource = products.Skip(current * pageCount).Take(pageCount).ToList();
        private void toolStripMenuPageUP_Click(object sender, EventArgs e)
        {
            if (products == null)
            {
                products = ProductManager.SelectAllProducts();
            }
            currentPage++;
            if (currentPage > pageNum)
                currentPage = 0;
            DisplayPage(currentPage);
        }

        private void toolStripMenuPageDown_Click(object sender, EventArgs e)
        {
            if (products == null)
            {
                products = ProductManager.SelectAllProducts();
            }
            currentPage--;
            if (currentPage < 0)
                currentPage = pageNum;
            DisplayPage(currentPage);
        }

        
    }
}
