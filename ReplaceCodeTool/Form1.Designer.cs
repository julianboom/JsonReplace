namespace ReplaceCodeTool
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtReplaceText = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNeedText = new System.Windows.Forms.TextBox();
            this.FlowID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TypeID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 316);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "要替换的文本：";
            // 
            // txtReplaceText
            // 
            this.txtReplaceText.Location = new System.Drawing.Point(220, 240);
            this.txtReplaceText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtReplaceText.MaxLength = 0;
            this.txtReplaceText.Multiline = true;
            this.txtReplaceText.Name = "txtReplaceText";
            this.txtReplaceText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReplaceText.Size = new System.Drawing.Size(508, 202);
            this.txtReplaceText.TabIndex = 1;
            this.txtReplaceText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReplaceText_KeyDown);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(772, 448);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(119, 31);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "替换";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 612);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "替换后的文本：";
            // 
            // txtNeedText
            // 
            this.txtNeedText.Location = new System.Drawing.Point(220, 468);
            this.txtNeedText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNeedText.MaxLength = 0;
            this.txtNeedText.Multiline = true;
            this.txtNeedText.Name = "txtNeedText";
            this.txtNeedText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNeedText.Size = new System.Drawing.Size(508, 225);
            this.txtNeedText.TabIndex = 4;
            this.txtNeedText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNeedText_KeyDown);
            // 
            // FlowID
            // 
            this.FlowID.Location = new System.Drawing.Point(220, 61);
            this.FlowID.Name = "FlowID";
            this.FlowID.Size = new System.Drawing.Size(237, 25);
            this.FlowID.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "FlowID：";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Type：";
            // 
            // TypeID
            // 
            this.TypeID.Location = new System.Drawing.Point(220, 147);
            this.TypeID.Name = "TypeID";
            this.TypeID.Size = new System.Drawing.Size(237, 25);
            this.TypeID.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 738);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TypeID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FlowID);
            this.Controls.Add(this.txtNeedText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtReplaceText);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "替换字符";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReplaceText;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNeedText;
        private System.Windows.Forms.TextBox FlowID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TypeID;
    }
}

