using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HomeWork2
{

    
    [Serializable]
    public sealed class Context
    {
        
        public string Path { get; set; }
       
        public List<Users> Users { get; set; }
        
        public List<ResInf> ResInfo { get; set; }
        
        public List<RoomCat> RoomCategories { get; set; }
       
        public List<Rooms> Rooms { get; set; }
        
        public Context(string Path)
        {
            this.Path = this.Path;
            Users = new List<Users>();
            ResInfo = new List<ResInf>();
            RoomCategories = new List<RoomCat>();
            Rooms = new List<Rooms>();
            if (!File.Exists(this.Path))
            {
                using (File.Create(this.Path)) { };
            }
        }
        public Context()
        {

        }
        
        public Context Refresh()
        {
            if (!File.Exists(Path))
            {
                throw new Exception("Не найден файл");
            }
            using (var File = new FileStream(Path, FileMode.Open, FileAccess.Read))
            {
                XmlSerializer ContextSer = new XmlSerializer(typeof(Context));
                try
                {
                    return (Context)ContextSer.Deserialize(File);
                }
                catch (Exception)
                {

                    throw new Exception("Файл пуст");
                }

            }
        }
        
        public void SaveChanges()
        {
            if (!File.Exists(Path))
            {
                throw new Exception("Не найден файл");
            }
            using (var File = new FileStream(Path, FileMode.Create, FileAccess.Write))
            {
                XmlSerializer ContextSer = new XmlSerializer(typeof(Context));
                ContextSer.Serialize(File, this);
            }
        }

    }
}
