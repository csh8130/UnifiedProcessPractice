namespace UnifiedProcessPractice
{
    partial class 식자재_발주_삭제
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
            System.Windows.Forms.Label purchaseOrderNumberLabel;
            System.Windows.Forms.Label ingredientNumberLabel;
            System.Windows.Forms.Label orderDateLabel;
            System.Windows.Forms.Label unitLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label isEndedLabel;
            System.Windows.Forms.Label employeeNumberLabel;
            System.Windows.Forms.Label businessNameLabel;
            this.databaseDataSet = new UnifiedProcessPractice.DatabaseDataSet();
            this.purchaseOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseOrderTableAdapter = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.PurchaseOrderTableAdapter();
            this.tableAdapterManager = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.ingredientNumberTextBox = new System.Windows.Forms.TextBox();
            this.orderDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.unitTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.isEndedCheckBox = new System.Windows.Forms.CheckBox();
            this.employeeNumberTextBox = new System.Windows.Forms.TextBox();
            this.businessNameTextBox = new System.Windows.Forms.TextBox();
            this.orderNumberCombobox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            purchaseOrderNumberLabel = new System.Windows.Forms.Label();
            ingredientNumberLabel = new System.Windows.Forms.Label();
            orderDateLabel = new System.Windows.Forms.Label();
            unitLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            isEndedLabel = new System.Windows.Forms.Label();
            employeeNumberLabel = new System.Windows.Forms.Label();
            businessNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // purchaseOrderNumberLabel
            // 
            purchaseOrderNumberLabel.AutoSize = true;
            purchaseOrderNumberLabel.Location = new System.Drawing.Point(75, 48);
            purchaseOrderNumberLabel.Name = "purchaseOrderNumberLabel";
            purchaseOrderNumberLabel.Size = new System.Drawing.Size(61, 12);
            purchaseOrderNumberLabel.TabIndex = 1;
            purchaseOrderNumberLabel.Text = "발주 번호:";
            // 
            // ingredientNumberLabel
            // 
            ingredientNumberLabel.AutoSize = true;
            ingredientNumberLabel.Location = new System.Drawing.Point(75, 75);
            ingredientNumberLabel.Name = "ingredientNumberLabel";
            ingredientNumberLabel.Size = new System.Drawing.Size(73, 12);
            ingredientNumberLabel.TabIndex = 3;
            ingredientNumberLabel.Text = "식재자 번호:";
            // 
            // orderDateLabel
            // 
            orderDateLabel.AutoSize = true;
            orderDateLabel.Location = new System.Drawing.Point(75, 105);
            orderDateLabel.Name = "orderDateLabel";
            orderDateLabel.Size = new System.Drawing.Size(57, 12);
            orderDateLabel.TabIndex = 21;
            orderDateLabel.Text = "주문일시:";
            // 
            // unitLabel
            // 
            unitLabel.AutoSize = true;
            unitLabel.Location = new System.Drawing.Point(75, 131);
            unitLabel.Name = "unitLabel";
            unitLabel.Size = new System.Drawing.Size(33, 12);
            unitLabel.TabIndex = 22;
            unitLabel.Text = "단위:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(75, 158);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(21, 12);
            amountLabel.TabIndex = 23;
            amountLabel.Text = "양:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(75, 185);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(59, 12);
            priceLabel.TabIndex = 24;
            priceLabel.Text = "가격 (원):";
            // 
            // isEndedLabel
            // 
            isEndedLabel.AutoSize = true;
            isEndedLabel.Location = new System.Drawing.Point(75, 214);
            isEndedLabel.Name = "isEndedLabel";
            isEndedLabel.Size = new System.Drawing.Size(89, 12);
            isEndedLabel.TabIndex = 25;
            isEndedLabel.Text = "발주 확정 여부:";
            // 
            // employeeNumberLabel
            // 
            employeeNumberLabel.AutoSize = true;
            employeeNumberLabel.Location = new System.Drawing.Point(75, 242);
            employeeNumberLabel.Name = "employeeNumberLabel";
            employeeNumberLabel.Size = new System.Drawing.Size(61, 12);
            employeeNumberLabel.TabIndex = 26;
            employeeNumberLabel.Text = "직원 번호:";
            // 
            // businessNameLabel
            // 
            businessNameLabel.AutoSize = true;
            businessNameLabel.Location = new System.Drawing.Point(75, 269);
            businessNameLabel.Name = "businessNameLabel";
            businessNameLabel.Size = new System.Drawing.Size(73, 12);
            businessNameLabel.TabIndex = 27;
            businessNameLabel.Text = "공급업체 명:";
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchaseOrderBindingSource
            // 
            this.purchaseOrderBindingSource.DataMember = "PurchaseOrder";
            this.purchaseOrderBindingSource.DataSource = this.databaseDataSet;
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
            // ingredientNumberTextBox
            // 
            this.ingredientNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseOrderBindingSource, "IngredientNumber", true));
            this.ingredientNumberTextBox.Location = new System.Drawing.Point(228, 72);
            this.ingredientNumberTextBox.Name = "ingredientNumberTextBox";
            this.ingredientNumberTextBox.ReadOnly = true;
            this.ingredientNumberTextBox.Size = new System.Drawing.Size(200, 21);
            this.ingredientNumberTextBox.TabIndex = 4;
            // 
            // orderDateDateTimePicker
            // 
            this.orderDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.purchaseOrderBindingSource, "OrderDate", true));
            this.orderDateDateTimePicker.Enabled = false;
            this.orderDateDateTimePicker.Location = new System.Drawing.Point(228, 99);
            this.orderDateDateTimePicker.Name = "orderDateDateTimePicker";
            this.orderDateDateTimePicker.Size = new System.Drawing.Size(200, 21);
            this.orderDateDateTimePicker.TabIndex = 6;
            // 
            // unitTextBox
            // 
            this.unitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseOrderBindingSource, "Unit", true));
            this.unitTextBox.Location = new System.Drawing.Point(228, 126);
            this.unitTextBox.Name = "unitTextBox";
            this.unitTextBox.ReadOnly = true;
            this.unitTextBox.Size = new System.Drawing.Size(200, 21);
            this.unitTextBox.TabIndex = 8;
            // 
            // amountTextBox
            // 
            this.amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseOrderBindingSource, "Amount", true));
            this.amountTextBox.Location = new System.Drawing.Point(228, 153);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.ReadOnly = true;
            this.amountTextBox.Size = new System.Drawing.Size(200, 21);
            this.amountTextBox.TabIndex = 10;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseOrderBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(228, 180);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(200, 21);
            this.priceTextBox.TabIndex = 12;
            // 
            // isEndedCheckBox
            // 
            this.isEndedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.purchaseOrderBindingSource, "IsEnded", true));
            this.isEndedCheckBox.Enabled = false;
            this.isEndedCheckBox.Location = new System.Drawing.Point(228, 207);
            this.isEndedCheckBox.Name = "isEndedCheckBox";
            this.isEndedCheckBox.Size = new System.Drawing.Size(200, 24);
            this.isEndedCheckBox.TabIndex = 14;
            this.isEndedCheckBox.UseVisualStyleBackColor = true;
            // 
            // employeeNumberTextBox
            // 
            this.employeeNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseOrderBindingSource, "EmployeeNumber", true));
            this.employeeNumberTextBox.Location = new System.Drawing.Point(228, 237);
            this.employeeNumberTextBox.Name = "employeeNumberTextBox";
            this.employeeNumberTextBox.ReadOnly = true;
            this.employeeNumberTextBox.Size = new System.Drawing.Size(200, 21);
            this.employeeNumberTextBox.TabIndex = 16;
            // 
            // businessNameTextBox
            // 
            this.businessNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseOrderBindingSource, "BusinessName", true));
            this.businessNameTextBox.Location = new System.Drawing.Point(228, 264);
            this.businessNameTextBox.Name = "businessNameTextBox";
            this.businessNameTextBox.ReadOnly = true;
            this.businessNameTextBox.Size = new System.Drawing.Size(200, 21);
            this.businessNameTextBox.TabIndex = 18;
            // 
            // orderNumberCombobox
            // 
            this.orderNumberCombobox.FormattingEnabled = true;
            this.orderNumberCombobox.Location = new System.Drawing.Point(228, 45);
            this.orderNumberCombobox.Name = "orderNumberCombobox";
            this.orderNumberCombobox.Size = new System.Drawing.Size(200, 20);
            this.orderNumberCombobox.TabIndex = 19;
            this.orderNumberCombobox.SelectedIndexChanged += new System.EventHandler(this.orderNumberCombobox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "삭제";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // 식자재_발주_삭제
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(orderDateLabel);
            this.Controls.Add(unitLabel);
            this.Controls.Add(amountLabel);
            this.Controls.Add(priceLabel);
            this.Controls.Add(isEndedLabel);
            this.Controls.Add(employeeNumberLabel);
            this.Controls.Add(businessNameLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.orderNumberCombobox);
            this.Controls.Add(purchaseOrderNumberLabel);
            this.Controls.Add(ingredientNumberLabel);
            this.Controls.Add(this.ingredientNumberTextBox);
            this.Controls.Add(this.orderDateDateTimePicker);
            this.Controls.Add(this.unitTextBox);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.isEndedCheckBox);
            this.Controls.Add(this.employeeNumberTextBox);
            this.Controls.Add(this.businessNameTextBox);
            this.Name = "식자재_발주_삭제";
            this.Size = new System.Drawing.Size(636, 359);
            this.Load += new System.EventHandler(this.식자재_발주_삭제_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox unitTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.CheckBox isEndedCheckBox;
        private System.Windows.Forms.TextBox employeeNumberTextBox;
        private System.Windows.Forms.TextBox businessNameTextBox;
        private System.Windows.Forms.ComboBox orderNumberCombobox;
        private System.Windows.Forms.Button button1;
    }
}
