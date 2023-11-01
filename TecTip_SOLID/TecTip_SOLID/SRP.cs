namespace TecTip_SOLID
{
    // Not conforming to SRP
    public class SolidWorksModelManager
    {
        public void DrawModel() { /* ... code to draw the model ... */ }
        public void SaveModel(string path) { /* ... code to save the model ... */ }
        public void PrintModel() { /* ... code to print the model ... */ }
    }

    // Conforming to SRP
    public class SolidWorksModel
    {
        public void DrawModel() { /* ... code to draw the model ... */ }
    }

    public class ModelSaver
    {
        public void SaveModel(SolidWorksModel model, string path) { /* ... code to save the model ... */ }
    }

    public class ModelPrinter
    {
        public void PrintModel(SolidWorksModel model) { /* ... code to print the model ... */ }
    }

}
