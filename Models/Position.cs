using System;
using System.Collection.Generic;

namespace Library.Models
{
    public class Position
     {
       public int ID {get;set;} 
       public string PositionName {get;set;}
       public string Responsibilities {get;set;}
       public string Requirements {get;set;}
       public DateTime BirthDate {get;set;}
       public decimal Salary {get;set;}

       public List<Employee> Employees {get;} = new List<Employee>();
      }
}
