namespace Farm.anton.johan
{   
    public class Crop : Entity
    {
        public string CropType { get; set; }
        public int Quantity { get; set; }
        private static int NextId = 1;
        
        public Crop(string _name, string _cropType, int _quantity) : base(NextId,_name)
        {
            NextId++;
            CropType = _cropType;
            Quantity = _quantity;

        }

        //Ger infon om Växten
        public override string GetDescription()
        {
            return $"Id: {Id}, Name: {Name}, Crop Type: {CropType}, Quantity: {Quantity}";
        }

        //lägg till i kvantitet 
        public void AddCrop(int _quantity)
        {
            
            Console.WriteLine("How many?");
            try
            {
                _quantity = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("You must write Id-number. ");
                return;
            }
            
            Quantity += _quantity;
        }

        public bool TakeCrop(Crop acrop)
        {
            if (acrop.Quantity < 0)
            {
                return false;
            }
            else 
            {
                return true;
            }
        }

    }
}