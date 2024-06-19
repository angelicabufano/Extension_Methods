namespace Extension_Methods;

internal class Program {
    static void Main(string[] args) {

        var str = "This is a test.";

        str.Debug("str is");

        var i = 12;
        i.Debug("i is ");

        i.Cubed().Debug("i cubed");

        i.Funct().Debug($"f({i}) = ");

    }
}
