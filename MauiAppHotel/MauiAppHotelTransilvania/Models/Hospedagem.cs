using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppHotelTransilvania.Models
{
    
    public class Hospedagem
    {
        Quarto _quartoselecionado;
        public Quarto QuartoSelecionado
        {
            get => _quartoselecionado;
            set
            {
                if (value == null)
                {
                    throw new Exception("Selecione um quarto");
                }
                _quartoselecionado = value;
            }

        }
        public int QntAdultos { get; set; }
        public int QntCriancas { get; set; }
        public DateTime DataCheckIn { get; set; }
        public DateTime DataCheckOut { get; set; }
        public int Estadia
        {
            get => DataCheckOut.Subtract(DataCheckIn).Days;
        }
        public double ValorTotal
        {
            get
            {
                double valor_adultos = QntAdultos * QuartoSelecionado.ValorDiariaAdulto;
                double valor_criancas = QntCriancas * QuartoSelecionado.ValorDiariaCrianca;

                double total = (valor_adultos + valor_criancas) * Estadia;

                return total;
            }
        }
    }
}
