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
                     
            string[] a = text.Split(new char[] {' ','.',',','!','?','-',':',';' });
            text = "";
            for (int q=0;q<a.Length-1;q++)
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
                if (a[q] == " ") text += a[q];
                else
                {
                    text += a[q]+" ";
                }
            }
            
        }
    }
}