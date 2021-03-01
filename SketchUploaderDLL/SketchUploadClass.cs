using System.Collections.Generic;
using System.IO.Ports;
using System.Windows.Forms;
using ArduinoUploader;
using ArduinoUploader.Hardware;

namespace SketchUploaderDLL
{
    public class uploaderClass
    {
        private uploaderClass _uploaderClass;
        
        private string filename { get; set; }
        private string portname { get; set; }
        private ArduinoModel model { get; set; }

        public uploaderClass()
        {
            
        }
        public uploaderClass(string filename, string portname, ArduinoModel model)
        {
            this.filename = filename;
            this.portname = portname;
            this.model = model;
        }
        
        public void uploadSketch(string Filename, ArduinoModel model, string port, int baudrate)
        {
            _uploaderClass = new uploaderClass(Filename, port, model);
            _uploaderClass.upload();
        }

        public void upload()
        {
            ArduinoSketchUploader uploader = new ArduinoSketchUploader(
                new ArduinoSketchUploaderOptions()
                {
                    FileName = this.filename,
                    PortName = this.portname,
                    ArduinoModel = this.model
                });
            uploader.UploadSketch();
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
            return ports;
        }
    } 
}