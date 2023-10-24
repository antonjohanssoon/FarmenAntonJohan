namespace Farm.anton.johan
{   //Innehåller djur som äter en vis typ av "Crop" med konstruktor som vi kan skapa en lista utav i AnimalManager
    public class Animal : Entity
    {
        public string Species { get; set; }
        private List<string> AcceptableCropType { get; set; }

        public Animal(string _name, string _species, List<string> _acceptableCropType) : base(_name)
        {
            Species = _species;
            AcceptableCropType = _acceptableCropType;
        }

        public override string GetDescription()
        {
            return $"Id: {Id}, Name: {Name}, Species: {Species}, AcceptableCropType: {AcceptableCropType}";
        }

        public void Feed(Crop acrop)
        {
            //vad äter djuret?
            //få fram en lista på alla djur så man kan välja vem man skall mata
            //sedan måste "AcceptableCropType == CropType " för att djuret skall äta det
        }
    }
}
