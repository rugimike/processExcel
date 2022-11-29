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
            //error in 4,7,
            using(var reader = new StreamReader(@"D:\kilifi\4.csv"))
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
                                  +" VALUES('2122', 'kili', 'normal', '2022-11-29', '"+ from + "', '"+ to + "', '"+linkId + "', '"+text.Replace("'", "''") + "','"+ networkCode + "');";
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
