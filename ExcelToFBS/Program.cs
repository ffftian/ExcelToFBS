using FlatBuffers;
using MyGame.Sample;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ExcelToFBS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] structData = Directory.GetFiles($@"{System.Environment.CurrentDirectory}\Struct");
            string[] table = Directory.GetFiles($@"{System.Environment.CurrentDirectory}\Table");

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;


            Directory.CreateDirectory($@"{System.Environment.CurrentDirectory}\Fbs");
            Directory.CreateDirectory($@"{System.Environment.CurrentDirectory}\Json");
            Directory.CreateDirectory($@"{System.Environment.CurrentDirectory}\Bytes");

            for (int i = 0; i < table.Length; i++)
            {
                FileInfo fileInfo = new FileInfo(table[i]);
                var fileName = fileInfo.Name.Split('.')[0];
                using (var package = new ExcelPackage(fileInfo))
                {
                    ExcelWorksheet sheet = package.Workbook.Worksheets[0];
                    string metaData = AnalyzeToFBX(sheet, fileName);
                    File.WriteAllText($@"{System.Environment.CurrentDirectory}\Fbs\{fileName}.fbs", metaData);


                    Console.WriteLine($"生成C#代码{fileName}");
                    string flatcPath = Path.Combine(System.Environment.CurrentDirectory, "flatc.exe");
                    Process flatc = Process.Start($"flatc.exe", $"--csharp Fbs/{fileName}.fbs");
                    flatc.WaitForExit();

                    Console.WriteLine($"生成Json{fileName}");
                    string data = AnalyzeJson(sheet, "datas");
                    File.WriteAllText($@"{System.Environment.CurrentDirectory}\Json\{fileName}.json", data);


                    Console.WriteLine($"Json转进二进制{fileName}");
                    flatc = Process.Start($"flatc.exe", $"-b Fbs/{fileName}.fbs Json/{fileName}.json");
                    flatc.WaitForExit();

                    Console.WriteLine($"二进制改名为{fileName}.bytes");
                    string binPath = $"{System.Environment.CurrentDirectory}/{fileName}.bin";
                    string bytesPath = $"{System.Environment.CurrentDirectory}/Bytes/{fileName}.bytes";
                    if(File.Exists(bytesPath))
                    {
                        File.Delete(bytesPath);
                    }
                    File.Move(binPath, bytesPath);

                    //byte[] databytes = AnalyzeToBin(sheet, fileName);
                    //Console.WriteLine($"生成二进制{fileName}");
                    //File.WriteAllBytes($@"{System.Environment.CurrentDirectory}\Bin\{fileName}.bin", databytes);

                }
            }



        }

        static public string AnalyzeToFBX(ExcelWorksheet sheet, string fileName)
        {
            //var obj = sheet.Cells.Value as object[,];

            int rowCount = sheet.Dimension.Rows;//竖排行
            int colCount = sheet.Dimension.Columns;//横排列
            FBSCreater fBSCreater = new FBSCreater("MiaoCsharp");
            TableCreater tableDataCreater = new TableCreater(fileName + "Data");//文件名作为类名
                                                                                //撰写数据
            for (int col = 1; col <= colCount; col++)
            {
                // 具体的获取数据
                object type = sheet.Cells[1, col].Value;
                object name = sheet.Cells[2, col].Value;
                if (type != null && name != null)
                {
                    tableDataCreater.AddElement(name.ToString(), type.ToString());
                }
                //TableCreater tableCreater = new TableCreater();
            }
            tableDataCreater.End();
            fBSCreater.AddTable(tableDataCreater, false);

            //撰写链表格式
            TableCreater tableCreater = new TableCreater(fileName + "Table");
            tableCreater.AddVector("datas", fileName + "Data");
            tableCreater.End();
            fBSCreater.AddTable(tableCreater, true);
            return fBSCreater.End();


        }

        static public string AnalyzeJson(ExcelWorksheet sheet, string fileName)
        {
            int rowCount = sheet.Dimension.Rows;//竖排行
            int colCount = sheet.Dimension.Columns;//横排列

            JArray array = new JArray();
            for (int y = 3; y <= rowCount; y++)
            {
                JObject data = new JObject();
                for (int x = 1; x <= colCount; x++)
                {
                    object key = sheet.Cells[2, x].Value;
                    object value = sheet.Cells[y, x].Value;
                    if (key == null || value == null)
                    {
                        break;
                    }

                    if (sheet.Cells[1, x].Value.ToString()[0] == '[')//数组鉴定
                    {
                        string[] valueArray = value.ToString().Split(new char[] {','},StringSplitOptions.RemoveEmptyEntries);

                        JProperty jProperty = new JProperty(key.ToString(), new JArray(valueArray));
                        data.Add(jProperty);
                    }
                    else
                    {
                        JProperty jProperty = new JProperty(key.ToString(), value.ToString());
                        data.Add(jProperty);
                    }
                }
                array.Add(data);
            }
            JObject rss =
new JObject(
    new JProperty("datas",
        new JArray(array)
        ));

            return rss.ToString();
        }

    }
}
