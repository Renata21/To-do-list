namespace To_do_list
{
    partial class Lista
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.button_new = new System.Windows.Forms.Button();
            this.button_read = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_edit = new System.Windows.Forms.Button();
            this.comboBox_afizeazaToDoTerminat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Location = new System.Drawing.Point(13, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(492, 241);
            this.dataGridView1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.label3.Location = new System.Drawing.Point(213, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 45);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lista ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_new
            // 
            this.button_new.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.button_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_new.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.button_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_new.ForeColor = System.Drawing.Color.White;
            this.button_new.Location = new System.Drawing.Point(0, 7);
            this.button_new.Name = "button_new";
            this.button_new.Size = new System.Drawing.Size(103, 40);
            this.button_new.TabIndex = 6;
            this.button_new.Text = "new";
            this.button_new.UseVisualStyleBackColor = false;
            this.button_new.Click += new System.EventHandler(this.button_new_Click);
            // 
            // button_read
            // 
            this.button_read.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_read.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.button_read.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_read.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.button_read.FlatAppearance.BorderSize = 0;
            this.button_read.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_read.ForeColor = System.Drawing.Color.White;
            this.button_read.Location = new System.Drawing.Point(129, 7);
            this.button_read.Name = "button_read";
            this.button_read.Size = new System.Drawing.Size(103, 40);
            this.button_read.TabIndex = 8;
            this.button_read.Text = "read";
            this.button_read.UseVisualStyleBackColor = false;
            this.button_read.Click += new System.EventHandler(this.button_read_Click);
            // 
            // button_delete
            // 
            this.button_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.button_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(387, 7);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(103, 40);
            this.button_delete.TabIndex = 9;
            this.button_delete.Text = "delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(58, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(517, 382);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button_edit);
            this.panel1.Controls.Add(this.button_delete);
            this.panel1.Controls.Add(this.button_read);
            this.panel1.Controls.Add(this.button_new);
            this.panel1.Location = new System.Drawing.Point(16, 308);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 59);
            this.panel1.TabIndex = 10;
            // 
            // button_edit
            // 
            this.button_edit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.button_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_edit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.button_edit.FlatAppearance.BorderSize = 0;
            this.button_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_edit.ForeColor = System.Drawing.Color.White;
            this.button_edit.Location = new System.Drawing.Point(258, 7);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(103, 40);
            this.button_edit.TabIndex = 10;
            this.button_edit.Text = "edit";
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // comboBox_afizeazaToDoTerminat
            // 
            this.comboBox_afizeazaToDoTerminat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_afizeazaToDoTerminat.FormattingEnabled = true;
            this.comboBox_afizeazaToDoTerminat.Items.AddRange(new object[] {
            "Da",
            "Nu"});
            this.comboBox_afizeazaToDoTerminat.Location = new System.Drawing.Point(405, 3);
            this.comboBox_afizeazaToDoTerminat.Name = "comboBox_afizeazaToDoTerminat";
            this.comboBox_afizeazaToDoTerminat.Size = new System.Drawing.Size(98, 24);
            this.comboBox_afizeazaToDoTerminat.TabIndex = 15;
            this.comboBox_afizeazaToDoTerminat.Text = "Da";
            this.comboBox_afizeazaToDoTerminat.SelectedIndexChanged += new System.EventHandler(this.modificare_afisare);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(2, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 27);
            this.label1.TabIndex = 16;
            this.label1.Text = "Doriți să se afișeze sarcinile terminate?";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comboBox_afizeazaToDoTerminat);
            this.panel2.Location = new System.Drawing.Point(58, 437);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(511, 36);
            this.panel2.TabIndex = 17;
            // 
            // Lista
            // 
            this.AcceptButton = this.button_new;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(632, 511);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.MinimumSize = new System.Drawing.Size(527, 558);
            this.Name = "Lista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "To Do List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.inchidere_form);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_new;
        private System.Windows.Forms.Button button_read;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.ComboBox comboBox_afizeazaToDoTerminat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }  
}

