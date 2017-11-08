namespace UnifiedProcessPractice
{
    partial class 공급업체등록
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
            System.Windows.Forms.Label businessPhoneNoLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label businessNumberLabel;
            System.Windows.Forms.Label phoneNoLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label contractDateLabel;
            System.Windows.Forms.Label expireDateLabel;
            this.databaseDataSet = new UnifiedProcessPractice.DatabaseDataSet();
            this.businessCompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.businessCompanyTableAdapter = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.BusinessCompanyTableAdapter();
            this.tableAdapterManager = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.businessNameTextBox = new System.Windows.Forms.TextBox();
            this.businessPhoneNoTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.businessNumberTextBox = new System.Windows.Forms.TextBox();
            this.phoneNoTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.contractDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.expireDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            businessNameLabel = new System.Windows.Forms.Label();
            businessPhoneNoLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            businessNumberLabel = new System.Windows.Forms.Label();
            phoneNoLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            contractDateLabel = new System.Windows.Forms.Label();
            expireDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessCompanyBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // businessNameLabel
            // 
            businessNameLabel.AutoSize = true;
            businessNameLabel.Location = new System.Drawing.Point(37, 50);
            businessNameLabel.Name = "businessNameLabel";
            businessNameLabel.Size = new System.Drawing.Size(69, 12);
            businessNameLabel.TabIndex = 1;
            businessNameLabel.Text = "공급업체 명";
            // 
            // businessNameTextBox
            // 
            this.businessNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.businessCompanyBindingSource, "BusinessName", true));
            this.businessNameTextBox.Location = new System.Drawing.Point(138, 47);
            this.businessNameTextBox.Name = "businessNameTextBox";
            this.businessNameTextBox.Size = new System.Drawing.Size(170, 21);
            this.businessNameTextBox.TabIndex = 2;
            // 
            // businessPhoneNoLabel
            // 
            businessPhoneNoLabel.AutoSize = true;
            businessPhoneNoLabel.Location = new System.Drawing.Point(37, 85);
            businessPhoneNoLabel.Name = "businessPhoneNoLabel";
            businessPhoneNoLabel.Size = new System.Drawing.Size(41, 12);
            businessPhoneNoLabel.TabIndex = 3;
            businessPhoneNoLabel.Text = "연락처";
            // 
            // businessPhoneNoTextBox
            // 
            this.businessPhoneNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.businessCompanyBindingSource, "BusinessPhoneNo", true));
            this.businessPhoneNoTextBox.Location = new System.Drawing.Point(138, 82);
            this.businessPhoneNoTextBox.Name = "businessPhoneNoTextBox";
            this.businessPhoneNoTextBox.Size = new System.Drawing.Size(170, 21);
            this.businessPhoneNoTextBox.TabIndex = 4;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(37, 121);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(29, 12);
            addressLabel.TabIndex = 5;
            addressLabel.Text = "주소";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.businessCompanyBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(138, 118);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(170, 21);
            this.addressTextBox.TabIndex = 6;
            // 
            // businessNumberLabel
            // 
            businessNumberLabel.AutoSize = true;
            businessNumberLabel.Location = new System.Drawing.Point(37, 161);
            businessNumberLabel.Name = "businessNumberLabel";
            businessNumberLabel.Size = new System.Drawing.Size(89, 12);
            businessNumberLabel.TabIndex = 7;
            businessNumberLabel.Text = "사업자등록번호";
            // 
            // businessNumberTextBox
            // 
            this.businessNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.businessCompanyBindingSource, "BusinessNumber", true));
            this.businessNumberTextBox.Location = new System.Drawing.Point(138, 158);
            this.businessNumberTextBox.Name = "businessNumberTextBox";
            this.businessNumberTextBox.Size = new System.Drawing.Size(170, 21);
            this.businessNumberTextBox.TabIndex = 8;
            // 
            // phoneNoLabel
            // 
            phoneNoLabel.AutoSize = true;
            phoneNoLabel.Location = new System.Drawing.Point(37, 198);
            phoneNoLabel.Name = "phoneNoLabel";
            phoneNoLabel.Size = new System.Drawing.Size(81, 12);
            phoneNoLabel.TabIndex = 9;
            phoneNoLabel.Text = "담당자 연락처";
            // 
            // phoneNoTextBox
            // 
            this.phoneNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.businessCompanyBindingSource, "PhoneNo", true));
            this.phoneNoTextBox.Location = new System.Drawing.Point(138, 195);
            this.phoneNoTextBox.Name = "phoneNoTextBox";
            this.phoneNoTextBox.Size = new System.Drawing.Size(170, 21);
            this.phoneNoTextBox.TabIndex = 10;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(37, 234);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(69, 12);
            nameLabel.TabIndex = 11;
            nameLabel.Text = "담당자 이름";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.businessCompanyBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(138, 231);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(170, 21);
            this.nameTextBox.TabIndex = 12;
            // 
            // contractDateLabel
            // 
            contractDateLabel.AutoSize = true;
            contractDateLabel.Location = new System.Drawing.Point(327, 50);
            contractDateLabel.Name = "contractDateLabel";
            contractDateLabel.Size = new System.Drawing.Size(41, 12);
            contractDateLabel.TabIndex = 13;
            contractDateLabel.Text = "계약일";
            // 
            // contractDateDateTimePicker
            // 
            this.contractDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.businessCompanyBindingSource, "ContractDate", true));
            this.contractDateDateTimePicker.Location = new System.Drawing.Point(403, 44);
            this.contractDateDateTimePicker.Name = "contractDateDateTimePicker";
            this.contractDateDateTimePicker.Size = new System.Drawing.Size(170, 21);
            this.contractDateDateTimePicker.TabIndex = 14;
            // 
            // expireDateLabel
            // 
            expireDateLabel.AutoSize = true;
            expireDateLabel.Location = new System.Drawing.Point(327, 85);
            expireDateLabel.Name = "expireDateLabel";
            expireDateLabel.Size = new System.Drawing.Size(65, 12);
            expireDateLabel.TabIndex = 15;
            expireDateLabel.Text = "계약만료일";
            // 
            // expireDateDateTimePicker
            // 
            this.expireDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.businessCompanyBindingSource, "ExpireDate", true));
            this.expireDateDateTimePicker.Location = new System.Drawing.Point(403, 79);
            this.expireDateDateTimePicker.Name = "expireDateDateTimePicker";
            this.expireDateDateTimePicker.Size = new System.Drawing.Size(170, 21);
            this.expireDateDateTimePicker.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "등록";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // 공급업체등록
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(businessNameLabel);
            this.Controls.Add(this.businessNameTextBox);
            this.Controls.Add(businessPhoneNoLabel);
            this.Controls.Add(this.businessPhoneNoTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(businessNumberLabel);
            this.Controls.Add(this.businessNumberTextBox);
            this.Controls.Add(phoneNoLabel);
            this.Controls.Add(this.phoneNoTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(contractDateLabel);
            this.Controls.Add(this.contractDateDateTimePicker);
            this.Controls.Add(expireDateLabel);
            this.Controls.Add(this.expireDateDateTimePicker);
            this.Name = "공급업체등록";
            this.Size = new System.Drawing.Size(605, 339);
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
        private System.Windows.Forms.TextBox businessNameTextBox;
        private System.Windows.Forms.TextBox businessPhoneNoTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox businessNumberTextBox;
        private System.Windows.Forms.TextBox phoneNoTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.DateTimePicker contractDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker expireDateDateTimePicker;
        private System.Windows.Forms.Button button1;
    }
}
