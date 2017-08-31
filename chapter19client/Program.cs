using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

public class EchoClient
{
    public static void Main()
    {
        try
        {

            while (true)
            {
                TcpClient client = new TcpClient("127.0.0.1", 8080);
                StreamReader reader = new StreamReader(client.GetStream());
                StreamWriter writer = new StreamWriter(client.GetStream());
                String s = String.Empty;
                s = Console.ReadLine();
                if (s == "add")
                {
                    chapter19client.AddOrSub method = new chapter19client.AddOrSub();
                    int d = method.add(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                    Console.WriteLine();
                    writer.WriteLine(d.ToString());
                    writer.Flush();
                    String server_string = reader.ReadLine();
                    Console.WriteLine(server_string);
                }
               else if (s == "sub")
                {
                    chapter19client.AddOrSub method = new chapter19client.AddOrSub();
                    int d = method.Sub(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                    Console.WriteLine();
                    writer.WriteLine(d.ToString());
                    writer.Flush();
                    String server_string = reader.ReadLine();
                    Console.WriteLine(server_string);
                }



            }

            //reader.Close();
            //writer.Close();
            //client.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    } // end Main()
} // end class definition