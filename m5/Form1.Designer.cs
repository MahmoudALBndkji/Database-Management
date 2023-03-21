
namespace m5
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.my_db1DataSet = new m5.my_db1DataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addreasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imgDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.extinfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mydb1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.search = new System.Windows.Forms.Label();
            this.table1TableAdapter = new m5.my_db1DataSetTableAdapters.Table1TableAdapter();
            this.btn_Count_Student = new System.Windows.Forms.Button();
            this.btn_Select = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Count_Line = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.txt_Edit_ID = new System.Windows.Forms.TextBox();
            this.btn_Select_Edit = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.saToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.formatingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phone = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.addres = new System.Windows.Forms.Label();
            this.last_name = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.brw = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.newline = new System.Windows.Forms.Button();
            this.edite = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_db1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydb1DataSetBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table1BindingSource, "ext_info", true));
            this.richTextBox1.Location = new System.Drawing.Point(16, -194);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(222, 123);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "";
            // 
            // table1BindingSource
            // 
            this.table1BindingSource.DataMember = "Table1";
            this.table1BindingSource.DataSource = this.my_db1DataSet;
            // 
            // my_db1DataSet
            // 
            this.my_db1DataSet.DataSetName = "my_db1DataSet";
            this.my_db1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn,
            this.addreasDataGridViewTextBoxColumn,
            this.imgDataGridViewImageColumn,
            this.extinfoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.table1BindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(631, 64);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(702, 618);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "fname";
            this.fnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            this.fnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "lname";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "lname";
            this.lnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            this.lnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            this.phonenumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // addreasDataGridViewTextBoxColumn
            // 
            this.addreasDataGridViewTextBoxColumn.DataPropertyName = "addreas";
            this.addreasDataGridViewTextBoxColumn.HeaderText = "addreas";
            this.addreasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addreasDataGridViewTextBoxColumn.Name = "addreasDataGridViewTextBoxColumn";
            this.addreasDataGridViewTextBoxColumn.Width = 125;
            // 
            // imgDataGridViewImageColumn
            // 
            this.imgDataGridViewImageColumn.DataPropertyName = "img";
            this.imgDataGridViewImageColumn.HeaderText = "img";
            this.imgDataGridViewImageColumn.MinimumWidth = 6;
            this.imgDataGridViewImageColumn.Name = "imgDataGridViewImageColumn";
            this.imgDataGridViewImageColumn.Visible = false;
            this.imgDataGridViewImageColumn.Width = 125;
            // 
            // extinfoDataGridViewTextBoxColumn
            // 
            this.extinfoDataGridViewTextBoxColumn.DataPropertyName = "ext_info";
            this.extinfoDataGridViewTextBoxColumn.HeaderText = "ext_info";
            this.extinfoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.extinfoDataGridViewTextBoxColumn.Name = "extinfoDataGridViewTextBoxColumn";
            this.extinfoDataGridViewTextBoxColumn.Width = 125;
            // 
            // table1BindingSource1
            // 
            this.table1BindingSource1.DataMember = "Table1";
            this.table1BindingSource1.DataSource = this.mydb1DataSetBindingSource;
            // 
            // mydb1DataSetBindingSource
            // 
            this.mydb1DataSetBindingSource.DataSource = this.my_db1DataSet;
            this.mydb1DataSetBindingSource.Position = 0;
            // 
            // search
            // 
            this.search.AutoSize = true;
            this.search.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.search.Location = new System.Drawing.Point(628, 39);
            this.search.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(48, 17);
            this.search.TabIndex = 16;
            this.search.Text = "search";
            // 
            // table1TableAdapter
            // 
            this.table1TableAdapter.ClearBeforeFill = true;
            // 
            // btn_Count_Student
            // 
            this.btn_Count_Student.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Count_Student.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Count_Student.Location = new System.Drawing.Point(10, 213);
            this.btn_Count_Student.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Count_Student.Name = "btn_Count_Student";
            this.btn_Count_Student.Size = new System.Drawing.Size(120, 39);
            this.btn_Count_Student.TabIndex = 19;
            this.btn_Count_Student.Text = "Count_Student";
            this.btn_Count_Student.UseVisualStyleBackColor = true;
            this.btn_Count_Student.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Select
            // 
            this.btn_Select.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Select.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Select.Location = new System.Drawing.Point(137, 150);
            this.btn_Select.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(118, 37);
            this.btn_Select.TabIndex = 18;
            this.btn_Select.Text = "Select TextFile";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_SaveAs_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Save.Location = new System.Drawing.Point(10, 34);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(108, 37);
            this.btn_Save.TabIndex = 17;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Count_Line
            // 
            this.btn_Count_Line.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Count_Line.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Count_Line.Location = new System.Drawing.Point(22, 271);
            this.btn_Count_Line.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Count_Line.Name = "btn_Count_Line";
            this.btn_Count_Line.Size = new System.Drawing.Size(108, 39);
            this.btn_Count_Line.TabIndex = 20;
            this.btn_Count_Line.Text = "Count_Line";
            this.btn_Count_Line.UseVisualStyleBackColor = true;
            this.btn_Count_Line.Click += new System.EventHandler(this.btn_Count_Line_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Delete.Location = new System.Drawing.Point(130, 271);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(120, 39);
            this.btn_Delete.TabIndex = 21;
            this.btn_Delete.Text = "Delete File";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Create.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Create.Location = new System.Drawing.Point(134, 213);
            this.btn_Create.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(108, 39);
            this.btn_Create.TabIndex = 22;
            this.btn_Create.Text = "Create File";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Edit.Location = new System.Drawing.Point(10, 89);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(118, 38);
            this.btn_Edit.TabIndex = 18;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // txt_Edit_ID
            // 
            this.txt_Edit_ID.Location = new System.Drawing.Point(130, 97);
            this.txt_Edit_ID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Edit_ID.Name = "txt_Edit_ID";
            this.txt_Edit_ID.Size = new System.Drawing.Size(116, 24);
            this.txt_Edit_ID.TabIndex = 23;
            // 
            // btn_Select_Edit
            // 
            this.btn_Select_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Select_Edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Select_Edit.Location = new System.Drawing.Point(10, 150);
            this.btn_Select_Edit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Select_Edit.Name = "btn_Select_Edit";
            this.btn_Select_Edit.Size = new System.Drawing.Size(118, 37);
            this.btn_Select_Edit.TabIndex = 24;
            this.btn_Select_Edit.Text = "Select Edit File";
            this.btn_Select_Edit.UseVisualStyleBackColor = true;
            this.btn_Select_Edit.Click += new System.EventHandler(this.btn_Select_Edit_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(680, 36);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(653, 24);
            this.textBox6.TabIndex = 14;
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Save);
            this.panel1.Controls.Add(this.btn_Count_Line);
            this.panel1.Controls.Add(this.btn_Create);
            this.panel1.Controls.Add(this.txt_Edit_ID);
            this.panel1.Controls.Add(this.btn_Delete);
            this.panel1.Controls.Add(this.btn_Select_Edit);
            this.panel1.Controls.Add(this.btn_Edit);
            this.panel1.Controls.Add(this.btn_Count_Student);
            this.panel1.Controls.Add(this.btn_Select);
            this.panel1.Location = new System.Drawing.Point(365, 287);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 327);
            this.panel1.TabIndex = 18;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1344, 28);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripMenuItem2,
            this.saToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem3,
            this.printToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(221, 26);
            this.toolStripMenuItem2.Text = "..................................";
            // 
            // saToolStripMenuItem
            // 
            this.saToolStripMenuItem.Name = "saToolStripMenuItem";
            this.saToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.saToolStripMenuItem.Text = "Save";
            this.saToolStripMenuItem.Click += new System.EventHandler(this.saToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(221, 26);
            this.toolStripMenuItem3.Text = "..................................";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripMenuItem4,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripMenuItem5,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(200, 26);
            this.toolStripMenuItem4.Text = "....................................";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(200, 26);
            this.toolStripMenuItem5.Text = "....................................";
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem1,
            this.formatingToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // mainToolStripMenuItem1
            // 
            this.mainToolStripMenuItem1.Name = "mainToolStripMenuItem1";
            this.mainToolStripMenuItem1.Size = new System.Drawing.Size(160, 26);
            this.mainToolStripMenuItem1.Text = "Main";
            this.mainToolStripMenuItem1.Click += new System.EventHandler(this.mainToolStripMenuItem1_Click);
            // 
            // formatingToolStripMenuItem
            // 
            this.formatingToolStripMenuItem.Name = "formatingToolStripMenuItem";
            this.formatingToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.formatingToolStripMenuItem.Text = "Formating";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.phone.Location = new System.Drawing.Point(3, 294);
            this.phone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(47, 17);
            this.phone.TabIndex = 8;
            this.phone.Text = "phone";
            this.phone.Click += new System.EventHandler(this.label3_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.name.Location = new System.Drawing.Point(7, 226);
            this.name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(42, 17);
            this.name.TabIndex = 0;
            this.name.Text = "name";
            // 
            // addres
            // 
            this.addres.AutoSize = true;
            this.addres.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addres.Location = new System.Drawing.Point(0, 333);
            this.addres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addres.Name = "addres";
            this.addres.Size = new System.Drawing.Size(49, 17);
            this.addres.TabIndex = 9;
            this.addres.Text = "addres";
            // 
            // last_name
            // 
            this.last_name.AutoSize = true;
            this.last_name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.last_name.Location = new System.Drawing.Point(2, 258);
            this.last_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(70, 17);
            this.last_name.TabIndex = 7;
            this.last_name.Text = "last_name";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.info.Location = new System.Drawing.Point(0, 373);
            this.info.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(66, 17);
            this.info.TabIndex = 10;
            this.info.Text = "extra info";
            // 
            // brw
            // 
            this.brw.Location = new System.Drawing.Point(6, 91);
            this.brw.Margin = new System.Windows.Forms.Padding(2);
            this.brw.Name = "brw";
            this.brw.Size = new System.Drawing.Size(90, 27);
            this.brw.TabIndex = 1;
            this.brw.Text = "select img";
            this.brw.UseVisualStyleBackColor = true;
            this.brw.Click += new System.EventHandler(this.brw_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.table1BindingSource, "img", true));
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(150, 21);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(128, 177);
            this.pictureBox.TabIndex = 12;
            this.pictureBox.TabStop = false;
            // 
            // newline
            // 
            this.newline.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.newline.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newline.Location = new System.Drawing.Point(201, 515);
            this.newline.Margin = new System.Windows.Forms.Padding(2);
            this.newline.Name = "newline";
            this.newline.Size = new System.Drawing.Size(100, 39);
            this.newline.TabIndex = 5;
            this.newline.Text = "new";
            this.newline.UseVisualStyleBackColor = true;
            this.newline.Click += new System.EventHandler(this.newline_Click);
            // 
            // edite
            // 
            this.edite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.edite.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.edite.Location = new System.Drawing.Point(115, 515);
            this.edite.Margin = new System.Windows.Forms.Padding(2);
            this.edite.Name = "edite";
            this.edite.Size = new System.Drawing.Size(82, 39);
            this.edite.TabIndex = 4;
            this.edite.Text = "edite";
            this.edite.UseVisualStyleBackColor = true;
            this.edite.Click += new System.EventHandler(this.edite_Click);
            // 
            // save
            // 
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.save.Location = new System.Drawing.Point(14, 515);
            this.save.Margin = new System.Windows.Forms.Padding(2);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(101, 39);
            this.save.TabIndex = 2;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table1BindingSource, "fname", true));
            this.textBox1.Location = new System.Drawing.Point(72, 219);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 24);
            this.textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.my_db1DataSet, "Table1.lname", true));
            this.textBox2.Location = new System.Drawing.Point(72, 255);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(222, 24);
            this.textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table1BindingSource, "phone_number", true));
            this.textBox3.Location = new System.Drawing.Point(72, 291);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(222, 24);
            this.textBox3.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table1BindingSource, "addreas", true));
            this.textBox4.Location = new System.Drawing.Point(72, 330);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(222, 24);
            this.textBox4.TabIndex = 16;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel.Controls.Add(this.textBox4);
            this.panel.Controls.Add(this.textBox3);
            this.panel.Controls.Add(this.textBox2);
            this.panel.Controls.Add(this.textBox1);
            this.panel.Controls.Add(this.save);
            this.panel.Controls.Add(this.edite);
            this.panel.Controls.Add(this.newline);
            this.panel.Controls.Add(this.pictureBox);
            this.panel.Controls.Add(this.brw);
            this.panel.Controls.Add(this.info);
            this.panel.Controls.Add(this.last_name);
            this.panel.Controls.Add(this.addres);
            this.panel.Controls.Add(this.name);
            this.panel.Controls.Add(this.phone);
            this.panel.Location = new System.Drawing.Point(57, 43);
            this.panel.Margin = new System.Windows.Forms.Padding(2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(303, 571);
            this.panel.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(87, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Save to file";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::m5.Properties.Resources.photo1;
            this.ClientSize = new System.Drawing.Size(1344, 717);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "my editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_db1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydb1DataSetBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private my_db1DataSet my_db1DataSet;
        private System.Windows.Forms.BindingSource table1BindingSource;
        private my_db1DataSetTableAdapters.Table1TableAdapter table1TableAdapter;
        private System.Windows.Forms.BindingSource table1BindingSource1;
        private System.Windows.Forms.BindingSource mydb1DataSetBindingSource;
        private System.Windows.Forms.Label search;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addreasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imgDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extinfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Count_Student;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Count_Line;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.TextBox txt_Edit_ID;
        private System.Windows.Forms.Button btn_Select_Edit;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem saToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem formatingToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label addres;
        private System.Windows.Forms.Label last_name;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Button brw;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button newline;
        private System.Windows.Forms.Button edite;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel panel;
    }
}

