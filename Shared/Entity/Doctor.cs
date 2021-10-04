using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;


namespace Home2Med.Shared.Entity
{
    public class Doctor
    {
       public int Id {get;set;}
       [Required(ErrorMessage ="El campo {0} es requerido")]
       public string Name{get;set;}
       public int DocumentType { get; set; }
       public string Document { get; set; }
       public int Gender { get; set; }   
       public string Phone {get;set;}
       public int Speciality {get;set;}
       public string Photo { get; set; }
       public bool Status {get;set;}
    }
   /*public enum DoctorDocumentType
   {
      CedulaCiudadania  = 0,
      CedulaExtranjeria = 1,
      Pasaporte = 2
   }
   public enum DoctorGender
   {
      Femenino = 0,
      Masculino = 1
   }
   public enum DoctorSpeciality
   {
      MedicinaGeneral = 0,
      Anestesiólogo = 1,
      Cardiólogo = 2
   }*/


}    
