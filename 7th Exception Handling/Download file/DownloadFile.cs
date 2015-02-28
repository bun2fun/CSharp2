using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

/*
Download file

Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
Find in Google how to download files in C#.
Be sure to catch all exceptions and to free any used resources in the finally block.
 */

class DownloadFile
{
    static void Main()
    {
        string url = "http://telerikacademy.com/Content/Images/apple-touch-icon.png";
        string localFileName = Path.GetFileName(url);
        using (WebClient myWebClient = new WebClient())
        {
            try
            {
                Console.WriteLine("Start downloading {0}", url);
                myWebClient.DownloadFile(url, localFileName);
                Console.WriteLine("Download succesfull.");
            }
            catch (UnauthorizedAccessException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (NotSupportedException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (WebException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                if (myWebClient != null)
                {
                    myWebClient.Dispose();
                }
            }
        }
    }
}

