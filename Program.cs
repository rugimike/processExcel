using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            readCSV();
        }
        public static void readCSV()
        {
            using(var reader = new StreamReader(@"D:\readings.csv"))
            {
               
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split('\n');
                    try
                    {
                        var linevalue = values[0];
                        var indvalues = linevalue.Split(",");
                        var text = indvalues[5];
                        var date = indvalues[0];
                        var from = indvalues[3];
                        var messageid = indvalues[1];
                        var linkId = indvalues[2];
                        var to = indvalues[4];
                        var networkCode = 1;
                        var query = "INSERT INTO short_code_inbox(messageid,org,type,date,sender,receiver,linkid,text,networkCode)"
                                  +" VALUES('"+ messageid + "', 'kili', 'normal', '"+ date + "', '"+ from + "', '"+ to + "', '"+linkId + "', '"+text+"','"+ networkCode + "');";
                        Console.WriteLine(query);
                    }
                    catch (Exception e)
                    {
                        var x =e.ToString();
                    }

                    //listA.Add(values[0]);
                   // listB.Add(values[1]);
                }
            }
        }
    }
}
