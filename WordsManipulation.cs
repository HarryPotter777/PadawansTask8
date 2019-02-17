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

            string[] a = text.Split(new char[] { ' ' });
            int s = a.Length - 1;

            for (int q = 0; q < a.Length; q++)
            {
                string e = a[q];
                int m = (e.Length - 1);
                if (e.Length == 0) continue;
                while ((e[m] == ' ' || e[m] == ',' || e[m] == '!' || e[m] == '?' || e[m] == '-' || e[m] == '.' || e[m] == ';' || e[m] == ':'))
                {
                    e = e.Substring(0, m);
                    m--;
                }

                for (int i = 0; i < a.Length; i++)
                {

                    if (i == q) i++;
                    if (q == s) break;

                    string v = a[i];

                    if (v.Length == 0) continue;

                    int b = 0;
                    int c = (v.Length - 1);

                    while (v[c] == ' ' || v[c] == ',' || v[c] == '!' || v[c] == '?' || v[c] == '-' || v[c] == '.' || v[c] == ';' || v[c] == ':')
                    {
                        v = v.Substring(0, c);
                        c--;
                    }
                    while (b < v.Length)
                    {
                        if (!char.IsLetter(v[b]))
                        {
                            break;
                        }
                        b++;
                    }
                    if (b != v.Length) continue;


                    if (v == e) { a[i] = ""; }
                }


            }
            text = "";


            for (int r = 0; r < a.Length; r++)
            {
                if (r == a.Length - 1) text += a[r];
                else text += a[r] + " ";
            }
        }

    }
}