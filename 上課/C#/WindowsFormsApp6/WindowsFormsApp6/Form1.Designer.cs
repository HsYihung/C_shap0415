
namespace WindowsFormsApp6
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
            this.btnList = new System.Windows.Forms.Button();
            this.btnArrayList = new System.Windows.Forms.Button();
            this.btnDictionary = new System.Windows.Forms.Button();
            this.btnHashtable = new System.Windows.Forms.Button();
            this.btnSting進階 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.Location = new System.Drawing.Point(82, 42);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(128, 46);
            this.btnList.TabIndex = 0;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnArrayList
            // 
            this.btnArrayList.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArrayList.Location = new System.Drawing.Point(82, 134);
            this.btnArrayList.Name = "btnArrayList";
            this.btnArrayList.Size = new System.Drawing.Size(128, 46);
            this.btnArrayList.TabIndex = 1;
            this.btnArrayList.Text = "ArrayList";
            this.btnArrayList.UseVisualStyleBackColor = true;
            this.btnArrayList.Click += new System.EventHandler(this.btnArrayList_Click);
            // 
            // btnDictionary
            // 
            this.btnDictionary.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDictionary.Location = new System.Drawing.Point(82, 234);
            this.btnDictionary.Name = "btnDictionary";
            this.btnDictionary.Size = new System.Drawing.Size(128, 46);
            this.btnDictionary.TabIndex = 2;
            this.btnDictionary.Text = "Dictionary";
            this.btnDictionary.UseVisualStyleBackColor = true;
            this.btnDictionary.Click += new System.EventHandler(this.btnDictionary_Click);
            // 
            // btnHashtable
            // 
            this.btnHashtable.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHashtable.Location = new System.Drawing.Point(82, 331);
            this.btnHashtable.Name = "btnHashtable";
            this.btnHashtable.Size = new System.Drawing.Size(128, 46);
            this.btnHashtable.TabIndex = 3;
            this.btnHashtable.Text = "Hashtable";
            this.btnHashtable.UseVisualStyleBackColor = true;
            this.btnHashtable.Click += new System.EventHandler(this.btnHashtable_Click);
            // 
            // btnSting進階
            // 
            this.btnSting進階.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSting進階.Location = new System.Drawing.Point(82, 427);
            this.btnSting進階.Name = "btnSting進階";
            this.btnSting進階.Size = new System.Drawing.Size(128, 46);
            this.btnSting進階.TabIndex = 4;
            this.btnSting進階.Text = "Sting進階";
            this.btnSting進階.UseVisualStyleBackColor = true;
            this.btnSting進階.Click += new System.EventHandler(this.btnSting進階_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(287, 524);
            this.Controls.Add(this.btnSting進階);
            this.Controls.Add(this.btnHashtable);
            this.Controls.Add(this.btnDictionary);
            this.Controls.Add(this.btnArrayList);
            this.Controls.Add(this.btnList);
            this.Name = "Form1";
            this.Text = "Collections集合的練習";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnArrayList;
        private System.Windows.Forms.Button btnDictionary;
        private System.Windows.Forms.Button btnHashtable;
        private System.Windows.Forms.Button btnSting進階;
    }
}

