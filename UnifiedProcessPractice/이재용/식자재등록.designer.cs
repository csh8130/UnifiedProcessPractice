namespace UnifiedProcessPractice
{
    partial class 식자재등록
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
            this.databaseDataSet = new UnifiedProcessPractice.DatabaseDataSet();
            this.ingredientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ingredientTableAdapter = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.IngredientTableAdapter();
            this.tableAdapterManager = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.ingredientNumberTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.originTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.temperatureTextBox = new System.Windows.Forms.TextBox();
            this.humidityTextBox = new System.Windows.Forms.TextBox();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.measureTextBox = new System.Windows.Forms.TextBox();
            this.keepDateTextBox = new System.Windows.Forms.TextBox();
            this.keepCountTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ingredientNumberLabel
            // 
            ingredientNumberLabel.AutoSize = true;
            ingredientNumberLabel.Location = new System.Drawing.Point(172, 120);
            ingredientNumberLabel.Name = "ingredientNumberLabel";
            ingredientNumberLabel.Size = new System.Drawing.Size(77, 12);
            ingredientNumberLabel.TabIndex = 1;
            ingredientNumberLabel.Text = "식자재 번호 :";
            ingredientNumberLabel.Click += new System.EventHandler(this.ingredientNumberLabel_Click);
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(172, 147);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(65, 12);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "식자재 명 :";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(172, 175);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(37, 12);
            dateLabel.TabIndex = 5;
            dateLabel.Text = "날짜 :";
            // 
            // originLabel
            // 
            originLabel.AutoSize = true;
            originLabel.Location = new System.Drawing.Point(172, 201);
            originLabel.Name = "originLabel";
            originLabel.Size = new System.Drawing.Size(49, 12);
            originLabel.TabIndex = 7;
            originLabel.Text = "원산지 :";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(172, 228);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(37, 12);
            stateLabel.TabIndex = 9;
            stateLabel.Text = "상태 :";
            // 
            // temperatureLabel
            // 
            temperatureLabel.AutoSize = true;
            temperatureLabel.Location = new System.Drawing.Point(172, 255);
            temperatureLabel.Name = "temperatureLabel";
            temperatureLabel.Size = new System.Drawing.Size(89, 12);
            temperatureLabel.TabIndex = 11;
            temperatureLabel.Text = "보관장소 온도 :";
            // 
            // humidityLabel
            // 
            humidityLabel.AutoSize = true;
            humidityLabel.Location = new System.Drawing.Point(172, 282);
            humidityLabel.Name = "humidityLabel";
            humidityLabel.Size = new System.Drawing.Size(89, 12);
            humidityLabel.TabIndex = 13;
            humidityLabel.Text = "보관장소 습도 :";
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Location = new System.Drawing.Point(172, 309);
            countLabel.Name = "countLabel";
            countLabel.Size = new System.Drawing.Size(37, 12);
            countLabel.TabIndex = 15;
            countLabel.Text = "수량 :";
            // 
            // measureLabel
            // 
            measureLabel.AutoSize = true;
            measureLabel.Location = new System.Drawing.Point(172, 336);
            measureLabel.Name = "measureLabel";
            measureLabel.Size = new System.Drawing.Size(37, 12);
            measureLabel.TabIndex = 17;
            measureLabel.Text = "단위 :";
            // 
            // keepDateLabel
            // 
            keepDateLabel.AutoSize = true;
            keepDateLabel.Location = new System.Drawing.Point(172, 363);
            keepDateLabel.Name = "keepDateLabel";
            keepDateLabel.Size = new System.Drawing.Size(85, 12);
            keepDateLabel.TabIndex = 19;
            keepDateLabel.Text = "최장저장기간 :";
            // 
            // keepCountLabel
            // 
            keepCountLabel.AutoSize = true;
            keepCountLabel.Location = new System.Drawing.Point(172, 390);
            keepCountLabel.Name = "keepCountLabel";
            keepCountLabel.Size = new System.Drawing.Size(85, 12);
            keepCountLabel.TabIndex = 21;
            keepCountLabel.Text = "최소유지수량 :";
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // ingredientNumberTextBox
            // 
            this.ingredientNumberTextBox.Location = new System.Drawing.Point(291, 117);
            this.ingredientNumberTextBox.Name = "ingredientNumberTextBox";
            this.ingredientNumberTextBox.Size = new System.Drawing.Size(200, 21);
            this.ingredientNumberTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(291, 144);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 21);
            this.nameTextBox.TabIndex = 4;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ingredientBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(291, 171);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 21);
            this.dateDateTimePicker.TabIndex = 6;
            // 
            // originTextBox
            // 
            this.originTextBox.Location = new System.Drawing.Point(291, 198);
            this.originTextBox.Name = "originTextBox";
            this.originTextBox.Size = new System.Drawing.Size(200, 21);
            this.originTextBox.TabIndex = 8;
            // 
            // stateTextBox
            // 
            this.stateTextBox.Location = new System.Drawing.Point(291, 225);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(200, 21);
            this.stateTextBox.TabIndex = 10;
            // 
            // temperatureTextBox
            // 
            this.temperatureTextBox.Location = new System.Drawing.Point(291, 252);
            this.temperatureTextBox.Name = "temperatureTextBox";
            this.temperatureTextBox.Size = new System.Drawing.Size(200, 21);
            this.temperatureTextBox.TabIndex = 12;
            // 
            // humidityTextBox
            // 
            this.humidityTextBox.Location = new System.Drawing.Point(291, 279);
            this.humidityTextBox.Name = "humidityTextBox";
            this.humidityTextBox.Size = new System.Drawing.Size(200, 21);
            this.humidityTextBox.TabIndex = 14;
            // 
            // countTextBox
            // 
            this.countTextBox.Location = new System.Drawing.Point(291, 306);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(200, 21);
            this.countTextBox.TabIndex = 16;
            // 
            // measureTextBox
            // 
            this.measureTextBox.Location = new System.Drawing.Point(291, 333);
            this.measureTextBox.Name = "measureTextBox";
            this.measureTextBox.Size = new System.Drawing.Size(200, 21);
            this.measureTextBox.TabIndex = 18;
            // 
            // keepDateTextBox
            // 
            this.keepDateTextBox.Location = new System.Drawing.Point(291, 360);
            this.keepDateTextBox.Name = "keepDateTextBox";
            this.keepDateTextBox.Size = new System.Drawing.Size(200, 21);
            this.keepDateTextBox.TabIndex = 20;
            // 
            // keepCountTextBox
            // 
            this.keepCountTextBox.Location = new System.Drawing.Point(291, 387);
            this.keepCountTextBox.Name = "keepCountTextBox";
            this.keepCountTextBox.Size = new System.Drawing.Size(200, 21);
            this.keepCountTextBox.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(425, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "등록";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // 식자재등록
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(ingredientNumberLabel);
            this.Controls.Add(this.ingredientNumberTextBox);
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
            this.Name = "식자재등록";
            this.Size = new System.Drawing.Size(1098, 618);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource ingredientBindingSource;
        private DatabaseDataSetTableAdapters.IngredientTableAdapter ingredientTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox ingredientNumberTextBox;
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
        private System.Windows.Forms.Button button1;
    }
}
