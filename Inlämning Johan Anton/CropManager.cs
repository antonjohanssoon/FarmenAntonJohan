namespace Farm.anton.johan
{
    public class CropManager
    {

        List<Crop> cropList = new List<Crop>();
        public CropManager()
        {
            cropList.Add(new Crop("Grass", "Herbs", 80));
            cropList.Add(new Crop("Maize", "Herbs", 50));
            cropList.Add(new Crop("Wheat", "Dry Herbs", 100));
            cropList.Add(new Crop("Compost", "Other", 25));
        }
        private void ViewCrop()
        {
            for (int i = 0; i < cropList.Count; i++)
            {
                cropList[i].GetDescription();
            }
        }
        //öka kvantitet samt om befintligt crop finns, öka bara kvantitet
        private void AddCrop()
        {
            bool QuitLoop = false;
            ViewCrop();

            while (!QuitLoop)
            {

                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("What crop would you like to add?");
                    string input1 = Console.ReadLine();

                    Console.WriteLine("Is it crops or food crops?");
                    string input2 = Console.ReadLine();

                    Console.WriteLine("What quantity?");
                    int input3 = Convert.ToInt32(Console.ReadLine());

                    Crop newcrop = new Crop(input1, input2, input3);
                    cropList.Add(newcrop);

                    if (input1.ToLower() == cropList[i].Name.ToLower())
                    {
                        Console.WriteLine("What quantity would you like to add?");
                        int input5 = Convert.ToInt32(Console.ReadLine());
                        input5 += cropList[i].Quantity;
                    }

                    Console.WriteLine("Do you want to continue? yes/no?");
                    string input4 = Console.ReadLine();

                    if (input4 == "no")
                    {
                        QuitLoop = true;
                    }
                }
            }

        }

        private int RemoveCrop()
        {
            ViewCrop();

            Console.WriteLine("What crop do you want to remove? Answear by Id: ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            bool Cropfound = false;

            while (!Cropfound)
            {

                for (int i = 0; i < cropList.Count; i++)
                {
                    if (input1 == cropList[i].Id)
                    {
                        Console.WriteLine("What quantity do you want to remove?");
                        int subinput = Convert.ToInt32(Console.ReadLine());
                        int newquantity = cropList[i].Quantity - subinput;
                        Console.WriteLine(cropList[i].GetDescription);
                        Cropfound = true;
                        return newquantity;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Crop ID !");
                    }
                }
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
                        RemoveCrop();
                        break;
                    case "4":
                        Boolfound = true;
                        break;
                }
            }

        }
    }
}
