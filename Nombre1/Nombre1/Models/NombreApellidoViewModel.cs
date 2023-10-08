using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Nombre1.Models
{
    public class NombreApellidoViewModel : INotifyPropertyChanged
    {
        private NombreApellidoModel _nombreApellidoModel;

        public NombreApellidoModel NombreApellidoModel
        {
            get { return _nombreApellidoModel; }
            set
            {
                _nombreApellidoModel = value;
                OnPropertyChanged(nameof(NombreApellidoModel));
            }
        }

        public string NombreCompleto
        {
            get { return $"{NombreApellidoModel.Nombre} {NombreApellidoModel.Apellido}"; }
        }

        public ICommand CombinarNombresCommand { get; }

        public NombreApellidoViewModel()
        {
            NombreApellidoModel = new NombreApellidoModel();
            CombinarNombresCommand = new RelayCommand(CombinarNombres);
        }

        private void CombinarNombres()
        {
            OnPropertyChanged(nameof(NombreCompleto));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
