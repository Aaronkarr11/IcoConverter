using System.Windows;

namespace IcoConverter;


/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private IConverterLogic _converterLogic;
    private IcoConverterViewModel _icoConverterViewModel;

    public MainWindow(IcoConverterViewModel icoConverterViewModel)
    {

        _icoConverterViewModel = icoConverterViewModel;
        DataContext = _icoConverterViewModel;
        InitializeComponent();
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