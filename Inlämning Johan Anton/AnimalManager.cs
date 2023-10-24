namespace Farm.anton.johan
{
    public class AnimalManager
    {
        List<Animal> animalList = new List<Animal>();

        public AnimalManager()
        {
            List<string> CowCrops = new List<string> { "Wheat", "Hay" };
            List<string> BirdCrops = new List<string> { "Pellets" };
            List<string> GoatCrops = new List<string> { "Maize" };
            List<string> PigCrops = new List<string> { "Potato", "Carrot" };

            animalList.Add(new Animal("Märta", "Cow", CowCrops));
            animalList.Add(new Animal("Jens", "Bird", BirdCrops));
            animalList.Add(new Animal("Dante", "Goat", GoatCrops));
            animalList.Add(new Animal("Charlie", "Pig", PigCrops));

        }

        private void ViewAnimal()
        {
            for (int i = 0; i < animalList.Count; i++)
            {
                animalList[i].GetDescription();
            }
        }

        public void AddAnimal()
        {
            bool QuitLoop = false;
            ViewAnimal();

            while (!QuitLoop)
            {

                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("What´s the name of the animal you would like to add?");
                    string input1 = Console.ReadLine();

                    Console.WriteLine("What specie is the animal?");
                    string input2 = Console.ReadLine();

                    Console.WriteLine("How many crops can the animal eat?");
                    int loopInput = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("What crops should the animal eat?");
                    List<string> NewAnimalCrop = new List<string>();
                    for (i = 0; i < loopInput; i++)
                    {
                        string cropInput = Console.ReadLine();
                        NewAnimalCrop.Add(cropInput);
                    }

                    Animal newanimal = new Animal(input1, input2, NewAnimalCrop);
                    animalList.Add(newanimal);

                    Console.WriteLine("Do you want to continue? yes/no?");
                    string input4 = Console.ReadLine();

                    if (input4 == "no")
                    {
                        QuitLoop = true;
                        break;
                    }
                }
            }
        }

        private void RemoveAnimal()
        {
            ViewAnimal();

            Console.WriteLine("What animal do you want to remove from list above? Answear by Id: ");
            int input1 = Convert.ToInt32(Console.ReadLine());

            Animal animalToRemove = animalList.FirstOrDefault(animal => animal.Id == input1);

            if (animalToRemove != null)
            {
                animalList.Remove(animalToRemove);
                Console.WriteLine("Animal removed succesfully from the list!");
            }
            else
            {
                Console.WriteLine("No animal found with that ID!");
            }

        }

        private void FeedAnimals(Crop aCrop)
        {
            ViewAnimal();
            Console.WriteLine("What animal do you want to feed? Answer by ID!");
            int input = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < animalList.Count; i++)
            {
                if (input == animalList[i].Id)
                {
                    //???
                    //animalList[i].Feed();
                    Console.WriteLine("We goit here!");
                }
            }

        }

    }
}
