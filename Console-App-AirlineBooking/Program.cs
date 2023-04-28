namespace Console_App_AirlineBooking
{
    internal class Program
    {
        internal class AirlineBooking
        {
            static int counterBusiness=0;
            static int counterEconomy=0;
            static string[] business = new string[10];
            static string[] economy = new string[10];
            static void Main(string[] args)
            {
                for (int i = 0; i < 20; i++)
                {
                    BookingBusinessOrEconomy(MainPage());
                }
                Console.WriteLine("All Seats is Full");
            }
            static int MainPage()
            {
                Console.WriteLine("Welcome Airline's");
                Console.WriteLine("*BUSINESS SEAT FOR CHOOSE 1");
                Console.WriteLine("*ECONOMY SEAT FOR CHOOSE 2");
                int chooseYourClassSeat = Convert.ToInt32(Console.ReadLine());
                return chooseYourClassSeat;
            }
            private static void BookingBusinessOrEconomy(int x)
            {
                if (x == 1) { BookingProcessBusiness(EnterName(), SeatNumber()); }
                else if (x == 2) { BookingProcessEconomy(EnterName(), SeatNumber()); }
            }


            private static string EnterName()
            {
                Console.Write("Please Enter Your Name :");
                string name = Console.ReadLine();
                for (int i = 0; i < name.Length; i++)
                {
                    if (!char.IsLetter(name[i]))
                    {
                        Console.Clear();
                        Console.WriteLine("İsim harften başka karakter içermemeli");
                        EnterName();
                    }
                }
                return name;
            }

            private static int SeatNumber()
            {
                Console.Write("Lütfen koltuk numaranızı giriniz ");
                if (int.TryParse(Console.ReadLine(), out int seatNumber))
                {
                    return seatNumber;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Wrong");
                    return SeatNumber();
                }
            }

            private static string[] BookingProcessBusiness(string name, int seatNumberBusiness)
            {
                counterBusiness++;
                if (counterBusiness<=10 )
                {
                   
                    if (business[seatNumberBusiness-1]==null)
                    {
                        Console.Clear();
                        Console.WriteLine("BUSINESS CLASS");
                        business[seatNumberBusiness - 1] = name;
                    }
                    else
                    {
                       string rezervedby= business[seatNumberBusiness-1] ;
                        Console.WriteLine("Seat is rezerved by: " + rezervedby);
                    }
                    for (int i = 0; i < business.Length; i++)
                    {
                        Console.WriteLine(i + 1 + " number seat =" + business[i]);
                    }

                    return business;
                }
                else
                {
                    Console.WriteLine("Business seats is Full");
                    return business; 
                }
                
            }
            private static string[] BookingProcessEconomy(string name, int seatNumberEconomy)
            {


                counterEconomy++;
                if (counterEconomy <= 10)
                {

                    if (economy[seatNumberEconomy - 1] == null)
                    {
                        Console.Clear();
                        Console.WriteLine("ECONOMY CLASS");
                        economy[seatNumberEconomy - 1] = name;
                    }
                    else
                    {
                        string rezervedby = economy[seatNumberEconomy - 1];
                        Console.WriteLine("Seat is rezerved by: " + rezervedby);
                    }
                    for (int i = 0; i < economy.Length; i++)
                    {
                        Console.WriteLine(i + 1 + " number seat =" + economy[i]);
                    }

                    return economy;
                }
                else
                {
                    Console.WriteLine("Economy seats is Full");
                    return economy;
                }
            }
        }
    }
}