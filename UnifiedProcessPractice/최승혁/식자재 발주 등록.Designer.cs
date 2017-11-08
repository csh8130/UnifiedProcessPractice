namespace UnifiedProcessPractice
{
    partial class 식자재_발주_등록
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
            System.Windows.Forms.Label ingredientNumberLabel;
            System.Windows.Forms.Label orderDateLabel;
            System.Windows.Forms.Label unitLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label isEndedLabel;
            System.Windows.Forms.Label employeeNumberLabel;
            System.Windows.Forms.Label businessNameLabel;
            this.ingredientNumberTextBox = new System.Windows.Forms.TextBox();
            this.orderDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.isEndedCheckBox = new System.Windows.Forms.CheckBox();
            this.ingredientCombobox = new System.Windows.Forms.ComboBox();
            this.insertButton = new System.Windows.Forms.Button();
            this.purchaseOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new UnifiedProcessPractice.DatabaseDataSet();
            this.purchaseOrderTableAdapter = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.PurchaseOrderTableAdapter();
            this.tableAdapterManager = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.ingredientTableAdapter1 = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.IngredientTableAdapter();
            this.businessCompanyTableAdapter1 = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.BusinessCompanyTableAdapter();
            this.businessNameCombobox = new System.Windows.Forms.ComboBox();
            this.unitComboBox = new System.Windows.Forms.ComboBox();
            this.employeeNumCombobox = new System.Windows.Forms.ComboBox();
            this.employeeTableAdapter1 = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.EmployeeTableAdapter();
            ingredientNumberLabel = new System.Windows.Forms.Label();
            orderDateLabel = new System.Windows.Forms.Label();
            unitLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            isEndedLabel = new System.Windows.Forms.Label();
            employeeNumberLabel = new System.Windows.Forms.Label();
            businessNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ingredientNumberLabel
            // 
            ingredientNumberLabel.AutoSize = true;
            ingredientNumberLabel.Location = new System.Drawing.Point(46, 86);
            ingredientNumberLabel.Name = "ingredientNumberLabel";
            ingredientNumberLabel.Size = new System.Drawing.Size(81, 12);
            ingredientNumberLabel.TabIndex = 3;
            ingredientNumberLabel.Text = "식자재 번호 : ";
            // 
            // orderDateLabel
            // 
            orderDateLabel.AutoSize = true;
            orderDateLabel.Location = new System.Drawing.Point(46, 114);
            orderDateLabel.Name = "orderDateLabel";
            orderDateLabel.Size = new System.Drawing.Size(57, 12);
            orderDateLabel.TabIndex = 5;
            orderDateLabel.Text = "주문일시:";
            // 
            // unitLabel
            // 
            unitLabel.AutoSize = true;
            unitLabel.Location = new System.Drawing.Point(46, 140);
            unitLabel.Name = "unitLabel";
            unitLabel.Size = new System.Drawing.Size(33, 12);
            unitLabel.TabIndex = 7;
            unitLabel.Text = "단위:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(46, 167);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(21, 12);
            amountLabel.TabIndex = 9;
            amountLabel.Text = "양:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(46, 194);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(59, 12);
            priceLabel.TabIndex = 11;
            priceLabel.Text = "가격 (원):";
            // 
            // isEndedLabel
            // 
            isEndedLabel.AutoSize = true;
            isEndedLabel.Location = new System.Drawing.Point(46, 223);
            isEndedLabel.Name = "isEndedLabel";
            isEndedLabel.Size = new System.Drawing.Size(89, 12);
            isEndedLabel.TabIndex = 13;
            isEndedLabel.Text = "발주 확정 여부:";
            // 
            // employeeNumberLabel
            // 
            employeeNumberLabel.AutoSize = true;
            employeeNumberLabel.Location = new System.Drawing.Point(46, 251);
            employeeNumberLabel.Name = "employeeNumberLabel";
            employeeNumberLabel.Size = new System.Drawing.Size(61, 12);
            employeeNumberLabel.TabIndex = 15;
            employeeNumberLabel.Text = "직원 번호:";
            // 
            // businessNameLabel
            // 
            businessNameLabel.AutoSize = true;
            businessNameLabel.Location = new System.Drawing.Point(46, 278);
            businessNameLabel.Name = "businessNameLabel";
            businessNameLabel.Size = new System.Drawing.Size(73, 12);
            businessNameLabel.TabIndex = 17;
            businessNameLabel.Text = "공급업체 명:";
            // 
            // ingredientNumberTextBox
            // 
            this.ingredientNumberTextBox.Location = new System.Drawing.Point(350, 83);
            this.ingredientNumberTextBox.Name = "ingredientNumberTextBox";
            this.ingredientNumberTextBox.ReadOnly = true;
            this.ingredientNumberTextBox.Size = new System.Drawing.Size(78, 21);
            this.ingredientNumberTextBox.TabIndex = 4;
            // 
            // orderDateDateTimePicker
            // 
            this.orderDateDateTimePicker.CustomFormat = "yyyy-mm-dd HH:MM:ss";
            this.orderDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.purchaseOrderBindingSource, "OrderDate", true));
            this.orderDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.orderDateDateTimePicker.Location = new System.Drawing.Point(199, 110);
            this.orderDateDateTimePicker.Name = "orderDateDateTimePicker";
            this.orderDateDateTimePicker.Size = new System.Drawing.Size(229, 21);
            this.orderDateDateTimePicker.TabIndex = 6;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(199, 164);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(229, 21);
            this.amountTextBox.TabIndex = 10;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(199, 191);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(229, 21);
            this.priceTextBox.TabIndex = 12;
            // 
            // isEndedCheckBox
            // 
            this.isEndedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.purchaseOrderBindingSource, "IsEnded", true));
            this.isEndedCheckBox.Location = new System.Drawing.Point(199, 218);
            this.isEndedCheckBox.Name = "isEndedCheckBox";
            this.isEndedCheckBox.Size = new System.Drawing.Size(200, 24);
            this.isEndedCheckBox.TabIndex = 14;
            this.isEndedCheckBox.UseVisualStyleBackColor = true;
            // 
            // ingredientCombobox
            // 
            this.ingredientCombobox.FormattingEnabled = true;
            this.ingredientCombobox.Location = new System.Drawing.Point(201, 84);
            this.ingredientCombobox.Name = "ingredientCombobox";
            this.ingredientCombobox.Size = new System.Drawing.Size(143, 20);
            this.ingredientCombobox.TabIndex = 19;
            this.ingredientCombobox.SelectedIndexChanged += new System.EventHandler(this.ingredientCombobox_SelectedIndexChanged);
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(48, 313);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(75, 23);
            this.insertButton.TabIndex = 20;
            this.insertButton.Text = "등록";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
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
            this.tableAdapterManager.IngredientTableAdapter = this.ingredientTableAdapter1;
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
            // ingredientTableAdapter1
            // 
            this.ingredientTableAdapter1.ClearBeforeFill = true;
            // 
            // businessCompanyTableAdapter1
            // 
            this.businessCompanyTableAdapter1.ClearBeforeFill = true;
            // 
            // businessNameCombobox
            // 
            this.businessNameCombobox.FormattingEnabled = true;
            this.businessNameCombobox.Location = new System.Drawing.Point(199, 275);
            this.businessNameCombobox.Name = "businessNameCombobox";
            this.businessNameCombobox.Size = new System.Drawing.Size(227, 20);
            this.businessNameCombobox.TabIndex = 21;
            // 
            // unitComboBox
            // 
            this.unitComboBox.FormattingEnabled = true;
            this.unitComboBox.Location = new System.Drawing.Point(199, 137);
            this.unitComboBox.Name = "unitComboBox";
            this.unitComboBox.Size = new System.Drawing.Size(227, 20);
            this.unitComboBox.TabIndex = 22;
            // 
            // employeeNumCombobox
            // 
            this.employeeNumCombobox.FormattingEnabled = true;
            this.employeeNumCombobox.Location = new System.Drawing.Point(199, 248);
            this.employeeNumCombobox.Name = "employeeNumCombobox";
            this.employeeNumCombobox.Size = new System.Drawing.Size(227, 20);
            this.employeeNumCombobox.TabIndex = 23;
            // 
            // employeeTableAdapter1
            // 
            this.employeeTableAdapter1.ClearBeforeFill = true;
            // 
            // 식자재_발주_등록
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.employeeNumCombobox);
            this.Controls.Add(this.unitComboBox);
            this.Controls.Add(this.businessNameCombobox);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.ingredientCombobox);
            this.Controls.Add(ingredientNumberLabel);
            this.Controls.Add(this.ingredientNumberTextBox);
            this.Controls.Add(orderDateLabel);
            this.Controls.Add(this.orderDateDateTimePicker);
            this.Controls.Add(unitLabel);
            this.Controls.Add(amountLabel);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(isEndedLabel);
            this.Controls.Add(this.isEndedCheckBox);
            this.Controls.Add(employeeNumberLabel);
            this.Controls.Add(businessNameLabel);
            this.Name = "식자재_발주_등록";
            this.Size = new System.Drawing.Size(651, 384);
            this.Load += new System.EventHandler(this.식자재_발주_등록_Load);
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
        private System.Windows.Forms.TextBox ingredientNumberTextBox;
        private System.Windows.Forms.DateTimePicker orderDateDateTimePicker;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.CheckBox isEndedCheckBox;
        private System.Windows.Forms.ComboBox ingredientCombobox;
        private DatabaseDataSetTableAdapters.IngredientTableAdapter ingredientTableAdapter1;
        private System.Windows.Forms.Button insertButton;
        private DatabaseDataSetTableAdapters.BusinessCompanyTableAdapter businessCompanyTableAdapter1;
        private System.Windows.Forms.ComboBox businessNameCombobox;
        private System.Windows.Forms.ComboBox unitComboBox;
        private System.Windows.Forms.ComboBox employeeNumCombobox;
        private DatabaseDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter1;
    }
}
