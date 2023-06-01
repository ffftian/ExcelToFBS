using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToFBS
{
    public class JsonCreater
    {
        public string metaData;
        public string arrayName;

        public JsonCreater(string array)
        {
            metaData += "{";
            metaData += $"\"array\":[";
            this.arrayName = array;
        }
        public void AddGroup()
        {

        }

        public void AddElement(string key, string value)
        {

        }
        public void EndGroup()
        {

        }
        public void End()
        {

        }



    }
}
