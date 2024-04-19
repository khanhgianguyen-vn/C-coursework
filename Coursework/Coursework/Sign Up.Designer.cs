namespace Coursework
{
    partial class SignUp
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label telephoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label passwordLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.teacherSubjectsLabel = new System.Windows.Forms.Label();
            this.database1DataSet = new Coursework.Database1DataSet();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PersonTableAdapter = new Coursework.Database1DataSetTableAdapters.PersonTableAdapter();
            this.tableAdapterManager = new Coursework.Database1DataSetTableAdapters.TableAdapterManager();
            this.personBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.personBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.role_lbl = new System.Windows.Forms.Label();
            this.next_btn = new System.Windows.Forms.Button();
            this.confirmPassword_lbl = new System.Windows.Forms.Label();
            this.administrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.administrationTableAdapter = new Coursework.Database1DataSetTableAdapters.AdministrationTableAdapter();
            this.adminSalaryLabel = new System.Windows.Forms.Label();
            this.teachingStaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminFullTimeLabel = new System.Windows.Forms.Label();
            this.fullTimeAdminCheckBox = new System.Windows.Forms.CheckBox();
            this.adminWorkingHoursLabel = new System.Windows.Forms.Label();
            this.teachingStaffTableAdapter = new Coursework.Database1DataSetTableAdapters.TeachingStaffTableAdapter();
            this.teacherSalaryLabel = new System.Windows.Forms.Label();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new Coursework.Database1DataSetTableAdapters.StudentTableAdapter();
            this.currentSubjectsLabel = new System.Windows.Forms.Label();
            this.previousSubjectsLabel = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.salary_adminTextBox = new System.Windows.Forms.TextBox();
            this.teacherSalaryTextBox = new System.Windows.Forms.TextBox();
            this.teacherSubjectsTextBox = new System.Windows.Forms.TextBox();
            this.workingHoursAdminTextBox = new System.Windows.Forms.TextBox();
            this.currentSubjectsTextBox = new System.Windows.Forms.TextBox();
            this.previousSubjectsTextBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.PictureBox();
            nameLabel = new System.Windows.Forms.Label();
            telephoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingNavigator)).BeginInit();
            this.personBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.administrationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachingStaffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = System.Drawing.Color.Transparent;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.ForeColor = System.Drawing.Color.Transparent;
            nameLabel.Location = new System.Drawing.Point(180, 148);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(55, 20);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name:";
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.BackColor = System.Drawing.Color.Transparent;
            telephoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telephoneLabel.ForeColor = System.Drawing.Color.Transparent;
            telephoneLabel.Location = new System.Drawing.Point(147, 186);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(88, 20);
            telephoneLabel.TabIndex = 3;
            telephoneLabel.Text = "Telephone:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = System.Drawing.Color.Transparent;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.ForeColor = System.Drawing.Color.White;
            emailLabel.Location = new System.Drawing.Point(187, 216);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(52, 20);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "Email:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = System.Drawing.Color.Transparent;
            passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            passwordLabel.ForeColor = System.Drawing.Color.White;
            passwordLabel.Location = new System.Drawing.Point(157, 251);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(82, 20);
            passwordLabel.TabIndex = 7;
            passwordLabel.Text = "Password:";
            // 
            // teacherSubjectsLabel
            // 
            this.teacherSubjectsLabel.AutoSize = true;
            this.teacherSubjectsLabel.BackColor = System.Drawing.Color.Transparent;
            this.teacherSubjectsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherSubjectsLabel.ForeColor = System.Drawing.Color.Transparent;
            this.teacherSubjectsLabel.Location = new System.Drawing.Point(552, 188);
            this.teacherSubjectsLabel.Name = "teacherSubjectsLabel";
            this.teacherSubjectsLabel.Size = new System.Drawing.Size(75, 20);
            this.teacherSubjectsLabel.TabIndex = 22;
            this.teacherSubjectsLabel.Text = "Subjects:";
            this.teacherSubjectsLabel.Visible = false;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataMember = "Person";
            this.personBindingSource.DataSource = this.database1DataSet;
            // 
            // PersonTableAdapter
            // 
            this.PersonTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdministrationTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PersonTableAdapter = this.PersonTableAdapter;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.TeachingStaffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Coursework.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // personBindingNavigator
            // 
            this.personBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.personBindingNavigator.BindingSource = this.personBindingSource;
            this.personBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.personBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.personBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.personBindingNavigatorSaveItem});
            this.personBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.personBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.personBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.personBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.personBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.personBindingNavigator.Name = "personBindingNavigator";
            this.personBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.personBindingNavigator.Size = new System.Drawing.Size(845, 25);
            this.personBindingNavigator.TabIndex = 0;
            this.personBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
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
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // personBindingNavigatorSaveItem
            // 
            this.personBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.personBindingNavigatorSaveItem.Name = "personBindingNavigatorSaveItem";
            this.personBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.personBindingNavigatorSaveItem.Text = "Save Data";
            this.personBindingNavigatorSaveItem.Click += new System.EventHandler(this.PersonBindingNavigatorSaveItem_Click);
            // 
            // roleComboBox
            // 
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Items.AddRange(new object[] {
            "Administrator",
            "Teacher",
            "Student"});
            this.roleComboBox.Location = new System.Drawing.Point(241, 326);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(238, 21);
            this.roleComboBox.TabIndex = 9;
            this.roleComboBox.SelectedIndexChanged += new System.EventHandler(this.roleComboBox_SelectedIndexChanged);
            // 
            // role_lbl
            // 
            this.role_lbl.AutoSize = true;
            this.role_lbl.BackColor = System.Drawing.Color.Transparent;
            this.role_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.role_lbl.ForeColor = System.Drawing.Color.White;
            this.role_lbl.Location = new System.Drawing.Point(193, 326);
            this.role_lbl.Name = "role_lbl";
            this.role_lbl.Size = new System.Drawing.Size(46, 20);
            this.role_lbl.TabIndex = 10;
            this.role_lbl.Text = "Role:";
            // 
            // next_btn
            // 
            this.next_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.next_btn.Location = new System.Drawing.Point(342, 369);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(238, 23);
            this.next_btn.TabIndex = 11;
            this.next_btn.Text = "Confirm";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // confirmPassword_lbl
            // 
            this.confirmPassword_lbl.AutoSize = true;
            this.confirmPassword_lbl.BackColor = System.Drawing.Color.Transparent;
            this.confirmPassword_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassword_lbl.ForeColor = System.Drawing.Color.White;
            this.confirmPassword_lbl.Location = new System.Drawing.Point(98, 288);
            this.confirmPassword_lbl.Name = "confirmPassword_lbl";
            this.confirmPassword_lbl.Size = new System.Drawing.Size(141, 20);
            this.confirmPassword_lbl.TabIndex = 13;
            this.confirmPassword_lbl.Text = "Confirm Password:";
            // 
            // administrationBindingSource
            // 
            this.administrationBindingSource.DataMember = "Administration";
            this.administrationBindingSource.DataSource = this.database1DataSet;
            // 
            // administrationTableAdapter
            // 
            this.administrationTableAdapter.ClearBeforeFill = true;
            // 
            // adminSalaryLabel
            // 
            this.adminSalaryLabel.AutoSize = true;
            this.adminSalaryLabel.BackColor = System.Drawing.Color.Transparent;
            this.adminSalaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminSalaryLabel.ForeColor = System.Drawing.Color.White;
            this.adminSalaryLabel.Location = new System.Drawing.Point(563, 150);
            this.adminSalaryLabel.Name = "adminSalaryLabel";
            this.adminSalaryLabel.Size = new System.Drawing.Size(57, 20);
            this.adminSalaryLabel.TabIndex = 14;
            this.adminSalaryLabel.Text = "Salary:";
            this.adminSalaryLabel.Visible = false;
            // 
            // teachingStaffBindingSource
            // 
            this.teachingStaffBindingSource.DataMember = "TeachingStaff";
            this.teachingStaffBindingSource.DataSource = this.database1DataSet;
            // 
            // adminFullTimeLabel
            // 
            this.adminFullTimeLabel.AutoSize = true;
            this.adminFullTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.adminFullTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminFullTimeLabel.ForeColor = System.Drawing.Color.White;
            this.adminFullTimeLabel.Location = new System.Drawing.Point(545, 186);
            this.adminFullTimeLabel.Name = "adminFullTimeLabel";
            this.adminFullTimeLabel.Size = new System.Drawing.Size(76, 20);
            this.adminFullTimeLabel.TabIndex = 16;
            this.adminFullTimeLabel.Text = "Full Time:";
            this.adminFullTimeLabel.Visible = false;
            // 
            // fullTimeAdminCheckBox
            // 
            this.fullTimeAdminCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.fullTimeAdminCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullTimeAdminCheckBox.Location = new System.Drawing.Point(633, 184);
            this.fullTimeAdminCheckBox.Name = "fullTimeAdminCheckBox";
            this.fullTimeAdminCheckBox.Size = new System.Drawing.Size(104, 24);
            this.fullTimeAdminCheckBox.TabIndex = 17;
            this.fullTimeAdminCheckBox.UseVisualStyleBackColor = false;
            this.fullTimeAdminCheckBox.Visible = false;
            // 
            // adminWorkingHoursLabel
            // 
            this.adminWorkingHoursLabel.AutoSize = true;
            this.adminWorkingHoursLabel.BackColor = System.Drawing.Color.Transparent;
            this.adminWorkingHoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminWorkingHoursLabel.ForeColor = System.Drawing.Color.White;
            this.adminWorkingHoursLabel.Location = new System.Drawing.Point(509, 220);
            this.adminWorkingHoursLabel.Name = "adminWorkingHoursLabel";
            this.adminWorkingHoursLabel.Size = new System.Drawing.Size(118, 20);
            this.adminWorkingHoursLabel.TabIndex = 18;
            this.adminWorkingHoursLabel.Text = "Working Hours:";
            this.adminWorkingHoursLabel.Visible = false;
            // 
            // teachingStaffTableAdapter
            // 
            this.teachingStaffTableAdapter.ClearBeforeFill = true;
            // 
            // teacherSalaryLabel
            // 
            this.teacherSalaryLabel.AutoSize = true;
            this.teacherSalaryLabel.BackColor = System.Drawing.Color.Transparent;
            this.teacherSalaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherSalaryLabel.ForeColor = System.Drawing.Color.White;
            this.teacherSalaryLabel.Location = new System.Drawing.Point(563, 151);
            this.teacherSalaryLabel.Name = "teacherSalaryLabel";
            this.teacherSalaryLabel.Size = new System.Drawing.Size(57, 20);
            this.teacherSalaryLabel.TabIndex = 20;
            this.teacherSalaryLabel.Text = "Salary:";
            this.teacherSalaryLabel.Visible = false;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.database1DataSet;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // currentSubjectsLabel
            // 
            this.currentSubjectsLabel.AutoSize = true;
            this.currentSubjectsLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentSubjectsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentSubjectsLabel.ForeColor = System.Drawing.Color.Transparent;
            this.currentSubjectsLabel.Location = new System.Drawing.Point(495, 151);
            this.currentSubjectsLabel.Name = "currentSubjectsLabel";
            this.currentSubjectsLabel.Size = new System.Drawing.Size(132, 20);
            this.currentSubjectsLabel.TabIndex = 25;
            this.currentSubjectsLabel.Text = "Current Subjects:";
            this.currentSubjectsLabel.Visible = false;
            // 
            // previousSubjectsLabel
            // 
            this.previousSubjectsLabel.AutoSize = true;
            this.previousSubjectsLabel.BackColor = System.Drawing.Color.Transparent;
            this.previousSubjectsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousSubjectsLabel.ForeColor = System.Drawing.Color.White;
            this.previousSubjectsLabel.Location = new System.Drawing.Point(495, 186);
            this.previousSubjectsLabel.Name = "previousSubjectsLabel";
            this.previousSubjectsLabel.Size = new System.Drawing.Size(139, 20);
            this.previousSubjectsLabel.TabIndex = 27;
            this.previousSubjectsLabel.Text = "Previous Subjects:";
            this.previousSubjectsLabel.Visible = false;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(375, 28);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(149, 99);
            this.Logo.TabIndex = 28;
            this.Logo.TabStop = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(242, 149);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(237, 20);
            this.nameTextBox.TabIndex = 29;
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.Location = new System.Drawing.Point(242, 185);
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(237, 20);
            this.telephoneTextBox.TabIndex = 30;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(242, 220);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(237, 20);
            this.emailTextBox.TabIndex = 31;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(242, 253);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '●';
            this.passwordTextBox.Size = new System.Drawing.Size(237, 20);
            this.passwordTextBox.TabIndex = 32;
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(242, 290);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.PasswordChar = '●';
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(237, 20);
            this.confirmPasswordTextBox.TabIndex = 33;
            // 
            // salary_adminTextBox
            // 
            this.salary_adminTextBox.Location = new System.Drawing.Point(633, 151);
            this.salary_adminTextBox.Name = "salary_adminTextBox";
            this.salary_adminTextBox.Size = new System.Drawing.Size(104, 20);
            this.salary_adminTextBox.TabIndex = 34;
            this.salary_adminTextBox.Visible = false;
            // 
            // teacherSalaryTextBox
            // 
            this.teacherSalaryTextBox.Location = new System.Drawing.Point(634, 151);
            this.teacherSalaryTextBox.Name = "teacherSalaryTextBox";
            this.teacherSalaryTextBox.Size = new System.Drawing.Size(104, 20);
            this.teacherSalaryTextBox.TabIndex = 35;
            this.teacherSalaryTextBox.Visible = false;
            // 
            // teacherSubjectsTextBox
            // 
            this.teacherSubjectsTextBox.Location = new System.Drawing.Point(633, 187);
            this.teacherSubjectsTextBox.Name = "teacherSubjectsTextBox";
            this.teacherSubjectsTextBox.Size = new System.Drawing.Size(178, 20);
            this.teacherSubjectsTextBox.TabIndex = 36;
            this.teacherSubjectsTextBox.Visible = false;
            // 
            // workingHoursAdminTextBox
            // 
            this.workingHoursAdminTextBox.Location = new System.Drawing.Point(634, 219);
            this.workingHoursAdminTextBox.Name = "workingHoursAdminTextBox";
            this.workingHoursAdminTextBox.Size = new System.Drawing.Size(103, 20);
            this.workingHoursAdminTextBox.TabIndex = 37;
            this.workingHoursAdminTextBox.Visible = false;
            // 
            // currentSubjectsTextBox
            // 
            this.currentSubjectsTextBox.Location = new System.Drawing.Point(633, 151);
            this.currentSubjectsTextBox.Name = "currentSubjectsTextBox";
            this.currentSubjectsTextBox.Size = new System.Drawing.Size(179, 20);
            this.currentSubjectsTextBox.TabIndex = 38;
            this.currentSubjectsTextBox.Visible = false;
            // 
            // previousSubjectsTextBox
            // 
            this.previousSubjectsTextBox.Location = new System.Drawing.Point(633, 186);
            this.previousSubjectsTextBox.Name = "previousSubjectsTextBox";
            this.previousSubjectsTextBox.Size = new System.Drawing.Size(178, 20);
            this.previousSubjectsTextBox.TabIndex = 39;
            this.previousSubjectsTextBox.Visible = false;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton.BackgroundImage")));
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.Location = new System.Drawing.Point(12, 40);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(44, 41);
            this.backButton.TabIndex = 40;
            this.backButton.TabStop = false;
            this.backButton.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(845, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.previousSubjectsTextBox);
            this.Controls.Add(this.currentSubjectsTextBox);
            this.Controls.Add(this.workingHoursAdminTextBox);
            this.Controls.Add(this.teacherSubjectsTextBox);
            this.Controls.Add(this.teacherSalaryTextBox);
            this.Controls.Add(this.salary_adminTextBox);
            this.Controls.Add(this.confirmPasswordTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.telephoneTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.previousSubjectsLabel);
            this.Controls.Add(this.currentSubjectsLabel);
            this.Controls.Add(this.teacherSubjectsLabel);
            this.Controls.Add(this.teacherSalaryLabel);
            this.Controls.Add(this.adminWorkingHoursLabel);
            this.Controls.Add(this.adminFullTimeLabel);
            this.Controls.Add(this.fullTimeAdminCheckBox);
            this.Controls.Add(this.adminSalaryLabel);
            this.Controls.Add(this.confirmPassword_lbl);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.role_lbl);
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(emailLabel);
            this.Controls.Add(telephoneLabel);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.personBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.SignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingNavigator)).EndInit();
            this.personBindingNavigator.ResumeLayout(false);
            this.personBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.administrationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachingStaffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource personBindingSource;
        private Database1DataSetTableAdapters.PersonTableAdapter PersonTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator personBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton personBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.Label role_lbl;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Label confirmPassword_lbl;
        private System.Windows.Forms.BindingSource administrationBindingSource;
        private Database1DataSetTableAdapters.AdministrationTableAdapter administrationTableAdapter;
        private System.Windows.Forms.CheckBox fullTimeAdminCheckBox;
        private System.Windows.Forms.Label adminSalaryLabel;
        private System.Windows.Forms.Label adminFullTimeLabel;
        private System.Windows.Forms.Label adminWorkingHoursLabel;
        private System.Windows.Forms.BindingSource teachingStaffBindingSource;
        private Database1DataSetTableAdapters.TeachingStaffTableAdapter teachingStaffTableAdapter;
        private System.Windows.Forms.Label teacherSalaryLabel;
        private System.Windows.Forms.Label teacherSubjectsLabel;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private Database1DataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.Label currentSubjectsLabel;
        private System.Windows.Forms.Label previousSubjectsLabel;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox telephoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.TextBox salary_adminTextBox;
        private System.Windows.Forms.TextBox teacherSalaryTextBox;
        private System.Windows.Forms.TextBox teacherSubjectsTextBox;
        private System.Windows.Forms.TextBox workingHoursAdminTextBox;
        private System.Windows.Forms.TextBox currentSubjectsTextBox;
        private System.Windows.Forms.TextBox previousSubjectsTextBox;
        private System.Windows.Forms.PictureBox backButton;
    }
}