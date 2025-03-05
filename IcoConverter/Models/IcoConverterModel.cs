using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;

namespace IcoConverter
{

    public class IcoConverterModel: ViewModelBase
    {
        public IcoConverterModel()
        {
            IcoSize = Helpers.BuildSizes();
        }


        public List<string> IcoSize { get; set; }
        public string Size { get; set; }
        public string InputPath { get; set; }
        public string OutputPath { get; set; }

        private string _MyMessage;
        public string MyMessage
        {
            get { return _MyMessage; }
            set { SetProperty(ref _MyMessage, value); }
        }

        //private string _Size;
        //public string Size
        //{
        //    get { return _Size; }
        //    set { SetProperty(ref _Size, value); }
        //}

        //private string _InputPath;
        //public string InputPath
        //{
        //    get { return _InputPath; }
        //    set { SetProperty(ref _InputPath, value); }
        //}

        //private string _OutputPath;
        //public string OutputPath
        //{
        //    get { return _OutputPath; }
        //    set { SetProperty(ref _OutputPath, value); }
        //}


        //private string _MyMessage;
        //public string MyMessage
        //{
        //    get { return _MyMessage; }
        //    set { SetProperty(ref _MyMessage, value); }
        //}


    }
}
