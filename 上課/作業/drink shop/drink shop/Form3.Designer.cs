
namespace drink_shop
{
    partial class Form3
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
            this.lblClient = new System.Windows.Forms.Label();
            this.lblClientNum = new System.Windows.Forms.Label();
            this.lboxDSList = new System.Windows.Forms.ListBox();
            this.radioDis1 = new System.Windows.Forms.RadioButton();
            this.btnReClient = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.chkTex = new System.Windows.Forms.CheckBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.radioDis2 = new System.Windows.Forms.RadioButton();
            this.radioDis3 = new System.Windows.Forms.RadioButton();
            this.btnListOneClear = new System.Windows.Forms.Button();
            this.btnNewList = new System.Windows.Forms.Button();
            this.btnReList = new System.Windows.Forms.Button();
            this.btnListAllClear = new System.Windows.Forms.Button();
            this.btnShowList = new System.Windows.Forms.Button();
            this.btnListtotxt = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(126, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "訂購清單";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblClient.Location = new System.Drawing.Point(12, 45);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(66, 21);
            this.lblClient.TabIndex = 1;
            this.lblClient.Text = "訂購人 :";
            // 
            // lblClientNum
            // 
            this.lblClientNum.AutoSize = true;
            this.lblClientNum.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblClientNum.Location = new System.Drawing.Point(12, 76);
            this.lblClientNum.Name = "lblClientNum";
            this.lblClientNum.Size = new System.Drawing.Size(98, 21);
            this.lblClientNum.TabIndex = 2;
            this.lblClientNum.Text = "訂購人電話 :";
            // 
            // lboxDSList
            // 
            this.lboxDSList.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lboxDSList.FormattingEnabled = true;
            this.lboxDSList.ItemHeight = 21;
            this.lboxDSList.Location = new System.Drawing.Point(12, 110);
            this.lboxDSList.Name = "lboxDSList";
            this.lboxDSList.Size = new System.Drawing.Size(356, 403);
            this.lboxDSList.TabIndex = 3;
            this.lboxDSList.SelectedIndexChanged += new System.EventHandler(this.lboxDSList_SelectedIndexChanged);
            // 
            // radioDis1
            // 
            this.radioDis1.AutoSize = true;
            this.radioDis1.Location = new System.Drawing.Point(12, 517);
            this.radioDis1.Name = "radioDis1";
            this.radioDis1.Size = new System.Drawing.Size(57, 20);
            this.radioDis1.TabIndex = 4;
            this.radioDis1.TabStop = true;
            this.radioDis1.Text = "優惠1";
            this.radioDis1.UseVisualStyleBackColor = true;
            this.radioDis1.CheckedChanged += new System.EventHandler(this.radioDis1_CheckedChanged);
            // 
            // btnReClient
            // 
            this.btnReClient.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReClient.Location = new System.Drawing.Point(228, 45);
            this.btnReClient.Name = "btnReClient";
            this.btnReClient.Size = new System.Drawing.Size(140, 27);
            this.btnReClient.TabIndex = 5;
            this.btnReClient.Text = "修改訂購人資訊";
            this.btnReClient.UseVisualStyleBackColor = true;
            this.btnReClient.Click += new System.EventHandler(this.btnReClient_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(186, 543);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "總價 :";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(242, 543);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(36, 21);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "0元";
            // 
            // chkTex
            // 
            this.chkTex.AutoSize = true;
            this.chkTex.Location = new System.Drawing.Point(283, 569);
            this.chkTex.Name = "chkTex";
            this.chkTex.Size = new System.Drawing.Size(69, 20);
            this.chkTex.TabIndex = 8;
            this.chkTex.Text = "5%稅金";
            this.chkTex.UseVisualStyleBackColor = true;
            this.chkTex.CheckedChanged += new System.EventHandler(this.chkTex_CheckedChanged);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(331, 662);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(46, 23);
            this.btnQuit.TabIndex = 9;
            this.btnQuit.Text = "退出";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // radioDis2
            // 
            this.radioDis2.AutoSize = true;
            this.radioDis2.Location = new System.Drawing.Point(12, 543);
            this.radioDis2.Name = "radioDis2";
            this.radioDis2.Size = new System.Drawing.Size(57, 20);
            this.radioDis2.TabIndex = 10;
            this.radioDis2.TabStop = true;
            this.radioDis2.Text = "優惠2";
            this.radioDis2.UseVisualStyleBackColor = true;
            this.radioDis2.CheckedChanged += new System.EventHandler(this.radioDis2_CheckedChanged);
            // 
            // radioDis3
            // 
            this.radioDis3.AutoSize = true;
            this.radioDis3.Location = new System.Drawing.Point(12, 569);
            this.radioDis3.Name = "radioDis3";
            this.radioDis3.Size = new System.Drawing.Size(57, 20);
            this.radioDis3.TabIndex = 11;
            this.radioDis3.TabStop = true;
            this.radioDis3.Text = "優惠3";
            this.radioDis3.UseVisualStyleBackColor = true;
            this.radioDis3.CheckedChanged += new System.EventHandler(this.radioDis3_CheckedChanged);
            // 
            // btnListOneClear
            // 
            this.btnListOneClear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnListOneClear.Location = new System.Drawing.Point(12, 595);
            this.btnListOneClear.Name = "btnListOneClear";
            this.btnListOneClear.Size = new System.Drawing.Size(66, 53);
            this.btnListOneClear.TabIndex = 12;
            this.btnListOneClear.Text = "清除所選訂單";
            this.btnListOneClear.UseVisualStyleBackColor = true;
            this.btnListOneClear.Click += new System.EventHandler(this.btnListOneClear_Click);
            // 
            // btnNewList
            // 
            this.btnNewList.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNewList.Location = new System.Drawing.Point(228, 595);
            this.btnNewList.Name = "btnNewList";
            this.btnNewList.Size = new System.Drawing.Size(66, 53);
            this.btnNewList.TabIndex = 13;
            this.btnNewList.Text = "新增訂購單";
            this.btnNewList.UseVisualStyleBackColor = true;
            this.btnNewList.Click += new System.EventHandler(this.btnNewList_Click);
            // 
            // btnReList
            // 
            this.btnReList.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReList.Location = new System.Drawing.Point(84, 595);
            this.btnReList.Name = "btnReList";
            this.btnReList.Size = new System.Drawing.Size(66, 53);
            this.btnReList.TabIndex = 15;
            this.btnReList.Text = "修改所選訂單";
            this.btnReList.UseVisualStyleBackColor = true;
            this.btnReList.Click += new System.EventHandler(this.btnReList_Click);
            // 
            // btnListAllClear
            // 
            this.btnListAllClear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnListAllClear.Location = new System.Drawing.Point(156, 595);
            this.btnListAllClear.Name = "btnListAllClear";
            this.btnListAllClear.Size = new System.Drawing.Size(66, 53);
            this.btnListAllClear.TabIndex = 14;
            this.btnListAllClear.Text = "清除所有訂單";
            this.btnListAllClear.UseVisualStyleBackColor = true;
            this.btnListAllClear.Click += new System.EventHandler(this.btnListAllClear_Click);
            // 
            // btnShowList
            // 
            this.btnShowList.Location = new System.Drawing.Point(254, 514);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(114, 23);
            this.btnShowList.TabIndex = 16;
            this.btnShowList.Text = "訂單詳細資訊";
            this.btnShowList.UseVisualStyleBackColor = true;
            // 
            // btnListtotxt
            // 
            this.btnListtotxt.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnListtotxt.Location = new System.Drawing.Point(300, 595);
            this.btnListtotxt.Name = "btnListtotxt";
            this.btnListtotxt.Size = new System.Drawing.Size(66, 53);
            this.btnListtotxt.TabIndex = 17;
            this.btnListtotxt.Text = "匯出訂購單";
            this.btnListtotxt.UseVisualStyleBackColor = true;
            this.btnListtotxt.Click += new System.EventHandler(this.btnListtotxt_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(2, 662);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(46, 23);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "返回訂購單";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(380, 686);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnListtotxt);
            this.Controls.Add(this.btnShowList);
            this.Controls.Add(this.btnReList);
            this.Controls.Add(this.btnListAllClear);
            this.Controls.Add(this.btnNewList);
            this.Controls.Add(this.btnListOneClear);
            this.Controls.Add(this.radioDis3);
            this.Controls.Add(this.radioDis2);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.chkTex);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnReClient);
            this.Controls.Add(this.radioDis1);
            this.Controls.Add(this.lboxDSList);
            this.Controls.Add(this.lblClientNum);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Form3";
            this.Text = "訂購清單";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblClientNum;
        private System.Windows.Forms.ListBox lboxDSList;
        private System.Windows.Forms.RadioButton radioDis1;
        private System.Windows.Forms.Button btnReClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox chkTex;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.RadioButton radioDis2;
        private System.Windows.Forms.RadioButton radioDis3;
        private System.Windows.Forms.Button btnListOneClear;
        private System.Windows.Forms.Button btnNewList;
        private System.Windows.Forms.Button btnReList;
        private System.Windows.Forms.Button btnListAllClear;
        private System.Windows.Forms.Button btnShowList;
        private System.Windows.Forms.Button btnListtotxt;
        private System.Windows.Forms.Button btnBack;
    }
}