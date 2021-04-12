using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace MyApp
{
    partial class AllInOne
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllInOne));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.bntMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (51)))), ((int) (((byte) (51)))), ((int) (((byte) (76)))));
            this.panelMenu.Controls.Add(this.button6);
            this.panelMenu.Controls.Add(this.button5);
            this.panelMenu.Controls.Add(this.button3);
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(238, 611);
            this.panelMenu.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.button6.ForeColor = System.Drawing.Color.Gainsboro;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, 320);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(238, 60);
            this.button6.TabIndex = 6;
            this.button6.Text = "Линейная диаграмма";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.button5.ForeColor = System.Drawing.Color.Gainsboro;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 260);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(238, 60);
            this.button5.TabIndex = 5;
            this.button5.Text = "Круглая диаграмма";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.button3.ForeColor = System.Drawing.Color.Gainsboro;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 200);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(238, 60);
            this.button3.TabIndex = 3;
            this.button3.Text = "График средних показаний";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.Image = ((System.Drawing.Image) (resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 140);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(238, 60);
            this.button2.TabIndex = 2;
            this.button2.Text = "Создание БД";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Image = ((System.Drawing.Image) (resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 80);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(238, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "Загрузка прошивки";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (39)))), ((int) (((byte) (39)))), ((int) (((byte) (58)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(238, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Дипломный проект";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 80);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (150)))), ((int) (((byte) (136)))));
            this.panelTitleBar.Controls.Add(this.bntMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(238, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1146, 80);
            this.panelTitleBar.TabIndex = 4;
            // 
            // bntMinimize
            // 
            this.bntMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.bntMinimize.FlatAppearance.BorderSize = 0;
            this.bntMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntMinimize.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.bntMinimize.ForeColor = System.Drawing.Color.White;
            this.bntMinimize.Location = new System.Drawing.Point(1056, 0);
            this.bntMinimize.Name = "bntMinimize";
            this.bntMinimize.Size = new System.Drawing.Size(30, 80);
            this.bntMinimize.TabIndex = 5;
            this.bntMinimize.Text = "O";
            this.bntMinimize.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.bntMinimize.UseVisualStyleBackColor = true;
            this.bntMinimize.Click += new System.EventHandler(this.bntMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Location = new System.Drawing.Point(1086, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(30, 80);
            this.btnMaximize.TabIndex = 4;
            this.btnMaximize.Text = "O";
            this.btnMaximize.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1116, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 80);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "O";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Image = ((System.Drawing.Image) (resources.GetObject("btnCloseChildForm.Image")));
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(86, 80);
            this.btnCloseChildForm.TabIndex = 2;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(497, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(95, 33);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "HOME";
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.BackColor = System.Drawing.Color.White;
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(238, 80);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(1146, 531);
            this.panelDesktopPane.TabIndex = 5;
            // 
            // AllInOne
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (12)))), ((int) (((byte) (46)))), ((int) (((byte) (100)))));
            this.ClientSize = new System.Drawing.Size(1384, 611);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.MinimumSize = new System.Drawing.Size(1400, 650);
            this.Name = "AllInOne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllInOne";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button bntMinimize;
        private System.Windows.Forms.Button btnMaximize;

        private System.Windows.Forms.Button btnClose;

        private System.Windows.Forms.Button btnCloseChildForm;

        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelDesktopPane;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Panel panelLogo;

        private System.Windows.Forms.Panel panelMenu;

        #endregion
    }
}