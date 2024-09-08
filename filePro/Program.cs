using System;
using System.IO;
using System.Collections.Generic;

class Program{
   static private void Main(string[] args){
        Console.WriteLine("starting with file");
        GetAllDir();
        GetAllFiles();
        GetAllSubDir();

    }
    static public void GetAllDir(){
        IEnumerable<string> ListOfDirectories = Directory.EnumerateDirectories("stores");
        foreach( var dir in ListOfDirectories){
            Console.WriteLine($"Directory.EnumerateDirectories {dir}");
        }
    }

    static public void GetAllFiles(){
        IEnumerable<string> ListOfFiles = Directory.EnumerateFiles("stores");
        foreach(var file in ListOfFiles){
            Console.WriteLine($" Directory.EnumerateFiles {file}");
        }
    }
    static public void GetAllSubDir(){
        IEnumerable<string> allListOfFilesInFolder = Directory.EnumerateFiles("stores","*.txt",SearchOption.AllDirectories);
        foreach(var file in allListOfFilesInFolder){
            Console.WriteLine($"Directory.EnumerateFile {file}");
        }
    }
}