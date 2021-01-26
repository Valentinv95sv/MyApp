using ArduinoUploader;
using ArduinoUploader.Hardware;

namespace SketchUploaderDLL
{
    public class uploaderClass
    {
        
        private string filename { get; set; }
        private string portname { get; set; }
        private ArduinoModel model { get; set; }
        
        public uploaderClass(string filename, string portname, ArduinoModel model)
        {
            this.filename = filename;
            this.portname = portname;
            this.model = model;
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
    } 
}