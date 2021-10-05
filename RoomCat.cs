using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    [Serializable]
    public class RoomCat
    {
        
        public int Id { get; set; }
      
        public string Name { get; set; }
        
        public List<Rooms> Rooms { get; set; }
       
        public RoomCat()
        {

        }
       
        public RoomCat(string Name)
        {
            this.Id = Id;
            this.Name = Name;
            Rooms = new List<Rooms>();
        }
    }
}
