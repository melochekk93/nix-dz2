using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    interface ICRUD
    {
       
        void AddRooms(Rooms room);
        
        IEnumerable<Rooms> GetRooms();
       
        Rooms GetRooms(int Id);
        
        void EditRooms(Rooms room);
        
        void DeleteRooms(int Id);
      

        void AddUsers(Users user);
        
        IEnumerable<Users> GetUsers();
        
        Users GetUser(int Id);
        
        void EditUsers(Users user);
       
        void DeleteUsers(int Id);
       

       
        void AddRoomCategory(RoomCat roomCategory);
        
        IEnumerable<RoomCat> grcat();
        
        RoomCat GetRoomCategory(int Id);
        
        void EditRoomCategory(RoomCat roomCategory);
        
        void DeleteRoomCategory(int Id);
      

        
        void AddResirvationInfo(ResInf reservationInfo);
       
        IEnumerable<ResInf> GetResInfo();
       
        ResInf GetResInf(int Id);
        
        void EditReservationInfo(ResInf reservationInfo);
        
        void DeleteReservationInfo(int Id);
        
    }
}
