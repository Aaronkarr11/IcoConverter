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

    }
}
