using System;
using System.Collections.Generic;
using System.Text;
using ReactiveUI;
using lab_5.Models;
namespace lab_5.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            InputText = "Hello!";
            RegexInput = ".*";
        }

        string _inputText;
        public string InputText
        {
            set
            {
                this.RaiseAndSetIfChanged(ref _inputText, value);
                TreatmentRegex();
            }
            get
            {
                return _inputText;
            }
        }
       
       
        string outputText;
        public string OutputText
        {
            set
            {
                this.RaiseAndSetIfChanged(ref outputText, value);
            }
            get
            {
                return outputText;
            }
        }
        public string Path
        {     set
            {
                try
                {
                    InputText = lab_5.Models.WorkToFail.ReadFromFile(@value);
                }
                catch
                {
                    OutputText = "File Error";
                }
            }
        }

        public string PathWrite
        {
            set
            {
                try
                {
                    lab_5.Models.WorkToFail.WriteToFail(@value, OutputText);
                }
                catch
                {
                    OutputText = "File Error";
                }
            }
        }
        string regexInput;
        public string RegexInput
        {
            set
            {
                regexInput = value;
                TreatmentRegex();
            }
            get
            {
                return regexInput;
            }
        }


        public void TreatmentRegex()
        {
            OutputText=lab_5.Models.RegularExpression.ExpressionProcessing(InputText, RegexInput);
        }

    }
}
