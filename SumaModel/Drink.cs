namespace SumaModel
{
    public class Drink
    {
        private double _price;
        private List<Addon> _addOns;
        
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price 
        {
            get { return _price; }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    throw new Exception("Price cannot be negative.");
                }

            } 
        }
        public List<Addon> Addon 
        {
            get { return Addon; } 
            set { _addOns = value; }
        }
        public string Temp { get; set; }

        public Drink() //default properties
        {
            ID = 1;
            Name = "Iced Coffee";
            Price = 2.50;
            //Addon.Name = "n/a";
            Temp = "Ice";

        }

    }   
}

