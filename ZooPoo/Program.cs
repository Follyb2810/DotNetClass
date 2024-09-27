﻿using System;

string[] pettingZoo = 
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

PlanSchoolVisit("School A");
PlanSchoolVisit("School B", 3);
PlanSchoolVisit("School C", 2);

void PlanSchoolVisit(string schoolName, int groups = 6) 
{
    RandomizeAnimals(); 
    string[,] group1 = AssignGroup(groups);
    Console.WriteLine(schoolName);
    PrintGroup(group1);
}

void RandomizeAnimals() 
{
    Random random = new Random();

    for (int i = 0; i < pettingZoo.Length; i++) 
    {
        int r = random.Next(i, pettingZoo.Length);

        string temp = pettingZoo[r];
        pettingZoo[r] = pettingZoo[i];
        pettingZoo[i] = temp;
    }
}

string[,] AssignGroup(int groups = 6) 
{
    string[,] result = new string[groups, pettingZoo.Length/groups];
    int start = 0;

    for (int i = 0; i < groups; i++) 
    {
        for (int j = 0; j < result.GetLength(1); j++) 
        {
            result[i,j] = pettingZoo[start++];
        }
    }

    return result;
}

void PrintGroup(string[,] groups) 
{
    for (int i = 0; i < groups.GetLength(0); i++) 
    {
        Console.Write($"Group {i + 1}: ");
        for (int j = 0; j < groups.GetLength(1); j++) 
        {
            Console.Write($"{groups[i,j]}  ");
        }
        Console.WriteLine();
    }
}
// // See https://aka.ms/new-console-template for more information
// using System;

// class Program
// {
//     public static void Main(string[] args)
//     {


//         string[] pettingZoo =
//         {
//     "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
//     "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
//     "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
// };

//         RandomizeAnimals();
//         string[,] group = AssignGroup();
//         Console.WriteLine("School A");
//         // PrintGroup(group);

//         void RandomizeAnimals()
//         {
//             Random random = new Random();

//             for (int i = 0; i < pettingZoo.Length; i++)
//             {
//                 int r = random.Next(i, pettingZoo.Length);

//                 string temp = pettingZoo[r];
//                 pettingZoo[r] = pettingZoo[i];
//                 pettingZoo[i] = temp;
//             }
//         }

//         string[,] AssignGroup(int groups = 6)
//         {
//             string[,] result = new string[groups, pettingZoo.Length / groups];
//             int start = 0;

//             for (int i = 0; i < groups; i++)
//             {
//                 for (int j = 0; j < result.GetLength(1); j++)
//                 {
//                     result[i, j] = pettingZoo[start++];
//                 }
//             }

//             return result;
//         }
//         void PrintGroup(string[,] group) 
// {
//     for (int i = 0; i < group.GetLength(0); i++) 
//     {
//         Console.Write($"Group {i + 1}: ");
//         for (int j = 0; j < group.GetLength(1); j++) 
//         {
//             Console.Write($"{group[i,j]}  ");
//         }
//         Console.WriteLine();
//     }
// }
//     }
// }
// // PlanSchoolVisit("School A");
// // PlanSchoolVisit("School B", 3);
// // PlanSchoolVisit("School C", 2);
// // void PlanSchoolVisit(string schoolName, int groups = 6)
// // {
// //     RandomizeAnimals();
// //     string[,] group = AssignGroup(groups);
// //     Console.WriteLine(schoolName);
// //     PrintGroup(group);
// // }
// // void PlanSchoolVisit(string schoolName, int groups = 6)
// // {
// //     RandomizeAnimals();
// //     string[,] group = AssignGroup();
// //     Console.WriteLine("School A");
// //     PrintGroup(group);
// // }
// // Console.WriteLine("Hello, World!");

// // string[] pettingZoo = 
// // {
// //     "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
// //     "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
// //     "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
// // };

// // RandomizeAnimals();
// // // string[,] group = AssignGroup();
// // Console.WriteLine("School A");
// // // PrintGroup(group);

// // void RandomizeAnimals() 
// // {
// //     Random random = new Random();

// //     for (int i = 0; i < pettingZoo.Length; i++) 
// //     {
// //         int r = random.Next(i, pettingZoo.Length);

// //         string temp = pettingZoo[r];
// //         pettingZoo[r] = pettingZoo[i];
// //         pettingZoo[i] = temp;
// //     }
// // }
// // foreach(string animal in pettingZoo) 
// // {
// //     Console.WriteLine(animal);
// // }