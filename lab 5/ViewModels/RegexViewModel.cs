using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;
namespace lab_5.ViewModels
{
    class RegexViewModel : ViewModelBase
    {
        string regexInput;
        public  string RegexInput
        {
            set
            {
                this.RaiseAndSetIfChanged(ref regexInput, value);
            }
            get
            {
                return regexInput;
            }
        }
    }
}
