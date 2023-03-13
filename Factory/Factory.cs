namespace Factory_Pattern
{
    public interface Factory
    {
        public string Name();
    }

    public enum Colors
    {
        Red,
        Green,
        Blue
    }
}