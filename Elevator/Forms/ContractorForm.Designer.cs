﻿namespace Elevator.Forms
{
    partial class ContractorForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContractorForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAllList = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.findButton = new System.Windows.Forms.Button();
            this.dataGridViewContractor = new System.Windows.Forms.DataGridView();
            this.idcontractorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namecontrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subdivisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.juraddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailindexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.innDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceContractor = new System.Windows.Forms.BindingSource(this.components);
            this.accountOfGrainElevatorDataSet = new Elevator.AccountOfGrainElevatorDataSet();
            this.addButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.contractorTableAdapter = new Elevator.AccountOfGrainElevatorDataSetTableAdapters.ContractorTableAdapter();
            this.nameContractortextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContractor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceContractor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountOfGrainElevatorDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nameContractortextBox);
            this.groupBox1.Controls.Add(this.btnAllList);
            this.groupBox1.Controls.Add(this.lbName);
            this.groupBox1.Controls.Add(this.findButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(824, 68);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // btnAllList
            // 
            this.btnAllList.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAllList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAllList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAllList.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAllList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllList.Location = new System.Drawing.Point(525, 23);
            this.btnAllList.Name = "btnAllList";
            this.btnAllList.Size = new System.Drawing.Size(281, 28);
            this.btnAllList.TabIndex = 7;
            this.btnAllList.Text = "Вывести полный список";
            this.btnAllList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAllList.UseVisualStyleBackColor = false;
            this.btnAllList.Click += new System.EventHandler(this.btnAllList_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.ForeColor = System.Drawing.Color.Black;
            this.lbName.Location = new System.Drawing.Point(9, 27);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(115, 18);
            this.lbName.TabIndex = 6;
            this.lbName.Text = "Наименование:";
            // 
            // findButton
            // 
            this.findButton.BackColor = System.Drawing.Color.DarkOrange;
            this.findButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.findButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.findButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.findButton.Location = new System.Drawing.Point(428, 23);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(82, 28);
            this.findButton.TabIndex = 5;
            this.findButton.Text = "Найти";
            this.findButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.findButton.UseVisualStyleBackColor = false;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // dataGridViewContractor
            // 
            this.dataGridViewContractor.AllowUserToAddRows = false;
            this.dataGridViewContractor.AllowUserToDeleteRows = false;
            this.dataGridViewContractor.AutoGenerateColumns = false;
            this.dataGridViewContractor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewContractor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            this.dataGridViewContractor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewContractor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewContractor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContractor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcontractorDataGridViewTextBoxColumn,
            this.namecontrDataGridViewTextBoxColumn,
            this.subdivisionDataGridViewTextBoxColumn,
            this.juraddressDataGridViewTextBoxColumn,
            this.factaddressDataGridViewTextBoxColumn,
            this.mailindexDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.innDataGridViewTextBoxColumn});
            this.dataGridViewContractor.DataSource = this.contractorBindingSource;
            this.dataGridViewContractor.EnableHeadersVisualStyles = false;
            this.dataGridViewContractor.Location = new System.Drawing.Point(12, 137);
            this.dataGridViewContractor.Name = "dataGridViewContractor";
            this.dataGridViewContractor.ReadOnly = true;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewContractor.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewContractor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewContractor.Size = new System.Drawing.Size(824, 102);
            this.dataGridViewContractor.TabIndex = 43;
            // 
            // idcontractorDataGridViewTextBoxColumn
            // 
            this.idcontractorDataGridViewTextBoxColumn.DataPropertyName = "id_contractor";
            this.idcontractorDataGridViewTextBoxColumn.HeaderText = "id_contractor";
            this.idcontractorDataGridViewTextBoxColumn.Name = "idcontractorDataGridViewTextBoxColumn";
            this.idcontractorDataGridViewTextBoxColumn.ReadOnly = true;
            this.idcontractorDataGridViewTextBoxColumn.Visible = false;
            // 
            // namecontrDataGridViewTextBoxColumn
            // 
            this.namecontrDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.namecontrDataGridViewTextBoxColumn.DataPropertyName = "name_contr";
            this.namecontrDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.namecontrDataGridViewTextBoxColumn.Name = "namecontrDataGridViewTextBoxColumn";
            this.namecontrDataGridViewTextBoxColumn.ReadOnly = true;
            this.namecontrDataGridViewTextBoxColumn.Width = 132;
            // 
            // subdivisionDataGridViewTextBoxColumn
            // 
            this.subdivisionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.subdivisionDataGridViewTextBoxColumn.DataPropertyName = "subdivision";
            this.subdivisionDataGridViewTextBoxColumn.HeaderText = "Подразделение";
            this.subdivisionDataGridViewTextBoxColumn.Name = "subdivisionDataGridViewTextBoxColumn";
            this.subdivisionDataGridViewTextBoxColumn.ReadOnly = true;
            this.subdivisionDataGridViewTextBoxColumn.Width = 139;
            // 
            // juraddressDataGridViewTextBoxColumn
            // 
            this.juraddressDataGridViewTextBoxColumn.DataPropertyName = "jur_address";
            this.juraddressDataGridViewTextBoxColumn.HeaderText = "Юр. адрес";
            this.juraddressDataGridViewTextBoxColumn.Name = "juraddressDataGridViewTextBoxColumn";
            this.juraddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // factaddressDataGridViewTextBoxColumn
            // 
            this.factaddressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.factaddressDataGridViewTextBoxColumn.DataPropertyName = "fact_address";
            this.factaddressDataGridViewTextBoxColumn.HeaderText = "Факт. адрес";
            this.factaddressDataGridViewTextBoxColumn.Name = "factaddressDataGridViewTextBoxColumn";
            this.factaddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.factaddressDataGridViewTextBoxColumn.Width = 111;
            // 
            // mailindexDataGridViewTextBoxColumn
            // 
            this.mailindexDataGridViewTextBoxColumn.DataPropertyName = "mail_index";
            this.mailindexDataGridViewTextBoxColumn.HeaderText = "Индекс";
            this.mailindexDataGridViewTextBoxColumn.Name = "mailindexDataGridViewTextBoxColumn";
            this.mailindexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // innDataGridViewTextBoxColumn
            // 
            this.innDataGridViewTextBoxColumn.DataPropertyName = "inn";
            this.innDataGridViewTextBoxColumn.HeaderText = "ИНН";
            this.innDataGridViewTextBoxColumn.Name = "innDataGridViewTextBoxColumn";
            this.innDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contractorBindingSource
            // 
            this.contractorBindingSource.DataMember = "Contractor";
            this.contractorBindingSource.DataSource = this.bindingSourceContractor;
            // 
            // bindingSourceContractor
            // 
            this.bindingSourceContractor.DataSource = this.accountOfGrainElevatorDataSet;
            this.bindingSourceContractor.Position = 0;
            // 
            // accountOfGrainElevatorDataSet
            // 
            this.accountOfGrainElevatorDataSet.DataSetName = "AccountOfGrainElevatorDataSet";
            this.accountOfGrainElevatorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.DarkOrange;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.Location = new System.Drawing.Point(12, 86);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(88, 28);
            this.addButton.TabIndex = 45;
            this.addButton.Text = "Добавить";
            this.addButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.DarkOrange;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.changeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changeButton.Location = new System.Drawing.Point(108, 86);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(88, 28);
            this.changeButton.TabIndex = 46;
            this.changeButton.Text = "Изменить";
            this.changeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.DarkOrange;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.deleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteButton.Location = new System.Drawing.Point(202, 86);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(88, 28);
            this.deleteButton.TabIndex = 47;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // contractorTableAdapter
            // 
            this.contractorTableAdapter.ClearBeforeFill = true;
            // 
            // nameContractortextBox
            // 
            this.nameContractortextBox.Location = new System.Drawing.Point(130, 27);
            this.nameContractortextBox.Name = "nameContractortextBox";
            this.nameContractortextBox.Size = new System.Drawing.Size(282, 22);
            this.nameContractortextBox.TabIndex = 48;
            // 
            // ContractorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(848, 379);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.dataGridViewContractor);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ContractorForm";
            this.Text = "Контрагенты";
            this.Load += new System.EventHandler(this.ContractorForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContractor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceContractor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountOfGrainElevatorDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAllList;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.DataGridView dataGridViewContractor;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.BindingSource bindingSourceContractor;
        private AccountOfGrainElevatorDataSet accountOfGrainElevatorDataSet;
        private System.Windows.Forms.BindingSource contractorBindingSource;
        private AccountOfGrainElevatorDataSetTableAdapters.ContractorTableAdapter contractorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcontractorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namecontrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subdivisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn juraddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn factaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailindexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn innDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox nameContractortextBox;
    }
}