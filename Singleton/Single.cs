using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal sealed class Single
    {
       public List<int> nums;
        private Single()
        {
            nums = new List<int>()
            {
                1,2,3,4,5,6
            };
        }
        private static Single _current = null;
        public static Single GetInstanse
        {
            get
            {
                if (_current == null)
                {
                    _current = new Single();
                }
                return _current;
            }
        }
        

    }
}
