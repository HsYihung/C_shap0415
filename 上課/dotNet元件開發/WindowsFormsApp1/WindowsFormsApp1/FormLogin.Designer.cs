﻿
namespace WindowsFormsApp1
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt使用者名稱 = new System.Windows.Forms.TextBox();
            this.txt密碼 = new System.Windows.Forms.TextBox();
            this.btn登入 = new System.Windows.Forms.Button();
            this.btn清除 = new System.Windows.Forms.Button();
            this.lbl回應訊息 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(9, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "使用者名稱";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(9, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "密碼";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt使用者名稱
            // 
            this.txt使用者名稱.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt使用者名稱.Location = new System.Drawing.Point(12, 77);
            this.txt使用者名稱.Name = "txt使用者名稱";
            this.txt使用者名稱.Size = new System.Drawing.Size(131, 30);
            this.txt使用者名稱.TabIndex = 2;
            // 
            // txt密碼
            // 
            this.txt密碼.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt密碼.Location = new System.Drawing.Point(12, 178);
            this.txt密碼.Name = "txt密碼";
            this.txt密碼.PasswordChar = '*';
            this.txt密碼.Size = new System.Drawing.Size(131, 30);
            this.txt密碼.TabIndex = 3;
            // 
            // btn登入
            // 
            this.btn登入.Location = new System.Drawing.Point(12, 286);
            this.btn登入.Name = "btn登入";
            this.btn登入.Size = new System.Drawing.Size(75, 23);
            this.btn登入.TabIndex = 4;
            this.btn登入.Text = "登入";
            this.btn登入.UseVisualStyleBackColor = true;
            this.btn登入.Click += new System.EventHandler(this.btn登入_Click);
            // 
            // btn清除
            // 
            this.btn清除.Location = new System.Drawing.Point(93, 286);
            this.btn清除.Name = "btn清除";
            this.btn清除.Size = new System.Drawing.Size(75, 23);
            this.btn清除.TabIndex = 5;
            this.btn清除.Text = "清除";
            this.btn清除.UseVisualStyleBackColor = true;
            this.btn清除.Click += new System.EventHandler(this.btn清除_Click);
            // 
            // lbl回應訊息
            // 
            this.lbl回應訊息.AutoEllipsis = true;
            this.lbl回應訊息.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbl回應訊息.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl回應訊息.Location = new System.Drawing.Point(15, 222);
            this.lbl回應訊息.Name = "lbl回應訊息";
            this.lbl回應訊息.Size = new System.Drawing.Size(153, 61);
            this.lbl回應訊息.TabIndex = 6;
            this.lbl回應訊息.Text = "回應訊息";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(185, 332);
            this.Controls.Add(this.lbl回應訊息);
            this.Controls.Add(this.btn清除);
            this.Controls.Add(this.btn登入);
            this.Controls.Add(this.txt密碼);
            this.Controls.Add(this.txt使用者名稱);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormLogin";
            this.Text = "使用者登入";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt使用者名稱;
        private System.Windows.Forms.TextBox txt密碼;
        private System.Windows.Forms.Button btn登入;
        private System.Windows.Forms.Button btn清除;
        private System.Windows.Forms.Label lbl回應訊息;
    }
}