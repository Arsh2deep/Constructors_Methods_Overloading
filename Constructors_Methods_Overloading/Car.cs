namespace Constructors_Methods_Overloading
{
    public class Car 
    {
        //Feilds
        string _make;
        string _model;
        int _year;
        int _mileage;

        public Car()//Default Constructor
        {
            _make = "Unassinged";
            _model = "Unassigned";
           _year = 0;
            _mileage = 0;
        }

        public Car(string make, string model)//Half info Constructor
        { 
            _make = make;
            _model = model;
            _year = 0;
            _mileage = 0;
        }

        public Car(int year,string make ,string model, int mileage )//FUll info constructor
        {
            Make = make;
            Model = model;
            Year = year;
            Mileage = mileage;
        }

        //Properties
        public string Make { get => _make; set => _make = value; }
        public string Model { get => _model; set => _model = value; }
        public int Year { get => _year; set => _year = value; }
        public int Mileage { get => _mileage; set => _mileage = value; }

        public override string ToString()
        {
            return $"{_year} {_make}  {_model} - Mileage {_mileage}";

        }

    }//Class

}//Namespace