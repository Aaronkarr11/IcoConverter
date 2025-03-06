namespace IcoConverter
{
    public interface IConverterLogic
    {
        string ConvertImageToIcon(string inputImagePath, int size, string outputImagePath);
    }
}