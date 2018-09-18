using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    class Program
    {
        static void Main(string[] args)
        {
            #region HWa
            //List<Shape> shape = new List<Shape>();

            //for (int i = 0; i < 10; i++)
            //{
            //    if (i >= 5)
            //    {
            //        Console.WriteLine("Enter digit for CIRCLE");
            //        float digit = float.Parse(Console.ReadLine());
            //        shape.Add(new Circle("Circle" + (i+1), digit));
            //    }
            //    else if (i < 5)
            //    {
            //        Console.WriteLine("Enter digit for Square");
            //        float digits = float.Parse(Console.ReadLine());
            //        shape.Add(new Square("Square" +(i+1), digits));
            //    }
            //}
            //#region hw7
            ////foreach (var inf in shape)
            ////{
            ////    //Console.WriteLine(inf.Area());
            ////    //Console.WriteLine(inf.Perimeter());
            ////    inf.Print();
            ////}

            ////double largestPerimeter = 0;
            ////bool first = true;
            ////string largestPerimeterName = "";
            ////foreach (var ps in shape)
            ////{
            ////    if (first)
            ////    {
            ////        largestPerimeterName = ps.Name;
            ////        largestPerimeter = ps.Perimeter();
            ////        first = false;
            ////    }
            ////    else if (ps.Perimeter() > largestPerimeter)
            ////    {
            ////        largestPerimeterName = ps.Name;
            ////        largestPerimeter = ps.Perimeter();
            ////    }
            ////}
            ////Console.WriteLine("_________________MAX PERIMETER________________");

            ////Console.WriteLine("{0} {1} has max perimeter", largestPerimeterName, largestPerimeter);
            //////sorted by Area

            ////Console.WriteLine("_________________SORTED BY AREA________________");
            ////shape.Sort();

            ////foreach (var ib in shape)
            ////{
            ////    ib.Print();
            ////}
            //#endregion


            //var AreafromRange = shape.Where(i => i.Area() > 10 && i.Area() < 100);
            //var curentDire = Directory.GetCurrentDirectory();
            //try
            //{
            //    using (StreamWriter writer = new StreamWriter(curentDire + @"\important.txt"))
            //    {

            //        foreach (var afr in AreafromRange)
            //        {
            //            Console.WriteLine("Area from Range 10 to 100 {0} {1}", afr.Area(), afr.Name);
            //            writer.WriteLine("Area from Range 10 to 100 {0} {1}", afr.Area(), afr.Name);
            //        }

            //    }
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("File Close");
            //}

            ////var containsLetter = from c in shape
            ////                     where c.Name.Contains("a")
            ////                     select c;
            //// Write all Name which contains letter "a" 
            //var containsLetter = shape.Where(a => a.Name.Contains("a"));
            //try
            //{
            //    using (StreamWriter writer = new StreamWriter(curentDire + @"\important2.txt"))
            //    {

            //        foreach (var afr in containsLetter)
            //        {
            //            Console.WriteLine("Which name contains letter 'a' :: {0} ", afr.Name);
            //            writer.WriteLine("Which name contains letter 'a' :: {0} ", afr.Name);
            //        }
            //    }
            //}
            //catch(Exception a)
            //{
            //    Console.WriteLine(a.Message);
            //}
            //// Remove all perimeter less then 5
            //Console.WriteLine("Remove from the list perimeter less then 5 {0}");
            //shape.RemoveAll(x => x.Perimeter() < 5);
            //foreach(var m in shape)
            //{
            //    m.Print();
            //}
            #endregion

            //List<string> readAllLines = new List<string>();

            var file = "Fromread.cs";
            var currentDir = Directory.GetCurrentDirectory() + "\\" + file;
            try
            {
                using (StreamReader sr = new StreamReader(currentDir))
                {
                    file = sr.ReadToEnd();        
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            
            var textFromFile = file.Split(new char[] { '\n' });
            for (int i = 0; i < textFromFile.Length;i++)
            {
                Console.WriteLine(" #{0} count {1}", (i+1), textFromFile[i].Count());
            }
            ///Min string
            foreach (var n in textFromFile.OrderBy(x => x.Length))
            {
                Console.WriteLine("MIN Line ='{0}'", n);
                break;
            }
            //Max string
            foreach (var n in textFromFile.OrderByDescending(x => x.Length))
            {
                Console.WriteLine("MAX Line ='{0}'", n);
                break;
            }
            //Contains Var
            var containsVar = textFromFile.Where(a => a.Contains("var"));
            foreach(var c in containsVar)
            {
                Console.WriteLine("Contains Var = {0}", c);
            }
            Console.ReadKey();
        }
    }
}
