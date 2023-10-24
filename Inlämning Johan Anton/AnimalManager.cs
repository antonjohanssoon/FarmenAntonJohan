namespace Farm.anton.johan
{
    public class AnimalManager
    {
        List<Animal> animalList = new List<Animal>();
        List<string> CowCrops;
        List<string> BirdCrops;
        List<string> GoatCrops;
        List<string> PigCrops;


        public AnimalManager()
        {
            CowCrops = new List<string> { "Wheat", "Hay"};
            BirdCrops = new List<string> { "Pellets"};
            GoatCrops = new List<string> { "Maize"};
            PigCrops = new List<string> { "Potato", "Carrot"};

            animalList.Add(new Animal("Märta", "Cow", CowCrops));
            animalList.Add(new Animal("Jens", "Bird", BirdCrops));
            animalList.Add(new Animal("Dante", "Goat", GoatCrops));
            animalList.Add(new Animal("Charlie", "Pig", PigCrops));

        }
        //tar första indexen i , skapa en variabel som användren väljer.
        //MenuCrops deklareras här, den vet bara att det är en lista som består av crops. 
        public void AnimalMenu(List<Crop> MenuCrops)
        {
            Console.WriteLine("Choose crop by Idex.");
            bool CropLoop = false;
            int cropchoice;
            while (!catchLoop)
            {
                for (int i = 0; i < MenuCrops.Count; i++)
                {
                    Console.WriteLine($"{i}\t{MenuCrops[i].Name} \n{MenuCrops[i].CropType}\n {MenuCrops[i].Quantity}");
                }
                try
                {
                    cropchoice = Convert.ToInt32(Console.ReadLine());
                    CropLoop = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            bool AnimalLoop = false;
            
            //man gör att val av animal och sen kontrolleras svaret.
            int AnimalChoice;
            while (!AnimalLoop)
            {

                for (int i = 0; i < animalList.Count ; i++)
                {
                    Console.WriteLine($"{i}\t{animalList[i].Name} \n {animalList[i].Id}\n ");
                }
                Console.WriteLine("Choose animal by index.");
                try
                {
                    AnimalChoice = Convert.ToInt32(Console.ReadLine());
                    AnimalLoop = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            //här skapas crops/animal och lägger in den specifika cropen och djuret i var sin variabel
            Crop Crops = MenuCrops[cropchoice];
            Animal animal = animalList[AnimalChoice];
            bool AnimalCrop = false;
            //switchCasen kollar så att varje djur tar den cropen man skrivit och retunerar true om det stämmer 
            switch (animal.Species)
            {
                case "Cow":
                    for (int i = 0; i < CowCrops.Count; i++)
                    {
                        if (Crops.Name == CowCrops[i])
                        {
                            AnimalCrop = true;
                            break;
                        }
                    }
                    break;

                case "Bird":
                    for (int i = 0; i < Bird.Count; i++)
                    {
                        if (Crops.Name == BirdCrops[i])
                        {
                            AnimalCrop = true;
                            break;
                        }
                    }
                    break;

                case "Goat":
                    for (int i = 0; i < Goat.Count; i++)
                    {
                        if (Crops.Name == GoatCrops[i])
                        {
                            AnimalCrop = true;
                            break;
                        }
                    }
                    break;

                case "Pig":
                    for (int i = 0; i < PigCrops.Count; i++)
                    {
                        if (Crops.Name == PigCrops[i])
                        {
                            AnimalCrop = true;
                            break;
                        }
                    }
                    break;
                    //behöver skapa en ny case för listan man skapar själv om man väljer att skapa ett nytt djur

            }

            //kontroll om djuret äter den cropen
            if (AnimalCrop == true)
            {
                FeedAnimals(animal,Crops);
            }
            else
            {
                Console.WriteLine("Wrong Croptype.");
            }
            
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
                Console.WriteLine("Animal succesfully removed from the list!");
            }
            else
            {
                Console.WriteLine("No animal found with that ID!");
            }

        }
        //tar mot från animalMenu, matematiken sker i feed funktionen som ligger i animal.
        //aAnimal = ett djur som blivit valt i Animalchoise
        //acrop väljs även i cropchoice

        private void FeedAnimals(Animal aAnimal,Crop acrop)
        {
            aAnimal.Feed(acrop);
        }

    }
}
