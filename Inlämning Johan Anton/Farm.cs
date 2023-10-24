﻿namespace Farm.anton.johan
{
    public class Farm
    {
        public void MainMenu()
        {
            CropManager cropmanager = new ();
            AnimalManager animalmanager = new();

            Console.WriteLine("Where do you want to go?");
            Console.WriteLine("1. Animal Menu");
            Console.WriteLine("2. Crop Menu");
            Console.WriteLine("9. End program");
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
                case "9":
                    Console.WriteLine("Program: Ended");
                    break;

            }
        }
    }
}
