using System;
using System.Collections.Generic;

namespace DoesItBlend
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IBlendable > items = new List<IBlendable>();
            items.Add(new Strawberry());
            items.Add(new Banana());
            items.Add(new Mango());
            items.Add(new IceCubes());
            items.Add(new CellPhone());

            string result = "";
            foreach(IBlendable item in items) //dynamic
            {
                result += item.Blend();
            }

            /*foreach (object item in items)
            {// We need to have some deff need to add methods in blend so it has deff 
            //public virtual string Blend add virual
            //list of object which are similare thats inhertance
            //virual has implimtaion
            // abstract doesnt have implimtaion 
                result += item.Blend();
            }*/
            Console.WriteLine(result);
        }
    }
}
