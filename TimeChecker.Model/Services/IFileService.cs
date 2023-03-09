namespace TimeChecker.Model.Services
{
    public interface IFileService
    {
        T Open<T>(string filename);
        void Save<T>(string filename, T list);
    }
}
