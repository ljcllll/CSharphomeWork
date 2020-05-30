using System;
using Crawler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrawlApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        public global::Crawler.Crawler crawler;

        public void start()
        {
            MsgListBox.Items.Clear();
            crawler.SendMsg += str =>
            {
                MsgListBox.BeginUpdate();
                MsgListBox.Items.Add(str);
                MsgListBox.EndUpdate();
                MsgListBox.SelectedIndex = MsgListBox.Items.Count - 1;
            };
        }
      
        private void startBtn_Click(object sender, EventArgs e)
        {
            int Number = 0;
            while (true)
            {
                if (int.TryParse(NumberText.Text, out Number) && Number > 0) break;             
            }
            crawler = new global::Crawler.Crawler(Number, StartUrlText.Text);
            start();
            new Thread(crawler.Crawl).Start();
        }

        private void endBtn_Click(object sender, EventArgs e)
        {
            crawler.Stop = true;
        }

    }
}
