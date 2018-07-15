using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dal.Repositories;
using Entities.Model;
using MetroFramework.Forms;

namespace AupsWF
{
    public partial class Form1 : MetroForm
    {
        private List<OperationPlan> _operationPlans;
        private List<Item> _items;
        private List<Machine> _machines;
        private List<WorkOperation> _workOperations;

        private readonly BindingSource _bindingSource;


        private readonly UnitOfWork _unitOfWork;

        public Form1()
        {
            InitializeComponent();
            _unitOfWork = new UnitOfWork();
            Load += new EventHandler(Form1_Load);
            pnlHome.Location = pnlWelcome.Location;
            pnlKontakt.Location = pnlWelcome.Location;
            _bindingSource = new BindingSource();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hidePanels();
            pnlWelcome.Visible = true;
            metroTabControl1.SelectedTab = metroTabPage2;
            btnDodaj.Visible = false;
        }

        private void btnKontakt_Click(object sender, EventArgs e)
        {
            hidePanels();
            pnlKontakt.Visible = true;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            hidePanels();
            pnlWelcome.Visible = true;
        }

        private void btnProces_Click_1(object sender, EventArgs e)
        {
            hidePanels();
            pnlHome.Visible = true;
            metroTabControl1.SelectedTab = metroTabPage1;
        }

        private void LoadOperationPlans()
        {
            gridOperacijaRada.ColumnHeadersVisible = Visible;
            gridOperacijaRada.Visible = true;
            _operationPlans = _unitOfWork.OperationPlans.GetAll().ToList();
            _bindingSource.DataSource = _operationPlans;
         
            gridOperacijaRada.DataSource = _bindingSource;
            btnDodaj.Visible = true;

        }

        private void LoadItems()
        {
            gridItem.Visible = true;
            _items = _unitOfWork.Items.GetAll().ToList();
            _bindingSource.DataSource = _items;

            var cell = new DataGridViewComboBoxCell
            {
                DataSource = (List<Item>)_items,
                ValueType = typeof(int),
                DisplayMember = "Name",
                ValueMember = "Id",
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing

            };

            gridItem.Columns[2].CellTemplate = cell;
            gridItem.DataSource = _bindingSource;
        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (metroTabControl1.SelectedIndex)
            {
                case 0:
                   
                    LoadOperationPlans();
                    break;
                case 1:
                    LoadItems();
                    break;
                case 2:
                    LoadProcedures();
                    break;
                case 3:
                    LoadMachines();
                    break;
                case 4:
                    LoadWorkOperations();
                    break;
            }
            
        }

        private void LoadMachines()
        {
            _machines = _unitOfWork.Machines.GetAll().ToList();
            _bindingSource.DataSource = _machines;
            gridMasina.DataSource = _bindingSource;
        }

        private void LoadWorkOperations()
        {
            _workOperations = _unitOfWork.WorkOperations.GetAll().ToList();
            _bindingSource.DataSource = _workOperations;

            _items = _unitOfWork.Items.GetAll().ToList();
            _items.Add(new Item{Id = 0, Name = "Izaberite predmet"});

            _machines = _unitOfWork.Machines.GetAll().ToList();

            _machines.Add(new Machine{Id = 0,Name = "Izaberite masinu"});

            var cellItems = new DataGridViewComboBoxCell
            {
                DataSource = (List<Item>)_items,
                ValueType = typeof(int),
                DisplayMember = "Name",
                ValueMember = "Id",
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing

            };

            var cellMachines = new DataGridViewComboBoxCell
            {
                DataSource = (List<Machine>)_machines,
                ValueType = typeof(int),
                DisplayMember = "Name",
                ValueMember = "Id",
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing

            };

            gridWorkOperation.Columns[3].CellTemplate = cellItems;
            gridWorkOperation.Columns[4].CellTemplate = cellMachines;
            gridWorkOperation.DataSource = _bindingSource;
         
        }

        private void LoadProcedures()
        {
            var items = _unitOfWork.Items.GetAll().ToList();
            _bindingSource.DataSource = items;
            cbItems.DataSource = _bindingSource;
        }

        private void EditOperationPlan(OperationPlan operationPlan, bool newOP = false)
        {
            var items = _unitOfWork.Items.GetAllFinalItems().ToList();
            var formOperacijaRada = new FormOperacijaRada(operationPlan, items,_unitOfWork, newOP);
            
            formOperacijaRada.ShowDialog();
        
        }
        

        private void btnDodaj_Click(object sender, EventArgs e)
        {

            var operationPlan = new OperationPlan
            {
                CreationDate = DateTime.Today,
                StartDate = DateTime.Today
            };
            _operationPlans.Add(operationPlan);
            EditOperationPlan(operationPlan,true);

            LoadOperationPlans();
            
        }

     

        

        private void hidePanels()
        {
            pnlWelcome.Visible = false;
            pnlHome.Visible = false;
            pnlKontakt.Visible = false;
        }

        private void gridOperacijaRada_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            var id = _operationPlans[e.RowIndex].Id;
            var op = _unitOfWork.OperationPlans.GetOperationPlanById(id);
      
            EditOperationPlan(op);


            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = cbItems.SelectedItem as Item;
            if (item == null) return;
            var id = item.Id;
            var procedures = _unitOfWork.WorkOperations.GetTechnicalProcessForItem(id);
            gridTehnoloskiProces.DataSource = procedures;

            double time = 0;
            foreach (var procedure in procedures)
            {
                time += procedure.TimeNeeded * procedure.Quantity;
            }

            processTime.Text = $"Potrebno vreme za izradu jedne jedinice je: {time}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Jeste li sigurni ??",
                "Potvrdi brisanje!!",
                MessageBoxButtons.YesNo);
            if (confirmResult != DialogResult.Yes) return;
            foreach (DataGridViewRow selectedRow in gridOperacijaRada.SelectedRows)
            {
                var item = _operationPlans[selectedRow.Index];
                if (item != null)
                {
                    _unitOfWork.OperationPlans.Delete(item);
                }
                gridOperacijaRada.Rows.RemoveAt(selectedRow.Index);
               
            }
            _unitOfWork.Save();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            if (ValidateWorkOperationData())
            {
                foreach (var item in _workOperations)
                {
                    if (item.Id == 0)
                    {
                        _unitOfWork.WorkOperations.Add(item);
                        _unitOfWork.Save();
                    }
                    else
                    {
                        _unitOfWork.WorkOperations.Update(item);
                        _unitOfWork.Save();
                    }
                }
            }
            else
            {
                MessageBox.Show("Molimo Vas da proverite ispravnost podataka pre snimanja!");
            }
            
        }

        private bool ValidateWorkOperationData()
        {
            foreach (var workOperation in _workOperations)
            {
                if (workOperation.ItemId == 0 || workOperation.MachineId == 0)
                {
                    return false;
                }

            }

            return true;
        }

        private void gridOperacijaRada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (Item item in _items)
            {
                if (item.Id == 0)
                {
                    _unitOfWork.Items.Add(item);
                    _unitOfWork.Save();
                }
                else
                {
                    _unitOfWork.Items.Update(item);
                    _unitOfWork.Save();
                }
            }
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Jeste li sigurni ??",
                "Potvrdi brisanje!!",
                MessageBoxButtons.YesNo);
            if (confirmResult != DialogResult.Yes) return;
            foreach (DataGridViewRow selectedRow in gridItem.SelectedRows)
            {
                var item = _items[selectedRow.Index];
                if (item != null)
                {
                    _unitOfWork.Items.Delete(item);
                }
                gridItem.Rows.RemoveAt(selectedRow.Index);

            }
            _unitOfWork.Save();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            foreach (var machine in _machines)
            {
                if (machine.Id == 0)
                {
                    _unitOfWork.Machines.Add(machine);
                    _unitOfWork.Save();
                }
                else
                {
                    _unitOfWork.Machines.Update(machine);
                    _unitOfWork.Save();
                }
            }
        }

        private void gridWorkOperation_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Jeste li sigurni ??",
                "Potvrdi brisanje!!",
                MessageBoxButtons.YesNo);
            if (confirmResult != DialogResult.Yes) return;
            foreach (DataGridViewRow selectedRow in gridWorkOperation.SelectedRows)
            {
                var item = _workOperations[selectedRow.Index];
                if (item != null)
                {
                    _unitOfWork.WorkOperations.Delete(item);
                }
                gridWorkOperation.Rows.RemoveAt(selectedRow.Index);

            }
            _unitOfWork.Save();
        }

      

    }
}
