namespace TecTip_SOLID
{
    public abstract class SolidWorksFeature
    {
        public abstract void ApplyToModel(SolidWorksModel model);
    }

    public class ExtrudeFeature : SolidWorksFeature
    {
        public override void ApplyToModel(SolidWorksModel model) { /* ... extrusion logic ... */ }
    }

    public class FilletFeature : SolidWorksFeature
    {
        public override void ApplyToModel(SolidWorksModel model) { /* ... filleting logic ... */ }
    }

    // Usage
    public void AddFeatureToModel(SolidWorksFeature feature, SolidWorksModel model)
    {
        feature.ApplyToModel(model); // Can be an instance of any subclass of SolidWorksFeature
    }

}
