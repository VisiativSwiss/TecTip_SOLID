namespace DIP
{
    public class SolidWorksModel
    {
        public void DrawModel() { /* ... code to draw the model ... */ }
    }
    public interface IRepository
    {
        string ReadData(string path);
    }

    public class FileRepository : IRepository
    {
        public string ReadData(string path)
        {
            return string.Empty; /* ... data reading logic ... */
        }
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
