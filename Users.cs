using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    
    [Serializable]
    public class Users
    {
       
        public int Id { get; set; }
       
        public string Name { get; set; }
       
        public string Surname { get; set; }
       
        public string Patronymic { get; set; }
       
        public string PassportID { get; set; }
        
        public DateTime DOB { get; set; }
       
        public List<ResInf> ReservationInfoo { get; set; }
       
        public Users(string Name, string Surname, string Patronymic, string PassportID, DateTime DOB)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Patronymic = Patronymic;
            this.PassportID = PassportID;
            this.DOB = DOB;
            ReservationInfoo = new List<ResInf>();
        }
        public Users()
        {
        }
    }
}
