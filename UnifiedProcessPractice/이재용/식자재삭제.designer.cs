namespace UnifiedProcessPractice
{
    partial class 식자재삭제
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label originLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label temperatureLabel;
            System.Windows.Forms.Label humidityLabel;
            System.Windows.Forms.Label countLabel;
            System.Windows.Forms.Label measureLabel;
            System.Windows.Forms.Label keepDateLabel;
            System.Windows.Forms.Label keepCountLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.ingredientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new UnifiedProcessPractice.DatabaseDataSet();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.originTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.temperatureTextBox = new System.Windows.Forms.TextBox();
            this.humidityTextBox = new System.Windows.Forms.TextBox();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.measureTextBox = new System.Windows.Forms.TextBox();
            this.keepDateTextBox = new System.Windows.Forms.TextBox();
            this.keepCountTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ingredientTableAdapter = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.IngredientTableAdapter();
            this.tableAdapterManager = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.TableAdapterManager();
            ingredientNumberLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            originLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            temperatureLabel = new System.Windows.Forms.Label();
            humidityLabel = new System.Windows.Forms.Label();
            countLabel = new System.Windows.Forms.Label();
            measureLabel = new System.Windows.Forms.Label();
            keepDateLabel = new System.Windows.Forms.Label();
            keepCountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ingredientNumberLabel
            // 
            ingredientNumberLabel.AutoSize = true;
            ingredientNumberLabel.Location = new System.Drawing.Point(177, 100);
            ingredientNumberLabel.Name = "ingredientNumberLabel";
            ingredientNumberLabel.Size = new System.Drawing.Size(77, 12);
            ingredientNumberLabel.TabIndex = 5;
            ingredientNumberLabel.Text = "식자재 번호 :";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(177, 127);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(65, 12);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "식자재 명 :";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(177, 155);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(37, 12);
            dateLabel.TabIndex = 9;
            dateLabel.Text = "날짜 :";
            // 
            // originLabel
            // 
            originLabel.AutoSize = true;
            originLabel.Location = new System.Drawing.Point(177, 181);
            originLabel.Name = "originLabel";
            originLabel.Size = new System.Drawing.Size(49, 12);
            originLabel.TabIndex = 11;
            originLabel.Text = "원산지 :";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(177, 208);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(37, 12);
            stateLabel.TabIndex = 13;
            stateLabel.Text = "상태 :";
            // 
            // temperatureLabel
            // 
            temperatureLabel.AutoSize = true;
            temperatureLabel.Location = new System.Drawing.Point(177, 235);
            temperatureLabel.Name = "temperatureLabel";
            temperatureLabel.Size = new System.Drawing.Size(89, 12);
            temperatureLabel.TabIndex = 15;
            temperatureLabel.Text = "보관장소 온도 :";
            // 
            // humidityLabel
            // 
            humidityLabel.AutoSize = true;
            humidityLabel.Location = new System.Drawing.Point(177, 262);
            humidityLabel.Name = "humidityLabel";
            humidityLabel.Size = new System.Drawing.Size(89, 12);
            humidityLabel.TabIndex = 17;
            humidityLabel.Text = "보관장소 습도 :";
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Location = new System.Drawing.Point(177, 289);
            countLabel.Name = "countLabel";
            countLabel.Size = new System.Drawing.Size(37, 12);
            countLabel.TabIndex = 19;
            countLabel.Text = "수량 :";
            // 
            // measureLabel
            // 
            measureLabel.AutoSize = true;
            measureLabel.Location = new System.Drawing.Point(177, 316);
            measureLabel.Name = "measureLabel";
            measureLabel.Size = new System.Drawing.Size(37, 12);
            measureLabel.TabIndex = 21;
            measureLabel.Text = "단위 :";
            // 
            // keepDateLabel
            // 
            keepDateLabel.AutoSize = true;
            keepDateLabel.Location = new System.Drawing.Point(177, 343);
            keepDateLabel.Name = "keepDateLabel";
            keepDateLabel.Size = new System.Drawing.Size(89, 12);
            keepDateLabel.TabIndex = 23;
            keepDateLabel.Text = "최장 저장기간 :";
            // 
            // keepCountLabel
            // 
            keepCountLabel.AutoSize = true;
            keepCountLabel.Location = new System.Drawing.Point(177, 370);
            keepCountLabel.Name = "keepCountLabel";
            keepCountLabel.Size = new System.Drawing.Size(89, 12);
            keepCountLabel.TabIndex = 25;
            keepCountLabel.Text = "최소 유지수량 :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(421, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "삭제";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ingredientBindingSource, "Name", true));
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Location = new System.Drawing.Point(296, 124);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 21);
            this.nameTextBox.TabIndex = 8;
            // 
            // ingredientBindingSource
            // 
            this.ingredientBindingSource.DataMember = "Ingredient";
            this.ingredientBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ingredientBindingSource, "Date", true));
            this.dateDateTimePicker.Enabled = false;
            this.dateDateTimePicker.Location = new System.Drawing.Point(296, 151);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 21);
            this.dateDateTimePicker.TabIndex = 10;
            // 
            // originTextBox
            // 
            this.originTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ingredientBindingSource, "Origin", true));
            this.originTextBox.Enabled = false;
            this.originTextBox.Location = new System.Drawing.Point(296, 178);
            this.originTextBox.Name = "originTextBox";
            this.originTextBox.Size = new System.Drawing.Size(200, 21);
            this.originTextBox.TabIndex = 12;
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ingredientBindingSource, "State", true));
            this.stateTextBox.Enabled = false;
            this.stateTextBox.Location = new System.Drawing.Point(296, 205);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(200, 21);
            this.stateTextBox.TabIndex = 14;
            // 
            // temperatureTextBox
            // 
            this.temperatureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ingredientBindingSource, "Temperature", true));
            this.temperatureTextBox.Enabled = false;
            this.temperatureTextBox.Location = new System.Drawing.Point(296, 232);
            this.temperatureTextBox.Name = "temperatureTextBox";
            this.temperatureTextBox.Size = new System.Drawing.Size(200, 21);
            this.temperatureTextBox.TabIndex = 16;
            // 
            // humidityTextBox
            // 
            this.humidityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ingredientBindingSource, "Humidity", true));
            this.humidityTextBox.Enabled = false;
            this.humidityTextBox.Location = new System.Drawing.Point(296, 259);
            this.humidityTextBox.Name = "humidityTextBox";
            this.humidityTextBox.Size = new System.Drawing.Size(200, 21);
            this.humidityTextBox.TabIndex = 18;
            // 
            // countTextBox
            // 
            this.countTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ingredientBindingSource, "Count", true));
            this.countTextBox.Enabled = false;
            this.countTextBox.Location = new System.Drawing.Point(296, 286);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(200, 21);
            this.countTextBox.TabIndex = 20;
            // 
            // measureTextBox
            // 
            this.measureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ingredientBindingSource, "Measure", true));
            this.measureTextBox.Enabled = false;
            this.measureTextBox.Location = new System.Drawing.Point(296, 313);
            this.measureTextBox.Name = "measureTextBox";
            this.measureTextBox.Size = new System.Drawing.Size(200, 21);
            this.measureTextBox.TabIndex = 22;
            // 
            // keepDateTextBox
            // 
            this.keepDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ingredientBindingSource, "KeepDate", true));
            this.keepDateTextBox.Enabled = false;
            this.keepDateTextBox.Location = new System.Drawing.Point(296, 340);
            this.keepDateTextBox.Name = "keepDateTextBox";
            this.keepDateTextBox.Size = new System.Drawing.Size(200, 21);
            this.keepDateTextBox.TabIndex = 24;
            // 
            // keepCountTextBox
            // 
            this.keepCountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ingredientBindingSource, "KeepCount", true));
            this.keepCountTextBox.Enabled = false;
            this.keepCountTextBox.Location = new System.Drawing.Point(296, 367);
            this.keepCountTextBox.Name = "keepCountTextBox";
            this.keepCountTextBox.Size = new System.Drawing.Size(200, 21);
            this.keepCountTextBox.TabIndex = 26;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(296, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 20);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ingredientTableAdapter
            // 
            this.ingredientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BusinessCompanyTableAdapter = null;
            this.tableAdapterManager.DisuseInfoTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.ExpectSalesVolumeTableAdapter = null;
            this.tableAdapterManager.IngredientConsumeTableAdapter = null;
            this.tableAdapterManager.IngredientTableAdapter = this.ingredientTableAdapter;
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
            // 식자재삭제
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(ingredientNumberLabel);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(originLabel);
            this.Controls.Add(this.originTextBox);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(temperatureLabel);
            this.Controls.Add(this.temperatureTextBox);
            this.Controls.Add(humidityLabel);
            this.Controls.Add(this.humidityTextBox);
            this.Controls.Add(countLabel);
            this.Controls.Add(this.countTextBox);
            this.Controls.Add(measureLabel);
            this.Controls.Add(this.measureTextBox);
            this.Controls.Add(keepDateLabel);
            this.Controls.Add(this.keepDateTextBox);
            this.Controls.Add(keepCountLabel);
            this.Controls.Add(this.keepCountTextBox);
            this.Controls.Add(this.button1);
            this.Name = "식자재삭제";
            this.Size = new System.Drawing.Size(948, 652);
            this.Load += new System.EventHandler(this.식자재삭제_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ingredientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource ingredientBindingSource;
        private DatabaseDataSetTableAdapters.IngredientTableAdapter ingredientTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox originTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox temperatureTextBox;
        private System.Windows.Forms.TextBox humidityTextBox;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.TextBox measureTextBox;
        private System.Windows.Forms.TextBox keepDateTextBox;
        private System.Windows.Forms.TextBox keepCountTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
