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
            int s = a.Length - 1;
            text = "";

            for (int q = 0; q < a.Length; q++)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (i == q) i++;
                    if (q == s) break;
                    if (a[i] == a[q])
                    {
                        a[i] = "";
                    }

                }

                if (q == s && a[q]=="") break;
                if (q == s && a[q] != "") { text += a[q]; break; }

                if (a[q] == "") text += " ";
                else
                {
                    text += a[q] + " ";
                }
            }

        }
    }
}

