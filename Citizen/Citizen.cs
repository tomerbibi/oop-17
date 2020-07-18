using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citizen
{
    class Citizen
    {
        public string _name;
        public Citizen[] _children;
        public readonly int _id;
        public readonly int _fatherId;
        public static int _numberOfCurrentCitizens;
        public const int _maximumNumberOfCitizens = 10000000;
        public Citizen (string name , int fatherId)
        {
            _name = name;
            _fatherId = fatherId;
        }
        public static void PrintNumberOfCitizens()
        {
            Console.WriteLine(_numberOfCurrentCitizens);
        }
        public static bool ReachedHalfOfMaximumSize()
        {
            if (_numberOfCurrentCitizens >= _maximumNumberOfCitizens / 2)
            {
                return true;
            }
            return false;
        }
        public void PrintId ()
        {
            Console.WriteLine(_id);
        }
        public void PringGapBetweenMyIdAndFather()
        {
            Console.WriteLine(_fatherId - _id);
        }
        public void SetChildren(Citizen[] c)
        {
         for (int i = 0; i < c.Length; i++)
            {
                c[i] = _children[i];
            }
        }

        public override string ToString()
        {
            return $"name: {_name}, ID: {_id}, father ID: {_fatherId}, amount of children: {_children.Length}";
        }

    }
}
