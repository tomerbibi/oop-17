using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citizen
{
    class Program
    {
        public static bool HadChildren(Citizen c)
        {
            if (c._children.Length == 0)
            {
                return false;
            }
            return true;
        }
        public static bool CheckValidity(Citizen c)
        {
            if (HadChildren(c))
            {
                for (int i = 0; i < c._children.Length; i++)
                {
                    if (c._children[i]._fatherId != c._id)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Citizen bob = new Citizen("bob", 2738);
            Citizen lacy = new Citizen("lacy", 2908);
            Citizen jina = new Citizen("jina", 2990);
            Citizen dan = new Citizen("dan", 2977);
            Citizen[] c = new Citizen[3] {lacy,jina,dan};
            bob._children = c;

        }
    }
}
