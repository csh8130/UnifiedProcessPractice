namespace UnifiedProcessPractice
{
    partial class 식자재_반품_등록
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
            this.orderNumberCombobox = new System.Windows.Forms.ComboBox();
            this.reasonTextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.purchaseOrderTableAdapter1 = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.PurchaseOrderTableAdapter();
            this.returnTableAdapter1 = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.ReturnTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.ingredNumCombobox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ingredientNameTextbox = new System.Windows.Forms.TextBox();
            this.ingredientTableAdapter1 = new UnifiedProcessPractice.DatabaseDataSetTableAdapters.IngredientTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // orderNumberCombobox
            // 
            this.orderNumberCombobox.FormattingEnabled = true;
            this.orderNumberCombobox.Location = new System.Drawing.Point(133, 45);
            this.orderNumberCombobox.Name = "orderNumberCombobox";
            this.orderNumberCombobox.Size = new System.Drawing.Size(158, 20);
            this.orderNumberCombobox.TabIndex = 0;
            // 
            // reasonTextBox1
            // 
            this.reasonTextBox1.Location = new System.Drawing.Point(133, 84);
            this.reasonTextBox1.Multiline = true;
            this.reasonTextBox1.Name = "reasonTextBox1";
            this.reasonTextBox1.Size = new System.Drawing.Size(158, 123);
            this.reasonTextBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "발주 번호:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "반품 사유:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "반품 등록";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // purchaseOrderTableAdapter1
            // 
            this.purchaseOrderTableAdapter1.ClearBeforeFill = true;
            // 
            // returnTableAdapter1
            // 
            this.returnTableAdapter1.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "식자재 번호:";
            // 
            // ingredNumCombobox
            // 
            this.ingredNumCombobox.FormattingEnabled = true;
            this.ingredNumCombobox.Location = new System.Drawing.Point(414, 45);
            this.ingredNumCombobox.Name = "ingredNumCombobox";
            this.ingredNumCombobox.Size = new System.Drawing.Size(200, 20);
            this.ingredNumCombobox.TabIndex = 6;
            this.ingredNumCombobox.SelectedIndexChanged += new System.EventHandler(this.ingredNumCombobox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "식자재 이름:";
            // 
            // ingredientNameTextbox
            // 
            this.ingredientNameTextbox.Location = new System.Drawing.Point(414, 84);
            this.ingredientNameTextbox.Name = "ingredientNameTextbox";
            this.ingredientNameTextbox.ReadOnly = true;
            this.ingredientNameTextbox.Size = new System.Drawing.Size(200, 21);
            this.ingredientNameTextbox.TabIndex = 8;
            // 
            // ingredientTableAdapter1
            // 
            this.ingredientTableAdapter1.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "식자재 공급일:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(414, 126);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // 식자재_반품_등록
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ingredientNameTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ingredNumCombobox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reasonTextBox1);
            this.Controls.Add(this.orderNumberCombobox);
            this.Name = "식자재_반품_등록";
            this.Size = new System.Drawing.Size(714, 317);
            this.Load += new System.EventHandler(this.식자재_반품_등록_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox orderNumberCombobox;
        private System.Windows.Forms.TextBox reasonTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private DatabaseDataSetTableAdapters.PurchaseOrderTableAdapter purchaseOrderTableAdapter1;
        private DatabaseDataSetTableAdapters.ReturnTableAdapter returnTableAdapter1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ingredNumCombobox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ingredientNameTextbox;
        private DatabaseDataSetTableAdapters.IngredientTableAdapter ingredientTableAdapter1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
