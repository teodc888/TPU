using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    public class Persona
    {
        private string nombre;
        private int edad;
        private string sexo;
        private float peso;
        private float altura;

        private const int PESO_IDEAL_BAJO = -1;
        private const int PESO_IDEAL_NORMAL = 0;
        private const int SOBREPESO = 1;

        public Persona(string nombre, int edad, string sexo, float peso, float altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.peso = peso;
            this.altura = altura;
        }

        public int CalcularIMC()
        {
            float imc = peso / (altura * altura);

            if (imc < 20)
            {
                return PESO_IDEAL_BAJO;
            }
            else if (imc >= 20 && imc <= 25)
            {
                return PESO_IDEAL_NORMAL;
            }
            else
            {
                return SOBREPESO;
            }
        }

        public bool EsMayorDeEdad()
        {
            return edad >= 21;
        }
    }
}
