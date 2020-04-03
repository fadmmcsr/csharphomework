namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.nText = new System.Windows.Forms.TextBox();
            this.lengText = new System.Windows.Forms.TextBox();
            this.per1Text = new System.Windows.Forms.TextBox();
            this.per2Text = new System.Windows.Forms.TextBox();
            this.th1Text = new System.Windows.Forms.TextBox();
            this.th2Text = new System.Windows.Forms.TextBox();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(539, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nText
            // 
            this.nText.Location = new System.Drawing.Point(54, 356);
            this.nText.Name = "nText";
            this.nText.Size = new System.Drawing.Size(100, 21);
            this.nText.TabIndex = 1;
            this.nText.Text = "10";
            // 
            // lengText
            // 
            this.lengText.Location = new System.Drawing.Point(203, 355);
            this.lengText.Name = "lengText";
            this.lengText.Size = new System.Drawing.Size(100, 21);
            this.lengText.TabIndex = 2;
            this.lengText.Text = "100";
            // 
            // per1Text
            // 
            this.per1Text.Location = new System.Drawing.Point(355, 356);
            this.per1Text.Name = "per1Text";
            this.per1Text.Size = new System.Drawing.Size(100, 21);
            this.per1Text.TabIndex = 3;
            this.per1Text.Text = "0.6";
            // 
            // per2Text
            // 
            this.per2Text.Location = new System.Drawing.Point(54, 397);
            this.per2Text.Name = "per2Text";
            this.per2Text.Size = new System.Drawing.Size(100, 21);
            this.per2Text.TabIndex = 4;
            this.per2Text.Text = "0.7";
            // 
            // th1Text
            // 
            this.th1Text.Location = new System.Drawing.Point(203, 397);
            this.th1Text.Name = "th1Text";
            this.th1Text.Size = new System.Drawing.Size(100, 21);
            this.th1Text.TabIndex = 5;
            this.th1Text.Text = "30";
            // 
            // th2Text
            // 
            this.th2Text.Location = new System.Drawing.Point(355, 397);
            this.th2Text.Name = "th2Text";
            this.th2Text.Size = new System.Drawing.Size(100, 21);
            this.th2Text.TabIndex = 6;
            this.th2Text.Text = "20";
            // 
            // colorComboBox
            // 
            this.colorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Green",
            "Red",
            "Yellow"});
            this.colorComboBox.Location = new System.Drawing.Point(539, 355);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(121, 20);
            this.colorComboBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "递归深度";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "主干长度";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "右分支长度比";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "左分支长度比";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "右分支角度";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(353, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "左分支角度";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(537, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "画笔颜色";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(699, 355);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(29, 12);
            this.statusLabel.TabIndex = 15;
            this.statusLabel.Text = "状态";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colorComboBox);
            this.Controls.Add(this.th2Text);
            this.Controls.Add(this.th1Text);
            this.Controls.Add(this.per2Text);
            this.Controls.Add(this.per1Text);
            this.Controls.Add(this.lengText);
            this.Controls.Add(this.nText);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nText;
        private System.Windows.Forms.TextBox lengText;
        private System.Windows.Forms.TextBox per1Text;
        private System.Windows.Forms.TextBox per2Text;
        private System.Windows.Forms.TextBox th1Text;
        private System.Windows.Forms.TextBox th2Text;
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label statusLabel;
    }
}

