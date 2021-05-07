using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Agency agency = new Agency();
            while (true)
            {
                
                Console.WriteLine("1. Usluzhi go klientot.(ime,prezime,godini,destinacija,broj na shalter)");
                Console.WriteLine("2. Prodadeni karti na shalterot.(Broj na shalter,vreme(od dd/MM/yyyy, do dd/MM/yyyy))");
                Console.WriteLine("3. Vkupen promet na shalterot.(Broj na shalter,vreme(od dd/MM/yyyy, do dd/MM/yyyy))");
                Console.WriteLine("4. Site prodadeni karti na agencijata, organizirani po shalter.(vreme(od dd/MM/yyyy, do dd/MM/yyyy))");
                Console.WriteLine("5. Vkupen promet na agencijata.");
                Console.WriteLine("6. Uspeshnost na agencijata.");
                Console.WriteLine("7. Izlez.");

                int broj = int.Parse(Console.ReadLine());

                if(broj == 1)
                {
                    string name = Console.ReadLine();
                    string lastname = Console.ReadLine();
                    int age = int.Parse(Console.ReadLine());
                    string destination = Console.ReadLine();
                    int numberOfDesk = int.Parse(Console.ReadLine());
                    DateTime dateOfDestination = DateTime.Now;
                    if (!agency.destinations.Contains(destination))
                    {
                        Console.WriteLine("Nema takva destinacija");
                        agency.updatePeopleVisited();
                    }
                    else
                    {
                        foreach (Desk desk in agency.listOfDesks)
                        {
                            if (desk.numOfDesk.Equals(numberOfDesk))
                            {
                                int destinationPrice = destination.Length * 2000;
                                desk.listOfPeople.Add(new Person(name, lastname, age, destination, dateOfDestination, destinationPrice));
                                desk.updateTicket();
                                desk.updateBudgetPerDesk(destinationPrice);
                                agency.updateBudget(destinationPrice);
                                agency.updatePeopleVisited();
                            }
                        }
                    }

                }
                else if (broj == 2)
                {
                    int numberOfDesk = int.Parse(Console.ReadLine());
                    DateTime from = DateTime.Parse(Console.ReadLine());
                    DateTime to = DateTime.Parse(Console.ReadLine());
                   
                    agency.listOfDesks.ForEach(desk =>
                    {
                        if (desk.numOfDesk.Equals(numberOfDesk))
                            Console.WriteLine("Vkupno prodadeni karti na shalterot: " + desk.ticketSold(from,to));

                    });
                }
                else if (broj == 3)
                {
                    int numberOfDesk = int.Parse(Console.ReadLine());
                    DateTime from = DateTime.Parse(Console.ReadLine());
                    DateTime to = DateTime.Parse(Console.ReadLine());
                    agency.listOfDesks.ForEach(desk =>
                    {
                        if (desk.numOfDesk.Equals(numberOfDesk))
                        {
                            int temp = desk.budgetDesk(from, to);
                            Console.WriteLine("Vkupno promet na shalterot: " + temp);
                        }

                    });
                }
                else if (broj == 4)
                {
                    DateTime from = DateTime.Parse(Console.ReadLine());
                    DateTime to = DateTime.Parse(Console.ReadLine()); 
                    Console.WriteLine(agency.printDesk(from,to));

                }
                else if (broj == 5)
                {
                    Console.WriteLine("Vkupen promet na agencijata: " + agency.budget);
                }
                else if (broj == 6)
                {
                    Console.WriteLine("Uspeshnost na agencijata: " + agency.rateOfSuccess());
                }
                else 
                {
                    break;
                }
            }
            
            
        }
    }
    class Person
    {
        public string name { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string destination { get; set; }
        public DateTime dateOfDestination { get; set; }
        public int destinationPrice { get; set; }

        public Person(string name, string lastName, int age, string destination, DateTime dateOfDestination,int destinationPrice)
        {
            this.name = name;
            this.lastName = lastName;
            this.age = age;
            this.destination = destination;
            this.dateOfDestination = dateOfDestination;
            this.destinationPrice = destinationPrice;
        }


    }
    class Desk
    {
        public List<Person> listOfPeople { get; set; }
        public int numOfDesk { get; set; }
        public int numOfTickets { get; set; }
        public int budgetPerDesk { get; set; }

        public Desk(int numOfDesk)
        {
            this.numOfDesk = numOfDesk;
            this.listOfPeople = new List<Person>();
        }

        public void updateBudgetPerDesk(int price)
        {
            this.budgetPerDesk += price;
        }

        public void updateTicket()
        {
            this.numOfTickets++;
        }

        public int ticketSold(DateTime from,DateTime to)
        {
            int temp = 0;
            listOfPeople.ForEach(person =>
            {
                if (person.dateOfDestination >= from && person.dateOfDestination <= to)
                {
                   
                    temp+=1;
                }
            });
            return temp;
        }
        public int budgetDesk(DateTime from, DateTime to)
        {
            int temp = 0;
            listOfPeople.ForEach(person =>
            {
                if (person.dateOfDestination >= from && person.dateOfDestination <= to)
                {
                    temp+= person.destinationPrice;
                }
            });
            return temp;
        }

    }
    class Agency
    {
        public List<string> destinations { get; set; }
        public List<Desk> listOfDesks { get; set; }
        public int budget;
        public int peopleVisited { get; set; }
        
        public Agency()
        {
            //Рим, Лондон, Токио, Софија, Истанбул, Торонто, Мајами, Загреб, Белград и Москва
            this.destinations = new List<string>() { "Rome", "London", "Tokyo", "Sofia", "Istanbul", "Toronto", "Miami", "Zagreb", "Belgrad", "Moscow" };
            this.listOfDesks = new List<Desk>() { new Desk(1), new Desk(2), new Desk(3), new Desk(4), new Desk(5), new Desk(6) };
            this.budget = 0;
        }

        public void updateBudget(int price)
        {
            this.budget += price;
        }

        public void updatePeopleVisited()
        {
            this.peopleVisited++;
        }

        public double rateOfSuccess()
        {
            double sum = 0.0;
            foreach(Desk desk in listOfDesks)
            {
                sum += desk.listOfPeople.Count;
            }
            return sum/this.peopleVisited;
        }

        public string printDesk(DateTime from,DateTime to)
        {
            StringBuilder sb = new StringBuilder();
            listOfDesks.ForEach(desk =>
            {
                sb.Append("Desk").Append(desk.numOfDesk).Append(":").Append(desk.ticketSold(from,to)).Append("\n");

            });

            return sb.ToString();
        }

        
    }
    
}
