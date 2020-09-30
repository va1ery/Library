using System;
using System.Collection.Generic;

namespace Library.Models
{
    public class Employee
     {
       public int ID {get;set;} 
       public string LastName {get;set;}
       public string FirstName {get;set;}
       public DateTime BirthDate {get;set;}
       public int PositionID {get;set;}
   // ...       
       public ICollection<Position> Positions  {get;set;}
      }
}
