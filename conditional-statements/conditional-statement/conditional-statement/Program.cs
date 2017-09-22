using System; 
2 using System.Collections.Generic; 
3 using System.Linq; 
4 using System.Text; 
5 using System.Threading.Tasks; 
6 
 
7 namespace conditional_statements
8 { 
9     class Program
10     { 
11         static void Main(string[] args)
12         { 
13             // Define instructions 
14             Console.WriteLine("Ohjelma tulostaa positiivinen, negatiivinen tai nolla."); 
15             bool isNumber; 
16             do 
17             { 
18 
 
19                 Console.Write("Syötä luku: "); 
20                 // Define variables 
21                 string userInput; 
22                 userInput = Console.ReadLine(); 
23 
 
24                 int evaluatedNumber; 
25                 isNumber = int.TryParse(userInput, out evaluatedNumber); 
26 
 
27                 // program logic 
28                 if (isNumber == true) 
29                 { 
30                     if (evaluatedNumber< 0) 
31                     { 
32                         Console.WriteLine($"Numero {evaluatedNumber} on negatiivinen"); 
33                     } 
34                     else if (evaluatedNumber > 0) 
35                     { 
36                         Console.WriteLine($"Numero {evaluatedNumber} on positiivinen"); 
37                     } 
38                     else 
39                     { 
40                         Console.WriteLine($"Numero {evaluatedNumber} on nolla"); 
41                     } 
42                 } 
43                 else 
44                 { 
45                     Console.WriteLine("Syötit muuta kuin numeroita."); 
46                 } 
47             } while (isNumber == false); 
48             Console.ReadKey(); 
49 
 
50         } 
51     } 
52 } 
