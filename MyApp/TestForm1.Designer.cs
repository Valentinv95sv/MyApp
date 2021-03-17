using System.ComponentModel;

namespace MyApp
{
    partial class TestForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm1));
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.dataGrid2 = new System.Windows.Forms.DataGrid();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize) (this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid1
            // 
            this.dataGrid1.AlternatingBackColor = System.Drawing.SystemColors.InfoText;
            this.dataGrid1.BackColor = System.Drawing.Color.White;
            this.dataGrid1.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid1.CaptionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGrid1.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dataGrid1.CaptionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGrid1.CaptionText = "Данные, полученные из базы данных";
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGrid1.Location = new System.Drawing.Point(33, 110);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.ParentRowsBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGrid1.PreferredRowHeight = 20;
            this.dataGrid1.Size = new System.Drawing.Size(278, 395);
            this.dataGrid1.TabIndex = 0;
            // 
            // dataGrid2
            // 
            this.dataGrid2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGrid2.CaptionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGrid2.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dataGrid2.CaptionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGrid2.CaptionText = "Данные, полученные  с Arduino";
            this.dataGrid2.DataMember = "";
            this.dataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid2.Location = new System.Drawing.Point(368, 110);
            this.dataGrid2.Name = "dataGrid2";
            this.dataGrid2.Size = new System.Drawing.Size(278, 395);
            this.dataGrid2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(702, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(263, 64);
            this.button2.TabIndex = 3;
            this.button2.Text = "Начать запись данных, полученных с Arduino, в базу данных";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("button3.BackgroundImage")));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(702, 195);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(263, 62);
            this.button3.TabIndex = 4;
            this.button3.Text = "Остановить запись данных, полученных с Arduino, в базу данных";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("button4.BackgroundImage")));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(702, 280);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(263, 52);
            this.button4.TabIndex = 5;
            this.button4.Text = "Отчистить формы вывода данных";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("button5.BackgroundImage")));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(702, 351);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(263, 54);
            this.button5.TabIndex = 6;
            this.button5.Text = "Отчистить таблицу базы данных";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(702, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 52);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Image = ((System.Drawing.Image) (resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 41);
            this.label1.TabIndex = 8;
            this.label1.Text = "Текущие данные, полученные с Arduino";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(354, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(574, 20);
            this.textBox1.TabIndex = 9;
            // 
            // TestForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1071, 558);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGrid2);
            this.Controls.Add(this.dataGrid1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "TestForm1";
            this.Text = "TestForm1";
            ((System.ComponentModel.ISupportInitialize) (this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGrid2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button button5;

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;

        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.DataGrid dataGrid2;

        #endregion
    }
}