//Creates a Menu class

public class Menu{
    private int _cost=0;
    private int _soda;
    private int _bread;
    private int _milk;
    private int _salad;
    private int _fruit;
    
    String Soda="Soda";
    String Bread="Bread";
    String Milk="Milk";
    String Salad="Salad";
    String Fruit="Fruit";
    public String userInput;

    public int CustomersOrder(){
            Console.WriteLine("-=Please enter what items you would like to purchase=-");
            Console.WriteLine("Soda $" +_soda);
            Console.WriteLine("Milk $" +_milk);
            Console.WriteLine("Bread $" +_bread);
            Console.WriteLine("Fruit $" +_fruit);
            Console.WriteLine("Salad $" +_salad);
            
            userInput = Console.ReadLine();
            if(userInput==Soda){
                _cost=_soda;
            }
            else if(userInput==Milk){
                _cost=_milk;
            }
            else if(userInput==Bread){
                _cost=_bread;
            }
            else if(userInput==Fruit){
                _cost=_fruit;
            }
            else if(userInput==Salad){
                _cost=_salad;
            }
            else{
                Console.WriteLine("Did not understand user input.");
                _cost = 0;
            }
            return _cost;
    }

     public Menu(){
         _soda=2;
         _milk=3;
        _bread=4;
        _fruit=5;
        _salad=6;
    }

}//end of class