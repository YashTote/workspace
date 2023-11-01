using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


namespace dotnetapp.Models
{
    public class Dealer
    {
       public int ID{get;set;}
       public string Name{get;set;}
    //    [Datatype(typeof(string))]
       public DateTime RegistrationDate{get;set;}

       public string AutoPartName{get;set;}
       public string Manufacturer{get;set;}
       public string MobileNumber{get;set;}
       public string Email{get;set;}
       public string Description{get;set;} 
    }
}