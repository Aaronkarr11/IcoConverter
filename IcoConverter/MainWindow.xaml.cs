using System.Diagnostics.Metrics;
using System.IO;
using System.Windows;

namespace IcoConverter
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _inputURL;
        private string _outputURL;
        private IConverterLogic _converterLogic;

        public MainWindow()
        {
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
                //byte[] bytes = File.ReadAllBytes(_inputURL);
                var newFile = _converterLogic.ConvertImageToIcon(_inputURL, 64);
                newFilePath = $"{_outputURL}\\{DateTime.Now.ToString("yyyyMMddhhmmss")}.ico";
                //_converterLogic.ConvertImageToIcon(_inputURL, newFilePath);
                File.WriteAllBytes(newFilePath, newFile);
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        //private void RenderLoadingBar(int total, int current)
        //{
        //    progressBar1.PerformStep();
        //    if (total == current)
        //    {
        //        lblOutput.Text = "All Done! 😊";
        //    }
        //}
    }
}