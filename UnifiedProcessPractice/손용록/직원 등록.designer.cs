namespace UnifiedProcessPractice
{
    partial class 직원_등록
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
            System.Windows.Forms.Label employeeNumberLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label positionLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label homePhoneNumLabel;
            System.Windows.Forms.Label cellPhoneNumLabel;
            System.Windows.Forms.Label eMailLabel;
            this.employeeNumberTextBox = new System.Windows.Forms.TextBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new UnifiedProcessPractice.DatabaseDataSet();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.homePhoneNumTextBox = new System.Windows.Forms.TextBox();
            this.cellPhoneNumTextBox = new System.Windows.Forms.TextBox();
            this.eMailTextBox = new System.Windows.Forms.TextBox();
            this.employeeTableAdapter = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.EmployeeTableAdapter();
            this.tableAdapterManager = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            employeeNumberLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            positionLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            homePhoneNumLabel = new System.Windows.Forms.Label();
            cellPhoneNumLabel = new System.Windows.Forms.Label();
            eMailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeNumberLabel
            // 
            employeeNumberLabel.AutoSize = true;
            employeeNumberLabel.Location = new System.Drawing.Point(260, 100);
            employeeNumberLabel.Name = "employeeNumberLabel";
            employeeNumberLabel.Size = new System.Drawing.Size(57, 12);
            employeeNumberLabel.TabIndex = 1;
            employeeNumberLabel.Text = "직원번호:";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(260, 127);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(20, 12);
            iDLabel.TabIndex = 3;
            iDLabel.Text = "ID:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(260, 154);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(66, 12);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "Password:";
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Location = new System.Drawing.Point(260, 181);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new System.Drawing.Size(33, 12);
            positionLabel.TabIndex = 7;
            positionLabel.Text = "직책:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(260, 208);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(33, 12);
            nameLabel.TabIndex = 9;
            nameLabel.Text = "이름:";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new System.Drawing.Point(260, 235);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(33, 12);
            ageLabel.TabIndex = 11;
            ageLabel.Text = "나이:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(260, 262);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(33, 12);
            addressLabel.TabIndex = 13;
            addressLabel.Text = "주소:";
            // 
            // homePhoneNumLabel
            // 
            homePhoneNumLabel.AutoSize = true;
            homePhoneNumLabel.Location = new System.Drawing.Point(260, 289);
            homePhoneNumLabel.Name = "homePhoneNumLabel";
            homePhoneNumLabel.Size = new System.Drawing.Size(69, 12);
            homePhoneNumLabel.TabIndex = 15;
            homePhoneNumLabel.Text = "집전화번호:";
            // 
            // cellPhoneNumLabel
            // 
            cellPhoneNumLabel.AutoSize = true;
            cellPhoneNumLabel.Location = new System.Drawing.Point(260, 316);
            cellPhoneNumLabel.Name = "cellPhoneNumLabel";
            cellPhoneNumLabel.Size = new System.Drawing.Size(81, 12);
            cellPhoneNumLabel.TabIndex = 17;
            cellPhoneNumLabel.Text = "휴대전화번호:";
            // 
            // eMailLabel
            // 
            eMailLabel.AutoSize = true;
            eMailLabel.Location = new System.Drawing.Point(260, 343);
            eMailLabel.Name = "eMailLabel";
            eMailLabel.Size = new System.Drawing.Size(41, 12);
            eMailLabel.TabIndex = 19;
            eMailLabel.Text = "EMail:";
            // 
            // employeeNumberTextBox
            // 
            this.employeeNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "EmployeeNumber", true));
            this.employeeNumberTextBox.Location = new System.Drawing.Point(381, 97);
            this.employeeNumberTextBox.Name = "employeeNumberTextBox";
            this.employeeNumberTextBox.Size = new System.Drawing.Size(100, 21);
            this.employeeNumberTextBox.TabIndex = 2;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(381, 124);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(100, 21);
            this.iDTextBox.TabIndex = 4;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(381, 151);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 21);
            this.passwordTextBox.TabIndex = 6;
            // 
            // positionTextBox
            // 
            this.positionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Position", true));
            this.positionTextBox.Location = new System.Drawing.Point(381, 178);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(100, 21);
            this.positionTextBox.TabIndex = 8;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(381, 205);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 21);
            this.nameTextBox.TabIndex = 10;
            // 
            // ageTextBox
            // 
            this.ageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Age", true));
            this.ageTextBox.Location = new System.Drawing.Point(381, 232);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(100, 21);
            this.ageTextBox.TabIndex = 12;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(381, 259);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 21);
            this.addressTextBox.TabIndex = 14;
            // 
            // homePhoneNumTextBox
            // 
            this.homePhoneNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "HomePhoneNum", true));
            this.homePhoneNumTextBox.Location = new System.Drawing.Point(381, 286);
            this.homePhoneNumTextBox.Name = "homePhoneNumTextBox";
            this.homePhoneNumTextBox.Size = new System.Drawing.Size(100, 21);
            this.homePhoneNumTextBox.TabIndex = 16;
            // 
            // cellPhoneNumTextBox
            // 
            this.cellPhoneNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "CellPhoneNum", true));
            this.cellPhoneNumTextBox.Location = new System.Drawing.Point(381, 313);
            this.cellPhoneNumTextBox.Name = "cellPhoneNumTextBox";
            this.cellPhoneNumTextBox.Size = new System.Drawing.Size(100, 21);
            this.cellPhoneNumTextBox.TabIndex = 18;
            // 
            // eMailTextBox
            // 
            this.eMailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "EMail", true));
            this.eMailTextBox.Location = new System.Drawing.Point(381, 340);
            this.eMailTextBox.Name = "eMailTextBox";
            this.eMailTextBox.Size = new System.Drawing.Size(100, 21);
            this.eMailTextBox.TabIndex = 20;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BusinessCompanyTableAdapter = null;
            this.tableAdapterManager.DisuseInfoTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
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
            this.tableAdapterManager.SARTableAdapter = null;
            this.tableAdapterManager.StockTableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = UnifiedProcessPractice.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WarehousingInfoTableAdapter = null;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(390, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "등록";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            // 
            // 직원_등록
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(employeeNumberLabel);
            this.Controls.Add(this.employeeNumberTextBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(positionLabel);
            this.Controls.Add(this.positionTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(ageLabel);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(homePhoneNumLabel);
            this.Controls.Add(this.homePhoneNumTextBox);
            this.Controls.Add(cellPhoneNumLabel);
            this.Controls.Add(this.cellPhoneNumTextBox);
            this.Controls.Add(eMailLabel);
            this.Controls.Add(this.eMailTextBox);
            this.Name = "직원_등록";
            this.Size = new System.Drawing.Size(717, 458);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private DatabaseDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox employeeNumberTextBox;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox homePhoneNumTextBox;
        private System.Windows.Forms.TextBox cellPhoneNumTextBox;
        private System.Windows.Forms.TextBox eMailTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
