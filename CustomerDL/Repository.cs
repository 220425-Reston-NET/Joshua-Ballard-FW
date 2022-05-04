using System.Text.Json;
using CustomerModel;

namespace CustomerDL
{
    public class Repository{
        //Designate the filepath:
        private static string _filepath = "../CustomerDL/Data/Customer.json";

        //Method adds customer information to our data:
        public static void AddCustomer(Customer p_customer){
            List<Customer> listOfCustomer = GetAllCustomer();
            listOfCustomer.Add(p_customer);

            string jsonString = JsonSerializer.Serialize(listOfCustomer, new JsonSerializerOptions{WriteIndented = true});
            File.WriteAllText(_filepath, jsonString);
        }
        
        public static List<Customer>GetAllCustomer(){
            string jsonString = File.ReadAllText(_filepath);
            List<Customer> listOfCustomer = JsonSerializer.Deserialize<List<Customer>>(jsonString);

            return listOfCustomer;                      
        }
    }

}
