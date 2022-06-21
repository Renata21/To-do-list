namespace To_do_list
{
    partial class To_do_nou
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker_termen = new System.Windows.Forms.DateTimePicker();
            this.label_termen = new System.Windows.Forms.Label();
            this.text_detalii2 = new System.Windows.Forms.TextBox();
            this.text_toDo = new System.Windows.Forms.TextBox();
            this.label_detalii = new System.Windows.Forms.Label();
            this.label_toDo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.button_cancel);
            this.groupBox1.Controls.Add(this.button_save);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.groupBox1.Location = new System.Drawing.Point(70, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 361);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adaugare nou todo";
            // 
            // button_cancel
            // 
            this.button_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.button_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.ForeColor = System.Drawing.Color.White;
            this.button_cancel.Location = new System.Drawing.Point(198, 318);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(103, 33);
            this.button_cancel.TabIndex = 13;
            this.button_cancel.Text = "cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_save
            // 
            this.button_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.button_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_save.ForeColor = System.Drawing.Color.White;
            this.button_save.Location = new System.Drawing.Point(68, 317);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(103, 33);
            this.button_save.TabIndex = 7;
            this.button_save.Text = "save";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dateTimePicker_termen);
            this.panel1.Controls.Add(this.label_termen);
            this.panel1.Controls.Add(this.text_detalii2);
            this.panel1.Controls.Add(this.text_toDo);
            this.panel1.Controls.Add(this.label_detalii);
            this.panel1.Controls.Add(this.label_toDo);
            this.panel1.Location = new System.Drawing.Point(6, 41);
            this.panel1.MaximumSize = new System.Drawing.Size(1700, 900);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 228);
            this.panel1.TabIndex = 14;
            // 
            // dateTimePicker_termen
            // 
            this.dateTimePicker_termen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_termen.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.dateTimePicker_termen.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.dateTimePicker_termen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dateTimePicker_termen.CustomFormat = "dddd d MMM HH\':\'mm";
            this.dateTimePicker_termen.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_termen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_termen.Location = new System.Drawing.Point(110, 192);
            this.dateTimePicker_termen.Name = "dateTimePicker_termen";
            this.dateTimePicker_termen.Size = new System.Drawing.Size(212, 25);
            this.dateTimePicker_termen.TabIndex = 11;
            this.dateTimePicker_termen.Value = new System.DateTime(2022, 2, 18, 17, 46, 18, 0);
            // 
            // label_termen
            // 
            this.label_termen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_termen.AutoSize = true;
            this.label_termen.BackColor = System.Drawing.Color.Transparent;
            this.label_termen.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_termen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.label_termen.Location = new System.Drawing.Point(16, 190);
            this.label_termen.Name = "label_termen";
            this.label_termen.Size = new System.Drawing.Size(83, 27);
            this.label_termen.TabIndex = 12;
            this.label_termen.Text = "Termen";
            // 
            // text_detalii2
            // 
            this.text_detalii2.AcceptsReturn = true;
            this.text_detalii2.AcceptsTab = true;
            this.text_detalii2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.text_detalii2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.text_detalii2.ForeColor = System.Drawing.Color.White;
            this.text_detalii2.Location = new System.Drawing.Point(110, 78);
            this.text_detalii2.Multiline = true;
            this.text_detalii2.Name = "text_detalii2";
            this.text_detalii2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_detalii2.Size = new System.Drawing.Size(212, 77);
            this.text_detalii2.TabIndex = 10;
            // 
            // text_toDo
            // 
            this.text_toDo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.text_toDo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.text_toDo.ForeColor = System.Drawing.Color.White;
            this.text_toDo.Location = new System.Drawing.Point(110, 28);
            this.text_toDo.MinimumSize = new System.Drawing.Size(4, 27);
            this.text_toDo.Name = "text_toDo";
            this.text_toDo.Size = new System.Drawing.Size(212, 30);
            this.text_toDo.TabIndex = 2;
            // 
            // label_detalii
            // 
            this.label_detalii.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_detalii.AutoSize = true;
            this.label_detalii.BackColor = System.Drawing.Color.Transparent;
            this.label_detalii.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_detalii.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.label_detalii.Location = new System.Drawing.Point(7, 91);
            this.label_detalii.Name = "label_detalii";
            this.label_detalii.Size = new System.Drawing.Size(74, 27);
            this.label_detalii.TabIndex = 1;
            this.label_detalii.Text = "Detalii";
            // 
            // label_toDo
            // 
            this.label_toDo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_toDo.AutoSize = true;
            this.label_toDo.BackColor = System.Drawing.Color.Transparent;
            this.label_toDo.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_toDo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.label_toDo.Location = new System.Drawing.Point(16, 28);
            this.label_toDo.MinimumSize = new System.Drawing.Size(0, 27);
            this.label_toDo.Name = "label_toDo";
            this.label_toDo.Size = new System.Drawing.Size(65, 27);
            this.label_toDo.TabIndex = 0;
            this.label_toDo.Text = "To do";
            // 
            // To_do_nou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(509, 511);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(527, 558);
            this.Name = "To_do_nou";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "To do nou";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_termen;
        public System.Windows.Forms.DateTimePicker dateTimePicker_termen;
        public System.Windows.Forms.TextBox text_detalii2;
        private System.Windows.Forms.Button button_save;
        public System.Windows.Forms.TextBox text_toDo;
        private System.Windows.Forms.Label label_detalii;
        private System.Windows.Forms.Label label_toDo;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Panel panel1;
    }
}