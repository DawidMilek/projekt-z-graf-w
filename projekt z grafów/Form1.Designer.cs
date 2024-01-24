namespace projekt_z_grafów
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.D_groupbox = new System.Windows.Forms.GroupBox();
            this.D_start = new System.Windows.Forms.Button();
            this.D_w_glab = new System.Windows.Forms.CheckBox();
            this.D_wszerz = new System.Windows.Forms.CheckBox();
            this.D_text = new System.Windows.Forms.TextBox();
            this.D_label = new System.Windows.Forms.Label();
            this.D_lista_wierzcholkow = new System.Windows.Forms.ListBox();
            this.D_wyniki = new System.Windows.Forms.ListBox();
            this.D_resetuj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.D_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(816, 540);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // D_groupbox
            // 
            this.D_groupbox.Controls.Add(this.D_start);
            this.D_groupbox.Controls.Add(this.D_w_glab);
            this.D_groupbox.Controls.Add(this.D_wszerz);
            this.D_groupbox.Controls.Add(this.D_text);
            this.D_groupbox.Location = new System.Drawing.Point(662, 41);
            this.D_groupbox.Name = "D_groupbox";
            this.D_groupbox.Size = new System.Drawing.Size(139, 133);
            this.D_groupbox.TabIndex = 1;
            this.D_groupbox.TabStop = false;
            // 
            // D_start
            // 
            this.D_start.Location = new System.Drawing.Point(34, 100);
            this.D_start.Name = "D_start";
            this.D_start.Size = new System.Drawing.Size(75, 23);
            this.D_start.TabIndex = 3;
            this.D_start.Text = "start";
            this.D_start.UseVisualStyleBackColor = true;
            this.D_start.Click += new System.EventHandler(this.D_start_Click);
            // 
            // D_w_glab
            // 
            this.D_w_glab.AutoSize = true;
            this.D_w_glab.Location = new System.Drawing.Point(21, 75);
            this.D_w_glab.Name = "D_w_glab";
            this.D_w_glab.Size = new System.Drawing.Size(62, 19);
            this.D_w_glab.TabIndex = 2;
            this.D_w_glab.Text = "w głąb";
            this.D_w_glab.UseVisualStyleBackColor = true;
            // 
            // D_wszerz
            // 
            this.D_wszerz.AutoSize = true;
            this.D_wszerz.Location = new System.Drawing.Point(21, 50);
            this.D_wszerz.Name = "D_wszerz";
            this.D_wszerz.Size = new System.Drawing.Size(64, 19);
            this.D_wszerz.TabIndex = 1;
            this.D_wszerz.Text = "wszerz";
            this.D_wszerz.UseVisualStyleBackColor = true;
            // 
            // D_text
            // 
            this.D_text.Location = new System.Drawing.Point(21, 20);
            this.D_text.Name = "D_text";
            this.D_text.Size = new System.Drawing.Size(100, 21);
            this.D_text.TabIndex = 0;
            // 
            // D_label
            // 
            this.D_label.AutoSize = true;
            this.D_label.Location = new System.Drawing.Point(659, 23);
            this.D_label.Name = "D_label";
            this.D_label.Size = new System.Drawing.Size(154, 15);
            this.D_label.TabIndex = 2;
            this.D_label.Text = "Podaj wierzchołek startowy";
            // 
            // D_lista_wierzcholkow
            // 
            this.D_lista_wierzcholkow.FormattingEnabled = true;
            this.D_lista_wierzcholkow.ItemHeight = 15;
            this.D_lista_wierzcholkow.Location = new System.Drawing.Point(662, 180);
            this.D_lista_wierzcholkow.Name = "D_lista_wierzcholkow";
            this.D_lista_wierzcholkow.Size = new System.Drawing.Size(138, 124);
            this.D_lista_wierzcholkow.TabIndex = 3;
            // 
            // D_wyniki
            // 
            this.D_wyniki.FormattingEnabled = true;
            this.D_wyniki.ItemHeight = 15;
            this.D_wyniki.Location = new System.Drawing.Point(662, 322);
            this.D_wyniki.Name = "D_wyniki";
            this.D_wyniki.Size = new System.Drawing.Size(138, 139);
            this.D_wyniki.TabIndex = 4;
            // 
            // D_resetuj
            // 
            this.D_resetuj.Location = new System.Drawing.Point(683, 479);
            this.D_resetuj.Name = "D_resetuj";
            this.D_resetuj.Size = new System.Drawing.Size(100, 23);
            this.D_resetuj.TabIndex = 5;
            this.D_resetuj.Text = "Resetuj";
            this.D_resetuj.UseVisualStyleBackColor = true;
            this.D_resetuj.Click += new System.EventHandler(this.D_resetuj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 540);
            this.Controls.Add(this.D_resetuj);
            this.Controls.Add(this.D_wyniki);
            this.Controls.Add(this.D_lista_wierzcholkow);
            this.Controls.Add(this.D_label);
            this.Controls.Add(this.D_groupbox);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.D_groupbox.ResumeLayout(false);
            this.D_groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox D_groupbox;
        private System.Windows.Forms.Label D_label;
        private System.Windows.Forms.Button D_start;
        private System.Windows.Forms.CheckBox D_w_glab;
        private System.Windows.Forms.CheckBox D_wszerz;
        private System.Windows.Forms.TextBox D_text;
        private System.Windows.Forms.ListBox D_lista_wierzcholkow;
        private System.Windows.Forms.ListBox D_wyniki;
        private System.Windows.Forms.Button D_resetuj;
    }
}