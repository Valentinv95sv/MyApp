using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

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
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer2 = new System.Timers.Timer();
            ((System.ComponentModel.ISupportInitialize) (this.timer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.timer2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.SynchronizingObject = this;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 28);
            this.label4.TabIndex = 18;
            this.label4.Text = "Данные, полученые из базы данных";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.ForeColor = System.Drawing.Color.Black;
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(329, 239);
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 341);
            this.panel1.TabIndex = 37;
            // 
            // AllDataFromDB
            // 
            this.AllDataFromDB.Dock = System.Windows.Forms.DockStyle.Top;
            this.AllDataFromDB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AllDataFromDB.ForeColor = System.Drawing.Color.White;
            this.AllDataFromDB.Location = new System.Drawing.Point(0, 273);
            this.AllDataFromDB.Margin = new System.Windows.Forms.Padding(2);
            this.AllDataFromDB.Name = "AllDataFromDB";
            this.AllDataFromDB.Size = new System.Drawing.Size(119, 39);
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
            this.button4.Location = new System.Drawing.Point(0, 234);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 39);
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
            this.PortWrite.Location = new System.Drawing.Point(0, 195);
            this.PortWrite.Margin = new System.Windows.Forms.Padding(2);
            this.PortWrite.Name = "PortWrite";
            this.PortWrite.Size = new System.Drawing.Size(119, 39);
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
            this.TruncateTable.Location = new System.Drawing.Point(0, 156);
            this.TruncateTable.Margin = new System.Windows.Forms.Padding(2);
            this.TruncateTable.Name = "TruncateTable";
            this.TruncateTable.Size = new System.Drawing.Size(119, 39);
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
            this.CreateTable.Location = new System.Drawing.Point(0, 117);
            this.CreateTable.Margin = new System.Windows.Forms.Padding(2);
            this.CreateTable.Name = "CreateTable";
            this.CreateTable.Size = new System.Drawing.Size(119, 39);
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
            this.ClearBtn.Location = new System.Drawing.Point(0, 78);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(119, 39);
            this.ClearBtn.TabIndex = 11;
            this.ClearBtn.Text = "Отчистить экранную форму";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // ClosePort
            // 
            this.ClosePort.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClosePort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClosePort.ForeColor = System.Drawing.Color.White;
            this.ClosePort.Location = new System.Drawing.Point(0, 39);
            this.ClosePort.Margin = new System.Windows.Forms.Padding(2);
            this.ClosePort.Name = "ClosePort";
            this.ClosePort.Size = new System.Drawing.Size(119, 39);
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
            this.OpenPort.Location = new System.Drawing.Point(0, 0);
            this.OpenPort.Margin = new System.Windows.Forms.Padding(2);
            this.OpenPort.Name = "OpenPort";
            this.OpenPort.Size = new System.Drawing.Size(119, 39);
            this.OpenPort.TabIndex = 9;
            this.OpenPort.Text = "Открыть Com порт";
            this.OpenPort.UseVisualStyleBackColor = true;
            this.OpenPort.Click += new System.EventHandler(this.OpenPort_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(119, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.panel2.Size = new System.Drawing.Size(353, 341);
            this.panel2.TabIndex = 38;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dataGridView1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(12, 102);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(329, 239);
            this.panel7.TabIndex = 39;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(12, 66);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(329, 36);
            this.panel6.TabIndex = 38;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataGridView2);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(12, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(329, 66);
            this.panel5.TabIndex = 37;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView2.Location = new System.Drawing.Point(0, 23);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(329, 43);
            this.dataGridView2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Данные, полученые с платформы";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "Отправка данных в платформу";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.Location = new System.Drawing.Point(472, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 175);
            this.button2.TabIndex = 41;
            this.button2.Text = "Создать БД";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.Location = new System.Drawing.Point(568, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 175);
            this.button3.TabIndex = 42;
            this.button3.Text = "Удалить БД";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000D;
            this.timer2.SynchronizingObject = this;
            this.timer2.Elapsed += new System.Timers.ElapsedEventHandler(this.timer2_Elapsed);
            // 
            // WorkWithArduinoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(666, 341);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(682, 380);
            this.Name = "WorkWithArduinoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.WorkWithArduinoForm_Load);
            ((System.ComponentModel.ISupportInitialize) (this.timer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.FormClosed += new FormClosedEventHandler(Form_closed);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.timer2)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Timers.Timer timer2;

        private System.Windows.Forms.Panel panel7;

        private System.Windows.Forms.Panel panel6;

        private System.Windows.Forms.DataGridView dataGridView2;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Panel panel5;

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;

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

        #endregion
    }
}