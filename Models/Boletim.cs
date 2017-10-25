using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Escola.Models
{
    public class Boletim : INotifyPropertyChanged
    {
        public Boletim()
        {
            
        }

        private int idBoletim, ano, idInstituicao, idCurso, idAluno;

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
        public int Ano
        {
            get
            {
                return ano;
            }
            set
            {
                ano = value;
                // Informar a alteração na propriedade
                OnPropertyChanged();
            }
        }
        public int IdInstituicao
        {
            get
            {
                return idInstituicao;
            }
            set
            {
                idInstituicao = value;
                // Informar a alteração na propriedade
                OnPropertyChanged();
            }
        }
        public int IdCurso
        {
            get
            {
                return idCurso;
            }
            set
            {
                idCurso = value;
                // Informar a alteração na propriedade
                OnPropertyChanged();
            }
        }
        public int IdAluno
        {
            get
            {
                return idAluno;
            }
            set
            {
                idAluno = value;
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
