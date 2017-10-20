using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmBase
{
    public class Photos
    {
        public long PhotoId { set; get; }
        public string PhotoName { set; get; }
        public byte[] PhotoData { set; get; }

        public Photos() { }

        public Photos(long photoId,
                       string photoName,
                        byte[] photoData)
        {
            PhotoName = photoName;
            PhotoId = photoId;
            PhotoData = photoData;
        }

        public Photos(string fileName)
        {
            PhotoName = Path.GetFileName(fileName);
            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                PhotoData = new byte[fs.Length];
                fs.Read(PhotoData, 0, PhotoData.Length);
            }
        }
    }
}
