
namespace WindowsFormsApp3
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
            this.btn有傳值的方法 = new System.Windows.Forms.Button();
            this.btn有參數的方法 = new System.Windows.Forms.Button();
            this.btn無參數的方法 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn有傳值的方法
            // 
            this.btn有傳值的方法.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn有傳值的方法.Location = new System.Drawing.Point(55, 124);
            this.btn有傳值的方法.Name = "btn有傳值的方法";
            this.btn有傳值的方法.Size = new System.Drawing.Size(220, 50);
            this.btn有傳值的方法.TabIndex = 0;
            this.btn有傳值的方法.Text = "回傳值的方法";
            this.btn有傳值的方法.UseVisualStyleBackColor = true;
            this.btn有傳值的方法.Click += new System.EventHandler(this.btn有傳值的方法_Click);
            // 
            // btn有參數的方法
            // 
            this.btn有參數的方法.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn有參數的方法.Location = new System.Drawing.Point(55, 68);
            this.btn有參數的方法.Name = "btn有參數的方法";
            this.btn有參數的方法.Size = new System.Drawing.Size(220, 50);
            this.btn有參數的方法.TabIndex = 1;
            this.btn有參數的方法.Text = "有參數的方法";
            this.btn有參數的方法.UseVisualStyleBackColor = true;
            this.btn有參數的方法.Click += new System.EventHandler(this.btn有參數的方法_Click);
            // 
            // btn無參數的方法
            // 
            this.btn無參數的方法.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn無參數的方法.Location = new System.Drawing.Point(55, 12);
            this.btn無參數的方法.Name = "btn無參數的方法";
            this.btn無參數的方法.Size = new System.Drawing.Size(220, 50);
            this.btn無參數的方法.TabIndex = 2;
            this.btn無參數的方法.Text = "無參數的方法";
            this.btn無參數的方法.UseVisualStyleBackColor = true;
            this.btn無參數的方法.Click += new System.EventHandler(this.btn無參數的方法_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(314, 186);
            this.Controls.Add(this.btn無參數的方法);
            this.Controls.Add(this.btn有參數的方法);
            this.Controls.Add(this.btn有傳值的方法);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn有傳值的方法;
        private System.Windows.Forms.Button btn有參數的方法;
        private System.Windows.Forms.Button btn無參數的方法;
    }
}

