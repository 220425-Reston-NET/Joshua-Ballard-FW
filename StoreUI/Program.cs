using CustomerModel;

Console.Clear();
//Create MainMenu object:
MainMenu menu = new MainMenu();

//Create Boolean variable for exiting program:
bool repeat = true;

while (repeat){
    Console.Clear();
    menu.Display();
    string ans = menu.YourChoice();

    if(ans=="1"){//add cutomer
        Console.Clear();
        //Logic add customer:
        Customer customerobj = new Customer();
    }
    if(ans=="2"){}
    else if(ans=="3"){}
    else if(ans=="4"){}
    else if(ans=="5"){}
    else if(ans=="6"){//exit
        repeat = false;
    }
}
