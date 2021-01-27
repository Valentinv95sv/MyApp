using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using ArduinoUploader.Hardware;
using ComPortParserDLL;
using DatabaseDLL;
using SketchUploaderDLL;

namespace GUIHandlerDLL
{
    public class GuiHandler
    {
        private DbClass db = new DbClass();
        private uploaderClass uploader;

        public void Init(string Filename, ArduinoModel model, string port, int baudrate)
        {
            uploader = new uploaderClass(Filename, port, model);
            uploader.upload();
        }

        public string openfile()
        {
            using (FileDialog fbd = new OpenFileDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    return fbd.FileName;
                }
            }
            return "Error";
        }
        public List<string> getModelList()
        {
            List<string> list = new List<string>();
            list.Add("Leonardo");
            list.Add("Mega1284");
            list.Add("Mega2560");
            list.Add("Micro");
            list.Add("NanoR2");
            list.Add("NanoR3");
            list.Add("UnoR3");
            return list;
        }
        public ArduinoModel SetModel(string myModel)
        {
            switch (myModel)
            {
                case "Leonardo":
                    return ArduinoModel.Leonardo;
                case "Mega1284":
                    return ArduinoModel.Mega1284;
                case "Mega2560":
                    return ArduinoModel.Mega2560;
                case "Micro":
                    return ArduinoModel.Micro;
                case "NanoR2":
                    return ArduinoModel.NanoR2;
                case "NanoR3":
                    return ArduinoModel.NanoR3;
                case "Unor3":
                    return ArduinoModel.UnoR3;
            }
            return ArduinoModel.NanoR3;
        }
        public string[] getPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            /*if (ports.Length == 0)
            {
                MessageBox.Show("com Port not found");
            }*/
            return ports;
        }
        public void DatabaseConnection(string username, string password)
        {
            string connectionOption ="SERVER=" + "localhost" + ";" + "DATABASE=" + "ArduinoDatabase" + ";" +
                                     "UID=" + username + ";" + "PASSWORD=" + password + ";";
            db.Connect(connectionOption);
            try
            {
                if (db.OpenConnection())
                {
                    db.CloseConnection();
                    MessageBox.Show("successfully connected to DB");
                }
                else
                {
                    MessageBox.Show("not connected");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public List<string> dbCount()
        {
            List<string> i = new List<string>();
            i = db.Select();
            return i;
        }

        public void insert()
        {
            string a = "hello";
            db.Insert(a);
        }
        
        
    }
}