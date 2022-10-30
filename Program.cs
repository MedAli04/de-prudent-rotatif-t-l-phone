using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Session1
{
    /// <summary>
    /// Reconvertis une chaîne de caractère en entier
    /// </summary>
    /// <returns></returns>
    public static int lireEntier()
    {
        string input = "";
        int num;
        do
        {
            input = Console.ReadLine();

        } while (!int.TryParse(input, out num));

        return num;
    } // "43" 43

    public static void Main()
    {
        Exercice1.faireEx1();
        Exercice2.faireEx2();
        Console.ReadKey();

    }
}

class Exercice1
{
    /// <summary>
    /// Vérifie si un nombre est un nombre premier
    /// </summary>
    public static bool Premier(int num)
    {
        if (num < 0) return false;

        for (int i = 2; i < num; i++)
        {
            if (num % i == 0) return false;
        }

        return true;
    }

    public static void faireEx1()
    {
        Console.WriteLine("Entrer un numéro : ");
        int num = Session1.lireEntier();


        // Affiche le résultat
        if (Premier(num))
        {
            Console.WriteLine(num.ToString() + " est un nombre premier");
        }
        else
        {
            Console.WriteLine(num.ToString() + " n'est pas un nombre premier");
        }
    }
}

class Exercice2
{
    /// <summary>
    /// Ajoute un numéro dans un tableau trié en le gardant trié
    /// </summary>
    /// <param name="tab">Le tableau</param>
    /// <param name="num">L'entier a insérer</param>
    public static void insererTab(int[] tab, int num)
    {

        bool isTrue = false;

        int next = tab[0];
        int n = tab.Length;
        for (int i = 0; i < n - 1; i++)
        {
            if (isTrue)
            {
                int swap = tab[i];
                tab[i] = next;
                next = swap;
            }
            // si (num < tab[i]) on commencera le décalage
            if ((num < tab[i]) && !isTrue)
            {
                next = tab[i];
                tab[i] = num;
                isTrue = true;
            }
        }
        // isTrue = Faux;
        // 11
        // 1 2 5 8 11

        tab[n - 1] = (!isTrue) ? num : next;
    }
    public static void faireEx2()
    {
        int[] tab = new int[6];
        tab[0] = 1;
        tab[1] = 2;
        tab[2] = 3;
        tab[3] = 4;
        tab[4] = 5;

        Console.WriteLine("Entrer un numéro: ");
        int num = Session1.lireEntier();

        insererTab(tab, num);

        // Affiche le tableau
        for (int i = 0; i < tab.Length; i++)
        {
            Console.WriteLine("tab[" + i + "] = " + tab[i]);
        }

    }
}
