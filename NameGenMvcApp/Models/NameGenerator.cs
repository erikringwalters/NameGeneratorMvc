using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NameGenMvcApp.Models
{
    public class NameGenerator
    {
        private string Name;
        Random rand = new Random();
        Random rand1 = new Random();
        int chance;
        ElfNameData elfName;
        OrcNameData orcName;
        private char[] Consonant = new char[] { 'b', 'c', 'd', 'f', 'g', 'h', 'j',
            'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
        //array of vowel
        private char[] Vowel = new char[] { 'a', 'e', 'i', 'o', 'u' };
        //Constructor
        public NameGenerator()
        {
            elfName = new ElfNameData();
            orcName = new OrcNameData();
            chance = rand1.Next(1, 101);
        }
        //
        public string getName(int size, Sex sex, Race race)
        {

            char firstLetter = (char)rand.Next(65, 90);
            //65 - 90 is capital A - Z.

            //If elf is specified race.
            if (race == Models.Race.Elf)
            {
                Name += elfName.Prefix[rand.Next(elfName.Prefix.Length - 1)];
                Name += elfName.Root[rand.Next(elfName.Root.Length - 1)];

            }
            //If orc is specified race.
            if (race == Models.Race.Orc)
            {
                Name += orcName.Prefix[rand.Next(orcName.Prefix.Length - 1)];
                Name += orcName.Root[rand.Next(orcName.Root.Length - 1)];

            }
            //If Any (default) is specified race.
            else if (race == Models.Race.Any)
            { 
                Name += firstLetter;//builds a name by piecing random characters together
                Name += randomVowel();
                for (int i = 0; i <= size / 2; i++)
                {
                    Name += organizeCheck();
                }
            }
            //If male is specified sex.
            if (sex == Models.Sex.Male)
            {
                //50% chance that name will end in 'o' if it does not already.
                if (chance >= 50 && Name[Name.Length - 1] != 'o')
                {
                    Name += 'o';
                }
            }
            //if female is specified sex.
            if (sex == Models.Sex.Female)
            {
                //50% chance that name will end in 'a' if it does not already.
                if (chance >= 50 && Name[Name.Length - 1] != 'a')
                {
                    Name += 'a';
                }
            }
            //if Any (default) is specified sex.
            if(sex == Models.Sex.Any)
            {
                //25% chance that name will be masculine if not already ending in 'o'
                if (chance <= 25 && Name[Name.Length - 1] != 'o')
                {
                    Name += 'o';
                }
                //25% chance that name will be feminine if not already ending in 'a'
                else if (chance <= 50 && Name[Name.Length - 1] != 'a')
                {
                    Name += 'a';
                }
                //Otherwise, keep name as is and move on.
            }

            //Name is all built and ready to return.
            return Name;
        }
        //
        public string getName(int size, Sex sex)
        {
            return getName(size, sex, Models.Race.Any);
        }
        //
        public string getName(int size)
        {
            return getName(size, Models.Sex.Any, Models.Race.Any);
        }
        //
        public string getName(int size, Race race)
        {
            return getName(size, Models.Sex.Any, race);
        }
        //
        public char randomVowel()
        {
            return Vowel[rand.Next(0, 5)];
        }
        //
        public char randomConsonant()
        {
            return Consonant[rand.Next(0,21)];
            //97 - 122 is lowercase a - z.
        }
        //
        public char randomLowercase()
        {
            char randomLowercase = (char) rand.Next(97, 123);
            //97 - 122 is lowercase a - z.
            return randomLowercase;
        }
        //
        public char organizeCheck()
        {

            bool LastIsVowel = false;
            bool secondLastIsVowel = false;

            for (int i = 0; i < 5; i++)
            {
                if (Name[Name.Length - 1] == Vowel[i])
                {//checks if last letter is a vowel ^
                    LastIsVowel = true;
                }
                if (Name[Name.Length - 2] == Vowel[i])
                {
                    secondLastIsVowel = true;
                }
            }
            if (LastIsVowel == false && secondLastIsVowel == false)
            {
                return randomVowel();
            }
            if (Name[Name.Length - 1] == 'q')//should have 'u' after 'q'
            {
                return 'u';
            }
            if ((Name[Name.Length - 1]) == 'x')//shouldn't have consonant successing 'x'
            {
                return randomVowel();
            }
            else
                return randomLowercase();
        }
        //
        public char getLastLetter()
        {
            return Name[Name.Length];
        }
        //
        public void displayName()
        {

        }
        //
    }
    public enum Race { Any, Human, Elf, Orc };
    public enum Sex { Any, Male, Female };

}