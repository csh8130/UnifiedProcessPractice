namespace UnifiedProcessPractice
{
    partial class 식자재출고정보등록
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
            System.Windows.Forms.Label releaseDateLabel;
            this.databaseDataSet = new UnifiedProcessPractice.DatabaseDataSet();
            this.sARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sARTableAdapter = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.SARTableAdapter();
            this.tableAdapterManager = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.releaseInfoTableAdapter = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.ReleaseInfoTableAdapter();
            this.ingredientNameTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.releaseInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.releaseDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.significantThingTextBox = new System.Windows.Forms.RichTextBox();
            this.ingredientNumberComboBox = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.ingredientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ingredientTableAdapter = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.IngredientTableAdapter();
            ingredientNameLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            significantThingLabel = new System.Windows.Forms.Label();
            ingredientNumberLabel = new System.Windows.Forms.Label();
            releaseDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sARBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.releaseInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ingredientNameLabel
            // 
            ingredientNameLabel.AutoSize = true;
            ingredientNameLabel.Location = new System.Drawing.Point(14, 17);
            ingredientNameLabel.Name = "ingredientNameLabel";
            ingredientNameLabel.Size = new System.Drawing.Size(69, 12);
            ingredientNameLabel.TabIndex = 3;
            ingredientNameLabel.Text = "식자재 이름";
            ingredientNameLabel.Click += new System.EventHandler(this.ingredientNameLabel_Click);
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(14, 71);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(29, 12);
            amountLabel.TabIndex = 5;
            amountLabel.Text = "수량";
            // 
            // significantThingLabel
            // 
            significantThingLabel.AutoSize = true;
            significantThingLabel.Location = new System.Drawing.Point(14, 134);
            significantThingLabel.Name = "significantThingLabel";
            significantThingLabel.Size = new System.Drawing.Size(53, 12);
            significantThingLabel.TabIndex = 7;
            significantThingLabel.Text = "특이사항";
            // 
            // ingredientNumberLabel
            // 
            ingredientNumberLabel.AutoSize = true;
            ingredientNumberLabel.Location = new System.Drawing.Point(14, 44);
            ingredientNumberLabel.Name = "ingredientNumberLabel";
            ingredientNumberLabel.Size = new System.Drawing.Size(69, 12);
            ingredientNumberLabel.TabIndex = 9;
            ingredientNumberLabel.Text = "식자재 번호";
            // 
            // releaseDateLabel
            // 
            releaseDateLabel.AutoSize = true;
            releaseDateLabel.Location = new System.Drawing.Point(14, 106);
            releaseDateLabel.Name = "releaseDateLabel";
            releaseDateLabel.Size = new System.Drawing.Size(57, 12);
            releaseDateLabel.TabIndex = 12;
            releaseDateLabel.Text = "출고 날짜";
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
            this.tableAdapterManager.ReleaseInfoTableAdapter = this.releaseInfoTableAdapter;
            this.tableAdapterManager.ReservationControlTableAdapter = null;
            this.tableAdapterManager.ReservationTableAdapter = null;
            this.tableAdapterManager.ReturnTableAdapter = null;
            this.tableAdapterManager.SARTableAdapter = this.sARTableAdapter;
            this.tableAdapterManager.StockTableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = UnifiedProcessPractice.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WarehousingInfoTableAdapter = null;
            // 
            // releaseInfoTableAdapter
            // 
            this.releaseInfoTableAdapter.ClearBeforeFill = true;
            // 
            // ingredientNameTextBox
            // 
            this.ingredientNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sARBindingSource, "IngredientName", true));
            this.ingredientNameTextBox.Location = new System.Drawing.Point(133, 14);
            this.ingredientNameTextBox.Name = "ingredientNameTextBox";
            this.ingredientNameTextBox.Size = new System.Drawing.Size(200, 21);
            this.ingredientNameTextBox.TabIndex = 4;
            // 
            // amountTextBox
            // 
            this.amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sARBindingSource, "Amount", true));
            this.amountTextBox.Location = new System.Drawing.Point(133, 68);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(200, 21);
            this.amountTextBox.TabIndex = 6;
            // 
            // releaseInfoBindingSource
            // 
            this.releaseInfoBindingSource.DataMember = "ReleaseInfo";
            this.releaseInfoBindingSource.DataSource = this.databaseDataSet;
            // 
            // releaseDateDateTimePicker
            // 
            this.releaseDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.releaseInfoBindingSource, "ReleaseDate", true));
            this.releaseDateDateTimePicker.Location = new System.Drawing.Point(133, 100);
            this.releaseDateDateTimePicker.Name = "releaseDateDateTimePicker";
            this.releaseDateDateTimePicker.Size = new System.Drawing.Size(200, 21);
            this.releaseDateDateTimePicker.TabIndex = 13;
            // 
            // significantThingTextBox
            // 
            this.significantThingTextBox.Location = new System.Drawing.Point(133, 134);
            this.significantThingTextBox.Name = "significantThingTextBox";
            this.significantThingTextBox.Size = new System.Drawing.Size(200, 122);
            this.significantThingTextBox.TabIndex = 14;
            this.significantThingTextBox.Text = "";
            // 
            // ingredientNumberComboBox
            // 
            this.ingredientNumberComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sARBindingSource, "IngredientNumber", true));
            this.ingredientNumberComboBox.FormattingEnabled = true;
            this.ingredientNumberComboBox.Location = new System.Drawing.Point(133, 41);
            this.ingredientNumberComboBox.Name = "ingredientNumberComboBox";
            this.ingredientNumberComboBox.Size = new System.Drawing.Size(200, 20);
            this.ingredientNumberComboBox.TabIndex = 15;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(184, 262);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "등록";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(265, 262);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 20;
            this.button5.Text = "취소";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ingredientBindingSource
            // 
            this.ingredientBindingSource.DataMember = "Ingredient";
            this.ingredientBindingSource.DataSource = this.databaseDataSet;
            // 
            // ingredientTableAdapter
            // 
            this.ingredientTableAdapter.ClearBeforeFill = true;
            // 
            // 식자재출고정보등록
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ingredientNumberComboBox);
            this.Controls.Add(this.significantThingTextBox);
            this.Controls.Add(releaseDateLabel);
            this.Controls.Add(this.releaseDateDateTimePicker);
            this.Controls.Add(ingredientNameLabel);
            this.Controls.Add(this.ingredientNameTextBox);
            this.Controls.Add(amountLabel);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(significantThingLabel);
            this.Controls.Add(ingredientNumberLabel);
            this.Name = "식자재출고정보등록";
            this.Size = new System.Drawing.Size(466, 392);
            this.Load += new System.EventHandler(this.식자재출고정보등록_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sARBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.releaseInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource sARBindingSource;
        private DatabaseDataSetTableAdapters.SARTableAdapter sARTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox ingredientNameTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private DatabaseDataSetTableAdapters.ReleaseInfoTableAdapter releaseInfoTableAdapter;
        private System.Windows.Forms.BindingSource releaseInfoBindingSource;
        private System.Windows.Forms.DateTimePicker releaseDateDateTimePicker;
        private System.Windows.Forms.RichTextBox significantThingTextBox;
        private System.Windows.Forms.ComboBox ingredientNumberComboBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource ingredientBindingSource;
        private DatabaseDataSetTableAdapters.IngredientTableAdapter ingredientTableAdapter;
    }
}
