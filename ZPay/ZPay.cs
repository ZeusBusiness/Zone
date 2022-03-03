using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zone.DataManager.Abstract.DataProvider.DigitalPayment.PineLabs;
using Zone.Infrastructure.Genric.DigitalPayment.PineLabs;

namespace ZPay
{
    public partial class ZPay : Form
    {
        private readonly ISaleRequestProvider _provider;
        private static SaleResponse response = new SaleResponse();
        public ZPay(ISaleRequestProvider provider)
        {
            InitializeComponent();
            _provider = provider;
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = @"C:\ZPay";
            watcher.NotifyFilter = NotifyFilters.Attributes
                                 | NotifyFilters.CreationTime
                                 | NotifyFilters.DirectoryName
                                 | NotifyFilters.FileName
                                 | NotifyFilters.LastAccess
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.Security
                                 | NotifyFilters.Size;

            watcher.Filter = "*.*";
            watcher.Created += new FileSystemEventHandler(OnCreated);
            //watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Error += new ErrorEventHandler(OnError);
            watcher.EnableRaisingEvents = true;
        }

        private async void OnCreated(object sender, FileSystemEventArgs e)
        {
            response = await _provider.SendData(e.FullPath);
        }


        private static void OnError(object sender, ErrorEventArgs e) =>
        PrintException(e.GetException());

        private static void PrintException(Exception? ex)
        {
            if (ex != null)
            {
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine("Stacktrace:");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine();
                PrintException(ex.InnerException);
            }
        }

        private void zeusLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://zeusbusiness.in");
        }
    }
}
