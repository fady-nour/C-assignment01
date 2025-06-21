namespace firstproject
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region variableintialize
            //int x;
            //    x= 4;
            //Int32 y = 9;
            //      y = x;
            ////y=4,x=4
            //      ++x; // x=x+1 or x+=1
            ////x=5
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            #endregion
            #region value type data type
            //point P1;
            //P1 = new point();
            //point p2 = new point();
            //P1.x = 1;
            //P1.y = 2;
            //p2.x = 3;
            //p2.y = 4;
            //Console.WriteLine($"p1 =({P1.x},{P1.y}):");
            //Console.WriteLine($"p2 = ({p2.x},{p2.y}):");
            //p2 = P1;
            //P1.x = 7;
            //P1.y = 9;
            //Console.WriteLine($"p1 =({P1.x},{P1.y}):");
            //Console.WriteLine($"p2 = ({p2.x},{p2.y}):");

            #endregion
            #region object
            //point3D p= new point3D();
            //p.x = 5;
            // point point;
            // point = new point();
            //point = new point3D();

            //print(5, 6);
            //print(5.5, 6.4);
            object obj = new object();
            //Object obj;
            obj = 123;//boxing
            obj = false;
            obj = 1.5;
            //obj = "FADy";
            obj = 12;
            string u = "hello";
            int x = 5, y = 5;
            // int sum = x + y+ (int)obj;
            //Console.WriteLine(sum);
            //sum = x + y +u; error because not type safety
            point point = new point();
            //Console.WriteLine(x);
            //Console.WriteLine(u);
            //Console.WriteLine(point);
            point p = new point();
            //string s = "hello";
            //Console.WriteLine(x.Equals(y));
            //Console.WriteLine(u.Equals(s));
            //Console.WriteLine(point.Equals(p));


            Console.WriteLine(point.GetHashCode());
            Console.WriteLine(p.GetHashCode());
            Console.WriteLine(x.GetType());
            Console.WriteLine(u.GetType());
            Console.WriteLine(point.GetType());

            #endregion



            #region object
            //point3D p= new point3D();
            //p.x = 5;
            // point point;
            // point = new point();
            //point = new point3D();

            //print(5, 6);
            //print(5.5, 6.4);
            object obj = new object();
            //Object obj;
            obj = 123;//boxing
            obj = false;
            obj = 1.5;
            //obj = "FADy";
            obj = 12;
            string u = "hello";
            int x = 5, y = 5;
            // int sum = x + y+ (int)obj;
            //Console.WriteLine(sum);
            //sum = x + y +u; error because not type safety
            point point = new point();
            //Console.WriteLine(x);
            //Console.WriteLine(u);
            //Console.WriteLine(point);
            point p = new point();
            //string s = "hello";
            //Console.WriteLine(x.Equals(y));
            //Console.WriteLine(u.Equals(s));
            //Console.WriteLine(point.Equals(p));


            Console.WriteLine(point.GetHashCode());
            Console.WriteLine(p.GetHashCode());
            Console.WriteLine(x.GetType());
            Console.WriteLine(u.GetType());
            Console.WriteLine(point.GetType());

#endregion


        }

        //static void print<t>(t x,t y)
        //    {
        //        Console.WriteLine(x);
        //        Console.WriteLine(y);
        //    }


    }
}
