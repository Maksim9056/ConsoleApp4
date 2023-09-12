namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte[] data =new byte[] { 0x1, 0x2 };
            long D = Convert.ToInt64( ConvertType.Van);
            Byte[] bytes1 = { 0xEC, 0x00, 0x00, 0x00,0X2,0x5 };
            Console.WriteLine("{0}--> 0x{1:X4} ({1:N0})", FormatBytes(bytes1),
                                            BitConverter.ToInt32(bytes1, 0));
            // Create an Integer from the upper four bytes of a byte array.
            Byte[] bytes2 = BitConverter.GetBytes(Int64.MaxValue / 2);
            Console.WriteLine("{0}--> 0x{1:X4} ({1:N0})", FormatBytes(bytes2),
                                            BitConverter.ToInt32(bytes2, 4));

            // Round-trip an integer value.
            int original = (int)Math.Pow(16, 3);
            Byte[] bytes3 = BitConverter.GetBytes(original);
            int restored = BitConverter.ToInt32(bytes3, 0);
            Console.WriteLine("int 32 ", original,  FormatBytes(bytes3), restored);
        
            //data =;
            string dS = Convert.ToString(D);
            dS += "d";
            data = Convert.FromHexString(dS);

            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine(Convert.ToInt32(data[i]));
            }



            Student student = new Student("MAX",2,"100");
            Person FF  = (Student)student;
            
            
            Console.WriteLine(FF.Name, FF.Id,((Student)FF).Mane);
            Console.ReadLine();
        }
        private static string FormatBytes(Byte[] bytes)
        {
            string value = "";
            foreach (var byt in bytes)
                value += string.Format("{0:X2} ", byt);

            return value;
        }
    }
    public class ConvertType 
    { 
        public static int Van {  get; set; } = 500;
    
    }

    public class Person
    {
        public string Name { get; set; }

        public int Id { get; set; }
        public Person(string name, int id)
        {
            Name = name;
            Id = id;
        }

    }
    public class Student : Person
    {
        public string Mane { get; set; }

        public Student(string name, int id,string mane) : base(name, id)
        {
            Mane = mane;
        }

    }
}