
namespace Eczamen
{
    partial class Form6
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
            this.bariant2DataSet = new Eczamen.Bariant2DataSet();
            this.skidkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skidkaTableAdapter = new Eczamen.Bariant2DataSetTableAdapters.SkidkaTableAdapter();
            this.tableAdapterManager = new Eczamen.Bariant2DataSetTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bariant2DataSet1 = new Eczamen.Bariant2DataSet1();
            this.skidkaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.skidkaTableAdapter1 = new Eczamen.Bariant2DataSet1TableAdapters.SkidkaTableAdapter();
            this.tableAdapterManager1 = new Eczamen.Bariant2DataSet1TableAdapters.TableAdapterManager();
            this.skidkaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bariant2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skidkaBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bariant2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skidkaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skidkaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bariant2DataSet
            // 
            this.bariant2DataSet.DataSetName = "Bariant2DataSet";
            this.bariant2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // skidkaBindingSource
            // 
            this.skidkaBindingSource.DataMember = "Skidka";
            this.skidkaBindingSource.DataSource = this.bariant2DataSet;
            // 
            // skidkaTableAdapter
            // 
            this.skidkaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.FloverTableAdapter = null;
            this.tableAdapterManager.MenedgerTableAdapter = null;
            this.tableAdapterManager.PostavkiTableAdapter = null;
            this.tableAdapterManager.SkidkaTableAdapter = this.skidkaTableAdapter;
            this.tableAdapterManager.UpdateOrder = Eczamen.Bariant2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.panel1.Location = new System.Drawing.Point(0, 294);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 45);
            this.panel1.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(307, 13);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Вернуться";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(406, 13);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Выход";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(100, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Возрастание";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(199, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Убывание";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сброс";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bariant2DataSet1
            // 
            this.bariant2DataSet1.DataSetName = "Bariant2DataSet1";
            this.bariant2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // skidkaBindingSource1
            // 
            this.skidkaBindingSource1.DataMember = "Skidka";
            this.skidkaBindingSource1.DataSource = this.bariant2DataSet1;
            // 
            // skidkaTableAdapter1
            // 
            this.skidkaTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AdminTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ClientTableAdapter = null;
            this.tableAdapterManager1.FloverTableAdapter = null;
            this.tableAdapterManager1.MenedgerTableAdapter = null;
            this.tableAdapterManager1.PostavkiTableAdapter = null;
            this.tableAdapterManager1.SkidkaTableAdapter = this.skidkaTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = Eczamen.Bariant2DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // skidkaDataGridView
            // 
            this.skidkaDataGridView.AutoGenerateColumns = false;
            this.skidkaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skidkaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.skidkaDataGridView.DataSource = this.skidkaBindingSource1;
            this.skidkaDataGridView.Location = new System.Drawing.Point(13, 12);
            this.skidkaDataGridView.Name = "skidkaDataGridView";
            this.skidkaDataGridView.Size = new System.Drawing.Size(468, 220);
            this.skidkaDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_Flover";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_Flover";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Skidka";
            this.dataGridViewTextBoxColumn2.HeaderText = "Skidka";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Max_skidka";
            this.dataGridViewTextBoxColumn3.HeaderText = "Max_skidka";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 339);
            this.Controls.Add(this.skidkaDataGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Менеджер";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bariant2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skidkaBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bariant2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skidkaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skidkaDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bariant2DataSet bariant2DataSet;
        private System.Windows.Forms.BindingSource skidkaBindingSource;
        private Bariant2DataSetTableAdapters.SkidkaTableAdapter skidkaTableAdapter;
        private Bariant2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Bariant2DataSet1 bariant2DataSet1;
        private System.Windows.Forms.BindingSource skidkaBindingSource1;
        private Bariant2DataSet1TableAdapters.SkidkaTableAdapter skidkaTableAdapter1;
        private Bariant2DataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView skidkaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}