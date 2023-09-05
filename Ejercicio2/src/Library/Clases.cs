using System;
using CrearAppointment;

namespace CrearAppointment
{

        public class Patient{
        public string Name{get;set;}
        public string Id{get;set;}
        public string PhoneNumber{get;set;}

        public Patient(string name,string id,string phoneNumber){
            this.Name = name;
            this.Id = id;
            this.PhoneNumber = phoneNumber;
        }
    }

    public class Appointment{
        public Patient patient;
        public DateTime date {get;set;}
        public string AppointmentPlace{get;set;}
        public Doctor doctor;
    }

    public class Doctor{
        public string DoctorName{get;set;}

        public Doctor(string doctorName){
            this.DoctorName = doctorName;
        }
    }
}