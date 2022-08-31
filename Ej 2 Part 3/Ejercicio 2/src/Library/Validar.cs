using System;
using System.Text;

namespace Library
{
    public class Validar
    {
    public static bool ValidarConsulta (Doctor doctor, Paciente paciente, FechayLugar fechaylugar)
    {
        return ((ValidarDoctor(doctor)) && (ValidarFechayLugar(fechaylugar)) && ValidarPaciente(paciente));
    

    }
    public static bool ValidarDoctor (Doctor doctor)
    {
        if ((string.IsNullOrEmpty(doctor.Name)) || (string.IsNullOrEmpty(doctor.Especialidad)))
        {
            return false;
        }
        else{
            return true;
        }

    }

    public static bool ValidarPaciente (Paciente paciente)
    {
        if ((string.IsNullOrEmpty(paciente.Name)) || (string.IsNullOrEmpty(paciente.Edad)) || (string.IsNullOrEmpty(paciente.Telefono)) || (string.IsNullOrEmpty(paciente.Cedula)))
        {
            return false;
        }
        else{
            return true;
        }

    }

    public static bool ValidarFechayLugar (FechayLugar fechayLugar)
    {
        if ((string.IsNullOrEmpty(fechayLugar.Lugar)) || (string.IsNullOrEmpty(fechayLugar.Fecha)))
        {
            return false;
        }
        else{
            return true;
        }

    }


    }

}
