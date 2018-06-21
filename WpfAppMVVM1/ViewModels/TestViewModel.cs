using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppMVVM1.Models;
using Prism.Mvvm;
using System.Windows.Input;
using Prism.Commands;

namespace WpfAppMVVM1.ViewModels
{
    class TestViewModel : BindableBase
    {
        private TestModel testModel;        

        public ICommand iclickcommand
        {
            get;
            set;
        }

        public TestViewModel()
        {
            testModel = new TestModel();             
            TestModel1("SAI","CSE");// testModel = new TestModel("SAI","CSE"); 

            //testModel1 = (new TestModel() { Name = "", Qualification = "" });
            
            iclickcommand = new DelegateCommand(ClickedMethod);
        }     

        public TestModel TestModel
        {
            get
            {
                return testModel;
            }
            set
            {
                SetProperty(ref testModel, value);
            }
        }

        private void ClickedMethod()
        {
            TestModel.Message = "You Have Clicked the button";
        }

        public void TestModel1(string Names, string Qualifications)
        {
            try
            {
                if (Names != null)
                {
                    testModel.Name = Names;
                    testModel.Qualification = Qualifications;
                }
                else
                {
                    //return null;
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

    }

}
