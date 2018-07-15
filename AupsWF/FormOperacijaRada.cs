using MetroFramework.Forms;
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

using AutoMapper;
using Dal.Repositories;
using Entities.Model;

namespace AupsWF
{
    public partial class FormOperacijaRada : MetroForm
    {
        private readonly OperationPlan _operationPlan;
        private readonly UnitOfWork _unitOfWork;
        private  bool _newOP;
        
        

        public FormOperacijaRada(OperationPlan operationPlan, List<Item> items,UnitOfWork unitOfWork,bool newOP = false)
        {
            _operationPlan = operationPlan;
            _unitOfWork = unitOfWork;
            _newOP = newOP;
            InitializeComponent();
            

            
            var bs = new BindingSource {DataSource = operationPlan.ProductionPlans};

            items.Add(new Item
            {
                Id = 0, Name = "Izaberite proizvod"
            });

            var shifts = new List<Shift>
            {
                new Shift{Value = 0, Display = "Nije izabrano"},
                new Shift{Value = 1, Display = "1 smena"},
                new Shift{Value = 2, Display = "2 smene"},
                new Shift{Value = 3, Display = "3 smene"}
            };

            var shiftsCell = new DataGridViewComboBoxCell
            {
                DataSource = (List<Shift>)shifts,
                ValueType = typeof(int),
                DisplayMember = "Display",
                ValueMember = "Value",
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };

         
            var cell = new DataGridViewComboBoxCell
            {
                DataSource = (List<Item>)items,
                ValueType = typeof(int),
                DisplayMember = "Name",
                ValueMember = "Id",
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
                
            };

            
            dataGridView1.Columns[1].CellTemplate = cell;
            dataGridView1.Columns[2].CellTemplate = shiftsCell;
       
            dataGridView1.DataSource = bs;
            DataToView();


        }

        private void DataToView()
        {
            txtKlijent.Text = _operationPlan.Client;
            startDate.Value = _operationPlan.StartDate;
            if (_operationPlan.CreationDate.Equals(new DateTime()))
            {
                _operationPlan.CreationDate = DateTime.Today;
                creationDate.Value = _operationPlan.CreationDate;
            }
            if (_operationPlan.EndDate.Equals(new DateTime()))
            {
                endDate.Value = DateTime.Today;
            }
            if (_operationPlan.Deadline.Equals(new DateTime()))
            {
                deadlineDate.Value = DateTime.Today;
            }
            

        }

        private void ViewToData()
        {
            _operationPlan.Client = txtKlijent.Text;
            _operationPlan.StartDate = startDate.Value;
            _operationPlan.CreationDate = creationDate.Value;
            _operationPlan.EndDate = endDate.Value;
            _operationPlan.Deadline = deadlineDate.Value;


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this._operationPlan != null)
            {
                if (ValidateData())
                {
                    ViewToData();
                    SaveData();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Molimo Vas da proverite ispravnost podataka pre snimanja!");
                }
                

            }
           
            
        }

        private void SaveData()
        {
            if (_newOP)
            {
                _unitOfWork.OperationPlans.Add(_operationPlan);
                _unitOfWork.Save();
            }
            else
            {
                _unitOfWork.OperationPlans.Update(_operationPlan);
                _unitOfWork.Save();
            }
        }

        private bool ValidateData()
        {
            if (txtKlijent.Text.Length < 4)
            {
                return false;
            }
            foreach (var plan in _operationPlan.ProductionPlans)
            {
                if (plan.ItemId == 0 || plan.Shifts == 0)
                {
                    return false;
                }
            }

            return true;
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            DateTime predictedDate = _unitOfWork.OperationPlans.CalculateProductionDeadline(_operationPlan);

            deadlineLabel.Text = $"Predviđeno vreme završetka: {predictedDate.ToString("d")}";

            deadlineDate.Value = predictedDate;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deletePlan_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Jeste li sigurni ??",
                "Potvrdi brisanje!!",
                MessageBoxButtons.YesNo);
            if (confirmResult != DialogResult.Yes) return;
            foreach (DataGridViewRow selectedRow in dataGridView1.SelectedRows)
            {
                var item = _operationPlan.ProductionPlans.ToList()[selectedRow.Index];  
                dataGridView1.Rows.RemoveAt(selectedRow.Index);
                _unitOfWork.ProductionPlans.Delete(item);
               
            }
            _unitOfWork.Save();
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

            if (e.ColumnIndex == 0)
            {
                int i;

                if (!int.TryParse(Convert.ToString(e.FormattedValue), out i))
                {
                    dataGridView1.Rows[e.RowIndex].ErrorText =
                        "Mora biti broj";
                    e.Cancel = true;

                }
            };
           
            
        }
    }
}
