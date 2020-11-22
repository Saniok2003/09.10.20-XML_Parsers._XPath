using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System;
using static System.Console;

namespace load_xml
{
    class Program
    {
        static void Main(string[] args)
        {
            OutputEncoding = Encoding.UTF8;
            while (true)
            {
                WriteLine("Погода какого города вас интересует?\n1 - Киев\n2 - Баку\n3 - Минск\n4 - EXIT");
                string action = ReadLine();
                int a = Convert.ToInt32(action);
                switch (a)
                {
                    case 1:
                        {
                            XmlDocument KievXML = new XmlDocument();
                            KievXML.Load("http://informer.gismeteo.by/rss/33345.xml");
                            XmlNodeList xNodeListKiev = KievXML.DocumentElement.SelectNodes("channel/item");
                            foreach (XmlNode xNode in xNodeListKiev)
                            {
                                WriteLine($"Title: {xNode.SelectSingleNode("title").InnerText}");
                                WriteLine($"Description: {xNode.SelectSingleNode("description").InnerText}");
                            }
                        }
                        break;
                    case 2:
                        {
                            XmlDocument BakuXML = new XmlDocument();
                            BakuXML.Load("http://informer.gismeteo.by/rss/37850.xml");
                            XmlNodeList xNodeListBaku = BakuXML.DocumentElement.SelectNodes("channel/item");
                            foreach (XmlNode xNode in xNodeListBaku)
                            {
                                WriteLine($"Title: {xNode.SelectSingleNode("title").InnerText}");
                                WriteLine($"Description: {xNode.SelectSingleNode("description").InnerText}");
                            }
                        }
                        break;
                    case 3:
                        {
                            XmlDocument MinskXML = new XmlDocument();
                            MinskXML.Load("http://informer.gismeteo.by/rss/26850.xml");
                            XmlNodeList xNodeListMinsk = MinskXML.DocumentElement.SelectNodes("channel/item");
                            foreach (XmlNode xNode in xNodeListMinsk)
                            {
                                WriteLine($"Title: {xNode.SelectSingleNode("title").InnerText}");
                                WriteLine($"Description: {xNode.SelectSingleNode("description").InnerText}");
                            }
                        }
                        break;
                    case 4:
                        {
                            Environment.Exit(0);
                        }
                        break;
                    default:
                        {
                            WriteLine("Incorrect number");
                        }
                        break;
                }
                ForegroundColor = ConsoleColor.Red;
                Write("Enter any key: ");
                ResetColor();
                ReadKey();
                Clear();
            }
        }
    }
}
