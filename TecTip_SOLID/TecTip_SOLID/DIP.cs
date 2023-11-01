namespace TecTip_SOLID
{
    // Not conforming to DIP
    public class ModelLoader
    {
        private FileRepository _repository = new FileRepository(); // High-level module depending on low-level

        public SolidWorksModel LoadModel(string path)
        {
            var data = _repository.ReadData(path);
            // Model loading logic...
            return new SolidWorksModel();
        }
    }

    // Conforming to DIP
    public interface IRepository
    {
        string ReadData(string path);
    }

    public class FileRepository : IRepository
    {
        public string ReadData(string path) { /* ... data reading logic ... */ }
    }

    public class ModelLoader
    {
        private IRepository _repository;

        public ModelLoader(IRepository repository)
        {
            _repository = repository;
        }

        public SolidWorksModel LoadModel(string path)
        {
            var data = _repository.ReadData(path);
            // Model loading logic...
            return new SolidWorksModel();
        }
    }

}
