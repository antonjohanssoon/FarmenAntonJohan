namespace Farm.anton.johan
{
    public class CropManager
    {

        List<Crop> cropList = new List<Crop>();
        public CropManager()
        {
            cropList.Add(new Crop("Grass", "Herbs", 8));
            cropList.Add(new Crop("Maize", "Herbs", 5));
            cropList.Add(new Crop("Wheat", "Dry Herbs", 10));
            cropList.Add(new Crop("Compost", "Other", 7));
        }
        private void ViewCrop()
        {
            for (int i = 0; i < cropList.Count; i++)
            {
                Console.WriteLine(cropList[i].GetDescription());
            }
        }

        private void AddCrop()
        {
            ;
            ViewCrop();

            Console.WriteLine("What crop would you like to add quantity in? Or maybe a new sort?");
            string input1 = Console.ReadLine();
            foreach (Crop crop in cropList)
            {
                if (input1.ToLower() == crop.Name.ToLower())
                {
<<<<<<< HEAD
                    Console.WriteLine("What crop would you like to add?");
                    string input1 = Console.ReadLine();
                    if (input1.ToLower() == cropList[i].Name.ToLower())
                    {
                        Crop crop = null;
                        crop.AddCrop(crop.Quantity);
                    }
=======
                    Console.WriteLine("What quantity would you like to add to " + crop.Name + " ?");
                    int input5 = Convert.ToInt32(Console.ReadLine());
                    crop.AddCrop(input5);
                    return;
>>>>>>> e36acb9638a4b107b6f00fab596270116c93cc1d

                }
            }

            Console.WriteLine("What type of crop is it?");
            string input2 = Console.ReadLine();

            Console.WriteLine("What quantity?");
            int input3 = Convert.ToInt32(Console.ReadLine());

            Crop newcrop = new Crop(input1, input2, input3);
            cropList.Add(newcrop);

            Console.WriteLine(newcrop.Name + " added to the list!");
        }

        private void RemoveCrop(int number)
        {
            foreach (Crop crop in cropList)
            {
                if (crop.Id == number)
                {
                    cropList.Remove(crop);
                    Console.WriteLine(crop.Name + " succesfully removed!");
                    break;
                }
                else
                {
                    Console.WriteLine("Crop ID does not exist!");
                    break;
                }
            }
            // while (!Cropfound)
            // {
            //
            //     //for (int i = 0; i < cropList.Count; i++)
            //     //{
            //     //    if (input1 == cropList[i].Id)
            //     //    {
            //     //        Console.WriteLine("What quantity do you want to remove?");
            //     //        int subinput = Convert.ToInt32(Console.ReadLine());
            //     //        int newquantity = cropList[i].Quantity - subinput;
            //     //        Console.WriteLine(cropList[i].Name + " new quantity is: " + newquantity);
            //     //        Cropfound = true;
            //     //
            //     //        return newquantity;
            //     //    }
            //     //    else
            //     //    {
            //     //        Console.WriteLine("Invalid Crop ID !");
            //     //    }
            //     //}
            // }
            // return 0;
        }
        //ger tbx lista
        public List<Crop> GetCrops()
        {
            return cropList;
        }

        public void CropMenu()
        {
            bool Boolfound = false;

            while (!Boolfound)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1: View Crops.");
                Console.WriteLine("2: Add Crops.");
                Console.WriteLine("3: Remove Crops.");
                Console.WriteLine("4: Quit");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        ViewCrop();
                        break;
                    case "2":
                        AddCrop();
                        break;
                    case "3":
                        ViewCrop();
                        Console.WriteLine("What crop do you want to remove? Answear by Id: ");
                        int input1 = Convert.ToInt32(Console.ReadLine());
                        RemoveCrop(input1);
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("You returned to main menu!");
                        Boolfound = true;
                        break;
                }
            }

        }
    }
}
