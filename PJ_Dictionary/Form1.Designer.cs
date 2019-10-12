namespace PJ_Dictionary
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
            this.tbx_Nhaptu = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.lb_Word = new System.Windows.Forms.Label();
            this.lb_WordType = new System.Windows.Forms.Label();
            this.lb_Mean1 = new System.Windows.Forms.Label();
            this.lb_Mean2 = new System.Windows.Forms.Label();
            this.lb_Mean3 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbx_Nhaptu
            // 
            this.tbx_Nhaptu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_Nhaptu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbx_Nhaptu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_Nhaptu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Nhaptu.Location = new System.Drawing.Point(562, 210);
            this.tbx_Nhaptu.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_Nhaptu.Name = "tbx_Nhaptu";
            this.tbx_Nhaptu.Size = new System.Drawing.Size(425, 36);
            this.tbx_Nhaptu.TabIndex = 0;
            this.tbx_Nhaptu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tbx_Nhaptu_KeyDown);
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Search.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(881, 213);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(104, 30);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Delete.BackColor = System.Drawing.Color.White;
            this.btn_Delete.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.Red;
            this.btn_Delete.Location = new System.Drawing.Point(1217, 292);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(95, 31);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Delele";
            this.btn_Delete.UseVisualStyleBackColor = false;
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Update.BackColor = System.Drawing.Color.White;
            this.btn_Update.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.Green;
            this.btn_Update.Location = new System.Drawing.Point(986, 292);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(95, 31);
            this.btn_Update.TabIndex = 3;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // lb_Word
            // 
            this.lb_Word.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Word.BackColor = System.Drawing.Color.Transparent;
            this.lb_Word.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Word.ForeColor = System.Drawing.Color.Blue;
            this.lb_Word.Location = new System.Drawing.Point(520, 292);
            this.lb_Word.Name = "lb_Word";
            this.lb_Word.Size = new System.Drawing.Size(301, 31);
            this.lb_Word.TabIndex = 4;
            this.lb_Word.Text = "từ tiến anh";
            // 
            // lb_WordType
            // 
            this.lb_WordType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_WordType.AutoSize = true;
            this.lb_WordType.BackColor = System.Drawing.Color.Gainsboro;
            this.lb_WordType.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_WordType.Location = new System.Drawing.Point(544, 350);
            this.lb_WordType.Name = "lb_WordType";
            this.lb_WordType.Size = new System.Drawing.Size(83, 29);
            this.lb_WordType.TabIndex = 5;
            this.lb_WordType.Text = "Loại từ";
            // 
            // lb_Mean1
            // 
            this.lb_Mean1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Mean1.AutoSize = true;
            this.lb_Mean1.BackColor = System.Drawing.Color.Transparent;
            this.lb_Mean1.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Mean1.Location = new System.Drawing.Point(616, 406);
            this.lb_Mean1.Name = "lb_Mean1";
            this.lb_Mean1.Size = new System.Drawing.Size(78, 27);
            this.lb_Mean1.TabIndex = 6;
            this.lb_Mean1.Text = "nghia 1";
            // 
            // lb_Mean2
            // 
            this.lb_Mean2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Mean2.AutoSize = true;
            this.lb_Mean2.BackColor = System.Drawing.Color.Transparent;
            this.lb_Mean2.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Mean2.Location = new System.Drawing.Point(616, 474);
            this.lb_Mean2.Name = "lb_Mean2";
            this.lb_Mean2.Size = new System.Drawing.Size(78, 27);
            this.lb_Mean2.TabIndex = 7;
            this.lb_Mean2.Text = "nghia 2";
            // 
            // lb_Mean3
            // 
            this.lb_Mean3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Mean3.AutoSize = true;
            this.lb_Mean3.BackColor = System.Drawing.Color.Transparent;
            this.lb_Mean3.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Mean3.Location = new System.Drawing.Point(616, 552);
            this.lb_Mean3.Name = "lb_Mean3";
            this.lb_Mean3.Size = new System.Drawing.Size(78, 27);
            this.lb_Mean3.TabIndex = 8;
            this.lb_Mean3.Text = "nghia 3";
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Add.BackColor = System.Drawing.Color.White;
            this.btn_Add.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.Blue;
            this.btn_Add.Location = new System.Drawing.Point(1089, 292);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(120, 31);
            this.btn_Add.TabIndex = 9;
            this.btn_Add.Text = "Add New";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(520, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(792, 3);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.Location = new System.Drawing.Point(586, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(10, 34);
            this.button2.TabIndex = 11;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button3.Location = new System.Drawing.Point(586, 473);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(10, 34);
            this.button3.TabIndex = 11;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button4.Location = new System.Drawing.Point(586, 551);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(10, 34);
            this.button4.TabIndex = 11;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PJ_Dictionary.Properties.Resources.a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1540, 698);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lb_Mean3);
            this.Controls.Add(this.lb_Mean2);
            this.Controls.Add(this.lb_Mean1);
            this.Controls.Add(this.lb_WordType);
            this.Controls.Add(this.lb_Word);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tbx_Nhaptu);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "T&T Dictionary";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lb_Word;
        public System.Windows.Forms.TextBox tbx_Nhaptu;
        public System.Windows.Forms.Button btn_Search;
        public System.Windows.Forms.Button btn_Delete;
        public System.Windows.Forms.Button btn_Update;
        public System.Windows.Forms.Label lb_WordType;
        public System.Windows.Forms.Label lb_Mean1;
        public System.Windows.Forms.Label lb_Mean2;
        public System.Windows.Forms.Label lb_Mean3;
        public System.Windows.Forms.Button btn_Add;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button4;
    }
}

