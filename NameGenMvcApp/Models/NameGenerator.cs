﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NameGenMvcApp.Models
{
    public class NameGenerator
    {
        enum gender { MALE, FEMALE, OTHER };
        private string Name;
        Random rand = new Random();
        ElfNameData elfName;
        int Race;//decides style of name(orc, dragon, etc.)
        int Sex;//decides whether name is more masculine/feminine/other
        int Size;//number of characters in name
        int DesiredSize;
        private char[] Consonant = new char[] { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
        private char[] Vowel = new char[] { 'a', 'e', 'i', 'o', 'u' };
        //Constructor
        public NameGenerator()
        {
            int Sex = 0;
            int Race = 0;
            int Size = 0;
            int DesiredSize = 10;
            elfName = new ElfNameData();
        }
        //
        public void getRace(int r)
        {
            Race = r;
        }
        //
        public void getSex(int s)
        {
            Sex = s;
        }
        //
        public string getName(int size, Sex sex, Race race)
        {
            
            char firstLetter = (char)rand.Next(65, 90);
            //65 - 90 is capital A - Z.
            if(sex == Models.Sex.Male)
            {

            }
            if(race == Models.Race.Elf)
            {
                Name += elfName.Prefix[rand.Next(elfName.Prefix.Length - 1)];
                Name += elfName.Root[rand.Next(elfName.Root.Length - 1)];
                return Name;
            }
            Name += firstLetter;//builds a name by piecing random characters together
            Name += randomVowel();
            for (int i = 0; i <= size / 2; i++)
            {
                Name += organizeCheck();
            }
            return Name;
        }
        //
        public string getName(int size, Sex sex)
        {
            return getName(size, sex, Models.Race.Other);
        }
        //
        public string getName(int size)
        {
            return getName(size, Models.Sex.Other, Models.Race.Other);
        }
        //
        public string getName(int size, Race race)
        {
            return getName(size, Models.Sex.Other, race);
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
    public enum Race { Other, Human, Elf, Orc };
    public enum Sex { Other, Male, Female };

}