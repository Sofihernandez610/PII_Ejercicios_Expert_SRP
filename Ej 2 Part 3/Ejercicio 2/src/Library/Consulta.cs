using System;
using System.Text;

namespace Library
{
    public class Consulta
    {

        public Doctor Doctor {get;set;}
        public FechayLugar FechayLugar {get; set;}

        public Paciente Paciente{get;set;}
        
        static int ID;
        
        public Consulta(Paciente paciente, FechayLugar fechayLugar, Doctor doctor)
        {
            this.Paciente=paciente;
            this.FechayLugar= fechayLugar;
            this.Doctor=doctor;
            ID++;
        }

        

    }
}
