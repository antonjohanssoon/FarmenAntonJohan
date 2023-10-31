namespace Farm.anton.johan
{   //Innehåller djur som äter en vis typ av "Crop" med konstruktor som vi kan skapa en lista utav i AnimalManager
    public class Animal : Entity
    {
        public string Species { get; set; }
        public string Crop1;
        public string Crop2;
        private static int NextId = 1;
        public Animal(string _name, string _species, string crop1, string crop2) : base(NextId, _name)
        {
            NextId++;
            Species = _species;
            Crop1 = crop1;
            Crop2 = crop2;
        }

        public override string GetDescription()
        {
            return $"Id: {Id}, Name: {Name}, Species: {Species}, Acceptable Crops: {Crop1}, {Crop2}";
        }

        public void Feed(Crop acrop)
        {
            acrop.Quantity -= 1;
        }
    }
}