/*改进书上例子9-10的爬虫程序。
 （1）只爬取起始网站上的网页 
（2）只有当爬取的是html文本时，才解析并爬取下一级URL。
 （3）相对地址转成绝对地址进行爬取。
（4）尝试使用Winform来配置初始URL，启动爬虫，显示已经爬取的URL和错误的URL信息。
*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Crawler
{
    public class Crawler
    {        
        public HashSet<string> Urls = new HashSet<string>();//存放已爬取地址
        public Queue<string> WaitUrls = new Queue<string>();//存放待爬取地址
        public string StartUrl { get; set; }//初始页面
        public int Number { get; set; }//爬取页面总数
        public static int Count;//已爬取页面数
        public string RootUrl;//主网站
        public bool Stop = false;
        public event Action<string> SendMsg;

        public Crawler()
        {
            StartUrl = "https://www.runoob.com/csharp/csharp-tutorial.html";
            Number = 10;            
        }

        public Crawler(int number,string startUrl)
        {
            StartUrl = startUrl;
            Number = number;
        }

        public static void Main(String[] args)
        {
            Crawler crawler = new Crawler();            
            crawler.Crawl();
            return;
        }
        
        public void Crawl()
        {
            Count = 0;
            WaitUrls.Enqueue(StartUrl);
            RootUrl = getRootUrl(StartUrl);
            while (WaitUrls.Count != 0)//待爬取页面存在未爬取url时
            {                
                if (Count >= Number || Stop)
                {
                    SendMsg("总共爬取"+Count+"个页面");
                    break;
                }
                string currentUrl = WaitUrls.Dequeue();                
                if (Urls.Contains(currentUrl)) continue;//已被爬取，跳过
                SendMsg("第" + (Count + 1) + "次爬取" + currentUrl);
                string html = DownLoad(currentUrl);               
                Parse(currentUrl,html);
                SendMsg("爬取结束");
                Urls.Add(currentUrl);
                Count++;
            }
        }

        //获取起始网站网址        
        public string getRootUrl(string url)
        {
            int index = 0;
            //找到第三个/对应的index
            for(int i = 0; i < 3 && index < url.Length; index++)
            {
                if (url[index] == '/') i++;
            }
            if (index == url.Length) return url;//说明是一级地址
            else return url.Substring(0, index - 1);
        }

        //比较网址
        public bool CompareRootUrl(string url1,string url2)
        {
            int index1 = url1.IndexOf("//");
            int index2 = url2.IndexOf("//");
            url1 = url1.Substring(index1 + 2);
            url2 = url2.Substring(index2 + 2);
            if (url1 == url2) return true;
            return false;
        }

        //获取上一级网址
        public string getParentUrl(string url)
        {
            int index = url.LastIndexOf('/');
            if (index == url.IndexOf("//") + 1) return url;
            else return url.Substring(0, index);
        }
        
        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = Count.ToString() + ".html";
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                SendMsg(ex.Message);
                return "";
            }
        }

        //爬取满足条件的url
        public void Parse(string currentUrl,string html)
        {
            string strRef = @"(href|HREF)[ ]*=[ ]*[""'][^""'#>]+[""'#?]";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)//对所有匹配的url进行筛选和转换
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                    .Trim('"', '\"', '#', '>', '?'); ;
                if (strRef.Length == 0) continue;
                // 相对url转换，绝对url判断
                if (strRef.IndexOf("//") == -1) strRef = ConvertRelativeUrl(currentUrl, strRef);
                else if (!CompareRootUrl(RootUrl, getRootUrl(strRef))) continue;                
                if (Urls.Contains(strRef)) continue;
                //SendMsg(strRef);
                WaitUrls.Enqueue(strRef);
            }
        }

        //转换相对地址
        public string ConvertRelativeUrl(string currentUrl, string url)
        {            
            if (url[0] == '/') return getRootUrl(currentUrl) + url;
            //需要返回上级页面时
            while (url[0] == '.')
            {
                if (url[1] == '/') url = url.Substring(2);
                else if (url[1] == '.' && url[2] == '/')
                {
                    currentUrl = getParentUrl(currentUrl);
                    url = url.Substring(3);
                }
            }
            return currentUrl + '/' + url;
        }
    }
}
