using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace test
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = 10;
            int k = 2;
            string s = ".*.*..**.*";

            int result = GetAnswer(s, k);
            Console.WriteLine(result);
        }
        public static int GetAnswer(string s, int k)
        {
            int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int length = getlength(s, k, i);
              
                if (result < length)
                {
                    result = length;
                }
            }
            return result;
        }

        public static int getlength(string s, int k, int start)
        {
            int length = 0;
    
            string a=string.Empty;
             a = s.Substring(start);
            StringBuilder sb = new StringBuilder(a);
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == '.' && k != 0)
                {
                    sb[i] = '*';
                    k--;
                }
                if ( k == 0 && sb[i] != '*')
                {
                    length = i;
                    break; 
                }
            }
            return length;
        }
    }
}