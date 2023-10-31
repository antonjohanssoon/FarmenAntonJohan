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
            Console.WriteLine("Your list of crops:");
            for (int i = 0; i < cropList.Count; i++)
            {
                Console.WriteLine(cropList[i].GetDescription());
            }
        }

        private void AddCrop()
        {
            bool QuitLoop = true;
            ViewCrop();

            while (QuitLoop)
            {


                Console.WriteLine("What crop would you like to add? Write it´s name");
                string input1 = Console.ReadLine();
                Crop crop = null;
                for (int i = 0; i < cropList.Count; i++)
                {
                    if (input1.ToLower() == cropList[i].Name.ToLower())
                    {
                        crop = cropList[i];
                        crop.AddCrop(crop.Quantity);
                        return;
                    }
                    else
                    {
                        Console.WriteLine("What type of crops is it?");
                        string input2 = Console.ReadLine();

                        Console.WriteLine("What quantity?");
                        int input3 = Convert.ToInt32(Console.ReadLine());

                        Crop newcrop = new Crop(input1, input2, input3);
                        cropList.Add(newcrop);
                        Console.WriteLine(newcrop.Name + " added to your list of crops!");
                        return;
                    }
                }
            }
        }



        private int RemoveCrop()
        {
            ViewCrop();

            Console.WriteLine("What crop do you want to remove? Answear by ID: "); //lägg in så man ser vilken man valde och dess nuvarande quantity
            int input1 = Convert.ToInt32(Console.ReadLine());
            bool Cropfound = false;


            for (int i = 0; i < cropList.Count; i++)
            {
                if (input1 == cropList[i].Id)
                {
                    Console.WriteLine("What quantity do you want to remove?");
                    int subinput = Convert.ToInt32(Console.ReadLine());
                    int newquantity = cropList[i].Quantity - subinput;
                    if (newquantity < 0)
                    {
                        Console.WriteLine("Invalid operation. Quantity can´t be less than 0!");
                        Cropfound = true;
                    }
                    else
                    {
                        Console.WriteLine(cropList[i].Name + " new quantity is: " + newquantity);
                        cropList[i].Quantity -= subinput;
                        Cropfound = true;
                        return newquantity;
                    }

                }
            }
            if (!Cropfound)
            {
                Console.WriteLine("Invalid Crop Index!");
            }

            return 0;
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
                Console.WriteLine("4: Return to main menu");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Clear();
                        ViewCrop();
                        break;
                    case "2":
                        Console.Clear();
                        AddCrop();
                        break;
                    case "3":
                        Console.Clear();
                        RemoveCrop();
                        break;
                    case "4":
                        Boolfound = true;
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
