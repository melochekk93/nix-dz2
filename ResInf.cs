using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    [Serializable]
    public class ResInf
    {
        public DateTime Start { get; set; }

        public DateTime End { get; set; }
        
        public Users user { get; set; }
        
        public Rooms room { get; set; }
        
        public override string ToString()
        {
            return ($"Номер {room.Id}, забронирован постояльцем {user.Name} {user.Patronymic} {user.Surname} c {Start} до {End}");
        }
        
        public ResInf(DateTime StartReservation, DateTime EndReservation, Users user, Rooms room)
        {
            this.Start = Start;
            this.End = End;
            this.user = user;
            this.room = room;
        }
        public ResInf()
        {
        }
    }
}
