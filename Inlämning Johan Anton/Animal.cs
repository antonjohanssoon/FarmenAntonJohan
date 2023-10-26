namespace Farm.anton.johan
{   //Innehåller djur som äter en vis typ av "Crop" med konstruktor som vi kan skapa en lista utav i AnimalManager
    public class Animal : Entity
    {
        public string Species { get; set; }
        public string Crop1;
        public string Crop2;
        public Animal(string _name, string _species, string crop1, string crop2) : base(_name)
        {
            Species = _species;
            Crop1 = crop1;
            Crop2 = crop2;
        }

        public override string GetDescription()
        {
            return $"Id: {Id}, Name: {Name}, Species: {Species}, AcceptableCropTypes: {Crop1}, {Crop2}";
        }

        public void Feed(Crop acrop)
        {
            acrop.Quantity -= 1;
        }
    }
}
//crops skall försvinna från quantity när ett djur äter crops.
//vad äter djuret?
//få fram en lista på alla djur så man kan välja vem man skall mata
//sedan måste "AcceptableCropType == CropType " för att djuret skall äta det