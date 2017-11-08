namespace UnifiedProcessPractice
{
    partial class 회원정보삭제
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
            this.databaseDataSet = new UnifiedProcessPractice.DatabaseDataSet();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberTableAdapter = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.MemberTableAdapter();
            this.tableAdapterManager = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.memberNumberTextBox = new System.Windows.Forms.TextBox();
            this.memberPWTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            memberNumberLabel = new System.Windows.Forms.Label();
            memberPWLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // memberNumberLabel
            // 
            memberNumberLabel.AutoSize = true;
            memberNumberLabel.Location = new System.Drawing.Point(113, 88);
            memberNumberLabel.Name = "memberNumberLabel";
            memberNumberLabel.Size = new System.Drawing.Size(109, 12);
            memberNumberLabel.TabIndex = 1;
            memberNumberLabel.Text = "삭제할 회원의 번호";
            // 
            // memberNumberTextBox
            // 
            this.memberNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "MemberNumber", true));
            this.memberNumberTextBox.Location = new System.Drawing.Point(224, 85);
            this.memberNumberTextBox.Name = "memberNumberTextBox";
            this.memberNumberTextBox.Size = new System.Drawing.Size(100, 21);
            this.memberNumberTextBox.TabIndex = 2;
            // 
            // memberPWLabel
            // 
            memberPWLabel.AutoSize = true;
            memberPWLabel.Location = new System.Drawing.Point(165, 147);
            memberPWLabel.Name = "memberPWLabel";
            memberPWLabel.Size = new System.Drawing.Size(53, 12);
            memberPWLabel.TabIndex = 3;
            memberPWLabel.Text = "패스워드";
            // 
            // memberPWTextBox
            // 
            this.memberPWTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "MemberPW", true));
            this.memberPWTextBox.Location = new System.Drawing.Point(224, 144);
            this.memberPWTextBox.Name = "memberPWTextBox";
            this.memberPWTextBox.PasswordChar = '*';
            this.memberPWTextBox.Size = new System.Drawing.Size(100, 21);
            this.memberPWTextBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "삭제";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // 회원정보삭제
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(memberPWLabel);
            this.Controls.Add(this.memberPWTextBox);
            this.Controls.Add(memberNumberLabel);
            this.Controls.Add(this.memberNumberTextBox);
            this.Name = "회원정보삭제";
            this.Size = new System.Drawing.Size(695, 352);
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
        private System.Windows.Forms.Button button1;
    }
}
