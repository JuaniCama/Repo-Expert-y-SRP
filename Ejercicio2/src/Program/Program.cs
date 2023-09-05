using System;
using CrearAppointment;

namespace CrearAppointment
{
    class Program
    {
        static void Main()
        {
            // string appointmentResult = AppointmentService.CreateAppointment("Steven Jhonson", "986782342", "5555-555-555", DateTime.Now, "Wall Street", "Armand");
            // Console.WriteLine(appointmentResult);

            // string appointmentResult2 = AppointmentService.CreateAppointment("Ralf Manson", "", "5555-555-555", DateTime.Now, "Queen Street", "");
            // Console.WriteLine(appointmentResult2);

            Patient paciente1 = new Patient("Steven Jhonson", "986782342", "5555-555-555");
            Patient paciente2 = new Patient("Ralf Manson", "", "5555-555-555");
            Doctor doctor1 = new Doctor("Armand");
            Doctor doctor2 = new Doctor("");
            string AppointmentSet1 = AppointmentService.CreateAppointment(paciente1,DateTime.Now, "Wall Street", doctor1);
            Console.WriteLine(AppointmentSet1);
            string AppointmentSet2 = AppointmentService.CreateAppointment(paciente2,DateTime.Now, "Queen Street", doctor2);
            Console.WriteLine(AppointmentSet2);
        }
    }
}
