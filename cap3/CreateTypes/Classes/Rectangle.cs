namespace CreateTypes.Classes
{
    public class Rectangle
    {
        public readonly float Width, Heigth;

        public Rectangle(float width, float heigth)
        {
            Width = width;
            Heigth = heigth;
        }

        public void Deconstruct(out float width, out float heigth)
        {
            width = Width;
            heigth = Heigth;
        }
    }
}