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
        private bool _result;
        private int _oper;
        private string _storedValue;
        private string _message;
        private bool _oper1;
        private bool _number;
        public ParametrizedRelayCommand Number { get; set; }
        public ParametrizedRelayCommand Operation { get; set; }
        public ParametrizedRelayCommand Function { get; set; }
        public RelayCommand Reset { get; set; }
        public RelayCommand Point { get; set; }
        public RelayCommand Sign { get; set; }
        public RelayCommand Result { get; set; }
        public bool CNumber
        {
            get => _number;
            set
            {
                _number = value;
                NotifyPropertyChanged();
            }
        }
        public bool CResult
        {
            get => _result;
            set
            {
                _result = value;
                NotifyPropertyChanged();
            }
        }
        public bool Oper
        {
            get => _oper1;
            set
            {
                _oper1 = value;
                NotifyPropertyChanged();
            }
        }
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
            CNumber = true;
            Oper = true;
            Number = new ParametrizedRelayCommand(
                (param) => 
                {
                    TextResult += param;
                    CResult = true;
                });
            Result = new RelayCommand(
                () =>
                {
                    if(_oper == 1)
                    {
                        TextResult = Convert.ToString(Convert.ToDouble(_storedValue) + Convert.ToDouble(TextResult));
                        _storedValue = "";
                        Oper = true;
                        CResult = false;
                        CNumber = true;
                        _oper = 0;
                    }
                    if (_oper == 2)
                    {
                        TextResult = Convert.ToString(Convert.ToDouble(_storedValue) - Convert.ToDouble(TextResult));
                        _storedValue = "";
                        Oper = true;
                        CResult = false;
                        CNumber = true;
                        _oper = 0;
                    }
                    if (_oper == 3)
                    {
                        TextResult = Convert.ToString(Convert.ToDouble(_storedValue) * Convert.ToDouble(TextResult));
                        _storedValue = "";
                        Oper = true;
                        CResult = false;
                        CNumber = true;
                        _oper = 0;
                    }
                    if (_oper == 4)
                    {
                        TextResult = Convert.ToString(Convert.ToDouble(_storedValue) / Convert.ToDouble(TextResult));
                        _storedValue = "";
                        Oper = true;
                        CResult = false;
                        CNumber = true;
                        _oper = 0;
                    }
                    if (_oper == 5)
                    {
                        TextResult = Convert.ToString(Convert.ToDouble(_storedValue) * Convert.ToDouble(_storedValue));
                        _storedValue = "";
                        Oper = true;
                        CResult = false;
                        CNumber = true;
                        _oper = 0;
                    }
                    if (_oper == 6)
                    {
                        TextResult = Convert.ToString(Math.Sqrt(Convert.ToDouble(_storedValue)));
                        _storedValue = "";
                        Oper = true;
                        CResult = false;
                        CNumber = true;
                        _oper = 0;
                    }
                    if (_oper == 7)
                    {
                        TextResult = Convert.ToString(Math.Log10(Convert.ToDouble(_storedValue)));
                        _storedValue = "";
                        Oper = true;
                        CResult = false;
                        CNumber = true;
                        _oper = 0;
                    }
                    if (_oper == 8)
                    {
                        TextResult = Convert.ToString(Convert.ToDouble(_storedValue) * Convert.ToDouble(_storedValue) * Convert.ToDouble(_storedValue));
                        _storedValue = "";
                        Oper = true;
                        CResult = false;
                        CNumber = true;
                        _oper = 0;
                    }
                });
            Reset = new RelayCommand(
                () =>
                {
                    TextResult = "0";
                    _storedValue = "0";
                    Oper = true;
                    CResult = true;
                    CNumber = true;
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
            Operation = new ParametrizedRelayCommand(
                (param) => 
                {
                    _storedValue = TextResult;
                    if (Convert.ToString(param) == "1")
                    {
                        _oper = 1;
                        Oper = false;
                        TextResult = "";
                        param = "0";
                        CResult = false;
                        CNumber = true;
                    }
                    if (Convert.ToString(param) == "2")
                    {
                        _oper = 2;
                        Oper = false;
                        TextResult = "";
                        param = "0";
                        CResult = false;
                        CNumber = true;
                    }
                    if (Convert.ToString(param) == "3")
                    {
                        _oper = 3;
                        Oper = false;
                        TextResult = "";
                        param = "0";
                        CResult = false;
                        CNumber = true;
                    }
                    if (Convert.ToString(param) == "4")
                    {
                        _oper = 4;
                        Oper = false;
                        TextResult = "";
                        param = "0";
                        CResult = false;
                        CNumber = true;
                    }
                }
                );
            Function = new ParametrizedRelayCommand(
                (param) =>
                {
                    _storedValue = TextResult;
                    if (Convert.ToString(param) == "5")
                    {
                        _oper = 5;
                        Oper = false;
                        TextResult = "";
                        param = "0";
                        CResult = true;
                        CNumber = false;
                    }
                    if (Convert.ToString(param) == "6")
                    {
                        _oper = 6;
                        Oper = false;
                        TextResult = "";
                        param = "0";
                        CResult = true;
                        CNumber = false;
                    }
                    if (Convert.ToString(param) == "7")
                    {
                        _oper = 7;
                        Oper = false;
                        TextResult = "";
                        param = "0";
                        CResult = true;
                        CNumber = false;
                    }
                    if (Convert.ToString(param) == "8")
                    {
                        _oper = 8;
                        Oper = false;
                        TextResult = "";
                        param = "0";
                        CResult = true;
                        CNumber = false;
                    }
                });

        }
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
