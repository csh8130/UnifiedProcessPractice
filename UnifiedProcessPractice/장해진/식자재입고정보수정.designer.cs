namespace UnifiedProcessPractice
{
    partial class 식자재입고정보수정
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
            System.Windows.Forms.Label warehousingDateLabel;
            System.Windows.Forms.Label supplyCompanyLabel;
            System.Windows.Forms.Label ingredientNameLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label significantThingLabel;
            System.Windows.Forms.Label ingredientNumberLabel;
            System.Windows.Forms.Label sARNumberLabel;
            this.databaseDataSet = new UnifiedProcessPractice.DatabaseDataSet();
            this.warehousingInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehousingInfoTableAdapter = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.WarehousingInfoTableAdapter();
            this.tableAdapterManager = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.businessCompanyTableAdapter1 = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.BusinessCompanyTableAdapter();
            this.ingredientConsumeTableAdapter1 = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.IngredientConsumeTableAdapter();
            this.ingredientTableAdapter1 = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.IngredientTableAdapter();
            this.sARTableAdapter = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.SARTableAdapter();
            this.warehousingDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.supplyCompanyTextBox = new System.Windows.Forms.TextBox();
            this.sARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.significantThingTextBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ingredientTableAdapter2 = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.IngredientTableAdapter();
            this.ingredientNameTextBox = new System.Windows.Forms.TextBox();
            this.ingredientNumberTextBox = new System.Windows.Forms.TextBox();
            this.sARNumberComboBox = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            warehousingDateLabel = new System.Windows.Forms.Label();
            supplyCompanyLabel = new System.Windows.Forms.Label();
            ingredientNameLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            significantThingLabel = new System.Windows.Forms.Label();
            ingredientNumberLabel = new System.Windows.Forms.Label();
            sARNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehousingInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sARBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // warehousingDateLabel
            // 
            warehousingDateLabel.AutoSize = true;
            warehousingDateLabel.Location = new System.Drawing.Point(22, 151);
            warehousingDateLabel.Name = "warehousingDateLabel";
            warehousingDateLabel.Size = new System.Drawing.Size(53, 12);
            warehousingDateLabel.TabIndex = 3;
            warehousingDateLabel.Text = "입고날짜";
            // 
            // supplyCompanyLabel
            // 
            supplyCompanyLabel.AutoSize = true;
            supplyCompanyLabel.Location = new System.Drawing.Point(22, 177);
            supplyCompanyLabel.Name = "supplyCompanyLabel";
            supplyCompanyLabel.Size = new System.Drawing.Size(53, 12);
            supplyCompanyLabel.TabIndex = 5;
            supplyCompanyLabel.Text = "공급업체";
            // 
            // ingredientNameLabel
            // 
            ingredientNameLabel.AutoSize = true;
            ingredientNameLabel.Location = new System.Drawing.Point(22, 66);
            ingredientNameLabel.Name = "ingredientNameLabel";
            ingredientNameLabel.Size = new System.Drawing.Size(69, 12);
            ingredientNameLabel.TabIndex = 9;
            ingredientNameLabel.Text = "식자재 이름";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(22, 123);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(29, 12);
            amountLabel.TabIndex = 11;
            amountLabel.Text = "수량";
            // 
            // significantThingLabel
            // 
            significantThingLabel.AutoSize = true;
            significantThingLabel.Location = new System.Drawing.Point(22, 201);
            significantThingLabel.Name = "significantThingLabel";
            significantThingLabel.Size = new System.Drawing.Size(53, 12);
            significantThingLabel.TabIndex = 13;
            significantThingLabel.Text = "특이사항";
            // 
            // ingredientNumberLabel
            // 
            ingredientNumberLabel.AutoSize = true;
            ingredientNumberLabel.Location = new System.Drawing.Point(22, 95);
            ingredientNumberLabel.Name = "ingredientNumberLabel";
            ingredientNumberLabel.Size = new System.Drawing.Size(65, 12);
            ingredientNumberLabel.TabIndex = 19;
            ingredientNumberLabel.Text = "식자재번호";
            // 
            // sARNumberLabel
            // 
            sARNumberLabel.AutoSize = true;
            sARNumberLabel.Location = new System.Drawing.Point(22, 25);
            sARNumberLabel.Name = "sARNumberLabel";
            sARNumberLabel.Size = new System.Drawing.Size(65, 12);
            sARNumberLabel.TabIndex = 20;
            sARNumberLabel.Text = "입출고번호";
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // warehousingInfoBindingSource
            // 
            this.warehousingInfoBindingSource.DataMember = "WarehousingInfo";
            this.warehousingInfoBindingSource.DataSource = this.databaseDataSet;
            // 
            // warehousingInfoTableAdapter
            // 
            this.warehousingInfoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BusinessCompanyTableAdapter = this.businessCompanyTableAdapter1;
            this.tableAdapterManager.DisuseInfoTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.ExpectSalesVolumeTableAdapter = null;
            this.tableAdapterManager.IngredientConsumeTableAdapter = this.ingredientConsumeTableAdapter1;
            this.tableAdapterManager.IngredientTableAdapter = this.ingredientTableAdapter1;
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
            // businessCompanyTableAdapter1
            // 
            this.businessCompanyTableAdapter1.ClearBeforeFill = true;
            // 
            // ingredientConsumeTableAdapter1
            // 
            this.ingredientConsumeTableAdapter1.ClearBeforeFill = true;
            // 
            // ingredientTableAdapter1
            // 
            this.ingredientTableAdapter1.ClearBeforeFill = true;
            // 
            // sARTableAdapter
            // 
            this.sARTableAdapter.ClearBeforeFill = true;
            // 
            // warehousingDateDateTimePicker
            // 
            this.warehousingDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.warehousingInfoBindingSource, "WarehousingDate", true));
            this.warehousingDateDateTimePicker.Location = new System.Drawing.Point(139, 147);
            this.warehousingDateDateTimePicker.Name = "warehousingDateDateTimePicker";
            this.warehousingDateDateTimePicker.Size = new System.Drawing.Size(200, 21);
            this.warehousingDateDateTimePicker.TabIndex = 4;
            // 
            // supplyCompanyTextBox
            // 
            this.supplyCompanyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.warehousingInfoBindingSource, "SupplyCompany", true));
            this.supplyCompanyTextBox.Location = new System.Drawing.Point(139, 174);
            this.supplyCompanyTextBox.Name = "supplyCompanyTextBox";
            this.supplyCompanyTextBox.Size = new System.Drawing.Size(200, 21);
            this.supplyCompanyTextBox.TabIndex = 6;
            // 
            // sARBindingSource
            // 
            this.sARBindingSource.DataMember = "SAR";
            this.sARBindingSource.DataSource = this.databaseDataSet;
            // 
            // amountTextBox
            // 
            this.amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sARBindingSource, "Amount", true));
            this.amountTextBox.Location = new System.Drawing.Point(141, 120);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(198, 21);
            this.amountTextBox.TabIndex = 12;
            // 
            // significantThingTextBox
            // 
            this.significantThingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sARBindingSource, "IngredientNumber", true));
            this.significantThingTextBox.Location = new System.Drawing.Point(139, 201);
            this.significantThingTextBox.Name = "significantThingTextBox";
            this.significantThingTextBox.Size = new System.Drawing.Size(200, 96);
            this.significantThingTextBox.TabIndex = 17;
            this.significantThingTextBox.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "수정";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(264, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "취소";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ingredientTableAdapter2
            // 
            this.ingredientTableAdapter2.ClearBeforeFill = true;
            // 
            // ingredientNameTextBox
            // 
            this.ingredientNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sARBindingSource, "IngredientName", true));
            this.ingredientNameTextBox.Location = new System.Drawing.Point(141, 63);
            this.ingredientNameTextBox.Name = "ingredientNameTextBox";
            this.ingredientNameTextBox.ReadOnly = true;
            this.ingredientNameTextBox.Size = new System.Drawing.Size(198, 21);
            this.ingredientNameTextBox.TabIndex = 10;
            // 
            // ingredientNumberTextBox
            // 
            this.ingredientNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sARBindingSource, "IngredientNumber", true));
            this.ingredientNumberTextBox.Location = new System.Drawing.Point(141, 92);
            this.ingredientNumberTextBox.Name = "ingredientNumberTextBox";
            this.ingredientNumberTextBox.ReadOnly = true;
            this.ingredientNumberTextBox.Size = new System.Drawing.Size(198, 21);
            this.ingredientNumberTextBox.TabIndex = 20;
            // 
            // sARNumberComboBox
            // 
            this.sARNumberComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sARBindingSource, "SARNumber", true));
            this.sARNumberComboBox.FormattingEnabled = true;
            this.sARNumberComboBox.Location = new System.Drawing.Point(141, 22);
            this.sARNumberComboBox.Name = "sARNumberComboBox";
            this.sARNumberComboBox.Size = new System.Drawing.Size(198, 20);
            this.sARNumberComboBox.TabIndex = 21;
            this.sARNumberComboBox.SelectedIndexChanged += new System.EventHandler(this.sARNumberComboBox_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(100, 315);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "삭제";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // 식자재입고정보수정
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button3);
            this.Controls.Add(sARNumberLabel);
            this.Controls.Add(this.sARNumberComboBox);
            this.Controls.Add(ingredientNumberLabel);
            this.Controls.Add(this.ingredientNumberTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.significantThingTextBox);
            this.Controls.Add(ingredientNameLabel);
            this.Controls.Add(this.ingredientNameTextBox);
            this.Controls.Add(amountLabel);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(significantThingLabel);
            this.Controls.Add(warehousingDateLabel);
            this.Controls.Add(this.warehousingDateDateTimePicker);
            this.Controls.Add(supplyCompanyLabel);
            this.Controls.Add(this.supplyCompanyTextBox);
            this.Name = "식자재입고정보수정";
            this.Size = new System.Drawing.Size(409, 358);
            this.Load += new System.EventHandler(this.식자재입고정보수정_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehousingInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sARBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource warehousingInfoBindingSource;
        private DatabaseDataSetTableAdapters.WarehousingInfoTableAdapter warehousingInfoTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DatabaseDataSetTableAdapters.SARTableAdapter sARTableAdapter;
        private System.Windows.Forms.DateTimePicker warehousingDateDateTimePicker;
        private System.Windows.Forms.TextBox supplyCompanyTextBox;
        private System.Windows.Forms.BindingSource sARBindingSource;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.RichTextBox significantThingTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private DatabaseDataSetTableAdapters.IngredientTableAdapter ingredientTableAdapter1;
        private DatabaseDataSetTableAdapters.IngredientTableAdapter ingredientTableAdapter2;
        private DatabaseDataSetTableAdapters.IngredientConsumeTableAdapter ingredientConsumeTableAdapter1;
        private DatabaseDataSetTableAdapters.BusinessCompanyTableAdapter businessCompanyTableAdapter1;
        private System.Windows.Forms.TextBox ingredientNameTextBox;
        private System.Windows.Forms.TextBox ingredientNumberTextBox;
        private System.Windows.Forms.ComboBox sARNumberComboBox;
        private System.Windows.Forms.Button button3;
    }
}
