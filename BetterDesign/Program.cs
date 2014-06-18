using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterDesign
{
    public class ObjectA
    {
        int aProp;
    }

    public class ObjectB
    {
        string bProp;
    }

    public class ObjectC
    {
        List<int> cProp;
    }

    public class baseDBService<T>
    {
        public void add(T obj);
        public void remove(T obj);
        public List<T> findAll();
    }

    public class objectADBService : baseDBService<ObjectA>
    {
        public List<ObjectA> findAllObjectAWithIntPropEqualZero() { return new List<ObjectA>(); }
    }

    public class objectBDBService : baseDBService<ObjectB>
    {
        public List<ObjectB> findAllObjectBWithStrPropEmpty() { return new List<ObjectB>(); }
    }

    public class objectCDBService : baseDBService<ObjectC>
    {
        public List<ObjectC> findAllObjectCWithListPropEmpty() { return new List<ObjectC>(); }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
