using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso1
{
    public class OrderRange
    {
        public static Tuple<List<int>, List<int>> Build(List<int> list)
        {
            var parList = new List<int>();
            var imparList = new List<int>();

            foreach (var num in list.Distinct().Order()) {
                if (num <= 0) continue;

                if (num % 2 == 0) parList.Add(num);
                else imparList.Add(num);
            }
            return Tuple.Create(parList, imparList);
        }
    }
}
