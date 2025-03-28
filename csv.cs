using System;
using System.Data;

namespace csv
{
    internal class Program 

    static void Main(string[] args){
        var filePath 
        using(var reader = new StreamReader(csvPath))
        {
            while(reader.EndOfStream == false){
                var line = reader.ReadLine();
                var cells = line.Split(',').ToList();
                if(hasData){

                }
            }
        }
    }

    static bool hasData(List<string> line){
        return cells.Any(x => x.length > 0);

    }
}