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
                pbStatus.Value = 0;
                _inputURL = inutPath.Text;
                _outputURL = outputPath.Text;

                string newFilePath = String.Empty;
                //byte[] bytes = File.ReadAllBytes(_inputURL);
                var newFile = _converterLogic.ConvertImageToIcon(_inputURL, 64);
                newFilePath = $"{_outputURL}\\{DateTime.Now.ToString("yyyyMMddhhmmss")}.ico";

                RenderLoadingBar(100);
                File.WriteAllBytes(newFilePath, newFile);

            }
            catch (Exception ex)
            {

                throw;
            }

        }

        //pbStatus

        private void RenderLoadingBar(int seed)
        {
            for (int i = 0; i < seed; i++)
            {
                pbStatus.Value++;
            }
        }

        private void inutPath_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            inutPath.Text = "";
        }

        private void inutPath_GotFocus(object sender, RoutedEventArgs e)
        {
            inutPath.Text = "";
        }
    }



}