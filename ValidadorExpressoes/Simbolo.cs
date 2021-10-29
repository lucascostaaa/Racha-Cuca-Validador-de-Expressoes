namespace ValidadorExpressoes
{
    public abstract class Simbolo
    {
        public static ParentesesFecha ParentesesFecha { get; } = new();
        public static ParentesesAbre ParentesesAbre { get; } = new();

    }

    public class ParentesesFecha : Simbolo
    {
    }
    public class ParentesesAbre : Simbolo
    {
    }
}