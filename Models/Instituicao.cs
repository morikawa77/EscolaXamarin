using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Escola.Models
{
    public class Instituicao : INotifyPropertyChanged
    {
		public Instituicao()
		{
			
		}

        private int id;
        private string nome;

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                // Informar a alteração na propriedade
                OnPropertyChanged();
            }
        }
        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value.Substring(0, 50);
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
