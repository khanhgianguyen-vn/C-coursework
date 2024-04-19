namespace Coursework
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.view_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logout_btn = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.database1DataSet1 = new Coursework.Database1DataSet();
            this.database1DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainMenu_lbl = new System.Windows.Forms.Label();
            this.database1DataSet2 = new Coursework.Database1DataSet();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.ascending_btn = new System.Windows.Forms.Button();
            this.descending_btn = new System.Windows.Forms.Button();
            this.search_textbox = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.search_lbl = new System.Windows.Forms.Label();
            this.role_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // view_btn
            // 
            this.view_btn.BackColor = System.Drawing.Color.White;
            this.view_btn.Location = new System.Drawing.Point(76, 0);
            this.view_btn.Name = "view_btn";
            this.view_btn.Size = new System.Drawing.Size(127, 47);
            this.view_btn.TabIndex = 0;
            this.view_btn.Text = "View";
            this.view_btn.UseVisualStyleBackColor = false;
            this.view_btn.Click += new System.EventHandler(this.view_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.White;
            this.add_btn.Location = new System.Drawing.Point(200, 0);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(127, 47);
            this.add_btn.TabIndex = 1;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.White;
            this.delete_btn.Location = new System.Drawing.Point(844, 331);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(209, 47);
            this.delete_btn.TabIndex = 3;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Visible = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1106, 47);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.White;
            this.logout_btn.Location = new System.Drawing.Point(979, 0);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(127, 47);
            this.logout_btn.TabIndex = 6;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.White;
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(70, 47);
            this.Logo.TabIndex = 7;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database1DataSet1BindingSource
            // 
            this.database1DataSet1BindingSource.DataSource = this.database1DataSet1;
            this.database1DataSet1BindingSource.Position = 0;
            // 
            // mainMenu_lbl
            // 
            this.mainMenu_lbl.BackColor = System.Drawing.Color.Transparent;
            this.mainMenu_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenu_lbl.ForeColor = System.Drawing.Color.White;
            this.mainMenu_lbl.Location = new System.Drawing.Point(281, 186);
            this.mainMenu_lbl.Name = "mainMenu_lbl";
            this.mainMenu_lbl.Size = new System.Drawing.Size(663, 294);
            this.mainMenu_lbl.TabIndex = 0;
            this.mainMenu_lbl.Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.";
            // 
            // database1DataSet2
            // 
            this.database1DataSet2.DataSetName = "Database1DataSet";
            this.database1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(0, 44);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(793, 580);
            this.dataGridView.TabIndex = 8;
            this.dataGridView.Visible = false;
            // 
            // roleComboBox
            // 
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Location = new System.Drawing.Point(844, 231);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(209, 21);
            this.roleComboBox.TabIndex = 9;
            this.roleComboBox.Visible = false;
            this.roleComboBox.SelectedIndexChanged += new System.EventHandler(this.roleComboBox_SelectedIndexChanged);
            // 
            // ascending_btn
            // 
            this.ascending_btn.BackColor = System.Drawing.Color.White;
            this.ascending_btn.Location = new System.Drawing.Point(844, 258);
            this.ascending_btn.Name = "ascending_btn";
            this.ascending_btn.Size = new System.Drawing.Size(100, 47);
            this.ascending_btn.TabIndex = 10;
            this.ascending_btn.Text = "Ascending";
            this.ascending_btn.UseVisualStyleBackColor = false;
            this.ascending_btn.Visible = false;
            this.ascending_btn.Click += new System.EventHandler(this.ascending_btn_Click);
            // 
            // descending_btn
            // 
            this.descending_btn.BackColor = System.Drawing.Color.White;
            this.descending_btn.Location = new System.Drawing.Point(950, 258);
            this.descending_btn.Name = "descending_btn";
            this.descending_btn.Size = new System.Drawing.Size(103, 47);
            this.descending_btn.TabIndex = 11;
            this.descending_btn.Text = "Descending";
            this.descending_btn.UseVisualStyleBackColor = false;
            this.descending_btn.Visible = false;
            this.descending_btn.Click += new System.EventHandler(this.descending_btn_Click);
            // 
            // search_textbox
            // 
            this.search_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_textbox.Location = new System.Drawing.Point(844, 99);
            this.search_textbox.Name = "search_textbox";
            this.search_textbox.Size = new System.Drawing.Size(209, 21);
            this.search_textbox.TabIndex = 13;
            this.search_textbox.Visible = false;
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.White;
            this.search_btn.Location = new System.Drawing.Point(844, 136);
            this.search_btn.Name = "search_btn";
            this.search_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.search_btn.Size = new System.Drawing.Size(209, 30);
            this.search_btn.TabIndex = 14;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Visible = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // search_lbl
            // 
            this.search_lbl.AutoSize = true;
            this.search_lbl.BackColor = System.Drawing.Color.Transparent;
            this.search_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_lbl.ForeColor = System.Drawing.Color.White;
            this.search_lbl.Location = new System.Drawing.Point(841, 78);
            this.search_lbl.Name = "search_lbl";
            this.search_lbl.Size = new System.Drawing.Size(59, 18);
            this.search_lbl.TabIndex = 15;
            this.search_lbl.Text = "Search:";
            this.search_lbl.Visible = false;
            // 
            // role_lbl
            // 
            this.role_lbl.AutoSize = true;
            this.role_lbl.BackColor = System.Drawing.Color.Transparent;
            this.role_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.role_lbl.ForeColor = System.Drawing.Color.White;
            this.role_lbl.Location = new System.Drawing.Point(841, 210);
            this.role_lbl.Name = "role_lbl";
            this.role_lbl.Size = new System.Drawing.Size(43, 18);
            this.role_lbl.TabIndex = 16;
            this.role_lbl.Text = "Role:";
            this.role_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.role_lbl.Visible = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1106, 624);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.role_lbl);
            this.Controls.Add(this.search_lbl);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.search_textbox);
            this.Controls.Add(this.descending_btn);
            this.Controls.Add(this.ascending_btn);
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.mainMenu_lbl);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.view_btn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desktop Information System";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button view_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.PictureBox Logo;
        private Database1DataSet database1DataSet1;
        private System.Windows.Forms.BindingSource database1DataSet1BindingSource;
        private System.Windows.Forms.Label mainMenu_lbl;
        private Database1DataSet database1DataSet2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.Button ascending_btn;
        private System.Windows.Forms.Button descending_btn;
        private System.Windows.Forms.TextBox search_textbox;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Label search_lbl;
        private System.Windows.Forms.Label role_lbl;
    }
}