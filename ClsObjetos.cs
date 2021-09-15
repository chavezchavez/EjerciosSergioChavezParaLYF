using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioSergioChavez
{
    class ClsObjetos
    {
    }
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Resultado
    {
        public string user { get; set; }
        public string debt { get; set; }
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class ResultadoInvalido
    {
        public string message { get; set; }
    }

    public class Persona
    {
        public string account { get; set; }
        public decimal paid { get; set; }
    }





}
