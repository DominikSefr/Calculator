using Responsive_app.ViewModel.AppUIBasics.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Responsive_app.ViewModel
{
    class MainViewModel : INotifyPropertyChanged
    {
        private string _input;
        private string _storedValue;
       // private CalculatorOperation _operation = CalculatorOperation.None;
        private string _message;
        public ParametrizedRelayCommand Number { get; set; }
        public ParametrizedRelayCommand Operation { get; set; }
        public ParametrizedRelayCommand Function { get; set; }
        public RelayCommand Reset { get; set; }
        public RelayCommand Point { get; set; }
        public RelayCommand Sign { get; set; }
        public RelayCommand Result { get; set; }
        public string TextResult
        {
            get => _message;
            set
            {
                _message = value;
                NotifyPropertyChanged();
            }
        }
        public MainViewModel()
        {
            Number = new ParametrizedRelayCommand(
                 (param) =>
                    TextResult += param
                 );
            Reset = new RelayCommand(
                () =>
                {
                    TextResult = "";
                }
                );
            Point = new RelayCommand(
                () =>
                {
                    if (!TextResult.Contains(".") && TextResult.Length > 0)
                    {
                        TextResult += "."; 
                    }
                }
                );
            Sign = new RelayCommand(
                () =>
                {
                    TextResult = Convert.ToString(Convert.ToDouble(TextResult) * -1);
                }
                );

        }
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
