Menu cost = new Menu();
int total=0;
string answer;

bool repeat=true;
while(repeat==true){  
    Console.Clear();
    total += cost.CustomersOrder();

    Console.WriteLine("Would you like to purchase more items? (Y or N)");
    answer = Console.ReadLine();
    
    if (answer =="Y"){
        repeat=true;
    }
    else if (answer == "N"){
        repeat = false;
        Console.WriteLine("Total: $" + total);
        Console.WriteLine("Thank you for shopping with us. Have a nice day");
    }
    else{
        Console.WriteLine("Did not understand input.");
        Console.WriteLine("Press any key to continue");
        Console.ReadLine();

    }
}



// // See https://aka.ms/new-console-template for more information
// Console.Clear(); //Will clear the console
// Console.WriteLine("Hello, World!"); //Writeline will write something in the terminal

// //[Class name] [NameOfObject] = new [Class name]();
// Car carObj1 = new Car();

// //Referencing class members within an object
// int mile = carObj1.TotalDistancePerFuel();

// carObj1.Sum(5, 10);

// Console.WriteLine(mile);

// Console.WriteLine("End of Method");
// string owner = "Chadel";

// Car carObj2 = new Car(owner);
// Console.WriteLine(carObj2.Owner);
// carObj2.Owner = "Maaz";
// Console.WriteLine(carObj2.Owner);

// //Checking if our property constraints is working
// carObj2.Fuel = -100;
// Console.WriteLine(carObj2.Fuel);

// bool repeat =false;
// while(repeat)
// {
//     String answer = Console.ReadLine();
//     if (answer ==""){

//     }
//     else if (answer == "Exit"){
//         repeat = false;

//     }
//     else{

//     }
// }