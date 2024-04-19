namespace Coursework
{
    partial class add_subject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_subject));
            this.current_subject_textbox = new System.Windows.Forms.TextBox();
            this.previous_subject_textbox = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.current_subject_lbl = new System.Windows.Forms.Label();
            this.previous_subject_lbl = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            this.SuspendLayout();
            // 
            // current_subject_textbox
            // 
            this.current_subject_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_subject_textbox.Location = new System.Drawing.Point(78, 63);
            this.current_subject_textbox.Name = "current_subject_textbox";
            this.current_subject_textbox.Size = new System.Drawing.Size(254, 24);
            this.current_subject_textbox.TabIndex = 0;
            // 
            // previous_subject_textbox
            // 
            this.previous_subject_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previous_subject_textbox.Location = new System.Drawing.Point(78, 116);
            this.previous_subject_textbox.Name = "previous_subject_textbox";
            this.previous_subject_textbox.Size = new System.Drawing.Size(254, 24);
            this.previous_subject_textbox.TabIndex = 1;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(78, 170);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(254, 23);
            this.add_btn.TabIndex = 2;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // current_subject_lbl
            // 
            this.current_subject_lbl.AutoSize = true;
            this.current_subject_lbl.BackColor = System.Drawing.Color.Transparent;
            this.current_subject_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_subject_lbl.ForeColor = System.Drawing.Color.White;
            this.current_subject_lbl.Location = new System.Drawing.Point(75, 42);
            this.current_subject_lbl.Name = "current_subject_lbl";
            this.current_subject_lbl.Size = new System.Drawing.Size(110, 18);
            this.current_subject_lbl.TabIndex = 3;
            this.current_subject_lbl.Text = "Current Subject";
            // 
            // previous_subject_lbl
            // 
            this.previous_subject_lbl.AutoSize = true;
            this.previous_subject_lbl.BackColor = System.Drawing.Color.Transparent;
            this.previous_subject_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previous_subject_lbl.ForeColor = System.Drawing.Color.White;
            this.previous_subject_lbl.Location = new System.Drawing.Point(75, 95);
            this.previous_subject_lbl.Name = "previous_subject_lbl";
            this.previous_subject_lbl.Size = new System.Drawing.Size(119, 18);
            this.previous_subject_lbl.TabIndex = 4;
            this.previous_subject_lbl.Text = "Previous Subject";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton.BackgroundImage")));
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(44, 41);
            this.backButton.TabIndex = 41;
            this.backButton.TabStop = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // add_subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(420, 249);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.previous_subject_lbl);
            this.Controls.Add(this.current_subject_lbl);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.previous_subject_textbox);
            this.Controls.Add(this.current_subject_textbox);
            this.Name = "add_subject";
            this.Text = "Add Subjects";
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox current_subject_textbox;
        private System.Windows.Forms.TextBox previous_subject_textbox;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label current_subject_lbl;
        private System.Windows.Forms.Label previous_subject_lbl;
        private System.Windows.Forms.PictureBox backButton;
    }
}