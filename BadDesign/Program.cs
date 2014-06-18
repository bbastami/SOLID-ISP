using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadDesign
{
    public class ObjectA
    {
        int aProp;
    }

    public class ObjectB
    {
        string bProp;
    }

    public class bloatedDBService
    {
        public void addObjectA(ObjectA oa)
        { 
            // code to add oa to DB
        }

        public void removeObjectA(ObjectA oa)
        {
            // code to remove oa from DB
        }

        public void addObjectB(ObjectB ob)
        {
            // code to add ob to DB
        }

        public void removeObjectB(ObjectB ob)
        {
            // code to remove ob from DB
        }

        public List<ObjectA> findAllObjectA() { return new List<ObjectA>(); }
        public List<ObjectB> findAllObjectB() { return new List<ObjectB>(); }
        public List<ObjectA> findAllObjectAWithIntPropEqualZero() { return new List<ObjectA>(); }
        public List<ObjectB> findAllObjectBWithStrPropEmpty() { return new List<ObjectB>(); }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
