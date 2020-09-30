using System;
using System.Collections;
using System.IO;
using System.Text;

namespace Exception_Stream
{
    class Program
    {
        static void Main(string[] args)
        {
            /*// 1 - Exceção
            TratamentoExcecao();*/

            /*//2 - CriarArquivo
            CriarArquivo();*/

           /* //3 - Cria e le arquivo
            LerArquivo();*/

            //3 - Gerencia Diretorio
            GerenciaDiretorio();

            Console.ReadLine();

        }

        /// <summary>
        /// 2 - Criar Arquivo
        /// </summary>
        static void CriarArquivo()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(@"C:\Fapen\teste.txt"))
                {
                    writer.WriteLine("Primeira linha ");
                    writer.WriteLine("Segunda Linha");
                    writer.WriteLine("Terceira linha do arquivo");
                    writer.Write(" Quarta linha!");
                    writer.WriteLine("mantem na mesma linha!");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message + "  " + ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("Finalizou a execução");
            }


        }

        /// <summary>
        /// 3 - Gerencia Diretorio
        /// </summary>
        static void GerenciaDiretorio()
        {
            DirectoryInfo di = new DirectoryInfo(@"c:\Dir1");
            try
            {
                if (di.Exists)
                {
                    Console.WriteLine("Diretório já existente.");

                    di.Delete();
                    Console.WriteLine("Diretório Excluído com sucesso!.");

                }
                else
                {
                    di.Create();
                    Console.WriteLine("Diretório Criado com sucesso!.");
                }

              
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao excluir diretório: {0}", e.ToString());
            }
            finally 
            {
                Console.WriteLine("Procedimento finalizado!");
            }
        }

        /// <summary>
        /// 3 - Cria e le arquivo
        /// </summary>
        static void LerArquivo()
        {
            string arquivo = @"C:\fapen\teste.txt";
            StringBuilder sb = new StringBuilder();
            if (File.Exists(arquivo))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(arquivo))
                    {
                        String linha;
                        // Lê linha por linha até o final do arquivo
                        while ((linha = sr.ReadLine()) != null)
                        {
                            sb.AppendLine(linha);
                        }
                        Console.WriteLine(sb.ToString());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Operação finalizada!");
                }
            }
            else
            {
                Console.WriteLine(" O arquivo " + arquivo + " não foi localizado !");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// 1 - Exceção
        /// </summary>
        static void TratamentoExcecao()
        {
            ArrayList arr = new ArrayList();
            arr.Add(1);
            arr.Add("TEste");
            arr.Add(2);
            arr.Add(3);
            arr.Add(4);
            arr.Add(5);
            arr.Add(6);
            arr.Add(7);
            arr.Add(8);
            arr.Add(9);
            arr.Add(10);

            try
            {
                foreach (int item in arr)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("o ArrayList contem tipo invalido " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Programa finalizou!");
            }

        }
    }
}
