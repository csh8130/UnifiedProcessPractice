namespace UnifiedProcessPractice
{
    partial class 회원정보등록
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
            System.Windows.Forms.Label phoneNoLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label birtgDateLabel;
            System.Windows.Forms.Label memberIDLabel;
            this.databaseDataSet = new UnifiedProcessPractice.DatabaseDataSet();
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuTableAdapter = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.MenuTableAdapter();
            this.tableAdapterManager = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.memberTableAdapter = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.MemberTableAdapter();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.birtgDateTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.memberIDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.phonNum1 = new System.Windows.Forms.TextBox();
            this.phonNum2 = new System.Windows.Forms.TextBox();
            this.phonNum0 = new System.Windows.Forms.TextBox();
            phoneNoLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            birtgDateLabel = new System.Windows.Forms.Label();
            memberIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // phoneNoLabel
            // 
            phoneNoLabel.AutoSize = true;
            phoneNoLabel.Location = new System.Drawing.Point(36, 142);
            phoneNoLabel.Name = "phoneNoLabel";
            phoneNoLabel.Size = new System.Drawing.Size(59, 12);
            phoneNoLabel.TabIndex = 8;
            phoneNoLabel.Text = "전화번호*";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(36, 201);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(29, 12);
            addressLabel.TabIndex = 10;
            addressLabel.Text = "주소";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(36, 91);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(29, 12);
            nameLabel.TabIndex = 12;
            nameLabel.Text = "성명";
            // 
            // birtgDateLabel
            // 
            birtgDateLabel.AutoSize = true;
            birtgDateLabel.Location = new System.Drawing.Point(36, 255);
            birtgDateLabel.Name = "birtgDateLabel";
            birtgDateLabel.Size = new System.Drawing.Size(53, 12);
            birtgDateLabel.TabIndex = 14;
            birtgDateLabel.Text = "생년월일";
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuBindingSource
            // 
            this.menuBindingSource.DataMember = "Menu";
            this.menuBindingSource.DataSource = this.databaseDataSet;
            // 
            // menuTableAdapter
            // 
            this.menuTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.MenuTableAdapter = this.menuTableAdapter;
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
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "Member";
            this.memberBindingSource.DataSource = this.databaseDataSet;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(147, 198);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(163, 21);
            this.addressTextBox.TabIndex = 11;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(147, 88);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 21);
            this.nameTextBox.TabIndex = 13;
            // 
            // birtgDateTextBox
            // 
            this.birtgDateTextBox.Location = new System.Drawing.Point(147, 252);
            this.birtgDateTextBox.Name = "birtgDateTextBox";
            this.birtgDateTextBox.Size = new System.Drawing.Size(100, 21);
            this.birtgDateTextBox.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "등록";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(292, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "취소";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // memberIDLabel
            // 
            memberIDLabel.AutoSize = true;
            memberIDLabel.Location = new System.Drawing.Point(36, 37);
            memberIDLabel.Name = "memberIDLabel";
            memberIDLabel.Size = new System.Drawing.Size(16, 12);
            memberIDLabel.TabIndex = 19;
            memberIDLabel.Text = "ID";
            // 
            // memberIDTextBox
            // 
            this.memberIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "MemberID", true));
            this.memberIDTextBox.Location = new System.Drawing.Point(147, 34);
            this.memberIDTextBox.Name = "memberIDTextBox";
            this.memberIDTextBox.Size = new System.Drawing.Size(100, 21);
            this.memberIDTextBox.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 22;
            this.label2.Text = "-";
            // 
            // phonNum1
            // 
            this.phonNum1.Location = new System.Drawing.Point(197, 139);
            this.phonNum1.Name = "phonNum1";
            this.phonNum1.Size = new System.Drawing.Size(32, 21);
            this.phonNum1.TabIndex = 23;
       
            // 
            // phonNum2
            // 
            this.phonNum2.Location = new System.Drawing.Point(252, 139);
            this.phonNum2.Name = "phonNum2";
            this.phonNum2.Size = new System.Drawing.Size(32, 21);
            this.phonNum2.TabIndex = 24;
            // 
            // phonNum0
            // 
            this.phonNum0.Location = new System.Drawing.Point(147, 139);
            this.phonNum0.Name = "phonNum0";
            this.phonNum0.Size = new System.Drawing.Size(27, 21);
            this.phonNum0.TabIndex = 25;
            this.phonNum0.Text = "010";
            // 
            // 회원정보등록
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.phonNum0);
            this.Controls.Add(this.phonNum2);
            this.Controls.Add(this.phonNum1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(memberIDLabel);
            this.Controls.Add(this.memberIDTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(phoneNoLabel);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(birtgDateLabel);
            this.Controls.Add(this.birtgDateTextBox);
            this.Name = "회원정보등록";
            this.Size = new System.Drawing.Size(646, 407);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource menuBindingSource;
        private DatabaseDataSetTableAdapters.MenuTableAdapter menuTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DatabaseDataSetTableAdapters.MemberTableAdapter memberTableAdapter;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox birtgDateTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox memberIDTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phonNum1;
        private System.Windows.Forms.TextBox phonNum2;
        private System.Windows.Forms.TextBox phonNum0;
    }
}
