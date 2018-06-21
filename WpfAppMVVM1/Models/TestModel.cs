using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace WpfAppMVVM1.Models
{
    class TestModel : BindableBase
    {
        public string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                SetProperty(ref _name, value);
            }
        }


        public string _qualification;
        public string Qualification
        {
            get
            {
                return _qualification;
            }
            set
            {
                SetProperty(ref _qualification, value);
            }
        }

        public string _message;
        public string Message
        {
            get
            {
                return _message;
            }
            set
            {
                SetProperty(ref _message, value);
            }
        }
    }    
}
