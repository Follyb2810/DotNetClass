using System;
using System.Collections.Generic;
using System.IO;

public class Program{
    private static void Main(string[] args){
        Console.WriteLine("starting with files in advance");
        // Call the FindFiles method to retrieve the list of sales files
        // var salesFiles = FindFiles("stores");
        // foreach(var file in salesFiles){
        //     Console.WriteLine(file);  // Print each file path
        // }
        GetAllDir();
    }
    static public void GetAllDir(){
        IEnumerable<string> ListOfDirectories = Directory.EnumerateDirectories("stores");
        foreach( var dir in ListOfDirectories){
            Console.WriteLine($"Directory.EnumerateDirectories {dir}");
        }
    }
    // Correctly define the FindFiles method to return a List of strings
    private static List<string> FindFiles(string folder){
        List<string> salesFiles = new List<string>();

        // Correctly enumerate files in the directory
        var foundFiles = Directory.EnumerateFiles(folder, "*", SearchOption.AllDirectories);

        // Print the found files (joined by commas)
        Console.WriteLine($"{string.Join(",", foundFiles)}");

        // Loop through the found files and add only those ending with 'salesFiles.json' to the list
        foreach(var file in foundFiles){
            if(file.EndsWith("sales.json")){
                salesFiles.Add(file);
            }
        }

        // Return the list of sales files
        return salesFiles;
    }
}
