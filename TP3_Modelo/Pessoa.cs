using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_Modelo
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }

        public int CalcularDiasProximoAniversario()
        {
            //TODO: Programar método.
            DateTime aniversario = new DateTime(DateTime.Now.Year, DataNascimento.Month, DataNascimento.Day);
            DateTime hoje = DateTime.Now;
            TimeSpan numeroDias = aniversario - hoje;

            if (numeroDias.Days < 0)
            {
                // O aniversário já passou.
                // Calcular quanto tempo falta para o aniversário do ano que vem.
                DateTime proxAniversario = aniversario.AddYears(1);
                numeroDias = proxAniversario - hoje;
            } else if (numeroDias.Days == 0 && 
                        numeroDias.Hours <= 0 && 
                        numeroDias.Minutes <= 0 && 
                        numeroDias.Seconds <= 0 && 
                        numeroDias.Milliseconds <= 0)
            {
                // Número de dias igual a zero = falta menos de um dia inteiro
                // Número de dias igual a zero e o número de horas menor ou igual a zero = 
                // O aniversário é hoje.
                return 0;
            }
            var resultado = numeroDias.Days + 1;
            return resultado;
        }

        public string Parabens()
        {
                return $"Parabéns, {this.Nome}, " +
                       $"pelos seus {DateTime.Now.Year - DataNascimento.Year} anos. ";
        }
    }
}
