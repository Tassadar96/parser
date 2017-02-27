using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace parser
{      
    class Program
    {
        static void Main(string[] args)
        {
            // загружаем html-страницу как строку
            WebClient client = new WebClient();
            string htmlDocument = client.DownloadString("https://ru.wikipedia.org/wiki/Шеннон,_Клод");
            // создаем модель обьекта документа
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(htmlDocument);
            // через XPath получаем содержимое одного узла
            var text = doc.DocumentNode.SelectSingleNode("//*[@id='mw-content-text']/p[2]");
            
            string typeText = text.InnerText;

            Console.WriteLine(typeText);                  
                       
            Console.ReadLine();
        }
    }
}
