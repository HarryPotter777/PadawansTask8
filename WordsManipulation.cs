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


            string[] a = text.Split(new char[] { ' ', '.', ',', '-', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);
            int index = 0;
            int s = a.Length - 1;

            for (int q = 0; q < a.Length; q++)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    string v = a[i];
                    if (i == q) i++;
                    if (q == s) break;


                    if (a[i] == a[q]) { a[i] = ""; }
                }

            }


            for (int i = 0; i < a.Length; i++)
            {
                int b = 0;
                if (a[i] == "") continue;

                string v = a[i];
                while (b < v.Length)
                {
                    if (!char.IsLetter(v[b]))
                    {
                        break;
                    }
                    b++;
                }
                if (b != v.Length) continue;


                index = text.IndexOf(a[i]);
                if (index != -1)
                {
                    if (a[i].EndsWith(a[i]))
                    {

                        text = text.Replace(a[i], "");
                        text = text.Insert(index, a[i]);
                    }
                }
            }
        }

    }
}