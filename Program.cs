using System;

namespace RandomClass
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var random = new Random();

            const int passwordLength = 10;
            var buffer = new char[passwordLength];
            for (var i = 0; i < passwordLength;i++)
               buffer[i] = (char)('a' + random.Next(0, 26)); //create random words using char casting on random numbers
            

            var password = new string(buffer);

            Console.WriteLine(password);

            //Console.WriteLine((int)'a');  //return character code for 'a'
        }
    }
}
