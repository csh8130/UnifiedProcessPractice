namespace UnifiedProcessPractice
{
    partial class 공급업체삭제
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
            System.Windows.Forms.Label businessNameLabel;
            System.Windows.Forms.Label businessNumberLabel;
            this.databaseDataSet = new UnifiedProcessPractice.DatabaseDataSet();
            this.businessCompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.businessCompanyTableAdapter = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.BusinessCompanyTableAdapter();
            this.tableAdapterManager = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.businessNumberTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            businessNameLabel = new System.Windows.Forms.Label();
            businessNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessCompanyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // businessNameLabel
            // 
            businessNameLabel.AutoSize = true;
            businessNameLabel.Location = new System.Drawing.Point(89, 77);
            businessNameLabel.Name = "businessNameLabel";
            businessNameLabel.Size = new System.Drawing.Size(69, 12);
            businessNameLabel.TabIndex = 1;
            businessNameLabel.Text = "공급업체 명";
            // 
            // businessNumberLabel
            // 
            businessNumberLabel.AutoSize = true;
            businessNumberLabel.Location = new System.Drawing.Point(89, 137);
            businessNumberLabel.Name = "businessNumberLabel";
            businessNumberLabel.Size = new System.Drawing.Size(89, 12);
            businessNumberLabel.TabIndex = 3;
            businessNumberLabel.Text = "사업자등록번호";
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // businessCompanyBindingSource
            // 
            this.businessCompanyBindingSource.DataMember = "BusinessCompany";
            this.businessCompanyBindingSource.DataSource = this.databaseDataSet;
            // 
            // businessCompanyTableAdapter
            // 
            this.businessCompanyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BusinessCompanyTableAdapter = this.businessCompanyTableAdapter;
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
            this.tableAdapterManager.PurchaseOrderTableAdapter = null;
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
            // businessNumberTextBox
            // 
            this.businessNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.businessCompanyBindingSource, "BusinessNumber", true));
            this.businessNumberTextBox.Enabled = false;
            this.businessNumberTextBox.Location = new System.Drawing.Point(206, 134);
            this.businessNumberTextBox.Name = "businessNumberTextBox";
            this.businessNumberTextBox.Size = new System.Drawing.Size(121, 21);
            this.businessNumberTextBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "삭제";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(206, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // 공급업체삭제
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(businessNumberLabel);
            this.Controls.Add(this.businessNumberTextBox);
            this.Controls.Add(businessNameLabel);
            this.Name = "공급업체삭제";
            this.Size = new System.Drawing.Size(604, 314);
            this.Load += new System.EventHandler(this.공급업체삭제_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessCompanyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource businessCompanyBindingSource;
        private DatabaseDataSetTableAdapters.BusinessCompanyTableAdapter businessCompanyTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox businessNumberTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
