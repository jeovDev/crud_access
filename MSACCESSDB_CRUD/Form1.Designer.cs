namespace MSACCESSDB_CRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txfname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txlname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtdob = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnnew = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnedit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btndel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btncancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnsave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label9 = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(41)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-19, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 54);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(0, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(622, 23);
            this.panel3.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(210, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "&Create , &Retrieve, &Update and &Delete";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(159, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "MICORSOFT ACCESS DATABASE";
            // 
            // txfname
            // 
            this.txfname.Location = new System.Drawing.Point(95, 130);
            this.txfname.Name = "txfname";
            this.txfname.Size = new System.Drawing.Size(185, 20);
            this.txfname.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Firstname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lastname";
            // 
            // txlname
            // 
            this.txlname.Location = new System.Drawing.Point(95, 156);
            this.txlname.Name = "txlname";
            this.txlname.Size = new System.Drawing.Size(185, 20);
            this.txlname.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Gender";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(103, 182);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 6;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(186, 182);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 7;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(95, 207);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(185, 21);
            this.cmbStatus.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Status";
            // 
            // dtdob
            // 
            this.dtdob.Location = new System.Drawing.Point(95, 232);
            this.dtdob.Name = "dtdob";
            this.dtdob.Size = new System.Drawing.Size(185, 20);
            this.dtdob.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Date of Birth";
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(320, 104);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listView1.RightToLeftLayout = true;
            this.listView1.Size = new System.Drawing.Size(262, 327);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Lastname";
            this.columnHeader2.Width = 113;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Firstname";
            this.columnHeader3.Width = 137;
            // 
            // btnnew
            // 
            this.btnnew.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(41)))), ((int)(((byte)(95)))));
            this.btnnew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(41)))), ((int)(((byte)(95)))));
            this.btnnew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnnew.BorderRadius = 0;
            this.btnnew.ButtonText = "  New";
            this.btnnew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnew.DisabledColor = System.Drawing.Color.Gray;
            this.btnnew.Iconcolor = System.Drawing.Color.Transparent;
            this.btnnew.Iconimage = null;
            this.btnnew.Iconimage_right = null;
            this.btnnew.Iconimage_right_Selected = null;
            this.btnnew.Iconimage_Selected = null;
            this.btnnew.IconMarginLeft = 0;
            this.btnnew.IconMarginRight = 0;
            this.btnnew.IconRightVisible = true;
            this.btnnew.IconRightZoom = 0D;
            this.btnnew.IconVisible = true;
            this.btnnew.IconZoom = 90D;
            this.btnnew.IsTab = false;
            this.btnnew.Location = new System.Drawing.Point(22, 270);
            this.btnnew.Name = "btnnew";
            this.btnnew.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(41)))), ((int)(((byte)(95)))));
            this.btnnew.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(41)))), ((int)(((byte)(95)))));
            this.btnnew.OnHoverTextColor = System.Drawing.Color.White;
            this.btnnew.selected = false;
            this.btnnew.Size = new System.Drawing.Size(292, 32);
            this.btnnew.TabIndex = 14;
            this.btnnew.Text = "  New";
            this.btnnew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnew.Textcolor = System.Drawing.Color.White;
            this.btnnew.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnedit
            // 
            this.btnedit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(41)))), ((int)(((byte)(95)))));
            this.btnedit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(41)))), ((int)(((byte)(95)))));
            this.btnedit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnedit.BorderRadius = 0;
            this.btnedit.ButtonText = "  Edit";
            this.btnedit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnedit.DisabledColor = System.Drawing.Color.Gray;
            this.btnedit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnedit.Iconimage = null;
            this.btnedit.Iconimage_right = null;
            this.btnedit.Iconimage_right_Selected = null;
            this.btnedit.Iconimage_Selected = null;
            this.btnedit.IconMarginLeft = 0;
            this.btnedit.IconMarginRight = 0;
            this.btnedit.IconRightVisible = true;
            this.btnedit.IconRightZoom = 0D;
            this.btnedit.IconVisible = true;
            this.btnedit.IconZoom = 90D;
            this.btnedit.IsTab = false;
            this.btnedit.Location = new System.Drawing.Point(22, 302);
            this.btnedit.Name = "btnedit";
            this.btnedit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(41)))), ((int)(((byte)(95)))));
            this.btnedit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(41)))), ((int)(((byte)(95)))));
            this.btnedit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnedit.selected = false;
            this.btnedit.Size = new System.Drawing.Size(292, 32);
            this.btnedit.TabIndex = 15;
            this.btnedit.Text = "  Edit";
            this.btnedit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnedit.Textcolor = System.Drawing.Color.White;
            this.btnedit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndel
            // 
            this.btndel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(41)))), ((int)(((byte)(95)))));
            this.btndel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(41)))), ((int)(((byte)(95)))));
            this.btndel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndel.BorderRadius = 0;
            this.btndel.ButtonText = "  Delete";
            this.btndel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndel.DisabledColor = System.Drawing.Color.Gray;
            this.btndel.Iconcolor = System.Drawing.Color.Transparent;
            this.btndel.Iconimage = null;
            this.btndel.Iconimage_right = null;
            this.btndel.Iconimage_right_Selected = null;
            this.btndel.Iconimage_Selected = null;
            this.btndel.IconMarginLeft = 0;
            this.btndel.IconMarginRight = 0;
            this.btndel.IconRightVisible = true;
            this.btndel.IconRightZoom = 0D;
            this.btndel.IconVisible = true;
            this.btndel.IconZoom = 90D;
            this.btndel.IsTab = false;
            this.btndel.Location = new System.Drawing.Point(22, 366);
            this.btndel.Name = "btndel";
            this.btndel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(41)))), ((int)(((byte)(95)))));
            this.btndel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(41)))), ((int)(((byte)(95)))));
            this.btndel.OnHoverTextColor = System.Drawing.Color.White;
            this.btndel.selected = false;
            this.btndel.Size = new System.Drawing.Size(292, 32);
            this.btndel.TabIndex = 16;
            this.btndel.Text = "  Delete";
            this.btndel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndel.Textcolor = System.Drawing.Color.White;
            this.btndel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btncancel
            // 
            this.btncancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(41)))), ((int)(((byte)(95)))));
            this.btncancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(41)))), ((int)(((byte)(95)))));
            this.btncancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancel.BorderRadius = 0;
            this.btncancel.ButtonText = "  Cancel";
            this.btncancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancel.DisabledColor = System.Drawing.Color.Gray;
            this.btncancel.Iconcolor = System.Drawing.Color.Transparent;
            this.btncancel.Iconimage = null;
            this.btncancel.Iconimage_right = null;
            this.btncancel.Iconimage_right_Selected = null;
            this.btncancel.Iconimage_Selected = null;
            this.btncancel.IconMarginLeft = 0;
            this.btncancel.IconMarginRight = 0;
            this.btncancel.IconRightVisible = true;
            this.btncancel.IconRightZoom = 0D;
            this.btncancel.IconVisible = true;
            this.btncancel.IconZoom = 90D;
            this.btncancel.IsTab = false;
            this.btncancel.Location = new System.Drawing.Point(22, 398);
            this.btncancel.Name = "btncancel";
            this.btncancel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(41)))), ((int)(((byte)(95)))));
            this.btncancel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(41)))), ((int)(((byte)(95)))));
            this.btncancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btncancel.selected = false;
            this.btncancel.Size = new System.Drawing.Size(292, 32);
            this.btncancel.TabIndex = 17;
            this.btncancel.Text = "  Cancel";
            this.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancel.Textcolor = System.Drawing.Color.White;
            this.btncancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // txSearch
            // 
            this.txSearch.Location = new System.Drawing.Point(371, 78);
            this.txSearch.Name = "txSearch";
            this.txSearch.Size = new System.Drawing.Size(211, 20);
            this.txSearch.TabIndex = 18;
            this.txSearch.TextChanged += new System.EventHandler(this.txSearch_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(324, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Search";
            // 
            // btnsave
            // 
            this.btnsave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(41)))), ((int)(((byte)(95)))));
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(41)))), ((int)(((byte)(95)))));
            this.btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsave.BorderRadius = 0;
            this.btnsave.ButtonText = "  Save";
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.DisabledColor = System.Drawing.Color.Gray;
            this.btnsave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnsave.Iconimage = null;
            this.btnsave.Iconimage_right = null;
            this.btnsave.Iconimage_right_Selected = null;
            this.btnsave.Iconimage_Selected = null;
            this.btnsave.IconMarginLeft = 0;
            this.btnsave.IconMarginRight = 0;
            this.btnsave.IconRightVisible = true;
            this.btnsave.IconRightZoom = 0D;
            this.btnsave.IconVisible = true;
            this.btnsave.IconZoom = 90D;
            this.btnsave.IsTab = false;
            this.btnsave.Location = new System.Drawing.Point(22, 334);
            this.btnsave.Name = "btnsave";
            this.btnsave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(41)))), ((int)(((byte)(95)))));
            this.btnsave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(41)))), ((int)(((byte)(95)))));
            this.btnsave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnsave.selected = false;
            this.btnsave.Size = new System.Drawing.Size(292, 32);
            this.btnsave.TabIndex = 23;
            this.btnsave.Text = "  Save";
            this.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave.Textcolor = System.Drawing.Color.White;
            this.btnsave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "ID";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(92, 110);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(0, 13);
            this.lbID.TabIndex = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(102, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // close
            // 
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(582, 2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(27, 24);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 27;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(594, 443);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txSearch);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtdob);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txlname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txfname);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txfname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txlname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtdob;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton btnnew;
        private Bunifu.Framework.UI.BunifuFlatButton btnedit;
        private Bunifu.Framework.UI.BunifuFlatButton btndel;
        private Bunifu.Framework.UI.BunifuFlatButton btncancel;
        private System.Windows.Forms.TextBox txSearch;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuFlatButton btnsave;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox close;
    }
}

