/*using System.Text;
using System;

namespace PadawansTask8
{
    public static class WordsManipulation
    {
        public static void RemoveDuplicateWords(ref string text)
        {

            if (text == null) throw new ArgumentNullException();
            if (text.Length == 0) throw new ArgumentException();
            string z = text;
            text = "";

            string[] a = z.Split(new char[] { ' ' });

            for (int h = 0; h < a.Length; h++)
            {
                a[h] += " ";
            }
            int aa = 0;
            while (aa<a.Length)
            {
                
                for (int h = 0; h < a.Length; h++)
                {
                    if (aa == h) h++;
                    if (aa == a.Length - 1) break;
                    if (a[aa] == a[h]) a[aa] = " ";
                    aa++;

                }
                aa++;
            }
            int y = (a.Length - 1);
            if (a[y].Length != 0) a[y] = a[y].Remove(a[y].Length-1);
            //else { }
            for (int h = 0; h < a.Length; h++)
            {
                text += a[h];
            }
        }
    }
}*/
/*



for (int q=0;q<a.Length;q++)
 {
     for (int i = 0; i < a.Length; i++)
     {
         if (i == q) i++;
         if (q == a.Length - 1) break;

         int indexOfChar = text.IndexOf(a[q]);

         if (indexOfChar!=-1)
         {
            z += a[q];
             text += a[q] + z;
         }

     }

        // text += a[q];

 }

}
}
}*/

using System.Text;
using System;

namespace PadawansTask8
{
    public static class WordsManipulation
    {
        public static void RemoveDuplicateWords(ref string text)
        {
            if (text == null) throw new ArgumentNullException();
            if (text.Length == 0) throw new ArgumentException();

            string[] a = text.Split(new char[] { ' '});
            text = "";
            for (int q = 0; q < a.Length; q++)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (i == q) i++;
                    if (q == a.Length - 1) break;
                    if (a[i] == a[q])
                    {
                        a[i] = " ";
                    }

                }
                if (q == a.Length - 1 && a[q]==" ") break;
                if (q == a.Length - 1 && a[q] != " ") { text += a[q]; break; }
                if (a[q] == " ") text += a[q];
                else
                {
                    text += a[q] + " ";
                }
            }

        }
    }
}

