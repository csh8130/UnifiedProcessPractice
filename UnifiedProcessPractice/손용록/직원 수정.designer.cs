﻿namespace UnifiedProcessPractice
{
    partial class 직원_수정
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new UnifiedProcessPractice.DatabaseDataSet();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.homePhoneNumTextBox = new System.Windows.Forms.TextBox();
            this.cellPhoneNumTextBox = new System.Windows.Forms.TextBox();
            this.eMailTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.employeeTableAdapter = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.EmployeeTableAdapter();
            this.tableAdapterManager = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.TableAdapterManager();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(380, 130);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.ReadOnly = true;
            this.passwordTextBox.Size = new System.Drawing.Size(100, 21);
            this.passwordTextBox.TabIndex = 6;
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
            // positionTextBox
            // 
            this.positionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Position", true));
            this.positionTextBox.Location = new System.Drawing.Point(380, 157);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.ReadOnly = true;
            this.positionTextBox.Size = new System.Drawing.Size(100, 21);
            this.positionTextBox.TabIndex = 8;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(380, 184);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(100, 21);
            this.nameTextBox.TabIndex = 10;
            // 
            // ageTextBox
            // 
            this.ageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Age", true));
            this.ageTextBox.Location = new System.Drawing.Point(380, 211);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.ReadOnly = true;
            this.ageTextBox.Size = new System.Drawing.Size(100, 21);
            this.ageTextBox.TabIndex = 12;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(380, 238);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.ReadOnly = true;
            this.addressTextBox.Size = new System.Drawing.Size(100, 21);
            this.addressTextBox.TabIndex = 14;
            // 
            // homePhoneNumTextBox
            // 
            this.homePhoneNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "HomePhoneNum", true));
            this.homePhoneNumTextBox.Location = new System.Drawing.Point(380, 265);
            this.homePhoneNumTextBox.Name = "homePhoneNumTextBox";
            this.homePhoneNumTextBox.ReadOnly = true;
            this.homePhoneNumTextBox.Size = new System.Drawing.Size(100, 21);
            this.homePhoneNumTextBox.TabIndex = 16;
            // 
            // cellPhoneNumTextBox
            // 
            this.cellPhoneNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "CellPhoneNum", true));
            this.cellPhoneNumTextBox.Location = new System.Drawing.Point(380, 292);
            this.cellPhoneNumTextBox.Name = "cellPhoneNumTextBox";
            this.cellPhoneNumTextBox.ReadOnly = true;
            this.cellPhoneNumTextBox.Size = new System.Drawing.Size(100, 21);
            this.cellPhoneNumTextBox.TabIndex = 18;
            // 
            // eMailTextBox
            // 
            this.eMailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "EMail", true));
            this.eMailTextBox.Location = new System.Drawing.Point(380, 319);
            this.eMailTextBox.Name = "eMailTextBox";
            this.eMailTextBox.ReadOnly = true;
            this.eMailTextBox.Size = new System.Drawing.Size(100, 21);
            this.eMailTextBox.TabIndex = 20;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(380, 103);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(405, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "수정";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(277, 103);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(20, 12);
            label1.TabIndex = 26;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(277, 130);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(66, 12);
            label2.TabIndex = 27;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(277, 157);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(33, 12);
            label3.TabIndex = 28;
            label3.Text = "직책:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(277, 184);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(33, 12);
            label4.TabIndex = 29;
            label4.Text = "이름:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(277, 211);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(33, 12);
            label5.TabIndex = 30;
            label5.Text = "나이:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(277, 238);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(33, 12);
            label6.TabIndex = 31;
            label6.Text = "주소:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(277, 265);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(69, 12);
            label7.TabIndex = 32;
            label7.Text = "집전화번호:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(277, 292);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(81, 12);
            label8.TabIndex = 33;
            label8.Text = "휴대전화번호:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(277, 319);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(41, 12);
            label9.TabIndex = 34;
            label9.Text = "EMail:";
            // 
            // 직원_수정
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(label1);
            this.Controls.Add(label2);
            this.Controls.Add(label3);
            this.Controls.Add(label4);
            this.Controls.Add(label5);
            this.Controls.Add(label6);
            this.Controls.Add(label7);
            this.Controls.Add(label8);
            this.Controls.Add(label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.positionTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.homePhoneNumTextBox);
            this.Controls.Add(this.cellPhoneNumTextBox);
            this.Controls.Add(this.eMailTextBox);
            this.Name = "직원_수정";
            this.Size = new System.Drawing.Size(860, 604);
            this.Load += new System.EventHandler(this.직원_수정_Load);
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
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox homePhoneNumTextBox;
        private System.Windows.Forms.TextBox cellPhoneNumTextBox;
        private System.Windows.Forms.TextBox eMailTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}
