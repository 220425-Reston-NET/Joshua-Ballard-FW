using CustomerModel;
using CustomerDL;
//Create MainMenu:
    public class MainMenu{
        public void Display(){
            Console.WriteLine("Welcome to Main Store Hub Window");
            Console.WriteLine("[1] - Add Customer");
            Console.WriteLine("[2] - Search for Customer");
            Console.WriteLine("[3] - View Store Front Inventory");
            Console.WriteLine("[4] - Place Order");
            Console.WriteLine("[5] - Replenish Inventory");
            Console.WriteLine("[6] - Exit Program");
        }

        public string YourChoice(){
            string userInput = Console.ReadLine();

            //userInput Choices:
            if(userInput=="1"){//add customer
                //Create customer object:
                Customer customerobj = new Customer();
                
                Console.WriteLine("Customer's Name: ");
                customerobj.Name = Console.ReadLine();

                Console.WriteLine("Customer's Address: ");
                customerobj.Address = Console.ReadLine();

                Console.WriteLine("Customer's Phone Number: ");
                customerobj.Phone = Console.ReadLine();

                Console.WriteLine("Customer's E-Mail: ");
                customerobj.Email = Console.ReadLine();

                Repository.AddCustomer(customerobj);
                return "1";
            }
            else if(userInput=="2"){
                return "2";
            }
            else if(userInput=="3"){
                return "3";
            }
            else if(userInput=="4"){
                return "4";
            }
            else if(userInput=="5"){
                return "5";
            }
            else if(userInput=="6"){
                return "6";
            }
            else {
                return "Error"; 
            }           
        }//end of YourChoice()

    }//end of MainMenu()