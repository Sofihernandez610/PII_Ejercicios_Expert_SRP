using System;
using System.Text;

namespace Library
{
    public class Paciente
    {
        public string Name {get; set;}
        public string Telefono {get; set;}
        public string Cedula {get;set;}
        public string Edad {get; set;}
        

        public Paciente (string name, string telefono, string edad, string cedula)
        {
            this.Name= name;
            this.Telefono = telefono;
            this.Edad= edad;
            this.Cedula=cedula;
        }

       

        


    }
}