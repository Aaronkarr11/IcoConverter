using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.IO;
using System.Windows.Input;

namespace IcoConverter
{

    public partial class IcoConverterViewModel: ObservableObject
    {
        private IConverterLogic _converterLogic;
        public ICommand ConvertCommand { get; set; }

        [ObservableProperty]
        public IcoConverterModel _myModel;

        public IcoConverterViewModel(IConverterLogic converterLogic)
        {
            _myModel = new IcoConverterModel();
            _converterLogic = converterLogic;
        }


        [RelayCommand]
        private void ConvertIcon()
        {
            try
            {
                string newFilePath = String.Empty;

                var fileType = Helpers.DetermineType(MyModel.InputPath);
                if (fileType == "Other") 
                {
                    MyModel.MyMessage = $"Please make sure the file is a jpg or png";
                }
                else
                {
                    var newFile = _converterLogic.ConvertImageToIcon(MyModel.InputPath, Convert.ToInt32(MyModel.Size), fileType);
                    newFilePath = $"{MyModel.OutputPath}\\{DateTime.Now.ToString("yyyyMMddhhmmss")}.ico";
                    File.WriteAllBytes(newFilePath, newFile);
                    MyModel.OutputPath = "All Done!";
                    MyModel.MyMessage = "All Done!";
                }
            }
            catch (Exception ex)
            {
                MyModel.MyMessage = $"Error: {ex.Message}";
            }
        }
    }
}
