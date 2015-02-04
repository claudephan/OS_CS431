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
        public string FileText;

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
            FileName = Ext;
        }
        public string getFileExt()
        {
            return FileExt;
        }

        public void setFileText(string txt)
        {
            FileName = txt;
        }
        public string getFileText()
        {
            return FileText;
        }

    }
}
