namespace Review
{
    internal class Program
    {
        delegate List<string> TestDelegate(List<string> names, string filter);
        static void Main(string[] args)
        {
            TestDelegate testDelegate = new TestDelegate(Test);
            List<string> names = new List<string>()
            {
                "Mate","Giorgi","Gela","Marina","Tamazi","Giorgi","Mariami","Ani","Mate","Giorgi",
            };
            // func(in params, out bool) action(in params)

            var name = names.Where(x => x.Contains("rgi"));

            //var result = Test(names, "rgi");
            var result = testDelegate(names, "rgi");
        }

        static List<string> Test(List<string> names, string filter)
        {
            List<string> resultNames = new List<string>(); 
            string firstName = null;
            foreach (var name in names)
            {
                if (name.Contains(filter))
                {
                    resultNames.Add(name);
                }
            }
            return resultNames;
        }
    }
}