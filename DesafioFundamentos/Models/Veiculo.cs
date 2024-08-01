using System.Text.RegularExpressions;
using DesafioFundamentos.Exceptions;

namespace DesafioFundamentos.Models
{
    public class Veiculo
    {
        private string _placa;
        public string Placa
        {
            get
            {
                return _placa.ToUpper();
            }

            set
            {
                if (!ValidarPlaca(value))
                {
                    throw new InvalidArgumentException();
                }
                _placa = value;

            }
        }
        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }

        public Veiculo() { }
        public Veiculo(string placa)
        {
            Placa = placa;
        }

        public static bool ValidarPlaca(string placa)
        {
            string padrao = @"^[A-Z]{3}-\d{4}$";
            Regex regex = new Regex(padrao);
            return regex.IsMatch(placa.ToUpper());
        }
    }
}