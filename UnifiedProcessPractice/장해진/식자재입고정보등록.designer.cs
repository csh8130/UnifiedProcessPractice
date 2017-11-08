namespace UnifiedProcessPractice
{
    partial class 식자재입고정보등록
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
            System.Windows.Forms.Label ingredientNameLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label significantThingLabel;
            System.Windows.Forms.Label ingredientNumberLabel;
            System.Windows.Forms.Label warehousingDateLabel;
            System.Windows.Forms.Label supplyCompanyLabel;
            this.databaseDataSet = new UnifiedProcessPractice.DatabaseDataSet();
            this.sARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sARTableAdapter = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.SARTableAdapter();
            this.tableAdapterManager = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.warehousingInfoTableAdapter = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.WarehousingInfoTableAdapter();
            this.ingredientNameTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.warehousingInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehousingDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.supplyCompanyTextBox = new System.Windows.Forms.TextBox();
            this.significantThingTextBox = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.ingredientNumberComboBox = new System.Windows.Forms.ComboBox();
            this.ingredientTableAdapter1 = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.IngredientTableAdapter();
            ingredientNameLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            significantThingLabel = new System.Windows.Forms.Label();
            ingredientNumberLabel = new System.Windows.Forms.Label();
            warehousingDateLabel = new System.Windows.Forms.Label();
            supplyCompanyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sARBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehousingInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ingredientNameLabel
            // 
            ingredientNameLabel.AutoSize = true;
            ingredientNameLabel.Location = new System.Drawing.Point(24, 25);
            ingredientNameLabel.Name = "ingredientNameLabel";
            ingredientNameLabel.Size = new System.Drawing.Size(69, 12);
            ingredientNameLabel.TabIndex = 3;
            ingredientNameLabel.Text = "식자재 이름";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(24, 80);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(29, 12);
            amountLabel.TabIndex = 5;
            amountLabel.Text = "수량";
            // 
            // significantThingLabel
            // 
            significantThingLabel.AutoSize = true;
            significantThingLabel.Location = new System.Drawing.Point(24, 163);
            significantThingLabel.Name = "significantThingLabel";
            significantThingLabel.Size = new System.Drawing.Size(53, 12);
            significantThingLabel.TabIndex = 7;
            significantThingLabel.Text = "특이사항";
            // 
            // ingredientNumberLabel
            // 
            ingredientNumberLabel.AutoSize = true;
            ingredientNumberLabel.Location = new System.Drawing.Point(24, 53);
            ingredientNumberLabel.Name = "ingredientNumberLabel";
            ingredientNumberLabel.Size = new System.Drawing.Size(69, 12);
            ingredientNumberLabel.TabIndex = 9;
            ingredientNumberLabel.Text = "식자재 번호";
            // 
            // warehousingDateLabel
            // 
            warehousingDateLabel.AutoSize = true;
            warehousingDateLabel.Location = new System.Drawing.Point(26, 108);
            warehousingDateLabel.Name = "warehousingDateLabel";
            warehousingDateLabel.Size = new System.Drawing.Size(53, 12);
            warehousingDateLabel.TabIndex = 13;
            warehousingDateLabel.Text = "입고날짜";
            // 
            // supplyCompanyLabel
            // 
            supplyCompanyLabel.AutoSize = true;
            supplyCompanyLabel.Location = new System.Drawing.Point(26, 134);
            supplyCompanyLabel.Name = "supplyCompanyLabel";
            supplyCompanyLabel.Size = new System.Drawing.Size(53, 12);
            supplyCompanyLabel.TabIndex = 15;
            supplyCompanyLabel.Text = "공급업체";
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sARBindingSource
            // 
            this.sARBindingSource.DataMember = "SAR";
            this.sARBindingSource.DataSource = this.databaseDataSet;
            // 
            // sARTableAdapter
            // 
            this.sARTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ReturnTableAdapter = null;
            this.tableAdapterManager.SARTableAdapter = this.sARTableAdapter;
            this.tableAdapterManager.StockTableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = UnifiedProcessPractice.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WarehousingInfoTableAdapter = this.warehousingInfoTableAdapter;
            // 
            // warehousingInfoTableAdapter
            // 
            this.warehousingInfoTableAdapter.ClearBeforeFill = true;
            // 
            // ingredientNameTextBox
            // 
            this.ingredientNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sARBindingSource, "IngredientName", true));
            this.ingredientNameTextBox.Location = new System.Drawing.Point(143, 22);
            this.ingredientNameTextBox.Name = "ingredientNameTextBox";
            this.ingredientNameTextBox.Size = new System.Drawing.Size(200, 21);
            this.ingredientNameTextBox.TabIndex = 4;
            // 
            // amountTextBox
            // 
            this.amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sARBindingSource, "Amount", true));
            this.amountTextBox.Location = new System.Drawing.Point(143, 77);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(200, 21);
            this.amountTextBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "등록";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // warehousingInfoBindingSource
            // 
            this.warehousingInfoBindingSource.DataMember = "WarehousingInfo";
            this.warehousingInfoBindingSource.DataSource = this.databaseDataSet;
            // 
            // warehousingDateDateTimePicker
            // 
            this.warehousingDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.warehousingInfoBindingSource, "WarehousingDate", true));
            this.warehousingDateDateTimePicker.Location = new System.Drawing.Point(143, 104);
            this.warehousingDateDateTimePicker.Name = "warehousingDateDateTimePicker";
            this.warehousingDateDateTimePicker.Size = new System.Drawing.Size(200, 21);
            this.warehousingDateDateTimePicker.TabIndex = 14;
            // 
            // supplyCompanyTextBox
            // 
            this.supplyCompanyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.warehousingInfoBindingSource, "SupplyCompany", true));
            this.supplyCompanyTextBox.Location = new System.Drawing.Point(143, 131);
            this.supplyCompanyTextBox.Name = "supplyCompanyTextBox";
            this.supplyCompanyTextBox.Size = new System.Drawing.Size(200, 21);
            this.supplyCompanyTextBox.TabIndex = 16;
            // 
            // significantThingTextBox
            // 
            this.significantThingTextBox.Location = new System.Drawing.Point(143, 163);
            this.significantThingTextBox.Name = "significantThingTextBox";
            this.significantThingTextBox.Size = new System.Drawing.Size(200, 76);
            this.significantThingTextBox.TabIndex = 17;
            this.significantThingTextBox.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(268, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "취소";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ingredientNumberComboBox
            // 
            this.ingredientNumberComboBox.FormattingEnabled = true;
            this.ingredientNumberComboBox.Location = new System.Drawing.Point(143, 49);
            this.ingredientNumberComboBox.Name = "ingredientNumberComboBox";
            this.ingredientNumberComboBox.Size = new System.Drawing.Size(200, 20);
            this.ingredientNumberComboBox.TabIndex = 20;
            // 
            // ingredientTableAdapter1
            // 
            this.ingredientTableAdapter1.ClearBeforeFill = true;
            // 
            // 식자재입고정보등록
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ingredientNumberComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.significantThingTextBox);
            this.Controls.Add(warehousingDateLabel);
            this.Controls.Add(this.warehousingDateDateTimePicker);
            this.Controls.Add(supplyCompanyLabel);
            this.Controls.Add(this.supplyCompanyTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(ingredientNameLabel);
            this.Controls.Add(this.ingredientNameTextBox);
            this.Controls.Add(amountLabel);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(significantThingLabel);
            this.Controls.Add(ingredientNumberLabel);
            this.Name = "식자재입고정보등록";
            this.Size = new System.Drawing.Size(394, 312);
            this.Load += new System.EventHandler(this.식자재입고정보등록_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sARBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehousingInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource sARBindingSource;
        private DatabaseDataSetTableAdapters.SARTableAdapter sARTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Button button1;
        private DatabaseDataSetTableAdapters.WarehousingInfoTableAdapter warehousingInfoTableAdapter;
        private System.Windows.Forms.BindingSource warehousingInfoBindingSource;
        private System.Windows.Forms.DateTimePicker warehousingDateDateTimePicker;
        private System.Windows.Forms.TextBox supplyCompanyTextBox;
        private System.Windows.Forms.RichTextBox significantThingTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox ingredientNameTextBox;
        private System.Windows.Forms.ComboBox ingredientNumberComboBox;
        private DatabaseDataSetTableAdapters.IngredientTableAdapter ingredientTableAdapter1;
    }
}
