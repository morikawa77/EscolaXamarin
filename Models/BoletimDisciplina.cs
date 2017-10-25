using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Escola.Models
{
    public class BoletimDisciplina : INotifyPropertyChanged
    {
        public BoletimDisciplina()
        {
            
        }

        private decimal nota;
        private string periodo;
        private int idBoletim, idDisciplina;

        public decimal Nota
        {
            get
            {
                return nota;
            }
            set
            {
                nota = value;
                // Informar a alteração na propriedade
                OnPropertyChanged();
            }
        }
        public string Periodo
        {
            get
            {
                return periodo;
            }
            set
            {
                periodo = value.Substring(0,50);
                // Informar a alteração na propriedade
                OnPropertyChanged();
            }
        }
        public int IdBoletim
        {
            get
            {
                return idBoletim;
            }
            set
            {
                idBoletim = value;
                // Informar a alteração na propriedade
                OnPropertyChanged();
            }
        }
        public int IdDisciplina
        {
            get
            {
                return idDisciplina;
            }
            set
            {
                idDisciplina = value;
                // Informar a alteração na propriedade
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        //Método para registrar a alteração da propriedade
        private void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
