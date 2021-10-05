using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    [Serializable]
    public class Rooms
    {
       
        public int Id { get; set; }
        
        public List<RoomCat> Categories { get; set; }
       
        public List<ResInf> ResInfo { get; set; }
       
        public bool IsBooked { get { if (ResInfo.Count() == 0) { return false; } else { return true; } } }
       
        public Rooms(int Id)
        {
            this.Id = Id;
            Categories = new List<RoomCat>();
            ResInfo = new List<ResInf>();

        }
        public Rooms() { }




    }
}
