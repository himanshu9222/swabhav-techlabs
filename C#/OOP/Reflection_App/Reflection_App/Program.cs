using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Collections.Generic;

namespace Reflection_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Type myType = (typeof(Foo));
            MethodInfo[] myMethodArray = myType.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            //Console.WriteLine(myMethodArray.Length);
            List<String> methodPassed = new List<string>();
            var instance = Activator.CreateInstance(myType);

            foreach (var method in instance.GetType().GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
            {
                object[] attrs = method.GetCustomAttributes(true);
                object methodReturnType= method.Invoke(instance, new Object[] { });
                foreach (object attr in attrs)
                {
                    if ((bool)methodReturnType)
                    {
                        methodPassed.Add(method.ToString());
                    }
                }
            }

            Console.WriteLine("Method Passes are ");
            foreach(string p in methodPassed){
                Console.WriteLine(p);
            }

            //Console.WriteLine(myMethodArray.Length);
            //5Print(myMethodArray);
            Console.ReadKey();
        }

        static void Print(MethodInfo[] myMethodArray)
        {
            foreach (MethodInfo m in myMethodArray)
            {
                Console.WriteLine(m + "\n");
            }
        }
    }
}


//foreach (MethodInfo methodInfo in myMethodArray)
//{
//    object[] attrs = methodInfo.GetCustomAttributes(true);
//    //methodInfo.Invoke(attrs, new Object[] { });


//    foreach (object attr in attrs)
//    {
//       //method.
//        Console.WriteLine(attr);
//        Console.WriteLine(methodInfo);
//    }
//}

