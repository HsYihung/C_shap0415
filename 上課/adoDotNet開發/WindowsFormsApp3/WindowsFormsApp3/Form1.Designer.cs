
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mydbDataSet = new WindowsFormsApp3.mydbDataSet();
            this.personsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personsTableAdapter = new WindowsFormsApp3.mydbDataSetTableAdapters.personsTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp3.mydbDataSetTableAdapters.TableAdapterManager();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.personsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.personsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personsDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txt姓名 = new System.Windows.Forms.TextBox();
            this.txt地址 = new System.Windows.Forms.TextBox();
            this.txt電話 = new System.Windows.Forms.TextBox();
            this.txt點數 = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dtp生日 = new System.Windows.Forms.DateTimePicker();
            this.chk婚姻狀態 = new System.Windows.Forms.CheckBox();
            this.btn第一筆 = new System.Windows.Forms.Button();
            this.btn上一筆 = new System.Windows.Forms.Button();
            this.btn最後一筆 = new System.Windows.Forms.Button();
            this.btn下一筆 = new System.Windows.Forms.Button();
            this.btn儲存修改 = new System.Windows.Forms.Button();
            this.btn刪除 = new System.Windows.Forms.Button();
            this.btn回復資料 = new System.Windows.Forms.Button();
            this.gpBox新增資料 = new System.Windows.Forms.GroupBox();
            this.btn新增資料儲存 = new System.Windows.Forms.Button();
            this.btn新增資料新增 = new System.Windows.Forms.Button();
            this.lbl第幾筆共幾筆 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingNavigator)).BeginInit();
            this.personsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personsDataGridView)).BeginInit();
            this.gpBox新增資料.SuspendLayout();
            this.SuspendLayout();
            // 
            // mydbDataSet
            // 
            this.mydbDataSet.DataSetName = "mydbDataSet";
            this.mydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personsBindingSource
            // 
            this.personsBindingSource.DataMember = "persons";
            this.personsBindingSource.DataSource = this.mydbDataSet;
            // 
            // personsTableAdapter
            // 
            this.personsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.personsTableAdapter = this.personsTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp3.mydbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(27, 22);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "加入新的";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "刪除";
            // 
            // personsBindingNavigatorSaveItem
            // 
            this.personsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.personsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("personsBindingNavigatorSaveItem.Image")));
            this.personsBindingNavigatorSaveItem.Name = "personsBindingNavigatorSaveItem";
            this.personsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.personsBindingNavigatorSaveItem.Text = "儲存資料";
            this.personsBindingNavigatorSaveItem.Click += new System.EventHandler(this.personsBindingNavigatorSaveItem_Click);
            // 
            // personsBindingNavigator
            // 
            this.personsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.personsBindingNavigator.BindingSource = this.personsBindingSource;
            this.personsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.personsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.personsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.personsBindingNavigatorSaveItem});
            this.personsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.personsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.personsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.personsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.personsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.personsBindingNavigator.Name = "personsBindingNavigator";
            this.personsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.personsBindingNavigator.Size = new System.Drawing.Size(572, 25);
            this.personsBindingNavigator.TabIndex = 0;
            this.personsBindingNavigator.Text = "bindingNavigator1";
            this.personsBindingNavigator.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "會員點數";
            this.dataGridViewTextBoxColumn7.HeaderText = "會員點數";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "婚姻狀態";
            this.dataGridViewCheckBoxColumn1.HeaderText = "婚姻狀態";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "生日";
            this.dataGridViewTextBoxColumn6.HeaderText = "生日";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn5.HeaderText = "email";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "地址";
            this.dataGridViewTextBoxColumn4.HeaderText = "地址";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "電話";
            this.dataGridViewTextBoxColumn3.HeaderText = "電話";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "姓名";
            this.dataGridViewTextBoxColumn2.HeaderText = "姓名";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // personsDataGridView
            // 
            this.personsDataGridView.AutoGenerateColumns = false;
            this.personsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn7});
            this.personsDataGridView.DataSource = this.personsBindingSource;
            this.personsDataGridView.Location = new System.Drawing.Point(562, 28);
            this.personsDataGridView.Name = "personsDataGridView";
            this.personsDataGridView.RowTemplate.Height = 24;
            this.personsDataGridView.Size = new System.Drawing.Size(10, 10);
            this.personsDataGridView.TabIndex = 1;
            this.personsDataGridView.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "電話";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(12, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "生日";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(12, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(12, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "地址";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(12, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 26);
            this.label9.TabIndex = 8;
            this.label9.Text = "婚姻狀態";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(12, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 26);
            this.label7.TabIndex = 9;
            this.label7.Text = "點數";
            // 
            // lblId
            // 
            this.lblId.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "Id", true));
            this.lblId.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblId.Location = new System.Drawing.Point(137, 40);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(124, 26);
            this.lblId.TabIndex = 10;
            this.lblId.Text = "0";
            // 
            // txt姓名
            // 
            this.txt姓名.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "姓名", true));
            this.txt姓名.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt姓名.Location = new System.Drawing.Point(137, 69);
            this.txt姓名.Name = "txt姓名";
            this.txt姓名.Size = new System.Drawing.Size(302, 35);
            this.txt姓名.TabIndex = 11;
            // 
            // txt地址
            // 
            this.txt地址.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "地址", true));
            this.txt地址.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt地址.Location = new System.Drawing.Point(137, 151);
            this.txt地址.Name = "txt地址";
            this.txt地址.Size = new System.Drawing.Size(354, 35);
            this.txt地址.TabIndex = 12;
            // 
            // txt電話
            // 
            this.txt電話.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "電話", true));
            this.txt電話.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt電話.Location = new System.Drawing.Point(137, 110);
            this.txt電話.Name = "txt電話";
            this.txt電話.Size = new System.Drawing.Size(302, 35);
            this.txt電話.TabIndex = 13;
            // 
            // txt點數
            // 
            this.txt點數.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "會員點數", true));
            this.txt點數.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt點數.Location = new System.Drawing.Point(137, 314);
            this.txt點數.Name = "txt點數";
            this.txt點數.Size = new System.Drawing.Size(167, 35);
            this.txt點數.TabIndex = 15;
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "email", true));
            this.txtEmail.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEmail.Location = new System.Drawing.Point(137, 192);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(354, 35);
            this.txtEmail.TabIndex = 16;
            // 
            // dtp生日
            // 
            this.dtp生日.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.personsBindingSource, "生日", true));
            this.dtp生日.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp生日.Location = new System.Drawing.Point(137, 233);
            this.dtp生日.Name = "dtp生日";
            this.dtp生日.Size = new System.Drawing.Size(302, 35);
            this.dtp生日.TabIndex = 17;
            // 
            // chk婚姻狀態
            // 
            this.chk婚姻狀態.AutoSize = true;
            this.chk婚姻狀態.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.personsBindingSource, "婚姻狀態", true));
            this.chk婚姻狀態.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk婚姻狀態.Location = new System.Drawing.Point(137, 274);
            this.chk婚姻狀態.Name = "chk婚姻狀態";
            this.chk婚姻狀態.Size = new System.Drawing.Size(73, 30);
            this.chk婚姻狀態.TabIndex = 18;
            this.chk婚姻狀態.Text = "已婚";
            this.chk婚姻狀態.UseVisualStyleBackColor = true;
            // 
            // btn第一筆
            // 
            this.btn第一筆.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn第一筆.Location = new System.Drawing.Point(17, 389);
            this.btn第一筆.Name = "btn第一筆";
            this.btn第一筆.Size = new System.Drawing.Size(101, 32);
            this.btn第一筆.TabIndex = 19;
            this.btn第一筆.Text = "第一筆";
            this.btn第一筆.UseVisualStyleBackColor = true;
            this.btn第一筆.Click += new System.EventHandler(this.btn第一筆_Click);
            // 
            // btn上一筆
            // 
            this.btn上一筆.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn上一筆.Location = new System.Drawing.Point(124, 389);
            this.btn上一筆.Name = "btn上一筆";
            this.btn上一筆.Size = new System.Drawing.Size(101, 32);
            this.btn上一筆.TabIndex = 20;
            this.btn上一筆.Text = "上一筆";
            this.btn上一筆.UseVisualStyleBackColor = true;
            this.btn上一筆.Click += new System.EventHandler(this.btn上一筆_Click);
            // 
            // btn最後一筆
            // 
            this.btn最後一筆.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn最後一筆.Location = new System.Drawing.Point(338, 389);
            this.btn最後一筆.Name = "btn最後一筆";
            this.btn最後一筆.Size = new System.Drawing.Size(101, 32);
            this.btn最後一筆.TabIndex = 22;
            this.btn最後一筆.Text = "最後一筆";
            this.btn最後一筆.UseVisualStyleBackColor = true;
            this.btn最後一筆.Click += new System.EventHandler(this.btn最後一筆_Click);
            // 
            // btn下一筆
            // 
            this.btn下一筆.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn下一筆.Location = new System.Drawing.Point(231, 389);
            this.btn下一筆.Name = "btn下一筆";
            this.btn下一筆.Size = new System.Drawing.Size(101, 32);
            this.btn下一筆.TabIndex = 21;
            this.btn下一筆.Text = "下一筆";
            this.btn下一筆.UseVisualStyleBackColor = true;
            this.btn下一筆.Click += new System.EventHandler(this.btn下一筆_Click);
            // 
            // btn儲存修改
            // 
            this.btn儲存修改.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn儲存修改.Location = new System.Drawing.Point(17, 427);
            this.btn儲存修改.Name = "btn儲存修改";
            this.btn儲存修改.Size = new System.Drawing.Size(101, 32);
            this.btn儲存修改.TabIndex = 23;
            this.btn儲存修改.Text = "儲存修改";
            this.btn儲存修改.UseVisualStyleBackColor = true;
            this.btn儲存修改.Click += new System.EventHandler(this.btn儲存修改_Click);
            // 
            // btn刪除
            // 
            this.btn刪除.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刪除.Location = new System.Drawing.Point(124, 427);
            this.btn刪除.Name = "btn刪除";
            this.btn刪除.Size = new System.Drawing.Size(101, 32);
            this.btn刪除.TabIndex = 24;
            this.btn刪除.Text = "刪除";
            this.btn刪除.UseVisualStyleBackColor = true;
            this.btn刪除.Click += new System.EventHandler(this.btn刪除_Click);
            // 
            // btn回復資料
            // 
            this.btn回復資料.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn回復資料.Location = new System.Drawing.Point(231, 427);
            this.btn回復資料.Name = "btn回復資料";
            this.btn回復資料.Size = new System.Drawing.Size(101, 32);
            this.btn回復資料.TabIndex = 25;
            this.btn回復資料.Text = "回復資料";
            this.btn回復資料.UseVisualStyleBackColor = true;
            this.btn回復資料.Click += new System.EventHandler(this.btn回復資料_Click);
            // 
            // gpBox新增資料
            // 
            this.gpBox新增資料.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gpBox新增資料.Controls.Add(this.btn新增資料儲存);
            this.gpBox新增資料.Controls.Add(this.btn新增資料新增);
            this.gpBox新增資料.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpBox新增資料.Location = new System.Drawing.Point(338, 427);
            this.gpBox新增資料.Name = "gpBox新增資料";
            this.gpBox新增資料.Size = new System.Drawing.Size(222, 68);
            this.gpBox新增資料.TabIndex = 26;
            this.gpBox新增資料.TabStop = false;
            this.gpBox新增資料.Text = "新增資料";
            // 
            // btn新增資料儲存
            // 
            this.btn新增資料儲存.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn新增資料儲存.Location = new System.Drawing.Point(142, 28);
            this.btn新增資料儲存.Name = "btn新增資料儲存";
            this.btn新增資料儲存.Size = new System.Drawing.Size(74, 32);
            this.btn新增資料儲存.TabIndex = 28;
            this.btn新增資料儲存.Text = "儲存";
            this.btn新增資料儲存.UseVisualStyleBackColor = true;
            this.btn新增資料儲存.Click += new System.EventHandler(this.btn新增資料儲存_Click);
            // 
            // btn新增資料新增
            // 
            this.btn新增資料新增.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn新增資料新增.Location = new System.Drawing.Point(6, 26);
            this.btn新增資料新增.Name = "btn新增資料新增";
            this.btn新增資料新增.Size = new System.Drawing.Size(74, 32);
            this.btn新增資料新增.TabIndex = 27;
            this.btn新增資料新增.Text = "新增";
            this.btn新增資料新增.UseVisualStyleBackColor = true;
            this.btn新增資料新增.Click += new System.EventHandler(this.btn新增資料新增_Click);
            // 
            // lbl第幾筆共幾筆
            // 
            this.lbl第幾筆共幾筆.AutoSize = true;
            this.lbl第幾筆共幾筆.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl第幾筆共幾筆.Location = new System.Drawing.Point(171, 360);
            this.lbl第幾筆共幾筆.Name = "lbl第幾筆共幾筆";
            this.lbl第幾筆共幾筆.Size = new System.Drawing.Size(133, 26);
            this.lbl第幾筆共幾筆.TabIndex = 27;
            this.lbl第幾筆共幾筆.Text = "第X筆/共X筆";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(572, 511);
            this.Controls.Add(this.lbl第幾筆共幾筆);
            this.Controls.Add(this.gpBox新增資料);
            this.Controls.Add(this.btn回復資料);
            this.Controls.Add(this.btn刪除);
            this.Controls.Add(this.btn儲存修改);
            this.Controls.Add(this.btn最後一筆);
            this.Controls.Add(this.btn下一筆);
            this.Controls.Add(this.btn上一筆);
            this.Controls.Add(this.btn第一筆);
            this.Controls.Add(this.chk婚姻狀態);
            this.Controls.Add(this.dtp生日);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txt點數);
            this.Controls.Add(this.txt電話);
            this.Controls.Add(this.txt地址);
            this.Controls.Add(this.txt姓名);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.personsBindingNavigator);
            this.Controls.Add(this.personsDataGridView);
            this.Name = "Form1";
            this.Text = "會員資料連表單(SQL Sever)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingNavigator)).EndInit();
            this.personsBindingNavigator.ResumeLayout(false);
            this.personsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personsDataGridView)).EndInit();
            this.gpBox新增資料.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private mydbDataSet mydbDataSet;
        private System.Windows.Forms.BindingSource personsBindingSource;
        private mydbDataSetTableAdapters.personsTableAdapter personsTableAdapter;
        private mydbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton personsBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator personsBindingNavigator;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView personsDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txt姓名;
        private System.Windows.Forms.TextBox txt地址;
        private System.Windows.Forms.TextBox txt電話;
        private System.Windows.Forms.TextBox txt點數;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dtp生日;
        private System.Windows.Forms.CheckBox chk婚姻狀態;
        private System.Windows.Forms.Button btn第一筆;
        private System.Windows.Forms.Button btn上一筆;
        private System.Windows.Forms.Button btn最後一筆;
        private System.Windows.Forms.Button btn下一筆;
        private System.Windows.Forms.Button btn儲存修改;
        private System.Windows.Forms.Button btn刪除;
        private System.Windows.Forms.Button btn回復資料;
        private System.Windows.Forms.GroupBox gpBox新增資料;
        private System.Windows.Forms.Button btn新增資料儲存;
        private System.Windows.Forms.Button btn新增資料新增;
        private System.Windows.Forms.Label lbl第幾筆共幾筆;
    }
}

