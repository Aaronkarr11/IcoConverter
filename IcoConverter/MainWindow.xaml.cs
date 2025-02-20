using System.Diagnostics.Metrics;
using System.IO;
using System.Net.NetworkInformation;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media.Animation;

namespace IcoConverter
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string? _inputURL;
        private string? _outputURL;
        private IConverterLogic _converterLogic;
        public IcoConverterViewModel _icoConverterViewModel;

        public MainWindow()
        {
            _icoConverterViewModel = new IcoConverterViewModel();
            _icoConverterViewModel.Message = "Tst";
            DataContext = _icoConverterViewModel;
            _converterLogic = new ConverterLogic();
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _inputURL = inutPath.Text;
                _outputURL = outputPath.Text;
                string newFilePath = String.Empty;
                var newFile = _converterLogic.ConvertImageToIcon(_inputURL, 64);
                newFilePath = $"{_outputURL}\\{DateTime.Now.ToString("yyyyMMddhhmmss")}.ico";
                File.WriteAllBytes(newFilePath, newFile);
                _icoConverterViewModel.Message = "All Done!";
            }
            catch (Exception ex)
            {
                _icoConverterViewModel.Message = $"Error: {ex.Message}";
            }
        }


        private void inutPath_GotFocus(object sender, RoutedEventArgs e)
        {
            inutPath.Text = "";
        }

        private void outputPath_GotFocus(object sender, RoutedEventArgs e)
        {
            outputPath.Text = "";
        }
    }




}