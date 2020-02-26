using Responsive_app.ViewModel.AppUIBasics.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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

        public event PropertyChangedEventHandler PropertyChanged;

        public ParametrizedRelayCommand Number { get; set; }
        public ParametrizedRelayCommand Operation { get; set; }
        public ParametrizedRelayCommand Function { get; set; }
        public RelayCommand Reset { get; set; }
        public RelayCommand Point { get; set; }
        public RelayCommand Sign { get; set; }
        public RelayCommand Result { get; set; }
        public MainViewModel()
        {
           /* Number = new ParametrizedRelayCommand(
                (param) => );*/
        }
    }
}
