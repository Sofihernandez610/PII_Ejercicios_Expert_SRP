using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            FechayLugar fecha1= new FechayLugar("17/8","Arocena");
            Paciente paciente1= new Paciente("Steven Jhonson","099555656","17","5555-555-555");
            Doctor doctor1 = new Doctor("Steven Jhonson", "Medicina General");
            bool isvalid = Validar.ValidarConsulta(doctor1, paciente1, fecha1);
            if (isvalid==true)
            {
                Consulta consult= new Consulta(paciente1,fecha1,doctor1);
                Console.WriteLine("se creo correctamente la consulta");
            }

        

            
        }
    }
}
