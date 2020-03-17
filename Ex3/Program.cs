using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass testclass = new MyClass();
            MyStruct teststruct = new MyStruct();

            testclass.change = "не изменено";
            teststruct.change = "не изменено";

            ClassTaker(testclass);
            StructTaker(ref teststruct);//Ничего не изменится так как мы передаем не ссылку, а значение.
            //Для того чтобы изменить значение в структуре, применяем ref.
            //Тогда мы передаём ссылку и меняем её.

            Console.WriteLine("Class - {0}", testclass.change);
            Console.WriteLine("Struct - {0}", teststruct.change);
        }
        static void ClassTaker(MyClass c)
        {
            c.change = "изменено";
        }
        static void StructTaker(ref MyStruct s)
        {
            s.change = "изменено";
        }

    }

    class MyClass
    {
        public string change;
    }

    struct MyStruct
    {
        public string change;
    }

    
}
