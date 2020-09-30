using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Library.Models
{
    public class Employee
     {
       public int ID {get;set;} 
       public string LastName {get;set;}
       public string FirstName {get;set;}
       public DateTime BirthDate {get;set;}
       public int PositionID {get;set;}
       public Position Positions { get; set; }
   // ...       
   //    public ICollection<Position> Positions  {get;set;}
      }
}
