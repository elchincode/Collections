﻿using Collections;
using System;

namespace Collection
{
    public class Program
    {


        public static void Main(string[] args)
        {

            List<Group> team = new List<Group>();

            var group = new Group
            {

                Name = "p-331"


            };

            Checker(team, group);


            var group2 = new Group
            {

                Name = "p-3311"


            };
            Checker(team, group2);


            foreach (var item in team)
            {
                Console.WriteLine(item.GetDetails());
            }




        }



        public static void Checker(List<Group> team, Group group)
        {

            var isDublicatedId = team.Any(p => p.Name == group.Name);


            if (!isDublicatedId)
            {
                team.Add(group);
            }

        }

    }
}