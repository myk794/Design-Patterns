namespace Factory_Pattern
{
    public class RedCube : Factory
    {
        public string Name() => "Red";
    }
    public class GreenCube : Factory
    {
        public string Name() => "Green";
    }

    public class BlueCube : Factory
    {
        public string Name() => "Blue";
    }
}