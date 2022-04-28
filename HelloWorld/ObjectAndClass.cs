//This is how you create a class by using the class keyword
//This is just there to make the class available
//[Access modifier]class [Object title]
public class Car
{
    //This is a field
    //It is used to store information or define the current state of the object
    //Default fields should be 'private'
    private string _color;
    private string _owner;
    private int _fuel;
    private int _gallonPerMile;

    //Method:
    public int TotalDistancePerFuel()
    {
        Console.WriteLine("Current Fuel: " + _fuel);
        Console.WriteLine($"Gallon Per Mile: {_gallonPerMile} This is the owner: {_owner}");

        Console.WriteLine(_fuel/_gallonPerMile + " This is how many miles");

        //Return keyword sends back information:
        return _fuel/_gallonPerMile;
    }

    //Methods with parameters:
    public void Sum(int num1, int num2){
        Console.WriteLine("Sum method calculation: " + (num1+num2));
    }

    //This is a constructor (special method that will run whenever you create an object):
    public Car(){
        _color = "Blue";
        _fuel = 100;
        _gallonPerMile = 5;
        _owner = "Stephen";
    }

    public Car(String p_owner){
        _owner = p_owner;
    }
    
    //This is Property
    //Give us the flexibility to check that the data being stored is coreect, only certain things can access data
    //Making things read or write only
    public string Owner{
        //get keyword is how data is shared:
        get{return _owner + " is the owner of the car.";}

        //set keyword is how you change the data that is stored:
        set{_owner=value + " Owner";}
    }

    //Fuel restricion(Only 1-100)
    public int Fuel{
        get{return _fuel;}


        set{
            if(value<=100 && Fuel>=0)
            {
                _fuel=value;
            }
            //else if (value >=0)
            //{
            //   _fuel = value;
            // }
            else
            {
                Console.WriteLine("Fuel can ONLY hold 0-100 gallons.");
            }
        }
    }
    
}//end of program