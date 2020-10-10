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

        public static string Setup(string url)
        { 
            try
            {
                WebClient webClient = new WebClient();

                MainText = webClient.DownloadString(url);

                //Name, UrlForDescription, UrlForMainBody

                string[] entries = MainText.Split(',');
                if (entries.Length % 3 != 0) { return "Lewis has messed up the code: please email him at: support@x1.games"; }

                for (int i = 0; i < entries.Length - 1; i += 3)
                {
                    string descriptionRaw = webClient.DownloadString(entries[i + 1]);
                    string mainRaw = webClient.DownloadString(entries[i + 2]);

                    string description = descriptionRaw.Replace(@"â€™", @"'");
                    string main = mainRaw.Replace(@"â€™", @"'");

                    description = description.Replace(@"â€œ", '"'.ToString());
                    main = main.Replace(@"â€œ", '"'.ToString());
                    description = description.Replace(@"â€", '"'.ToString());
                    main = main.Replace(@"â€", '"'.ToString());

                    Poems.Add(new Poem(entries[i], description , main ));
                }
            }
            catch(Exception e) { return e.ToString(); }
            return string.Empty;
        }
   }
    // â€™

}


