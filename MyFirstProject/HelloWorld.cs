using System;

namespace CSharpHelloWorld
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            // Hola mundo
            Console.WriteLine("Hola, C#");

            var myClass = new MyClass("judá");
            myClass.myName = "Benja";
            Console.WriteLine(myClass.myName);

            /**
            Esto
            es
            un
            comentario
            */

            // Tipo de variables

            string myString = "Esto es una cadena de texto";
            myString = "Aquí cambio el valor de la cadena de texto";
            Console.WriteLine(myString);

            int myInt = 10;
            myInt += 4;
            Console.WriteLine(myInt);
            Console.WriteLine(myInt - 1);
            Console.WriteLine(myInt);

            double myDouble = 6.5;
            float myFloat = 6.5f;

            Console.WriteLine(myDouble);
            Console.WriteLine(myFloat);

            Console.WriteLine(myInt + myDouble + myFloat);

            dynamic myDynamic = 6;
            myDynamic = "Mi dato dinámico";
            Console.WriteLine(myDynamic + myFloat);

            var myVar = "Mi variable de tipo inferido";
            Console.WriteLine(myVar);

            bool myBool = true;
            Console.WriteLine(myBool);

            const string MyConst = "Mi constante";
            Console.WriteLine(MyConst);

            // Estructuras

            var myArray = new string[] { "Judá", "Carrillo", "Pacherres" };
            Console.WriteLine(myArray);


            myArray[2] = "18";
            Console.WriteLine(myArray[2]);

            var myDictionary = new Dictionary<string, int>
            {
                {"juda", 18},
                {"david", 22},
                {"sofia", 25}

            };

            Console.WriteLine(myDictionary["juda"]);

            var mySet = new HashSet<string>
            {
                "Judá", "Carrillo", "Pacherres"
            };


            var myTuple = ("Judá", "Carrillo", "Pacherres", "Judá");
            Console.WriteLine(myTuple);

            // Bucles

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            foreach (var x in myArray) { Console.WriteLine(x); }
            foreach (var x in mySet) { Console.WriteLine(x); };

            foreach (var x in myDictionary) { Console.WriteLine(x); }

            // Flujos     

            if (myInt == 14 || myBool == true)
            {
                Console.WriteLine("El valor es 11");
            }
            else if (myInt == 12 || myBool == false)
            {
                Console.WriteLine("El valor es 12");
            }
            else
            {
                Console.WriteLine("El valor no es 11");
            }

            MyFunction();
            Console.WriteLine(MyFunctionWithReturn(5));
        }

        static void MyFunction()
        {
            Console.WriteLine("Mi función");
        }

        static int MyFunctionWithReturn(int param)
        {
            return 10 + param;
        }

        class MyClass
        {
            public string myName { get; set; }

            public MyClass (string myCurrentName)
            {
                this.myName = myCurrentName;
            }
        }

    }

}