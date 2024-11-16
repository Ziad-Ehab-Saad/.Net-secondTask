

namespace SecondTaskEraaSoft
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //my working List
            List<int> list = new List<int>();
            //choice from user (lower case)
            char choice = '\0';
            string emptyList = "the list is empty!!!!";

            double mean = 0.0;
            int min = 0;
            int max = 0;
            double sumOflist = 0.0;





            //------
            do
            {
                //Menu choices
                Console.WriteLine("----------------------P.Print Numbers----------------------");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("----------------------A.Add a Number (Bouns task : choose between duplicates or NOT) -----------------------");
                Console.WriteLine("--------------------------------------------");

                Console.WriteLine("----------------------M.Display Mean of Numbers.----------------------");
                Console.WriteLine("--------------------------------------------");

                Console.WriteLine("-----------------------S.Display Smallest Number----------------------");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("----------------------L.Display largest of Numbers----------------------");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("----------------------F.Find an index of an Item------------------------");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("----------------------C.Clear the list ----------------------");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("----------------------Z.Sort elemnts (bouns)");
                Console.WriteLine("--------------------------------------------");

                Console.WriteLine("----------------------Q.Quit---------------------------------");
                Console.WriteLine("----------------------");

                //----------
                //get choice from user .
                Console.WriteLine("Enter your choice");

                choice = char.ToLower(char.Parse(Console.ReadLine()));
                //-------------------
                //choosing from mylist .
               switch (choice)
                {
                    case 'p':
                        if (list.Count==0)
                        {
                            Console.WriteLine("[] - list is empry");
                        }
                        else
                        {
                            Console.Write("[");
                            for (int i = 0; i < list.Count; i++)
                            {
                                
                                Console.Write($"{list[i]}");
                                Console.Write(" ");
                            }
                            Console.Write("]");
                            Console.Write("\n");
                        }


                    break;
                    case 'a':
                        int inputData = 0;
                        string text = "Enter the element to add it in the list";
                        Console.WriteLine("Press \"D\" for Duplicates or \"N\" to NOT allow it  ");
                        char duplicates = char.ToLower (char.Parse(Console.ReadLine()));
                        if (duplicates == 'd')
                        {
                            Console.WriteLine(text);
                             inputData = int.Parse(Console.ReadLine());
                            list.Add(inputData);
                            Console.WriteLine($"{inputData} added ....");

                        }
                        else if (duplicates =='n')
                        {
                            bool flag = false;
                            Console.WriteLine(text);
                            inputData = int.Parse(Console.ReadLine());
                            for (int i = 0; i < list.Count; i++)
                            {
                                if (inputData == list[i])
                                {
                                    flag = true;
                                    break;
                                }

                            }
                            if (flag ==true)
                            {
                                Console.WriteLine("the item is already exists ");
                            }
                            else
                            {
                                list.Add(inputData);
                                Console.WriteLine($"{inputData} is added....");
                            }




                        }

                        break;
                    
                    
                    
                    case 'm':
                        if (list.Count == 0)
                        {
                            Console.WriteLine("Unable to Calculate Mean , No Data");
                        }
                        else
                        {
                            for (int i = 0; i < list.Count; i++)
                            {
                                sumOflist = sumOflist + list[i];
                            }
                            mean = sumOflist / list.Count;
                        Console.WriteLine($"the mean of the list = {mean}");
                        }
                        break;
                    case 's':
                        if (list.Count==0)
                        {
                            Console.WriteLine("unable to calculate smallest num , list is empty ");
                        }
                        else
                        {
                            min = list[0];
                            for (int i = 1; i < list.Count; i++)
                            {

                                if (min > list[i])
                                {
                                    min = list[i];

                                }
                            }
                            Console.WriteLine($"the smallest  number = {min}");
                        }
                        break;


                    case 'l':
                        if (list.Count == 0)
                        {
                            Console.WriteLine("unable to calculate largest num, list is empty");
                        }

                        else
                        {

                            max = list[0];
                            for (int i = 1; i < list.Count; i++)
                            {

                                if (max < list[i])
                                {
                                    max = list[i];
                                }

                            }



                            Console.WriteLine($"the largest number = {max}");
                        }
                        break;

                    case 'f':
                        if (list.Count == 0)
                        {
                            Console.WriteLine("list is empty ");
                        }
                        else
                        {
                            bool flag = false;
                            int found = 0;
                            Console.WriteLine("Enter the element to return its index if exists");
                            int item = int.Parse(Console.ReadLine());
                            for (int i = 0; i < list.Count; i++)
                            {
                                if (item == list[i])
                                {
                                    found = i;
                                    flag = true;
                                    break;

                                }


                            }

                            if (flag == true)
                            {
                                Console.WriteLine($"the index of your item : {found}");
                            }
                            else
                            {
                                Console.WriteLine("item is not found");
                            }
                        }

                            break;

                    case 'c':
                        if (list.Count == 0)
                        {
                            Console.WriteLine(emptyList);
                        }
                        else
                        {
                            list.Clear();
                            Console.WriteLine("List is now empty!!");
                        }
                        break;
                    case 'z':
                        list.Sort();
                        Console.WriteLine("list is Sorted...");

                        break;
                    case 'q':
                        Console.WriteLine("Goodbye......");
                        break;
                    default:
                        Console.WriteLine("Unknown Selection please try again!!!!");
                        break;
                }




               
             



            } while (choice!='q');









           
          

           







        }
    }
}
