namespace UnifiedProcessPractice
{
    partial class 회원정보수정
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
            System.Windows.Forms.Label memberNumberLabel;
            System.Windows.Forms.Label memberPWLabel;
            System.Windows.Forms.Label phoneNoLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label birtgDateLabel;
            this.databaseDataSet = new UnifiedProcessPractice.DatabaseDataSet();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberTableAdapter = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.MemberTableAdapter();
            this.tableAdapterManager = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.memberNumberTextBox = new System.Windows.Forms.TextBox();
            this.memberPWTextBox = new System.Windows.Forms.TextBox();
            this.phoneNoTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.birtgDateTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            memberNumberLabel = new System.Windows.Forms.Label();
            memberPWLabel = new System.Windows.Forms.Label();
            phoneNoLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            birtgDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // memberNumberLabel
            // 
            memberNumberLabel.AutoSize = true;
            memberNumberLabel.Location = new System.Drawing.Point(29, 37);
            memberNumberLabel.Name = "memberNumberLabel";
            memberNumberLabel.Size = new System.Drawing.Size(109, 12);
            memberNumberLabel.TabIndex = 1;
            memberNumberLabel.Text = "수정할 회원의 번호";
            // 
            // memberPWLabel
            // 
            memberPWLabel.AutoSize = true;
            memberPWLabel.Location = new System.Drawing.Point(347, 102);
            memberPWLabel.Name = "memberPWLabel";
            memberPWLabel.Size = new System.Drawing.Size(53, 12);
            memberPWLabel.TabIndex = 5;
            memberPWLabel.Text = "비밀번호";
            // 
            // phoneNoLabel
            // 
            phoneNoLabel.AutoSize = true;
            phoneNoLabel.Location = new System.Drawing.Point(89, 146);
            phoneNoLabel.Name = "phoneNoLabel";
            phoneNoLabel.Size = new System.Drawing.Size(53, 12);
            phoneNoLabel.TabIndex = 9;
            phoneNoLabel.Text = "전화번호";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(113, 191);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(29, 12);
            addressLabel.TabIndex = 11;
            addressLabel.Text = "주소";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(113, 102);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(29, 12);
            nameLabel.TabIndex = 13;
            nameLabel.Text = "성명";

            // 
            // birtgDateLabel
            // 
            birtgDateLabel.AutoSize = true;
            birtgDateLabel.Location = new System.Drawing.Point(89, 236);
            birtgDateLabel.Name = "birtgDateLabel";
            birtgDateLabel.Size = new System.Drawing.Size(53, 12);
            birtgDateLabel.TabIndex = 15;
            birtgDateLabel.Text = "생년월일";
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "Member";
            this.memberBindingSource.DataSource = this.databaseDataSet;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.MemberTableAdapter = this.memberTableAdapter;
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
            // memberNumberTextBox
            // 
            this.memberNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "MemberNumber", true));
            this.memberNumberTextBox.Location = new System.Drawing.Point(144, 34);
            this.memberNumberTextBox.Name = "memberNumberTextBox";
            this.memberNumberTextBox.Size = new System.Drawing.Size(100, 21);
            this.memberNumberTextBox.TabIndex = 2;
            // 
            // memberPWTextBox
            // 
            this.memberPWTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "MemberPW", true));
            this.memberPWTextBox.Location = new System.Drawing.Point(406, 99);
            this.memberPWTextBox.Name = "memberPWTextBox";
            this.memberPWTextBox.PasswordChar = '*';
            this.memberPWTextBox.Size = new System.Drawing.Size(100, 21);
            this.memberPWTextBox.TabIndex = 6;
            // 
            // phoneNoTextBox
            // 
            this.phoneNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "PhoneNo", true));
            this.phoneNoTextBox.Location = new System.Drawing.Point(160, 143);
            this.phoneNoTextBox.Name = "phoneNoTextBox";
            this.phoneNoTextBox.Size = new System.Drawing.Size(100, 21);
            this.phoneNoTextBox.TabIndex = 10;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(160, 188);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 21);
            this.addressTextBox.TabIndex = 12;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(160, 99);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 21);
            this.nameTextBox.TabIndex = 14;
            // 
            // birtgDateTextBox
            // 
            this.birtgDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "BirtgDate", true));
            this.birtgDateTextBox.Location = new System.Drawing.Point(160, 233);
            this.birtgDateTextBox.Name = "birtgDateTextBox";
            this.birtgDateTextBox.Size = new System.Drawing.Size(100, 21);
            this.birtgDateTextBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "비밀번호 확인";
  
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(406, 142);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "수정";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(321, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "취소";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // 회원정보수정
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(memberNumberLabel);
            this.Controls.Add(this.memberNumberTextBox);
            this.Controls.Add(memberPWLabel);
            this.Controls.Add(this.memberPWTextBox);
            this.Controls.Add(phoneNoLabel);
            this.Controls.Add(this.phoneNoTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(birtgDateLabel);
            this.Controls.Add(this.birtgDateTextBox);
            this.Name = "회원정보수정";
            this.Size = new System.Drawing.Size(643, 396);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private DatabaseDataSetTableAdapters.MemberTableAdapter memberTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox memberNumberTextBox;
        private System.Windows.Forms.TextBox memberPWTextBox;
        private System.Windows.Forms.TextBox phoneNoTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox birtgDateTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
