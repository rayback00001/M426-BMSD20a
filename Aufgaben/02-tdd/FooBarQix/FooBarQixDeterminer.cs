using System.Reflection.Metadata;

namespace FooBarQix
{
    public class FooBarQixDeterminer
    {
        public string Determine(int input)
        {
            string res = string.Empty;

            if (input % 5 == 0)
                res += "Bar";

            if (input % 3 == 0)
                res += "Foo";

            if (input % 7 == 0)
                res += "Qix";

            if (res == string.Empty)
                return input.ToString();

            return res;
        }

    }
}