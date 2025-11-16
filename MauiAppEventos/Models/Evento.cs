using System.ComponentModel;

namespace MauiAppEventos
{
    public class Evento : INotifyPropertyChanged
    {
        private DateTime dataInicio = DateTime.Now;
        private DateTime dataTermino = DateTime.Now.AddDays(1);

        public string Nome { get; set; }
        public int NumeroParticipantes { get; set; }
        public string Local { get; set; }
        public double CustoPorParticipante { get; set; }

        public DateTime DataInicio
        {
            get => dataInicio;
            set
            {
                if (dataInicio != value)
                {
                    dataInicio = value;
                    // Garante que a data de término seja sempre >= início
                    if (dataTermino < dataInicio)
                        DataTermino = dataInicio.AddDays(1);

                    OnPropertyChanged(nameof(DataInicio));
                }
            }
        }

        public DateTime DataTermino
        {
            get => dataTermino;
            set
            {
                if (dataTermino != value)
                {
                    dataTermino = value;
                    OnPropertyChanged(nameof(DataTermino));
                }
            }
        }

        public int DuracaoEmDias => (DataTermino - DataInicio).Days + 1;
        public double CustoTotal => NumeroParticipantes * CustoPorParticipante;

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}