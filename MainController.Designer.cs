namespace Sowt
{
    partial class MainController
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.FontFamily = new System.Windows.Forms.Button();
            this.FullVerification = new System.Windows.Forms.Button();
            this.Font = new System.Windows.Forms.Button();
            this.Indentation = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DownloadFile = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.Close = new System.Windows.Forms.Button();
            this.Interval = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Interval);
            this.panel1.Controls.Add(this.FontFamily);
            this.panel1.Controls.Add(this.FullVerification);
            this.panel1.Controls.Add(this.Font);
            this.panel1.Controls.Add(this.Indentation);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 361);
            this.panel1.TabIndex = 0;
            // 
            // FontFamily
            // 
            this.FontFamily.Location = new System.Drawing.Point(97, 73);
            this.FontFamily.Name = "FontFamily";
            this.FontFamily.Size = new System.Drawing.Size(103, 100);
            this.FontFamily.TabIndex = 6;
            this.FontFamily.Text = "Тип шрифта";
            this.FontFamily.UseVisualStyleBackColor = true;
            this.FontFamily.Click += new System.EventHandler(this.button6_Click);
            // 
            // FullVerification
            // 
            this.FullVerification.Location = new System.Drawing.Point(0, 267);
            this.FullVerification.Name = "FullVerification";
            this.FullVerification.Size = new System.Drawing.Size(200, 100);
            this.FullVerification.TabIndex = 5;
            this.FullVerification.Text = "Проверить всё!";
            this.FullVerification.UseVisualStyleBackColor = true;
            this.FullVerification.Click += new System.EventHandler(this.button3_Click);
            // 
            // Font
            // 
            this.Font.Location = new System.Drawing.Point(0, 73);
            this.Font.Name = "Font";
            this.Font.Size = new System.Drawing.Size(103, 100);
            this.Font.TabIndex = 4;
            this.Font.Text = "Размерность шрифта";
            this.Font.UseVisualStyleBackColor = true;
            this.Font.Click += new System.EventHandler(this.button2_Click);
            // 
            // Indentation
            // 
            this.Indentation.Location = new System.Drawing.Point(0, 170);
            this.Indentation.Name = "Indentation";
            this.Indentation.Size = new System.Drawing.Size(103, 100);
            this.Indentation.TabIndex = 3;
            this.Indentation.Text = "Анализ отступов";
            this.Indentation.UseVisualStyleBackColor = true;
            this.Indentation.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Image = global::Sowt.Properties.Resources.imgonline_com_ua_Resize_QLf7xc1JEE5;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 100);
            this.label2.TabIndex = 2;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // DownloadFile
            // 
            this.DownloadFile.Location = new System.Drawing.Point(401, 73);
            this.DownloadFile.Name = "DownloadFile";
            this.DownloadFile.Size = new System.Drawing.Size(217, 63);
            this.DownloadFile.TabIndex = 2;
            this.DownloadFile.Text = "Загрузить файл";
            this.DownloadFile.UseVisualStyleBackColor = true;
            this.DownloadFile.Click += new System.EventHandler(this.button4_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox.Location = new System.Drawing.Point(302, 142);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(417, 207);
            this.richTextBox.TabIndex = 3;
            this.richTextBox.Text = "";
            // 
            // Close
            // 
            this.Close.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Close.Image = global::Sowt.Properties.Resources._2_39;
            this.Close.Location = new System.Drawing.Point(789, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(46, 39);
            this.Close.TabIndex = 0;
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.button5_Click);
            // 
            // Interval
            // 
            this.Interval.Location = new System.Drawing.Point(97, 170);
            this.Interval.Name = "Interval";
            this.Interval.Size = new System.Drawing.Size(103, 100);
            this.Interval.TabIndex = 7;
            this.Interval.Text = "Межстрочный интервалов";
            this.Interval.UseVisualStyleBackColor = true;
            this.Interval.Click += new System.EventHandler(this.button7_Click);
            // 
            // MainController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(116)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(834, 361);
            this.ControlBox = false;
            this.Controls.Add(this.Close);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.DownloadFile);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(850, 377);
            this.MinimumSize = new System.Drawing.Size(850, 377);
            this.Name = "MainController";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button FullVerification;
        private System.Windows.Forms.Button Font;
        private System.Windows.Forms.Button Indentation;
        private System.Windows.Forms.Button DownloadFile;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button FontFamily;
        private System.Windows.Forms.Button Interval;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}