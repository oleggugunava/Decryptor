namespace Decryptor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please chose environment: for development type-d, production-p. to exit type - exit");
                var option = Console.ReadLine();
                if (option == "exit")
                {
                    break;
                }

                if (!(option == "d" || option == "p"))
                {
                    continue;
                }

                Console.WriteLine("Please paste encrypted string:");

                var text = Console.ReadLine();

                var result= EncryptionHelper.Decrypt(text, option == "d" ? "dev" : "prod_alt");

                Console.WriteLine($"Decrypted value = {result}");
                Console.WriteLine();
                Console.WriteLine();
            }
           
        }
    }
}