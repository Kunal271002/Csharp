Console.WriteLine(" World!!!");
// // Console.WriteLine("Praise the great leader... Kunal Sharma");
// string KunalSharma = "My name is Kunal Sharma";
// Console.WriteLine(KunalSharma);



//crud 
//Create Read Update Delete.

//Create and Concatinate
var name = "Kunal";
Console.WriteLine(name);
var lname = "Sharma ";
var fullname = name + lname;
Console.WriteLine(fullname);

//Templates Literals 
Console.WriteLine($"I am buying a puffer fish {fullname} you cannot stop me");

//Read
Console.WriteLine(fullname);

//Update 
string newfish = fullname.Replace("KunalSharma","Gaurav Myana");
Console.WriteLine(newfish);