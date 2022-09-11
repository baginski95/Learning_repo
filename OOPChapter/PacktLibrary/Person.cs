using System;
using static System.Console;
using System.Collections.Generic;

namespace Packt.Shared
{
    public class Person : object
    {
        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld FavoriteAncientWonder;
        public WondersOfTheAncientWorld BucketList;
        public List<Person> Children = new List<Person>();
    }
  
}
