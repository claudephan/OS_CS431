using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS_CS431
{
    class File
    {
        public string FileName;
        public string FileExt;
        public List<string> FileText;
        public string FileDate;
        public string FileSize;

        public File(string FileName, string FileExt, List<string> FileText)
        {
            this.FileName = FileName;
            this.FileExt = FileExt;
            this.FileText = FileText;
            this.FileSize = "69kb";
            this.FileDate = Cosmos.Hardware.RTC.Month + "/" + Cosmos.Hardware.RTC.DayOfTheMonth + "/" + Cosmos.Hardware.RTC.Year;
        }

        public string getFileSize()
        {
            return FileSize;
        }
        public string getFileDate()
        {
            return FileDate;
        }
        
        
        public void setFileName(string FN)
        {
            FileName = FN;
        }
        public string getFileName()
        {
            return FileName;
        }

        public void setFileExt(string Ext)
        {
            FileExt = Ext;
        }
        public string getFileExt()
        {
            return FileExt;
        }

        public void setFileText(List<string> txt)
        {
            FileText = txt;
        }
        public List<string> getFileText()
        {
            return FileText;
        }

    }
}
