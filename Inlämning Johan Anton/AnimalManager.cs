namespace Farm.anton.johan
{ //göra om animal-classens konstruktor. så att listan tar typ 2
    public class AnimalManager
    {
        List<Animal> animalList = new List<Animal>();

        public AnimalManager()
        {

            animalList.Add(new Animal("Märta", "Cow", "Wheat", "Grass"));
            animalList.Add(new Animal("Jens", "Bird", "Seeds", "Maize"));
            animalList.Add(new Animal("Dante", "Goat", "Grass", "Wheat"));
            animalList.Add(new Animal("Charlie", "Pig", "Maize", "Compost"));

        }
        //tar första indexen i , skapa en variabel som användren väljer.
        //MenuCrops deklareras här, den vet bara att det är en lista som består av crops. 
        public void AnimalMenu(List<Crop> MenuCrops)
        {
            bool breakbool = false;
            while (!breakbool)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1: View Animals.");
                Console.WriteLine("2: Add Animals.");
                Console.WriteLine("3: Remove Animal.");
                Console.WriteLine("4: Feed animal");
                Console.WriteLine("5: Return to main menu");
                string switchinput = Console.ReadLine();

                switch (switchinput)
                {
                    case "1":
                        Console.Clear();
                        ViewAnimal();
                        break;
                    case "2":
                        Console.Clear();
                        AddAnimal();
                        break;
                    case "3":
                        Console.Clear();
                        RemoveAnimal();
                        break;
                    case "4":
                        Console.WriteLine("Choose crop by Index.");
                        bool CropLoop = false;
                        int cropchoice = 0;

                        //Skapar denna variablen för att kunna jämföra cropchoice2 med crop1/crop2 som djuret har.
                        Crop cropchoice2 = null;

                        while (!CropLoop)
                        {
                            for (int i = 0; i < MenuCrops.Count; i++)
                            {
                                Console.WriteLine($"{i}, {MenuCrops[i].Name}");
                                Console.WriteLine("");
                            }
                            try
                            {
                                cropchoice = Convert.ToInt32(Console.ReadLine());
                                //Gör om cropchoice som är int till cropchoice2 som är av typen Crop
                                cropchoice2 = MenuCrops[cropchoice];

                                CropLoop = true;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e);
                            }
                        }
                        bool AnimalLoop = false;
                        //man gör att val av animal och sen kontrolleras svaret.
                        int AnimalChoice = 0;


                        while (!AnimalLoop)
                        {
                            for (int i = 0; i < animalList.Count; i++)
                            {
                                Console.WriteLine($"{i}, {animalList[i].Species} , {animalList[i].Name} , {animalList[i].Crop1} or {animalList[i].Crop2} ");
                            }
                            Console.WriteLine("Choose animal by index.");
                            try
                            {
                                AnimalChoice = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e);
                                return;
                            }

                            //här skapas crops/animal och lägger in den specifika cropen och djuret i var sin variabel
                            Crop Crops = MenuCrops[cropchoice];
                            Animal animal = animalList[AnimalChoice];
                            bool AnimalCrop = false;
                            //kontroll om djuret äter den cropen
                            if (cropchoice2.Name == animal.Crop1 || cropchoice2.Name == animal.Crop2)
                            {
                                AnimalCrop = true;
                            }

                            //kontroll om djuret äter den cropen
                            if (AnimalCrop == true)
                            {
                                FeedAnimals(animal, Crops);

                                Console.WriteLine();
                                AnimalLoop = true;
                            }
                            else
                            {
                                Console.WriteLine("Wrong crop type for this animal.");
                                break;
                            }

                        }
                        break;
                    case "5":
                        Console.WriteLine("You returned to main menu!");
                        breakbool = true;
                        break;
                    default:
                        break;

                }

            }

        }
        private void ViewAnimal()
        {
            Console.WriteLine("Your list of animals:");
            for (int i = 0; i < animalList.Count; i++)
            {
                Console.WriteLine(animalList[i].GetDescription());
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

                    Console.WriteLine("What species is the animal?");
                    string input2 = Console.ReadLine();

                    Console.WriteLine("Write 2 crops the animal can eat.");
                    string crop1 = Console.ReadLine();
                    string crop2 = Console.ReadLine();

                    Animal newanimal = new Animal(input1, input2, crop1, crop2);
                    animalList.Add(newanimal);
                    Console.WriteLine(newanimal.Name + " added to your list of animals!");

                    Console.WriteLine("Do you want to add another animal? yes/no?");
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
                Console.WriteLine(animalToRemove.Name + " succesfully removed from the list!");
            }
            else
            {
                Console.WriteLine("No animal found with that ID!");
            }
        }


        //tar mot från animalMenu, matematiken sker i feed funktionen som ligger i animal.
        //aAnimal = ett djur som blivit valt i Animalchoise
        //acrop väljs även i cropchoice


        private void FeedAnimals(Animal aAnimal, Crop acrop)
        {
            aAnimal.Feed(acrop);
            if (acrop.TakeCrop(acrop) == true)
            {
                Console.WriteLine(aAnimal.Name + " feeded succesfully!");
            }
            else
            {
                Console.WriteLine("No crops left");
            }
        }
    }
}
