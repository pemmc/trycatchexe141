using System;
using System.Globalization;

using System.IO;

namespace trycatchexe141
{
    class Program
    {
        static void Main(string[] args)
        {
            //CultureInfo culture = new CultureInfo("pt-BR");
            
            try
            {
                int n1 = int.Parse(Console.ReadLine());

                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;

                Console.WriteLine(result);

            }
          
            //Vamos tratar/capturar UMA EVENTUAL EXCEÇÃO
            /* TIPO GENERICO
            catch (Exception)
            {

                Console.WriteLine("Minha mensagem em portugues e livre");

            }
            */

            //TRATAMENTO ESPECÍFICO
            catch (DivideByZeroException)
            {

              
                Console.WriteLine("MINHA MENSAGEM DE ERRO");


            }

            catch (FormatException e)
            {

                Console.WriteLine("Entrada de dados no formatao errado: " + e.Message);
            }

            finally
            {
                Console.WriteLine("Independente de ter dado certo ou não, será excecutado");

            }

            FileStream fs = null;
            try
            {
                fs = new FileStream("data.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);

                Console.WriteLine("DEU CERTO!");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);

                Console.WriteLine("DEU ERRADOOOO!");
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }
    }
}
