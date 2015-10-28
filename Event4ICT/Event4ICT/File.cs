using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event4ICT
{
    class File
    {
        private string name;
        private string fileType;
        private int fileID;
        private string filePath;

        public int FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }
        

        public int FileID
        {
            get { return fileID; }
            set { fileID = value; }
        }
        

        public string FileType
        {
            get { return fileType; }
            set { fileType = value; }
        }
        

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public File(int fileID, string name, string fileType, string filePath)
        {
            this.fileID = fileID;
            this.name = name;
            this.fileType = fileType;
            this.filePath = filePath;
        }

        public File(int fileID, string name, string fileType, string filePath)
        {
            this.fileID = fileID;
            this.name = name;
            this.fileType = fileType;
            
        }
    }
}
