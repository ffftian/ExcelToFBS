using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToFBS
{

    public class FBSCreater
    {
        public string fbsMeta;
        public string nameSpeace;

        public TableCreater root;//主节点

        public FBSCreater(string nameSpeace)
        {
            this.nameSpeace = nameSpeace;
            fbsMeta = $"namespace {nameSpeace};\n";

        }

        public void AddTable(TableCreater tableCreater,bool isRoot = false)
        {
            if(isRoot)
            {
                root = tableCreater;
            }
            fbsMeta += tableCreater.tableMeta;
        }


        public string End()
        {
            fbsMeta += $"root_type {root.tableName};";
            return fbsMeta;
        }
    }

    public class TableCreater
    {
        
        public string tableName;
        public string tableMeta;
         

        public TableCreater(string name)
        {
            tableName = name;
            tableMeta = $"table {name} {"{"}\n";
        }

        public void AddElement(string name, string type)
        {
            tableMeta += $"{name}:{type};\n";
        }
        public void AddVector(string name,string type)
        {
            tableMeta += $"{name}:[{type}];\n";
        }
        public void End()
        {
            tableMeta += "}\n";
        }
    }
}
