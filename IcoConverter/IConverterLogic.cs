namespace IcoConverter
{
    public interface IConverterLogic
    {
        byte[] ConvertImageToIcon(string inputImagePath, int size);
        void ConvertImageToIcon(string inputImagePath, string outputIconPath);
    }
}