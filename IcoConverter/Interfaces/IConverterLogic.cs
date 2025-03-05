namespace IcoConverter
{
    public interface IConverterLogic
    {
        byte[] ConvertImageToIcon(string inputImagePath, int size, string fileType);
        void ConvertImageToIcon(string inputImagePath, string outputIconPath);
    }
}