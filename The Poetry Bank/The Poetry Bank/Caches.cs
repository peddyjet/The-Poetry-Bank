using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Poetry_Bank
{
  public static class Caches
   {
        public static List<Poem> Poems { get; private set; } = new List<Poem>();
        public static string MainText { get; private set; }

        public static bool Setup(string url)
        {
            WebClient webClient = new WebClient();
            try
            {
               MainText = webClient.DownloadString(url);  
            }
            catch { return false; }

            //Name, UrlForDescription, UrlForMainBody

            string[] entries = MainText.Split(',');
            if ((entries.Length - 1) % 3 != 0) { return false; }

            for (int i = 0; i < entries.Length - 1; i += 3)
            {
                Poems.Add(new Poem(entries[i], webClient.DownloadString(entries[i + 1]), webClient.DownloadString(entries[i + 2])));
            }

            return true;
        }
   }


}


