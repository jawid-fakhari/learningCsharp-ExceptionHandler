using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandler
{
    public class ExceptionManager
    {
        static int[] numbers = { 1, 8, 12, 5 };
        public static bool WrongAnswer = false;

        public static int GetNumber(int index)
        {
            // 2a- per evitare errore string della funzione GetNumber che deve ritornare solo int, creiamo un int output che ritorna infine l'output nel caso di exception
            int output = -1;
            // 1a- usiamo try catch + finally per gestire exceptions
            try
            {
                output = numbers[index];

            }
            // 1b- usando Exception class che fa parte del System library e diamo il nome "ex"
            catch (Exception ex)
            {
                // message ci da l'errore
                Console.WriteLine(ex.Message);
                // stacktrace ci dimostra dove si trova l'errore nel nostro codice
                Console.WriteLine(ex.StackTrace);
            }
            //2b- finally sempre viene eseguito e fa parte di try e catch e qui se condizione output combacia allora ci da un error massage(che abbiamo scritto in program) e boolean ritorna true altrimenti boolean rimane falso
            finally
            {
                if (output == -1)
                {
                    WrongAnswer = true;
                }
                else
                {
                    WrongAnswer = false;
                }
            }
            return output;
        }
    }
}
