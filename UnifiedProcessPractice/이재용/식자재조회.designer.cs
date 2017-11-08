namespace UnifiedProcessPractice
{
    partial class 식자재조회
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
            this.ingredientDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingredientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new UnifiedProcessPractice.DatabaseDataSet();
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
            this.ingredientTableAdapter = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.IngredientTableAdapter();
            this.tableAdapterManager = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.TableAdapterManager();
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
            ((System.ComponentModel.ISupportInitialize)(this.ingredientDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(96, 398);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(65, 12);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "식자재 명 :";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(96, 426);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(37, 12);
            dateLabel.TabIndex = 5;
            dateLabel.Text = "날짜 :";
            // 
            // originLabel
            // 
            originLabel.AutoSize = true;
            originLabel.Location = new System.Drawing.Point(96, 452);
            originLabel.Name = "originLabel";
            originLabel.Size = new System.Drawing.Size(49, 12);
            originLabel.TabIndex = 7;
            originLabel.Text = "원산지 :";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(96, 479);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(37, 12);
            stateLabel.TabIndex = 9;
            stateLabel.Text = "상태 :";
            // 
            // temperatureLabel
            // 
            temperatureLabel.AutoSize = true;
            temperatureLabel.Location = new System.Drawing.Point(96, 506);
            temperatureLabel.Name = "temperatureLabel";
            temperatureLabel.Size = new System.Drawing.Size(89, 12);
            temperatureLabel.TabIndex = 11;
            temperatureLabel.Text = "저장장소 온도 :";
            // 
            // humidityLabel
            // 
            humidityLabel.AutoSize = true;
            humidityLabel.Location = new System.Drawing.Point(443, 398);
            humidityLabel.Name = "humidityLabel";
            humidityLabel.Size = new System.Drawing.Size(89, 12);
            humidityLabel.TabIndex = 13;
            humidityLabel.Text = "저장장소 습도 :";
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Location = new System.Drawing.Point(443, 425);
            countLabel.Name = "countLabel";
            countLabel.Size = new System.Drawing.Size(37, 12);
            countLabel.TabIndex = 15;
            countLabel.Text = "수량 :";
            // 
            // measureLabel
            // 
            measureLabel.AutoSize = true;
            measureLabel.Location = new System.Drawing.Point(443, 452);
            measureLabel.Name = "measureLabel";
            measureLabel.Size = new System.Drawing.Size(37, 12);
            measureLabel.TabIndex = 17;
            measureLabel.Text = "단위 :";
            // 
            // keepDateLabel
            // 
            keepDateLabel.AutoSize = true;
            keepDateLabel.Location = new System.Drawing.Point(443, 479);
            keepDateLabel.Name = "keepDateLabel";
            keepDateLabel.Size = new System.Drawing.Size(89, 12);
            keepDateLabel.TabIndex = 19;
            keepDateLabel.Text = "최장 저장기간 :";
            // 
            // keepCountLabel
            // 
            keepCountLabel.AutoSize = true;
            keepCountLabel.Location = new System.Drawing.Point(443, 506);
            keepCountLabel.Name = "keepCountLabel";
            keepCountLabel.Size = new System.Drawing.Size(89, 12);
            keepCountLabel.TabIndex = 21;
            keepCountLabel.Text = "최소 유지수량 :";
            // 
            // ingredientDataGridView
            // 
            this.ingredientDataGridView.AutoGenerateColumns = false;
            this.ingredientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ingredientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.ingredientDataGridView.DataSource = this.ingredientBindingSource;
            this.ingredientDataGridView.Location = new System.Drawing.Point(44, 21);
            this.ingredientDataGridView.Name = "ingredientDataGridView";
            this.ingredientDataGridView.RowTemplate.Height = 23;
            this.ingredientDataGridView.Size = new System.Drawing.Size(1156, 332);
            this.ingredientDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IngredientNumber";
            this.dataGridViewTextBoxColumn1.HeaderText = "IngredientNumber";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Origin";
            this.dataGridViewTextBoxColumn4.HeaderText = "Origin";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "State";
            this.dataGridViewTextBoxColumn5.HeaderText = "State";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Temperature";
            this.dataGridViewTextBoxColumn6.HeaderText = "Temperature";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Humidity";
            this.dataGridViewTextBoxColumn7.HeaderText = "Humidity";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Count";
            this.dataGridViewTextBoxColumn8.HeaderText = "Count";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Measure";
            this.dataGridViewTextBoxColumn9.HeaderText = "Measure";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "KeepDate";
            this.dataGridViewTextBoxColumn10.HeaderText = "KeepDate";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "KeepCount";
            this.dataGridViewTextBoxColumn11.HeaderText = "KeepCount";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
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
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(215, 395);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 21);
            this.nameTextBox.TabIndex = 4;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.CustomFormat = "yyyy-mm-dd";
            this.dateDateTimePicker.Location = new System.Drawing.Point(215, 422);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 21);
            this.dateDateTimePicker.TabIndex = 6;
            // 
            // originTextBox
            // 
            this.originTextBox.Location = new System.Drawing.Point(215, 449);
            this.originTextBox.Name = "originTextBox";
            this.originTextBox.Size = new System.Drawing.Size(200, 21);
            this.originTextBox.TabIndex = 8;
            // 
            // stateTextBox
            // 
            this.stateTextBox.Location = new System.Drawing.Point(215, 476);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(200, 21);
            this.stateTextBox.TabIndex = 10;
            // 
            // temperatureTextBox
            // 
            this.temperatureTextBox.Location = new System.Drawing.Point(215, 503);
            this.temperatureTextBox.Name = "temperatureTextBox";
            this.temperatureTextBox.Size = new System.Drawing.Size(200, 21);
            this.temperatureTextBox.TabIndex = 12;
            // 
            // humidityTextBox
            // 
            this.humidityTextBox.Location = new System.Drawing.Point(562, 395);
            this.humidityTextBox.Name = "humidityTextBox";
            this.humidityTextBox.Size = new System.Drawing.Size(200, 21);
            this.humidityTextBox.TabIndex = 14;
            // 
            // countTextBox
            // 
            this.countTextBox.Location = new System.Drawing.Point(562, 422);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(200, 21);
            this.countTextBox.TabIndex = 16;
            // 
            // measureTextBox
            // 
            this.measureTextBox.Location = new System.Drawing.Point(562, 449);
            this.measureTextBox.Name = "measureTextBox";
            this.measureTextBox.Size = new System.Drawing.Size(200, 21);
            this.measureTextBox.TabIndex = 18;
            // 
            // keepDateTextBox
            // 
            this.keepDateTextBox.Location = new System.Drawing.Point(562, 476);
            this.keepDateTextBox.Name = "keepDateTextBox";
            this.keepDateTextBox.Size = new System.Drawing.Size(200, 21);
            this.keepDateTextBox.TabIndex = 20;
            // 
            // keepCountTextBox
            // 
            this.keepCountTextBox.Location = new System.Drawing.Point(562, 503);
            this.keepCountTextBox.Name = "keepCountTextBox";
            this.keepCountTextBox.Size = new System.Drawing.Size(200, 21);
            this.keepCountTextBox.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(827, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "조회";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // 식자재조회
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
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
            this.Controls.Add(this.ingredientDataGridView);
            this.Name = "식자재조회";
            this.Size = new System.Drawing.Size(1263, 631);
            this.Load += new System.EventHandler(this.식자재조회_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ingredientDataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView ingredientDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
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
