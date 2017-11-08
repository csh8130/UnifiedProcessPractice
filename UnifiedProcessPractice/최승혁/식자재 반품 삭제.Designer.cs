namespace UnifiedProcessPractice
{
    partial class 식자재_반품_삭제
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
            System.Windows.Forms.Label returnNumberLabel;
            System.Windows.Forms.Label ingredientNameLabel;
            System.Windows.Forms.Label supplyDateLabel;
            System.Windows.Forms.Label reasonLabel;
            System.Windows.Forms.Label returnDateLabel;
            System.Windows.Forms.Label isEndedLabel;
            System.Windows.Forms.Label purchaseOrderNumberLabel;
            System.Windows.Forms.Label ingredientNumberLabel;
            this.ingredientNameTextBox = new System.Windows.Forms.TextBox();
            this.supplyDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.reasonTextBox = new System.Windows.Forms.TextBox();
            this.returnDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.isEndedCheckBox = new System.Windows.Forms.CheckBox();
            this.purchaseOrderNumberTextBox = new System.Windows.Forms.TextBox();
            this.ingredientNumberTextBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.returnNumCombobox = new System.Windows.Forms.ComboBox();
            this.returnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new UnifiedProcessPractice.DatabaseDataSet();
            this.returnTableAdapter = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.ReturnTableAdapter();
            this.tableAdapterManager = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.TableAdapterManager();
            returnNumberLabel = new System.Windows.Forms.Label();
            ingredientNameLabel = new System.Windows.Forms.Label();
            supplyDateLabel = new System.Windows.Forms.Label();
            reasonLabel = new System.Windows.Forms.Label();
            returnDateLabel = new System.Windows.Forms.Label();
            isEndedLabel = new System.Windows.Forms.Label();
            purchaseOrderNumberLabel = new System.Windows.Forms.Label();
            ingredientNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.returnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // returnNumberLabel
            // 
            returnNumberLabel.AutoSize = true;
            returnNumberLabel.Location = new System.Drawing.Point(48, 27);
            returnNumberLabel.Name = "returnNumberLabel";
            returnNumberLabel.Size = new System.Drawing.Size(94, 12);
            returnNumberLabel.TabIndex = 1;
            returnNumberLabel.Text = "Return Number:";
            // 
            // ingredientNameLabel
            // 
            ingredientNameLabel.AutoSize = true;
            ingredientNameLabel.Location = new System.Drawing.Point(48, 54);
            ingredientNameLabel.Name = "ingredientNameLabel";
            ingredientNameLabel.Size = new System.Drawing.Size(102, 12);
            ingredientNameLabel.TabIndex = 3;
            ingredientNameLabel.Text = "Ingredient Name:";
            // 
            // supplyDateLabel
            // 
            supplyDateLabel.AutoSize = true;
            supplyDateLabel.Location = new System.Drawing.Point(48, 82);
            supplyDateLabel.Name = "supplyDateLabel";
            supplyDateLabel.Size = new System.Drawing.Size(77, 12);
            supplyDateLabel.TabIndex = 5;
            supplyDateLabel.Text = "Supply Date:";
            // 
            // reasonLabel
            // 
            reasonLabel.AutoSize = true;
            reasonLabel.Location = new System.Drawing.Point(48, 108);
            reasonLabel.Name = "reasonLabel";
            reasonLabel.Size = new System.Drawing.Size(52, 12);
            reasonLabel.TabIndex = 7;
            reasonLabel.Text = "Reason:";
            // 
            // returnDateLabel
            // 
            returnDateLabel.AutoSize = true;
            returnDateLabel.Location = new System.Drawing.Point(48, 160);
            returnDateLabel.Name = "returnDateLabel";
            returnDateLabel.Size = new System.Drawing.Size(74, 12);
            returnDateLabel.TabIndex = 9;
            returnDateLabel.Text = "Return Date:";
            // 
            // isEndedLabel
            // 
            isEndedLabel.AutoSize = true;
            isEndedLabel.Location = new System.Drawing.Point(48, 188);
            isEndedLabel.Name = "isEndedLabel";
            isEndedLabel.Size = new System.Drawing.Size(59, 12);
            isEndedLabel.TabIndex = 11;
            isEndedLabel.Text = "Is Ended:";
            // 
            // purchaseOrderNumberLabel
            // 
            purchaseOrderNumberLabel.AutoSize = true;
            purchaseOrderNumberLabel.Location = new System.Drawing.Point(48, 216);
            purchaseOrderNumberLabel.Name = "purchaseOrderNumberLabel";
            purchaseOrderNumberLabel.Size = new System.Drawing.Size(147, 12);
            purchaseOrderNumberLabel.TabIndex = 13;
            purchaseOrderNumberLabel.Text = "Purchase Order Number:";
            // 
            // ingredientNumberLabel
            // 
            ingredientNumberLabel.AutoSize = true;
            ingredientNumberLabel.Location = new System.Drawing.Point(48, 243);
            ingredientNumberLabel.Name = "ingredientNumberLabel";
            ingredientNumberLabel.Size = new System.Drawing.Size(113, 12);
            ingredientNumberLabel.TabIndex = 15;
            ingredientNumberLabel.Text = "Ingredient Number:";
            // 
            // ingredientNameTextBox
            // 
            this.ingredientNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.returnBindingSource, "IngredientName", true));
            this.ingredientNameTextBox.Location = new System.Drawing.Point(201, 51);
            this.ingredientNameTextBox.Name = "ingredientNameTextBox";
            this.ingredientNameTextBox.ReadOnly = true;
            this.ingredientNameTextBox.Size = new System.Drawing.Size(200, 21);
            this.ingredientNameTextBox.TabIndex = 4;
            // 
            // supplyDateDateTimePicker
            // 
            this.supplyDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.returnBindingSource, "SupplyDate", true));
            this.supplyDateDateTimePicker.Enabled = false;
            this.supplyDateDateTimePicker.Location = new System.Drawing.Point(201, 78);
            this.supplyDateDateTimePicker.Name = "supplyDateDateTimePicker";
            this.supplyDateDateTimePicker.Size = new System.Drawing.Size(200, 21);
            this.supplyDateDateTimePicker.TabIndex = 6;
            // 
            // reasonTextBox
            // 
            this.reasonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.returnBindingSource, "Reason", true));
            this.reasonTextBox.Location = new System.Drawing.Point(201, 105);
            this.reasonTextBox.Multiline = true;
            this.reasonTextBox.Name = "reasonTextBox";
            this.reasonTextBox.ReadOnly = true;
            this.reasonTextBox.Size = new System.Drawing.Size(200, 45);
            this.reasonTextBox.TabIndex = 8;
            // 
            // returnDateDateTimePicker
            // 
            this.returnDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.returnBindingSource, "ReturnDate", true));
            this.returnDateDateTimePicker.Enabled = false;
            this.returnDateDateTimePicker.Location = new System.Drawing.Point(201, 156);
            this.returnDateDateTimePicker.Name = "returnDateDateTimePicker";
            this.returnDateDateTimePicker.Size = new System.Drawing.Size(200, 21);
            this.returnDateDateTimePicker.TabIndex = 10;
            // 
            // isEndedCheckBox
            // 
            this.isEndedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.returnBindingSource, "IsEnded", true));
            this.isEndedCheckBox.Enabled = false;
            this.isEndedCheckBox.Location = new System.Drawing.Point(201, 183);
            this.isEndedCheckBox.Name = "isEndedCheckBox";
            this.isEndedCheckBox.Size = new System.Drawing.Size(200, 24);
            this.isEndedCheckBox.TabIndex = 12;
            this.isEndedCheckBox.UseVisualStyleBackColor = true;
            // 
            // purchaseOrderNumberTextBox
            // 
            this.purchaseOrderNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.returnBindingSource, "PurchaseOrderNumber", true));
            this.purchaseOrderNumberTextBox.Location = new System.Drawing.Point(201, 213);
            this.purchaseOrderNumberTextBox.Name = "purchaseOrderNumberTextBox";
            this.purchaseOrderNumberTextBox.ReadOnly = true;
            this.purchaseOrderNumberTextBox.Size = new System.Drawing.Size(200, 21);
            this.purchaseOrderNumberTextBox.TabIndex = 14;
            // 
            // ingredientNumberTextBox
            // 
            this.ingredientNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.returnBindingSource, "IngredientNumber", true));
            this.ingredientNumberTextBox.Location = new System.Drawing.Point(201, 240);
            this.ingredientNumberTextBox.Name = "ingredientNumberTextBox";
            this.ingredientNumberTextBox.ReadOnly = true;
            this.ingredientNumberTextBox.Size = new System.Drawing.Size(200, 21);
            this.ingredientNumberTextBox.TabIndex = 16;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(326, 278);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 17;
            this.deleteButton.Text = "반품 삭제";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // returnNumCombobox
            // 
            this.returnNumCombobox.FormattingEnabled = true;
            this.returnNumCombobox.Location = new System.Drawing.Point(201, 24);
            this.returnNumCombobox.Name = "returnNumCombobox";
            this.returnNumCombobox.Size = new System.Drawing.Size(200, 20);
            this.returnNumCombobox.TabIndex = 18;
            this.returnNumCombobox.SelectedIndexChanged += new System.EventHandler(this.returnNumCombobox_SelectedIndexChanged);
            // 
            // returnBindingSource
            // 
            this.returnBindingSource.DataMember = "Return";
            this.returnBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // returnTableAdapter
            // 
            this.returnTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PurchaseOrderTableAdapter = null;
            this.tableAdapterManager.ReleaseInfoTableAdapter = null;
            this.tableAdapterManager.ReservationControlTableAdapter = null;
            this.tableAdapterManager.ReservationTableAdapter = null;
            this.tableAdapterManager.ReturnTableAdapter = this.returnTableAdapter;
            this.tableAdapterManager.SARTableAdapter = null;
            this.tableAdapterManager.StockTableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = UnifiedProcessPractice.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WarehousingInfoTableAdapter = null;
            // 
            // 식자재_반품_삭제
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.returnNumCombobox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(returnNumberLabel);
            this.Controls.Add(ingredientNameLabel);
            this.Controls.Add(this.ingredientNameTextBox);
            this.Controls.Add(supplyDateLabel);
            this.Controls.Add(this.supplyDateDateTimePicker);
            this.Controls.Add(reasonLabel);
            this.Controls.Add(this.reasonTextBox);
            this.Controls.Add(returnDateLabel);
            this.Controls.Add(this.returnDateDateTimePicker);
            this.Controls.Add(isEndedLabel);
            this.Controls.Add(this.isEndedCheckBox);
            this.Controls.Add(purchaseOrderNumberLabel);
            this.Controls.Add(this.purchaseOrderNumberTextBox);
            this.Controls.Add(ingredientNumberLabel);
            this.Controls.Add(this.ingredientNumberTextBox);
            this.Name = "식자재_반품_삭제";
            this.Size = new System.Drawing.Size(553, 347);
            this.Load += new System.EventHandler(this.식자재_반품_삭제_Load);
            ((System.ComponentModel.ISupportInitialize)(this.returnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource returnBindingSource;
        private DatabaseDataSetTableAdapters.ReturnTableAdapter returnTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox ingredientNameTextBox;
        private System.Windows.Forms.DateTimePicker supplyDateDateTimePicker;
        private System.Windows.Forms.TextBox reasonTextBox;
        private System.Windows.Forms.DateTimePicker returnDateDateTimePicker;
        private System.Windows.Forms.CheckBox isEndedCheckBox;
        private System.Windows.Forms.TextBox purchaseOrderNumberTextBox;
        private System.Windows.Forms.TextBox ingredientNumberTextBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ComboBox returnNumCombobox;
    }
}
