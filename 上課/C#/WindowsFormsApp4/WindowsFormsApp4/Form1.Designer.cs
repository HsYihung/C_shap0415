
namespace WindowsFormsApp4
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCbv1 = new System.Windows.Forms.Label();
            this.lblCbv2 = new System.Windows.Forms.Label();
            this.lblCbv3 = new System.Windows.Forms.Label();
            this.lblCbr3 = new System.Windows.Forms.Label();
            this.lblCbr2 = new System.Windows.Forms.Label();
            this.lblCbr1 = new System.Windows.Forms.Label();
            this.btnCbv測試 = new System.Windows.Forms.Button();
            this.btnCbr測試 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "傳值呼叫 Call By Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "傳址呼叫 Call By Reference";
            // 
            // lblCbv1
            // 
            this.lblCbv1.AutoSize = true;
            this.lblCbv1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCbv1.Location = new System.Drawing.Point(34, 46);
            this.lblCbv1.Name = "lblCbv1";
            this.lblCbv1.Size = new System.Drawing.Size(67, 26);
            this.lblCbv1.TabIndex = 2;
            this.lblCbv1.Text = "CBV1";
            // 
            // lblCbv2
            // 
            this.lblCbv2.AutoSize = true;
            this.lblCbv2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCbv2.Location = new System.Drawing.Point(34, 97);
            this.lblCbv2.Name = "lblCbv2";
            this.lblCbv2.Size = new System.Drawing.Size(67, 26);
            this.lblCbv2.TabIndex = 3;
            this.lblCbv2.Text = "CBV2";
            // 
            // lblCbv3
            // 
            this.lblCbv3.AutoSize = true;
            this.lblCbv3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCbv3.Location = new System.Drawing.Point(34, 147);
            this.lblCbv3.Name = "lblCbv3";
            this.lblCbv3.Size = new System.Drawing.Size(67, 26);
            this.lblCbv3.TabIndex = 4;
            this.lblCbv3.Text = "CBV3";
            // 
            // lblCbr3
            // 
            this.lblCbr3.AutoSize = true;
            this.lblCbr3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCbr3.Location = new System.Drawing.Point(34, 354);
            this.lblCbr3.Name = "lblCbr3";
            this.lblCbr3.Size = new System.Drawing.Size(67, 26);
            this.lblCbr3.TabIndex = 7;
            this.lblCbr3.Text = "CBR3";
            // 
            // lblCbr2
            // 
            this.lblCbr2.AutoSize = true;
            this.lblCbr2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCbr2.Location = new System.Drawing.Point(34, 304);
            this.lblCbr2.Name = "lblCbr2";
            this.lblCbr2.Size = new System.Drawing.Size(67, 26);
            this.lblCbr2.TabIndex = 6;
            this.lblCbr2.Text = "CBR2";
            // 
            // lblCbr1
            // 
            this.lblCbr1.AutoSize = true;
            this.lblCbr1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCbr1.Location = new System.Drawing.Point(34, 253);
            this.lblCbr1.Name = "lblCbr1";
            this.lblCbr1.Size = new System.Drawing.Size(67, 26);
            this.lblCbr1.TabIndex = 5;
            this.lblCbr1.Text = "CBR1";
            // 
            // btnCbv測試
            // 
            this.btnCbv測試.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCbv測試.Location = new System.Drawing.Point(302, 91);
            this.btnCbv測試.Name = "btnCbv測試";
            this.btnCbv測試.Size = new System.Drawing.Size(128, 38);
            this.btnCbv測試.TabIndex = 8;
            this.btnCbv測試.Text = "CBV測試";
            this.btnCbv測試.UseVisualStyleBackColor = true;
            this.btnCbv測試.Click += new System.EventHandler(this.btnCbv測試_Click);
            // 
            // btnCbr測試
            // 
            this.btnCbr測試.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCbr測試.Location = new System.Drawing.Point(302, 298);
            this.btnCbr測試.Name = "btnCbr測試";
            this.btnCbr測試.Size = new System.Drawing.Size(128, 38);
            this.btnCbr測試.TabIndex = 9;
            this.btnCbr測試.Text = "Cbr測試";
            this.btnCbr測試.UseVisualStyleBackColor = true;
            this.btnCbr測試.Click += new System.EventHandler(this.btnCbr測試_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(473, 407);
            this.Controls.Add(this.btnCbr測試);
            this.Controls.Add(this.btnCbv測試);
            this.Controls.Add(this.lblCbr3);
            this.Controls.Add(this.lblCbr2);
            this.Controls.Add(this.lblCbr1);
            this.Controls.Add(this.lblCbv3);
            this.Controls.Add(this.lblCbv2);
            this.Controls.Add(this.lblCbv1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "傳值呼叫與傳址呼叫";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCbv1;
        private System.Windows.Forms.Label lblCbv2;
        private System.Windows.Forms.Label lblCbv3;
        private System.Windows.Forms.Label lblCbr3;
        private System.Windows.Forms.Label lblCbr2;
        private System.Windows.Forms.Label lblCbr1;
        private System.Windows.Forms.Button btnCbv測試;
        private System.Windows.Forms.Button btnCbr測試;
    }
}

