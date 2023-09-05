using System;
using System.Text;
using CrearAppointment;

namespace CrearAppointment
{

//Haría falta un contenedor de información para para alojar los datos. Creando distintas clases se podría llegar a un código más legible y fácil de cambiar.
//Por otra parte, si se requiriera ver cierto dato de la cita, paciente o doctor, se podría acceder al mismo haciendo referencia al objeto. Estos fueron agregados
//en un archivo nuevo "Clases.cs"

    public class AppointmentService
    {
        public static string CreateAppointment(Patient patient, DateTime date, string appoinmentPlace, Doctor doctor)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(patient.Name))
            {
                stringBuilder.Append("Unable to schedule appointment, 'name' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(patient.Id))
            {
                stringBuilder.Append("Unable to schedule appointment, 'id' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(patient.PhoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, 'phone number' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appoinment place' is required\n");
                isValid = false;
            }


            if (string.IsNullOrEmpty(doctor.DoctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment scheduled");
            }

            return stringBuilder.ToString();
        }

    }
}
