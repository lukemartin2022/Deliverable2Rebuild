using System;

class Program {
  public static void Main (string[] args) {
        /*Buffet Program Instructions
        ---------------------------------------------------------
        Tasks:
        1. Ask party size
        2. Ask each person drink loop 
        3. Calculate & Write drink counts
        4. Calculate & Write total price
        ---------------------------------------------------------
        Menu:
        ----------------------------------------------------------*/
        //Water is free
        decimal Coffee_price = 2.00M;
        decimal buffet_price = 9.99M;


        /*----------------------------------------------------------*/

        //Declared Variables

    string response;
    decimal order_total_price, drink_total_price, buffet_total_price;
    int ask_count = 1;
    int W = 0; //number of waters ordered
    int C = 0; //number of coffee ordered

    //1. Ask party size
    //Max party size is 6 people

    Console.WriteLine("How many in your party?");
    int party_size = int.Parse(Console.ReadLine());

if (party_size > 6)
{
    Console.WriteLine("I'm sorry, the party limit is 6 people.");
}

else if (party_size < 7)
{

    //2. Ask each person drink loop
    //Ask party_size times
    Console.WriteLine("Ok, party of " + party_size + ", let's get started with some drinks. We have water and coffee.");

    do
    {
        Console.WriteLine("Person number " + ask_count + ", water or coffee?");
        response = Console.ReadLine();
                if (response == "coffee")
                {
                    Console.WriteLine("Coffee, alright.");
                    C += 1;

                }
                else if (response == "water")
                {
                    Console.WriteLine("Water, good choice.");
                    W += 1;
                }

                else if ((response != "water") || (response != "coffee"))
                {
                    Console.WriteLine("We don't have that.");
                }

        ask_count += 1;
    }
    while (ask_count <= party_size);//everyones drink order should be taken

    //3. Calculate & Write drink counts

    Console.WriteLine("So that's " + W + " waters and " + C + " coffees.");

    //4. Calculate & Write total price
    buffet_total_price = party_size * buffet_price;
    drink_total_price = C * Coffee_price;
    order_total_price = buffet_total_price + drink_total_price;

    Console.WriteLine(
        @"You're total price is $" + order_total_price + ". " +
        "Thank for you coming. Please come again!");
}
  }
}