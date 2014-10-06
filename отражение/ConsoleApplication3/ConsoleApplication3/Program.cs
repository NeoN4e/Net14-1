using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    //public class People
    //{
    //    int age;
    //    string fio;
    //    public string FIO { get { return fio;} set {fio=value ;} }
    //    public int Age { get { return age; } set { age = value; } }
    //    public People() { Console.WriteLine("11111"); }
    //    public void Init(string fio, int age)
    //    {
    //        Console.WriteLine( fio);
    //        Console.WriteLine(age);
    //    }
    //    public override string ToString()
    //    {
    //        return string.Format("ФИО:{0}\nВозраст:{1}", fio, age);
    //    } 
    //}
    class Program
    {
        delegate void Mydelegate (string s, int i);
        static void Main(string[] args)
        {
            //People p = new People();
            //Type type = typeof(People);
            //Type type = Type.GetType("ConsoleApplication3.People");
            //Console.WriteLine(type);
           /* BindingFlags b = BindingFlags.InvokeMethod | BindingFlags.Public |BindingFlags.Instance|BindingFlags.Static ;
            type.InvokeMember("Init", b, null,null, new object[] { "qwqwe", 12 });*/
            //ConstructorInfo ci = type.GetConstructor(new Type[] { });
            //object obj = ci.Invoke(new object[] { });
            //MethodInfo mi = type.GetMethod("Init");
            //mi.Invoke(obj,new object[] { "asasa", 12 });
            //Console.WriteLine(type);
           // MethodInfo mi = type.GetMethod("Init");
           //// Console.WriteLine(mi);
           // Mydelegate m = new Mydelegate(p.Init);
           // Delegate d = mi.CreateDelegate(typeof(Mydelegate));
           // ((Mydelegate)d)("sdsdsd",12);

             Assembly ass = Assembly.UnsafeLoadFrom(Path.GetFullPath("GameClassLib.dll"));
             Type[] types = ass.GetTypes();
             MethodInfo[] allMethod = null;
             foreach (var t in types)
             {
                 Console.WriteLine(t + "\nMethods:");
                 allMethod =t.GetMethods();
                 foreach (MethodInfo m in allMethod)
                 {
                     Console.WriteLine("\t" + m);
                     foreach (ParameterInfo param in m.GetParameters())
                     {
                         Console.WriteLine("\t\t" + param);
                     }
                 }
                 Console.WriteLine("\n\tField:");
                 foreach (FieldInfo f in t.GetFields())
                 {
                     Console.WriteLine("\t\t" + f.Name);
                 }
                 Console.WriteLine("\n\tProperties:");
                 foreach (PropertyInfo p in t.GetProperties())
                 {
                     Console.WriteLine("\t\t" + p.Name);
                 }

             }
             if (!allMethod[0].IsStatic)

             {
                 ConstructorInfo ci = types[0].GetConstructor(new Type[] { });
                 object o = ci.Invoke(new object[] { });
                 object obj = allMethod[0].Invoke(o, new object[] { 12 });
                
                 Console.WriteLine((obj as object[])[0]);
             }



        }
            
    }
}
