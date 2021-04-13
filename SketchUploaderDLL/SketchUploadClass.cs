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
            ArduinoSketchUploader uploader = new ArduinoSketchUploader(
                new ArduinoSketchUploaderOptions()
                {
                    FileName = Filename,
                    PortName = port,
                    ArduinoModel = model
                });
            uploader.UploadSketch();
        }

        public void uploadCheckSketch(string port, ArduinoModel model, int baudrate)
        {
            string filePath = "checkSktech.ino.eightanaloginputs.hex";
            ArduinoSketchUploader uploader = new ArduinoSketchUploader(
                new ArduinoSketchUploaderOptions()
                {
                    FileName = filePath,
                    PortName = port,
                    ArduinoModel = model
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
        
        public string[] getModelList()
        {
            string[] list = {"Leonardo", "Mega1284", "Mega2560", "Micro", "NanoR2", "NanoR3", "UnoR3"};
            return list;
        }
        
        public ArduinoModel SetModel()
        {
            /*switch (myModel)
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
            }*/
            return ArduinoModel.NanoR3;
        }

        public string[] getPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            return ports;
        }
    } 
}