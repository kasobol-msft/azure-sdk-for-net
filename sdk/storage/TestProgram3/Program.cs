using Azure.Storage.Blobs;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace TestProgram3
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var value = await new BlobClient(new Uri("https://pakrym0test0storage.blob.core.windows.net/myblobcontainer/VS2015 Image Library.zip")).DownloadAsync();
            var stream = value.Value.Content;

            var buffer = new byte[1024 * 1024];
            int read;
            int total = 0;
            var process = Process.GetCurrentProcess();
            while ((read = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
            {
                total += read;
                process.Refresh();
                Console.WriteLine("Downloaded " + total / 1024 / 1024 + "MB, Process memory " + process.PrivateMemorySize64 / 1024 / 1024 + "MB");
            }
        }
    }
}
