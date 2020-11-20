using System;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        public static async Task Main()
        {
            Projet ex = new Projet();

            Task t = ex.soustitre("Le Trône de fer");
            await t;
            Task t2 = ex.soustitre2("Estimez-vous heureux");
            await t2;
            Task t3 = ex.soustitre3("Vos couilles ne geleront pas");
            await t3;
            Task t4 = ex.soustitre4("Vous méprisez les blagues de nains, pas celles d'eunuques");
            await t4;
            Task t5 = ex.soustitre5("Parce que j'ai des couilles et pas vous");
            await t5;


            Console.ReadLine();


        }
    }
}
