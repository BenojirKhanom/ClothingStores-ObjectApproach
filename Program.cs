using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clothing_Stores
{
    abstract class shop
    {
        protected string Name { get; set; }
        protected string Location { get; set; }
        protected string Shop_no { get; set; }
        protected string starting_Hours { get; set; }
        protected string Closeing_Hours { get; set; }
        protected string Branches { get; set; }
        protected string Date_Of_Foundation { get; set; }

    }
    interface IKindOfClothes
    {
        string getKindOfClothes(string ClothesCategories);

    }
    sealed class ShopDetales : shop, IKindOfClothes
    {
        public ShopDetales(string Name, string Location, string Shop_no,
                           string starting_Hours, string Closeing_Hours,
                           string Branches, string Date_Of_Foundation)
        {
            this.Name = Name;
            this.Location = Location;
            this.Shop_no = Shop_no;
            this.starting_Hours = starting_Hours;
            this.Closeing_Hours = Closeing_Hours;
            this.Branches = Branches;
            this.Date_Of_Foundation = Date_Of_Foundation;

        }

        string IKindOfClothes.getKindOfClothes(string ClothesCategories)
        {
            return ClothesCategories;
        }
        public string Phone_Number { set; get; }
        public string Web_Page { get; set; }
        public string Mail_addrese { set; get; }
        public string FaceBook_Page { get; set; }
        public string Quality { set; get; }
        public string Price_range { get; set; }
        public string Behaviour { set; get; }
        public string Customer_review { get; set; }


        public override string ToString()
        {
            return $" Name : {this.Name} , Location : {this.Location} , Shop_no : {this.Shop_no} , " +
                   $" starting_Hours : {this.starting_Hours} , Closeing_Hours : {this.Closeing_Hours}" +
                   $" Branches : {this.Branches} ,  Date_Of_Foundation : {this.Date_Of_Foundation}" +
                   $" Phone_Number : {this.Phone_Number} , Web_Page : {this.Web_Page} , Mail_addrese : {this.Mail_addrese}" +
                   $" FaceBook_Page : {this.FaceBook_Page} , Quality : {this.Quality} , Price_range : {this.Price_range}" +
                   $" Behaviour : {this.Behaviour} , Customer_review : {this.Customer_review}";
        }
    }

    class Program
    {    
        enum ClothesCategoriesName
        {
            Net_Saree = 0,
            Jamdani_Saree = 1,
            Silk_Saree = 2,
            Katan_Saree = 3,
            Banarasi_Saree = 4,
            Floral_printed_saree = 5,
            Bridal_Saree = 6,
            Bridal_Lehenga =7,
            Nonbridal_lehenga = 8 ,
            Party_wear_lehenga = 9,
            Net_lehenga = 10,
            Kidds_lehenga = 11,
            Katan_lehenga = 12,
            Posmina_shawl = 13,
            gents_shawl = 14 ,
            ladies_shawl = 15 ,
            Branded_three_piece = 16,
            NonBranded_three_piece = 20 ,
            sharara_dress = 21 ,
            gharara_dress = 22 ,
            Long_Gawn = 23 ,
            kidds_Gawn = 24

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Available Clothes Categories");
            var enumList = Enum.GetNames(typeof(ClothesCategoriesName));
            foreach (var v in enumList)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("******************************************************");


            Console.WriteLine("Enter The Shop Name Please... ");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter The Shop Location Please... ");
            string Location = Console.ReadLine();
            Console.WriteLine("Enter The Shop's no Please... ");
            string Shop_no = Console.ReadLine();
            Console.WriteLine("Enter The Shop's starting Hours Please... ");
            string starting_Hours = Console.ReadLine();
            Console.WriteLine("Enter The Shop's Closeing Hours Please... ");
            string Closeing_Hours = Console.ReadLine();
            Console.WriteLine("Enter The Branches Address Please... ");
            string Branches = Console.ReadLine();
            Console.WriteLine("Enter The Date Of Foundation Please... ");
            string Date_Of_Foundation = Console.ReadLine();
            ShopDetales shopDetales = new ShopDetales(Name, Location, Shop_no, starting_Hours,
                                                      Closeing_Hours, Branches, Date_Of_Foundation);


            Console.WriteLine("Enter The shop's Phone Number Please... ");
            shopDetales.Phone_Number = Console.ReadLine();
            Console.WriteLine("Enter The shop's Web Page Please... ");
            shopDetales.Web_Page = Console.ReadLine();
            Console.WriteLine("Enter The shop's Mail addrese Please... ");
            shopDetales.Mail_addrese = Console.ReadLine();
            Console.WriteLine("Enter The shop's FaceBook Page Please... ");
            shopDetales.FaceBook_Page = Console.ReadLine();
            Console.WriteLine("Enter The shop's Quality Please... ");
            shopDetales.Quality = Console.ReadLine();
            Console.WriteLine("Enter The shop's Price range Please... ");
            shopDetales.Price_range = Console.ReadLine();
            Console.WriteLine("Enter The shop's Behaviour Please... ");
            shopDetales.Behaviour = Console.ReadLine();
            Console.WriteLine("Enter The shop's Customer review Please... ");
            shopDetales.Customer_review = Console.ReadLine();

            Console.WriteLine("Enter your  Wanted  Clothes Categorie Name Please... ");
            string Wanted_Clothes_Categorie = Console.ReadLine();

            IKindOfClothes ikc = (IKindOfClothes)shopDetales;

            List<string> CategorieList = new List<string>();
            CategorieList.Add(ikc.getKindOfClothes(Wanted_Clothes_Categorie));

            bool yesProceed = true;
            while (yesProceed)
            {
                Console.WriteLine("More Categorie ? Yes Or No");
                string YesNoInput = Console.ReadLine();
                if (YesNoInput.ToUpper() == "Yes".ToUpper())
                {
                    Console.WriteLine("Categorie Name:");
                    string subjectName = Console.ReadLine();
                    CategorieList.Add(ikc.getKindOfClothes(Wanted_Clothes_Categorie));

                }
                else
                {
                    yesProceed = false;
                }

            }
            Console.WriteLine("You have learned the following subject:");
            foreach (var s in CategorieList)
            {
                Console.WriteLine(s);
            }


            Console.ReadLine();

        }
    }
}

