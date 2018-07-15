namespace AupsWF
{
    partial class FormOperacijaRada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCalculate = new MetroFramework.Controls.MetroTile();
            this.deadlineDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.startDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtKlijent = new MetroFramework.Controls.MetroTextBox();
            this.lblKlijent = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroTile();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Shift = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.productionPlanBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.creationDate = new MetroFramework.Controls.MetroDateTime();
            this.label2 = new System.Windows.Forms.Label();
            this.endDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productionPlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productionPlanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.deletePlan = new MetroFramework.Controls.MetroTile();
            this.productionPlanVmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deadlineLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionPlanBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionPlanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionPlanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionPlanVmBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.ActiveControl = null;
            this.btnCalculate.BackColor = System.Drawing.Color.Transparent;
            this.btnCalculate.Location = new System.Drawing.Point(621, 267);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(44, 37);
            this.btnCalculate.TabIndex = 33;
            this.btnCalculate.TileImage = global::AupsWF.Properties.Resources.pic13;
            this.btnCalculate.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCalculate.UseCustomBackColor = true;
            this.btnCalculate.UseCustomForeColor = true;
            this.btnCalculate.UseSelectable = true;
            this.btnCalculate.UseTileImage = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // deadlineDate
            // 
            this.deadlineDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.deadlineDate.Location = new System.Drawing.Point(484, 267);
            this.deadlineDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.deadlineDate.Name = "deadlineDate";
            this.deadlineDate.Size = new System.Drawing.Size(106, 29);
            this.deadlineDate.TabIndex = 27;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(432, 277);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(34, 19);
            this.metroLabel2.TabIndex = 26;
            this.metroLabel2.Text = "Rok:";
            // 
            // startDate
            // 
            this.startDate.CustomFormat = "";
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDate.Location = new System.Drawing.Point(473, 189);
            this.startDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(181, 29);
            this.startDate.TabIndex = 25;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Enabled = false;
            this.metroLabel1.Location = new System.Drawing.Point(473, 153);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(130, 19);
            this.metroLabel1.TabIndex = 24;
            this.metroLabel1.Text = "Početak proizvodnje:";
            // 
            // txtKlijent
            // 
            // 
            // 
            // 
            this.txtKlijent.CustomButton.Image = null;
            this.txtKlijent.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.txtKlijent.CustomButton.Name = "";
            this.txtKlijent.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtKlijent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKlijent.CustomButton.TabIndex = 1;
            this.txtKlijent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKlijent.CustomButton.UseSelectable = true;
            this.txtKlijent.CustomButton.Visible = false;
            this.txtKlijent.Lines = new string[0];
            this.txtKlijent.Location = new System.Drawing.Point(484, 109);
            this.txtKlijent.MaxLength = 32767;
            this.txtKlijent.Name = "txtKlijent";
            this.txtKlijent.PasswordChar = '\0';
            this.txtKlijent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKlijent.SelectedText = "";
            this.txtKlijent.SelectionLength = 0;
            this.txtKlijent.SelectionStart = 0;
            this.txtKlijent.ShortcutsEnabled = true;
            this.txtKlijent.Size = new System.Drawing.Size(181, 23);
            this.txtKlijent.TabIndex = 23;
            this.txtKlijent.UseSelectable = true;
            this.txtKlijent.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKlijent.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblKlijent
            // 
            this.lblKlijent.AutoSize = true;
            this.lblKlijent.Location = new System.Drawing.Point(432, 113);
            this.lblKlijent.Name = "lblKlijent";
            this.lblKlijent.Size = new System.Drawing.Size(46, 19);
            this.lblKlijent.TabIndex = 22;
            this.lblKlijent.Text = "Klijent:";
            // 
            // btnSave
            // 
            this.btnSave.ActiveControl = null;
            this.btnSave.BackColor = System.Drawing.Color.Tan;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(515, 384);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 64);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Snimi";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.TileImage = global::AupsWF.Properties.Resources.pic12;
            this.btnSave.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseCustomForeColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.UseTileImage = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.quantityDataGridViewTextBoxColumn,
            this.Item,
            this.Shift});
            this.dataGridView1.DataSource = this.productionPlanBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(28, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(398, 294);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Količina";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // Item
            // 
            this.Item.DataPropertyName = "ItemId";
            this.Item.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Item.HeaderText = "Proizvod";
            this.Item.MinimumWidth = 100;
            this.Item.Name = "Item";
            this.Item.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Item.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Item.Width = 150;
            // 
            // Shift
            // 
            this.Shift.DataPropertyName = "Shifts";
            this.Shift.DataSource = this.productionPlanBindingSource2;
            this.Shift.DisplayMember = "Shifts";
            this.Shift.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Shift.HeaderText = "Broj smena";
            this.Shift.Name = "Shift";
            this.Shift.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Shift.ValueMember = "Shifts";
            // 
            // productionPlanBindingSource2
            // 
            this.productionPlanBindingSource2.DataSource = typeof(Entities.Model.ProductionPlan);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Item";
            this.dataGridViewTextBoxColumn1.HeaderText = "Item";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Item";
            this.dataGridViewTextBoxColumn2.HeaderText = "Item";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Prozvodni planovi:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tan;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(319, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 42);
            this.button2.TabIndex = 37;
            this.button2.Text = "Završi proizvodnju";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            // 
            // creationDate
            // 
            this.creationDate.CustomFormat = "";
            this.creationDate.Enabled = false;
            this.creationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.creationDate.Location = new System.Drawing.Point(462, 39);
            this.creationDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.creationDate.Name = "creationDate";
            this.creationDate.Size = new System.Drawing.Size(181, 29);
            this.creationDate.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Datum kreiranja:";
            // 
            // endDate
            // 
            this.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDate.Location = new System.Drawing.Point(132, 419);
            this.endDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(181, 29);
            this.endDate.TabIndex = 40;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Enabled = false;
            this.metroLabel3.Location = new System.Drawing.Point(23, 429);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(107, 19);
            this.metroLabel3.TabIndex = 41;
            this.metroLabel3.Text = "Kraj proizvodnje:";
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(Entities.Model.Item);
            // 
            // productionPlanBindingSource
            // 
            this.productionPlanBindingSource.DataSource = typeof(Entities.Model.ProductionPlan);
            // 
            // productionPlanBindingSource1
            // 
            this.productionPlanBindingSource1.DataSource = typeof(Entities.Model.ProductionPlan);
            // 
            // deletePlan
            // 
            this.deletePlan.ActiveControl = null;
            this.deletePlan.BackColor = System.Drawing.Color.Transparent;
            this.deletePlan.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.deletePlan.Location = new System.Drawing.Point(442, 341);
            this.deletePlan.Name = "deletePlan";
            this.deletePlan.Size = new System.Drawing.Size(69, 37);
            this.deletePlan.TabIndex = 42;
            this.deletePlan.Text = "Obriši";
            this.deletePlan.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deletePlan.UseCustomBackColor = true;
            this.deletePlan.UseCustomForeColor = true;
            this.deletePlan.UseSelectable = true;
            this.deletePlan.UseTileImage = true;
            this.deletePlan.Click += new System.EventHandler(this.deletePlan_Click);
            // 
            // deadlineLabel
            // 
            this.deadlineLabel.AutoSize = true;
            this.deadlineLabel.ForeColor = System.Drawing.Color.Brown;
            this.deadlineLabel.Location = new System.Drawing.Point(432, 309);
            this.deadlineLabel.Name = "deadlineLabel";
            this.deadlineLabel.Size = new System.Drawing.Size(0, 13);
            this.deadlineLabel.TabIndex = 43;
            // 
            // FormOperacijaRada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 455);
            this.Controls.Add(this.deadlineLabel);
            this.Controls.Add(this.deletePlan);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.creationDate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.deadlineDate);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtKlijent);
            this.Controls.Add(this.lblKlijent);
            this.Name = "FormOperacijaRada";
            this.Text = "Operativni plan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionPlanBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionPlanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionPlanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionPlanVmBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnCalculate;
        private MetroFramework.Controls.MetroDateTime deadlineDate;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime startDate;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtKlijent;
        private MetroFramework.Controls.MetroLabel lblKlijent;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource productionPlanBindingSource;
        private System.Windows.Forms.BindingSource productionPlanVmBindingSource;
        private System.Windows.Forms.BindingSource productionPlanBindingSource1;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTile btnSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource productionPlanBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Item;
        private System.Windows.Forms.DataGridViewComboBoxColumn Shift;
        private MetroFramework.Controls.MetroDateTime creationDate;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTile deletePlan;
        public MetroFramework.Controls.MetroDateTime endDate;
        private System.Windows.Forms.Label deadlineLabel;
    }
}