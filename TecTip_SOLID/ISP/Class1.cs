namespace ISP
{
    // Not conforming to ISP
    public interface IModelOperations
    {
        void Draw();
        void Rotate();
        void Scale();
        // A class implementing this interface might not need all these methods
    }

    // Conforming to ISP
    public interface IDrawable
    {
        void Draw();
    }

    public interface IRotatable
    {
        void Rotate();
    }

    public interface IScalable
    {
        void Scale();
    }

    public class SolidWorksModel : IDrawable, IRotatable
    {
        public void Draw() { /* ... drawing logic ... */ }
        public void Rotate() { /* ... rotation logic ... */ }
        // Scale is not implemented if not needed
    }

}
