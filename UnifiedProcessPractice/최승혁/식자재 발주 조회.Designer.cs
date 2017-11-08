namespace UnifiedProcessPractice
{
    partial class 식자재_발주_조회
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.purchaseOrderDataGridView = new System.Windows.Forms.DataGridView();
            this.selectButton = new System.Windows.Forms.Button();
            this.purchaseCombobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.businessNameCombobox = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new UnifiedProcessPractice.DatabaseDataSet();
            this.purchaseOrderTableAdapter = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.PurchaseOrderTableAdapter();
            this.tableAdapterManager = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.businessCompanyTableAdapter1 = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.BusinessCompanyTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // purchaseOrderDataGridView
            // 
            this.purchaseOrderDataGridView.AllowUserToAddRows = false;
            this.purchaseOrderDataGridView.AllowUserToDeleteRows = false;
            this.purchaseOrderDataGridView.AutoGenerateColumns = false;
            this.purchaseOrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchaseOrderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.purchaseOrderDataGridView.DataSource = this.purchaseOrderBindingSource;
            this.purchaseOrderDataGridView.Location = new System.Drawing.Point(45, 152);
            this.purchaseOrderDataGridView.Name = "purchaseOrderDataGridView";
            this.purchaseOrderDataGridView.ReadOnly = true;
            this.purchaseOrderDataGridView.RowTemplate.Height = 23;
            this.purchaseOrderDataGridView.Size = new System.Drawing.Size(794, 264);
            this.purchaseOrderDataGridView.TabIndex = 1;
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(649, 101);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(81, 22);
            this.selectButton.TabIndex = 2;
            this.selectButton.Text = "조회";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // purchaseCombobox
            // 
            this.purchaseCombobox.FormattingEnabled = true;
            this.purchaseCombobox.Location = new System.Drawing.Point(149, 36);
            this.purchaseCombobox.Name = "purchaseCombobox";
            this.purchaseCombobox.Size = new System.Drawing.Size(121, 20);
            this.purchaseCombobox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "발주번호";
            // 
            // businessNameCombobox
            // 
            this.businessNameCombobox.FormattingEnabled = true;
            this.businessNameCombobox.Location = new System.Drawing.Point(149, 68);
            this.businessNameCombobox.Name = "businessNameCombobox";
            this.businessNameCombobox.Size = new System.Drawing.Size(121, 20);
            this.businessNameCombobox.TabIndex = 7;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(78, 69);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(65, 12);
            this.label32.TabIndex = 8;
            this.label32.Text = "공급업체명";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PurchaseOrderNumber";
            this.dataGridViewTextBoxColumn1.HeaderText = "발주번호";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IngredientNumber";
            this.dataGridViewTextBoxColumn2.HeaderText = "식자재번호";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "OrderDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "주문일시";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Unit";
            this.dataGridViewTextBoxColumn4.HeaderText = "단위";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn5.HeaderText = "수량";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn6.HeaderText = "가격(원)";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsEnded";
            this.dataGridViewCheckBoxColumn1.HeaderText = "발주확정여부";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "EmployeeNumber";
            this.dataGridViewTextBoxColumn7.HeaderText = "직원번호";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "BusinessName";
            this.dataGridViewTextBoxColumn8.HeaderText = "발주업체명";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // purchaseOrderBindingSource
            // 
            this.purchaseOrderBindingSource.DataMember = "PurchaseOrder";
            this.purchaseOrderBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchaseOrderTableAdapter
            // 
            this.purchaseOrderTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BusinessCompanyTableAdapter = null;
            this.tableAdapterManager.DisuseInfoTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.ExpectSalesVolumeTableAdapter = null;
            this.tableAdapterManager.IngredientConsumeTableAdapter = null;
            this.tableAdapterManager.IngredientTableAdapter = null;
            this.tableAdapterManager.MemberTableAdapter = null;
            this.tableAdapterManager.MenuTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.PointOptionTableAdapter = null;
            this.tableAdapterManager.PurchaseOrderTableAdapter = this.purchaseOrderTableAdapter;
            this.tableAdapterManager.ReleaseInfoTableAdapter = null;
            this.tableAdapterManager.ReservationControlTableAdapter = null;
            this.tableAdapterManager.ReservationTableAdapter = null;
            this.tableAdapterManager.ReturnTableAdapter = null;
            this.tableAdapterManager.SARTableAdapter = null;
            this.tableAdapterManager.StockTableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = UnifiedProcessPractice.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WarehousingInfoTableAdapter = null;
            // 
            // businessCompanyTableAdapter1
            // 
            this.businessCompanyTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "기간";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(149, 100);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(390, 100);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "부터";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(596, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "까지";
            // 
            // 식자재_발주_조회
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.businessNameCombobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.purchaseCombobox);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.purchaseOrderDataGridView);
            this.Name = "식자재_발주_조회";
            this.Size = new System.Drawing.Size(879, 484);
            this.Load += new System.EventHandler(this.식자재_발주_조회_Load);
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource purchaseOrderBindingSource;
        private DatabaseDataSetTableAdapters.PurchaseOrderTableAdapter purchaseOrderTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView purchaseOrderDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.ComboBox purchaseCombobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox businessNameCombobox;
        private System.Windows.Forms.Label label32;
        private DatabaseDataSetTableAdapters.BusinessCompanyTableAdapter businessCompanyTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
