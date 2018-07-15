using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dal.Repositories;
using Entities.Model;

namespace Aups.Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var unitOfWork = new UnitOfWork();
            var items = unitOfWork.Items.GetAll().ToList();

            dataGridView1.DataSource = items;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = dataGridView1.DataSource;
            List<Item> Items = new List<Item>();
            Items = (List<Item>) data;
            Console.WriteLine(Items.Count);

        }
    }
}
