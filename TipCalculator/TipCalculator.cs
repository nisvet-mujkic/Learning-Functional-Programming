namespace TipCalculator
{
    public class TipCalculator
    {
        public static List<string> AddPerson(List<string> names, string name) =>
            new(names) { name };

        public static int GetTipPercentage(List<string> names)
        {
            if (names.Count > 5)
                return 20;
            else if (names.Count > 0)
                return 10;

            return 0;
        }
    }
}