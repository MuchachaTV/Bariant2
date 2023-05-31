
namespace Eczamen
{
    partial class Form7
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bariant2DataSet = new Eczamen.Bariant2DataSet();
            this.postavkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postavkiTableAdapter = new Eczamen.Bariant2DataSetTableAdapters.PostavkiTableAdapter();
            this.tableAdapterManager = new Eczamen.Bariant2DataSetTableAdapters.TableAdapterManager();
            this.postavkiBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.bariant2DataSet1 = new Eczamen.Bariant2DataSet1();
            this.postavkiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.postavkiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.postavkiTableAdapter1 = new Eczamen.Bariant2DataSet1TableAdapters.PostavkiTableAdapter();
            this.postavkiBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager1 = new Eczamen.Bariant2DataSet1TableAdapters.TableAdapterManager();
            this.postavkiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bariant2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavkiBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bariant2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavkiBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavkiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavkiBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavkiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 50);
            this.panel1.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(306, 15);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Вернуться";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(405, 15);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Выход";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(99, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Возрастание";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(198, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Убывание";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сброс";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bariant2DataSet
            // 
            this.bariant2DataSet.DataSetName = "Bariant2DataSet";
            this.bariant2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // postavkiBindingSource
            // 
            this.postavkiBindingSource.DataMember = "Postavki";
            this.postavkiBindingSource.DataSource = this.bariant2DataSet;
            // 
            // postavkiTableAdapter
            // 
            this.postavkiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.FloverTableAdapter = null;
            this.tableAdapterManager.MenedgerTableAdapter = null;
            this.tableAdapterManager.PostavkiTableAdapter = this.postavkiTableAdapter;
            this.tableAdapterManager.SkidkaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Eczamen.Bariant2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // postavkiBindingSource3
            // 
            this.postavkiBindingSource3.DataMember = "Postavki";
            this.postavkiBindingSource3.DataSource = this.bariant2DataSet1;
            // 
            // bariant2DataSet1
            // 
            this.bariant2DataSet1.DataSetName = "Bariant2DataSet1";
            this.bariant2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // postavkiBindingSource2
            // 
            this.postavkiBindingSource2.DataMember = "Postavki";
            this.postavkiBindingSource2.DataSource = this.bariant2DataSet1;
            // 
            // postavkiBindingSource1
            // 
            this.postavkiBindingSource1.DataMember = "Postavki";
            this.postavkiBindingSource1.DataSource = this.bariant2DataSet;
            // 
            // postavkiTableAdapter1
            // 
            this.postavkiTableAdapter1.ClearBeforeFill = true;
            // 
            // postavkiBindingSource4
            // 
            this.postavkiBindingSource4.DataMember = "Postavki";
            this.postavkiBindingSource4.DataSource = this.bariant2DataSet1;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AdminTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ClientTableAdapter = null;
            this.tableAdapterManager1.FloverTableAdapter = null;
            this.tableAdapterManager1.MenedgerTableAdapter = null;
            this.tableAdapterManager1.PostavkiTableAdapter = this.postavkiTableAdapter1;
            this.tableAdapterManager1.SkidkaTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Eczamen.Bariant2DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // postavkiDataGridView
            // 
            this.postavkiDataGridView.AutoGenerateColumns = false;
            this.postavkiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.postavkiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.postavkiDataGridView.DataSource = this.postavkiBindingSource2;
            this.postavkiDataGridView.Location = new System.Drawing.Point(12, 12);
            this.postavkiDataGridView.Name = "postavkiDataGridView";
            this.postavkiDataGridView.Size = new System.Drawing.Size(451, 220);
            this.postavkiDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_Flover";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_Flover";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Proizvoditel";
            this.dataGridViewTextBoxColumn2.HeaderText = "Proizvoditel";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Postavchik";
            this.dataGridViewTextBoxColumn3.HeaderText = "Postavchik";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Catalog_tovarov";
            this.dataGridViewTextBoxColumn4.HeaderText = "Catalog_tovarov";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 293);
            this.Controls.Add(this.postavkiDataGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Администратор";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bariant2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavkiBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bariant2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavkiBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavkiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavkiBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavkiDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Bariant2DataSet bariant2DataSet;
        private System.Windows.Forms.BindingSource postavkiBindingSource;
        private Bariant2DataSetTableAdapters.PostavkiTableAdapter postavkiTableAdapter;
        private Bariant2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource postavkiBindingSource1;
        private Bariant2DataSet1 bariant2DataSet1;
        private System.Windows.Forms.BindingSource postavkiBindingSource2;
        private Bariant2DataSet1TableAdapters.PostavkiTableAdapter postavkiTableAdapter1;
        private System.Windows.Forms.BindingSource postavkiBindingSource3;
        private System.Windows.Forms.BindingSource postavkiBindingSource4;
        private Bariant2DataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView postavkiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}