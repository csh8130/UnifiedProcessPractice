namespace UnifiedProcessPractice
{
    partial class 식자재출고정보수정
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
            System.Windows.Forms.Label sARNumberLabel;
            System.Windows.Forms.Label ingredientNameLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label significantThingLabel;
            System.Windows.Forms.Label ingredientNumberLabel;
            System.Windows.Forms.Label releaseDateLabel;
            this.databaseDataSet = new UnifiedProcessPractice.DatabaseDataSet();
            this.sARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sARTableAdapter = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.SARTableAdapter();
            this.tableAdapterManager = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.sARNumberComboBox = new System.Windows.Forms.ComboBox();
            this.ingredientNameTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.ingredientNumberTextBox = new System.Windows.Forms.TextBox();
            this.releaseInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.releaseInfoTableAdapter = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.ReleaseInfoTableAdapter();
            this.releaseDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.significantThingTextBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            sARNumberLabel = new System.Windows.Forms.Label();
            ingredientNameLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            significantThingLabel = new System.Windows.Forms.Label();
            ingredientNumberLabel = new System.Windows.Forms.Label();
            releaseDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sARBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.releaseInfoBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // sARNumberLabel
            // 
            sARNumberLabel.AutoSize = true;
            sARNumberLabel.Location = new System.Drawing.Point(29, 26);
            sARNumberLabel.Name = "sARNumberLabel";
            sARNumberLabel.Size = new System.Drawing.Size(65, 12);
            sARNumberLabel.TabIndex = 0;
            sARNumberLabel.Text = "입출고번호";
            // 
            // sARNumberComboBox
            // 
            this.sARNumberComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sARBindingSource, "SARNumber", true));
            this.sARNumberComboBox.FormattingEnabled = true;
            this.sARNumberComboBox.Location = new System.Drawing.Point(148, 23);
            this.sARNumberComboBox.Name = "sARNumberComboBox";
            this.sARNumberComboBox.Size = new System.Drawing.Size(200, 20);
            this.sARNumberComboBox.TabIndex = 1;
            this.sARNumberComboBox.SelectedIndexChanged += new System.EventHandler(this.sARNumberComboBox_SelectedIndexChanged);
            // 
            // ingredientNameLabel
            // 
            ingredientNameLabel.AutoSize = true;
            ingredientNameLabel.Location = new System.Drawing.Point(29, 52);
            ingredientNameLabel.Name = "ingredientNameLabel";
            ingredientNameLabel.Size = new System.Drawing.Size(69, 12);
            ingredientNameLabel.TabIndex = 2;
            ingredientNameLabel.Text = "식자재 이름";
            // 
            // ingredientNameTextBox
            // 
            this.ingredientNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sARBindingSource, "IngredientName", true));
            this.ingredientNameTextBox.Location = new System.Drawing.Point(148, 49);
            this.ingredientNameTextBox.Name = "ingredientNameTextBox";
            this.ingredientNameTextBox.ReadOnly = true;
            this.ingredientNameTextBox.Size = new System.Drawing.Size(200, 21);
            this.ingredientNameTextBox.TabIndex = 3;
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(29, 106);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(29, 12);
            amountLabel.TabIndex = 4;
            amountLabel.Text = "수량";
            // 
            // amountTextBox
            // 
            this.amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sARBindingSource, "Amount", true));
            this.amountTextBox.Location = new System.Drawing.Point(148, 103);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(200, 21);
            this.amountTextBox.TabIndex = 5;
            // 
            // significantThingLabel
            // 
            significantThingLabel.AutoSize = true;
            significantThingLabel.Location = new System.Drawing.Point(29, 163);
            significantThingLabel.Name = "significantThingLabel";
            significantThingLabel.Size = new System.Drawing.Size(53, 12);
            significantThingLabel.TabIndex = 6;
            significantThingLabel.Text = "특이사항";
            // 
            // ingredientNumberLabel
            // 
            ingredientNumberLabel.AutoSize = true;
            ingredientNumberLabel.Location = new System.Drawing.Point(29, 79);
            ingredientNumberLabel.Name = "ingredientNumberLabel";
            ingredientNumberLabel.Size = new System.Drawing.Size(69, 12);
            ingredientNumberLabel.TabIndex = 8;
            ingredientNumberLabel.Text = "식자재 번호";
            // 
            // ingredientNumberTextBox
            // 
            this.ingredientNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sARBindingSource, "IngredientNumber", true));
            this.ingredientNumberTextBox.Location = new System.Drawing.Point(148, 76);
            this.ingredientNumberTextBox.Name = "ingredientNumberTextBox";
            this.ingredientNumberTextBox.ReadOnly = true;
            this.ingredientNumberTextBox.Size = new System.Drawing.Size(200, 21);
            this.ingredientNumberTextBox.TabIndex = 10;
            this.ingredientNumberTextBox.TextChanged += new System.EventHandler(this.ingredientNumberTextBox_TextChanged);
            // 
            // releaseInfoBindingSource
            // 
            this.releaseInfoBindingSource.DataMember = "ReleaseInfo";
            this.releaseInfoBindingSource.DataSource = this.databaseDataSet;
            // 
            // releaseInfoTableAdapter
            // 
            this.releaseInfoTableAdapter.ClearBeforeFill = true;
            // 
            // releaseDateLabel
            // 
            releaseDateLabel.AutoSize = true;
            releaseDateLabel.Location = new System.Drawing.Point(29, 136);
            releaseDateLabel.Name = "releaseDateLabel";
            releaseDateLabel.Size = new System.Drawing.Size(53, 12);
            releaseDateLabel.TabIndex = 12;
            releaseDateLabel.Text = "출고날짜";
            // 
            // releaseDateDateTimePicker
            // 
            this.releaseDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.releaseInfoBindingSource, "ReleaseDate", true));
            this.releaseDateDateTimePicker.Location = new System.Drawing.Point(148, 130);
            this.releaseDateDateTimePicker.Name = "releaseDateDateTimePicker";
            this.releaseDateDateTimePicker.Size = new System.Drawing.Size(200, 21);
            this.releaseDateDateTimePicker.TabIndex = 13;
            // 
            // significantThingTextBox
            // 
            this.significantThingTextBox.Location = new System.Drawing.Point(148, 157);
            this.significantThingTextBox.Name = "significantThingTextBox";
            this.significantThingTextBox.Size = new System.Drawing.Size(200, 96);
            this.significantThingTextBox.TabIndex = 14;
            this.significantThingTextBox.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "수정";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(111, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "삭제";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(273, 273);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "취소";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // 식자재출고정보수정
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.significantThingTextBox);
            this.Controls.Add(releaseDateLabel);
            this.Controls.Add(this.releaseDateDateTimePicker);
            this.Controls.Add(this.ingredientNumberTextBox);
            this.Controls.Add(sARNumberLabel);
            this.Controls.Add(this.sARNumberComboBox);
            this.Controls.Add(ingredientNameLabel);
            this.Controls.Add(this.ingredientNameTextBox);
            this.Controls.Add(amountLabel);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(significantThingLabel);
            this.Controls.Add(ingredientNumberLabel);
            this.Name = "식자재출고정보수정";
            this.Size = new System.Drawing.Size(439, 318);
            this.Load += new System.EventHandler(this.식자재출고정보수정_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sARBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.releaseInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource sARBindingSource;
        private DatabaseDataSetTableAdapters.SARTableAdapter sARTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox sARNumberComboBox;
        private System.Windows.Forms.TextBox ingredientNameTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox ingredientNumberTextBox;
        private DatabaseDataSetTableAdapters.ReleaseInfoTableAdapter releaseInfoTableAdapter;
        private System.Windows.Forms.BindingSource releaseInfoBindingSource;
        private System.Windows.Forms.DateTimePicker releaseDateDateTimePicker;
        private System.Windows.Forms.RichTextBox significantThingTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
