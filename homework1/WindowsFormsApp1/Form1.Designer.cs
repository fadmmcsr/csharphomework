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
            this.op = new System.Windows.Forms.ComboBox();
            this.answer = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // op
            // 
            this.op.FormattingEnabled = true;
            this.op.Location = new System.Drawing.Point(118, 24);
            this.op.Name = "op";
            this.op.Size = new System.Drawing.Size(121, 20);
            this.op.TabIndex = 1;
            this.op.Text = "+";
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.answer.Location = new System.Drawing.Point(432, 26);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(11, 12);
            this.answer.TabIndex = 2;
            this.answer.Text = "0";
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(12, 23);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(100, 21);
            this.num1.TabIndex = 3;
            this.num1.Text = "0";
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(245, 23);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(100, 21);
            this.num2.TabIndex = 4;
            this.num2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 67);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.op);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox op;
        private System.Windows.Forms.Label answer;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
    }
}

