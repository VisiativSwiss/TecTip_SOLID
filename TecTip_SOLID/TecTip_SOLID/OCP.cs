namespace TecTip_SOLID
{
    // Not conforming to OCP
    public class ModelExporter
    {
        public void Export(SolidWorksModel model, string format)
        {
            if (format == "STL") { /* ... STL export logic ... */ }
            else if (format == "STEP") { /* ... STEP export logic ... */ }
            // Adding a new format requires modifying this class
        }
    }

    // Conforming to OCP
    public interface IModelExporter
    {
        void Export(SolidWorksModel model);
    }

    public class StlExporter : IModelExporter
    {
        public void Export(SolidWorksModel model) { /* ... STL export logic ... */ }
    }

    public class StepExporter : IModelExporter
    {
        public void Export(SolidWorksModel model) { /* ... STEP export logic ... */ }
    }

}
