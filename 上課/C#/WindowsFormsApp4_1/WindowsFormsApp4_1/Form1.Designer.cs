
namespace WindowsFormsApp4_1
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
            this.lblCBVtest1 = new System.Windows.Forms.Label();
            this.lblCBVtest2 = new System.Windows.Forms.Label();
            this.lblCBVtest3 = new System.Windows.Forms.Label();
            this.lblCBRtest3 = new System.Windows.Forms.Label();
            this.lblCBRtest2 = new System.Windows.Forms.Label();
            this.lblCBRtest1 = new System.Windows.Forms.Label();
            this.btnCBVtest = new System.Windows.Forms.Button();
            this.btnCBRtest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "傳值呼叫Call by Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "傳址呼叫Call by Reference";
            // 
            // lblCBVtest1
            // 
            this.lblCBVtest1.AutoSize = true;
            this.lblCBVtest1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCBVtest1.Location = new System.Drawing.Point(13, 64);
            this.lblCBVtest1.Name = "lblCBVtest1";
            this.lblCBVtest1.Size = new System.Drawing.Size(67, 26);
            this.lblCBVtest1.TabIndex = 2;
            this.lblCBVtest1.Text = "CBV1";
            // 
            // lblCBVtest2
            // 
            this.lblCBVtest2.AutoSize = true;
            this.lblCBVtest2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCBVtest2.Location = new System.Drawing.Point(13, 126);
            this.lblCBVtest2.Name = "lblCBVtest2";
            this.lblCBVtest2.Size = new System.Drawing.Size(67, 26);
            this.lblCBVtest2.TabIndex = 3;
            this.lblCBVtest2.Text = "CBV2";
            // 
            // lblCBVtest3
            // 
            this.lblCBVtest3.AutoSize = true;
            this.lblCBVtest3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCBVtest3.Location = new System.Drawing.Point(13, 187);
            this.lblCBVtest3.Name = "lblCBVtest3";
            this.lblCBVtest3.Size = new System.Drawing.Size(67, 26);
            this.lblCBVtest3.TabIndex = 4;
            this.lblCBVtest3.Text = "CBV3";
            // 
            // lblCBRtest3
            // 
            this.lblCBRtest3.AutoSize = true;
            this.lblCBRtest3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCBRtest3.Location = new System.Drawing.Point(13, 411);
            this.lblCBRtest3.Name = "lblCBRtest3";
            this.lblCBRtest3.Size = new System.Drawing.Size(67, 26);
            this.lblCBRtest3.TabIndex = 7;
            this.lblCBRtest3.Text = "CBR3";
            // 
            // lblCBRtest2
            // 
            this.lblCBRtest2.AutoSize = true;
            this.lblCBRtest2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCBRtest2.Location = new System.Drawing.Point(13, 350);
            this.lblCBRtest2.Name = "lblCBRtest2";
            this.lblCBRtest2.Size = new System.Drawing.Size(67, 26);
            this.lblCBRtest2.TabIndex = 6;
            this.lblCBRtest2.Text = "CBR2";
            // 
            // lblCBRtest1
            // 
            this.lblCBRtest1.AutoSize = true;
            this.lblCBRtest1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCBRtest1.Location = new System.Drawing.Point(13, 288);
            this.lblCBRtest1.Name = "lblCBRtest1";
            this.lblCBRtest1.Size = new System.Drawing.Size(67, 26);
            this.lblCBRtest1.TabIndex = 5;
            this.lblCBRtest1.Text = "CBR1";
            // 
            // btnCBVtest
            // 
            this.btnCBVtest.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCBVtest.Location = new System.Drawing.Point(304, 116);
            this.btnCBVtest.Name = "btnCBVtest";
            this.btnCBVtest.Size = new System.Drawing.Size(126, 47);
            this.btnCBVtest.TabIndex = 8;
            this.btnCBVtest.Text = "CBV_test";
            this.btnCBVtest.UseVisualStyleBackColor = true;
            this.btnCBVtest.Click += new System.EventHandler(this.btnCBVtest_Click);
            // 
            // btnCBRtest
            // 
            this.btnCBRtest.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCBRtest.Location = new System.Drawing.Point(304, 340);
            this.btnCBRtest.Name = "btnCBRtest";
            this.btnCBRtest.Size = new System.Drawing.Size(126, 47);
            this.btnCBRtest.TabIndex = 9;
            this.btnCBRtest.Text = "CBR_test";
            this.btnCBRtest.UseVisualStyleBackColor = true;
            this.btnCBRtest.Click += new System.EventHandler(this.btnCBRtest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(442, 450);
            this.Controls.Add(this.btnCBRtest);
            this.Controls.Add(this.btnCBVtest);
            this.Controls.Add(this.lblCBRtest3);
            this.Controls.Add(this.lblCBRtest2);
            this.Controls.Add(this.lblCBRtest1);
            this.Controls.Add(this.lblCBVtest3);
            this.Controls.Add(this.lblCBVtest2);
            this.Controls.Add(this.lblCBVtest1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCBVtest1;
        private System.Windows.Forms.Label lblCBVtest2;
        private System.Windows.Forms.Label lblCBVtest3;
        private System.Windows.Forms.Label lblCBRtest3;
        private System.Windows.Forms.Label lblCBRtest2;
        private System.Windows.Forms.Label lblCBRtest1;
        private System.Windows.Forms.Button btnCBVtest;
        private System.Windows.Forms.Button btnCBRtest;
    }
}

