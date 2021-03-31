using System.ComponentModel;

namespace MyApp
{
    partial class WorkWithArduinoForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Timers.Timer();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AllDataFromDB = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.PortWrite = new System.Windows.Forms.Button();
            this.TruncateTable = new System.Windows.Forms.Button();
            this.CreateTable = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.ClosePort = new System.Windows.Forms.Button();
            this.OpenPort = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.timer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "Соединение с базой данных";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.SynchronizingObject = this;
            this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Elapsed);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(12, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 28);
            this.label4.TabIndex = 18;
            this.label4.Text = "Даннаые, полученые из базы данных";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(12, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "номер Com порта";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 21);
            this.comboBox1.TabIndex = 29;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(329, 391);
            this.dataGridView1.TabIndex = 36;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(24, 26);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(158, 20);
            this.textBox5.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (51)))), ((int) (((byte) (51)))), ((int) (((byte) (76)))));
            this.panel1.Controls.Add(this.AllDataFromDB);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.PortWrite);
            this.panel1.Controls.Add(this.TruncateTable);
            this.panel1.Controls.Add(this.CreateTable);
            this.panel1.Controls.Add(this.ClearBtn);
            this.panel1.Controls.Add(this.ClosePort);
            this.panel1.Controls.Add(this.OpenPort);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 419);
            this.panel1.TabIndex = 37;
            // 
            // AllDataFromDB
            // 
            this.AllDataFromDB.Dock = System.Windows.Forms.DockStyle.Top;
            this.AllDataFromDB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AllDataFromDB.ForeColor = System.Drawing.Color.White;
            this.AllDataFromDB.Location = new System.Drawing.Point(0, 368);
            this.AllDataFromDB.Margin = new System.Windows.Forms.Padding(2);
            this.AllDataFromDB.Name = "AllDataFromDB";
            this.AllDataFromDB.Size = new System.Drawing.Size(119, 45);
            this.AllDataFromDB.TabIndex = 16;
            this.AllDataFromDB.Text = "Все записи базы данных";
            this.AllDataFromDB.UseVisualStyleBackColor = true;
            this.AllDataFromDB.Click += new System.EventHandler(this.AllDataFromDB_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(0, 315);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 53);
            this.button4.TabIndex = 15;
            this.button4.Text = "Удалить таблицу в БД";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // PortWrite
            // 
            this.PortWrite.Dock = System.Windows.Forms.DockStyle.Top;
            this.PortWrite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PortWrite.ForeColor = System.Drawing.Color.White;
            this.PortWrite.Location = new System.Drawing.Point(0, 270);
            this.PortWrite.Margin = new System.Windows.Forms.Padding(2);
            this.PortWrite.Name = "PortWrite";
            this.PortWrite.Size = new System.Drawing.Size(119, 45);
            this.PortWrite.TabIndex = 14;
            this.PortWrite.Text = "Отправить данные в Com порт";
            this.PortWrite.UseVisualStyleBackColor = true;
            this.PortWrite.Click += new System.EventHandler(this.PortWrite_Click);
            // 
            // TruncateTable
            // 
            this.TruncateTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.TruncateTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TruncateTable.ForeColor = System.Drawing.Color.White;
            this.TruncateTable.Location = new System.Drawing.Point(0, 225);
            this.TruncateTable.Margin = new System.Windows.Forms.Padding(2);
            this.TruncateTable.Name = "TruncateTable";
            this.TruncateTable.Size = new System.Drawing.Size(119, 45);
            this.TruncateTable.TabIndex = 13;
            this.TruncateTable.Text = "Отчистить все данные в таблице";
            this.TruncateTable.UseVisualStyleBackColor = true;
            this.TruncateTable.Click += new System.EventHandler(this.TruncateTable_Click);
            // 
            // CreateTable
            // 
            this.CreateTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.CreateTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CreateTable.ForeColor = System.Drawing.Color.White;
            this.CreateTable.Location = new System.Drawing.Point(0, 180);
            this.CreateTable.Margin = new System.Windows.Forms.Padding(2);
            this.CreateTable.Name = "CreateTable";
            this.CreateTable.Size = new System.Drawing.Size(119, 45);
            this.CreateTable.TabIndex = 12;
            this.CreateTable.Text = "Создать таблицу в БД";
            this.CreateTable.UseVisualStyleBackColor = true;
            this.CreateTable.Click += new System.EventHandler(this.CreateTable_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearBtn.ForeColor = System.Drawing.Color.White;
            this.ClearBtn.Location = new System.Drawing.Point(0, 135);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(119, 45);
            this.ClearBtn.TabIndex = 11;
            this.ClearBtn.Text = "Отчистить все поля";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // ClosePort
            // 
            this.ClosePort.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClosePort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClosePort.ForeColor = System.Drawing.Color.White;
            this.ClosePort.Location = new System.Drawing.Point(0, 90);
            this.ClosePort.Margin = new System.Windows.Forms.Padding(2);
            this.ClosePort.Name = "ClosePort";
            this.ClosePort.Size = new System.Drawing.Size(119, 45);
            this.ClosePort.TabIndex = 10;
            this.ClosePort.Text = "Закрыть Com порт";
            this.ClosePort.UseVisualStyleBackColor = true;
            this.ClosePort.Click += new System.EventHandler(this.ClosePort_Click);
            // 
            // OpenPort
            // 
            this.OpenPort.Dock = System.Windows.Forms.DockStyle.Top;
            this.OpenPort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OpenPort.ForeColor = System.Drawing.Color.White;
            this.OpenPort.Location = new System.Drawing.Point(0, 45);
            this.OpenPort.Margin = new System.Windows.Forms.Padding(2);
            this.OpenPort.Name = "OpenPort";
            this.OpenPort.Size = new System.Drawing.Size(119, 45);
            this.OpenPort.TabIndex = 9;
            this.OpenPort.Text = "Открыть Com порт";
            this.OpenPort.UseVisualStyleBackColor = true;
            this.OpenPort.Click += new System.EventHandler(this.OpenPort_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(119, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.panel2.Size = new System.Drawing.Size(353, 419);
            this.panel2.TabIndex = 38;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(472, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.panel3.Size = new System.Drawing.Size(194, 66);
            this.panel3.TabIndex = 39;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.textBox5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(472, 66);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(194, 100);
            this.panel4.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "Отправка данных в платформу";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WorkWithArduinoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(666, 419);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WorkWithArduinoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.WorkWithArduinoForm_Load);
            ((System.ComponentModel.ISupportInitialize) (this.timer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Panel panel4;

        private System.Windows.Forms.Panel panel3;

        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.Button AllDataFromDB;

        private System.Windows.Forms.Button button4;

        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button ClosePort;
        private System.Windows.Forms.Button CreateTable;
        private System.Windows.Forms.Button OpenPort;
        private System.Windows.Forms.Button PortWrite;
        private System.Windows.Forms.Button TruncateTable;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.TextBox textBox5;

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label4;

        private System.Timers.Timer timer1;

        private System.Windows.Forms.Button button1;

        #endregion
    }
}