using Task5;

class Program
{
    static void Main()
    {
        string[] lines = new[]
        {
            "ACT V",
            "Scene I. Mantua. A Street.",
            "Scene II. Friar Lawrence’s Cell.",
            "Scene III. A churchyard; in it a Monument belonging to the Capulets.",
            "",
            "   Dramatis Personae",
            "",
            "ESCALUS, Prince of Verona.",
            "MERCUTIO, kinsman to the Prince, and friend to Romeo.",
            "PARIS, a young Nobleman, kinsman to the Prince.",
            "Page to Paris."
        };

        var tree = LightHTMLParser.ParseLinesToHTML(lines);
        Console.WriteLine("HTML результат:");
        Console.WriteLine(tree.OuterHTML);

        long memoryUsed = MemoryUtil.MeasureMemoryUsage(() =>
        {
            var lines = new[]
            {
        "ACT V",
        "Scene I. Mantua. A Street.",
        "Scene II. Friar Lawrence’s Cell.",
        "Scene III. A churchyard; in it a Monument belonging to the Capulets.",
        "",
        "   Dramatis Personae",
        "",
        "ESCALUS, Prince of Verona.",
        "MERCUTIO, kinsman to the Prince, and friend to Romeo.",
        "PARIS, a young Nobleman, kinsman to the Prince.",
        "Page to Paris."
    };

            var root = LightHTMLParser.ParseLinesToHTML(lines);
            Console.WriteLine(root.OuterHTML);
        });

        Console.WriteLine($"Використано памʼяті: ~{memoryUsed} байт");
    }

    }
