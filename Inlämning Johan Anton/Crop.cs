﻿namespace Farm.anton.johan
{   //Innehåller olika växter med antal, typer,namn, id 

    public class Crop : Entity
    {
        List<Crop> cropList;
        public string CropType { get; set; }
        private int Quantity { get; set; }

        public Crop(string _name, string _cropType, int _quantity) : base(_name)
        {
            CropType = _cropType;
            Quantity = _quantity;

        }

        //Ger infon om Växten
        public override string GetDescription()
        {
            return $"Id: {Id}, Name: {Name}, Crop Type: {CropType}, Quantity: {Quantity}";
        }

        //lägg till i kvantitet 
        public void AddCrop(int _quantity)
        {
            
            Console.WriteLine("Write the ID-number of the crop you want to increase");
            int cropInput = 0;

            try
            {
                cropInput = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("You must write Id-number. ");
            }

            for (int i = 0; i < cropList.Count; i++)
            {
                if (cropInput == cropList[i].Id)
                {

                    cropList[i].Quantity += _quantity;
                }
                else
                {
                    Console.WriteLine("Crop ID not found!");
                }
            }

            Quantity += _quantity;
            Console.WriteLine(Name + " new quantity is: " + Quantity);

        }

        public bool TakeCrop(int _quantity)
        {
            if (Quantity <= 0)
            {
                return false;
                Console.WriteLine("No crop of that type exists. Feeding failed.");

            }
            else
            {
                Quantity -= _quantity;
                return true;
            }
        }

    }
}