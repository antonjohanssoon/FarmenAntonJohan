namespace Farm.anton.johan
{
    public class Farm
    {
        public void MainMenu()
        {

            CropManager cropmanager = new();
            AnimalManager animalmanager = new();

            bool breakMenu = true;
            while (breakMenu)
            {
                Console.WriteLine("Where do you want to go?");
                Console.WriteLine("1. Animal Menu");
                Console.WriteLine("2. Crop Menu");
                Console.WriteLine("3. End program");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        var Crops = cropmanager.GetCrops();
                        animalmanager.AnimalMenu(Crops);
                        break;
                    case "2":
                        cropmanager.CropMenu();
                        break;
                    case "3":
                        Console.WriteLine("Program: Ended");
                        breakMenu = false;
                        break;

                }
            }
        }
    }
}
