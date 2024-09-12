using System;
using System.Collections.Generic;

namespace C__Demo
{
    public class ListsDemo
    {
        public void ListsDemoMethod()
        {
            //list is a collection of items that can be of different data types and can be accessed by index and can increase or decrease in size dynamically.

            List<string> list = new List<string>();
            //adding items to the list
            list.Add("Item1");
            list.Add("Item2");

            //accessing items in the list
            string item = list[0];
            string item2 = list[1];

            //removing items from the list
            list.Remove("Item1");

            //insert items into the list
            list.Insert(0, "Item0");


            //count
            int count = list.Count;
            Console.WriteLine(count);

            //iterating over the list
            foreach (var a_list in list)
            {
                Console.WriteLine(a_list);
            }

            //contains
            bool contains = list.Contains("Item1");
            Console.WriteLine(contains);


            List<Player> players = new List<Player>();

            players.Add(new Player("player1"));
            players.Add(new Player("player2"));
            players.Add(new Player("player3"));


            foreach (var player in players)
            {
                Console.WriteLine(player.username);
            }
        }
    }
    class Player
    {
        public string username;

        public Player(string username)
        {
            this.username = username;
        }
    }
}