using System.Diagnostics;
using Zone.DataManager.Abstract.DataProvider.DigitalPayment.PineLabs;
using Zone.DataProvider.DigitalPayment.PineLabs;
using Zone.Infrastructure.Genric.DigitalPayment.PineLabs;

namespace ZPay
{
    public partial class ZPay : Form
    {
        private readonly ISaleRequestProvider _provider = null;
        private static SaleResponse response = new SaleResponse();
        private FileSystemWatcher watcher = null;

        public ZPay(ISaleRequestProvider provider)
        {
            _provider = provider;
            InitializeComponent();
            string path = @"C:\ZPay";
            watcher = new FileSystemWatcher
            {
                Path = path
            };
            watcher.NotifyFilter = NotifyFilters.Attributes
                                | NotifyFilters.CreationTime
                                | NotifyFilters.DirectoryName
                                | NotifyFilters.FileName
                                | NotifyFilters.LastAccess
                                | NotifyFilters.LastWrite
                                | NotifyFilters.Security
                                | NotifyFilters.Size;

            watcher.Filter = "*.json";
            watcher.Created += new FileSystemEventHandler(OnCreated);

            watcher.EnableRaisingEvents = true;
            watcher.Error += new ErrorEventHandler(OnError);
        }


        public async void OnCreated(object sender, FileSystemEventArgs e)
        {

            response = await _provider.SendData(e.FullPath);

        }
        private void refreshPic_Click(object sender, EventArgs e)
        {
            if (!response.ResponseCode)
            {
                OnTransactionSuccess();
            }
            else
            {
                OnTransactionError();
            }
        }

        private void logPicture_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(@"C:\ZPay");
            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }
        }

        public async void OnTransactionSuccess()
        {
            datetime.Text = "DateTime: " + response.InvoiceDate;
            responseMessage.Text = "Message: " + response.ResponseMessage;
            transactionID.Text = "TxnID: " + response.PlutusTransactionReferenceID.ToString();
            responseStatus.Text = "Response: Success";
        }
        public async void OnTransactionError()
        {
            datetime.Text = "DateTime: " + response.InvoiceDate;
            responseMessage.Text = "Message: " + response.ResponseMessage;
            transactionID.Visible = false;
            responseStatus.Text = "Response: Failure";
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
            var processes = Process.GetProcessesByName("Chrome");
            var path = processes.FirstOrDefault()?.MainModule?.FileName;
            Process.Start(path, "https://zeusbusiness.in");
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                Hide();
                notifyIcon.Visible = true;
            }
        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Show();
            notifyIcon.Visible = false;
        }

        private void ZPay_Load(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
        }
    }
}
