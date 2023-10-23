namespace Farm.anton.johan
{
    public class AnimalManager
    {
        List<Animal> animalList = new List<Animal>();
        List<string> acceptableCrops = new List<string> { "Wheat", "Corn", "Barley" };

        public AnimalManager()
        {
            List<string> CowCrops = new List<string>();
            List<string> BirdCrops = new List<string>();
            List<string> GoatCrops = new List<string>();
            List<string> PigCrops = new List<string>();

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

        private void AddAnimal()
        {
            bool QuitLoop = false;
            ViewAnimal();

            while (!QuitLoop)
            {

                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("What animal would you like to add?");
                    string input1 = Console.ReadLine();

                    Console.WriteLine("What specie is the animal?");
                    string input2 = Console.ReadLine();

                    Console.WriteLine("What crop does it eat? Food crops or crops?");
                    string input3 = (Console.ReadLine());

                    Animal newanimal = new Animal(input1, input2, input3);
                    animalList.Add(newanimal);

                    Console.WriteLine("Do you want to continue? yes/no?");
                    string input4 = Console.ReadLine();

                    if (input4 == "no")
                    {
                        QuitLoop = true;
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

        private void FeedAnimals(string Crop)
        {
            ViewAnimal();
            Console.WriteLine("What animal do you want to feed? Answer by ID!");
            int input = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < animalList.Count; i++)
            {
                if (input == animalList[i].Id)
                {
                    //???
                }
            }

        }

    }
}
