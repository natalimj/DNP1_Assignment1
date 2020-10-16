using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using FamilyApp.Models;


namespace FamilyApp.Data
{
    public class MemberService : IMemberService
    {
        private string adultsFile = "adults.json";
        private string childrenFile = "children.json";
        private string petsFile = "pets.json";
        private string childInterestFile = "childinterest.json";
        

        public IList<Adult> Adults { get; private set; }
        public IList<Child> Children { get; private set; }
        
        public IList<Pet> Pets { get; private set; }
        public IList<ChildInterest> ChildInterests { get;  set; }
        
        public MemberService()
        {
         
            if (!File.Exists(adultsFile))
            {
                WriteAdultsToFile();
            }
            else
            {
                string content = File.ReadAllText(adultsFile);
                Adults = JsonSerializer.Deserialize<List<Adult>>(content);
            }

            if (!File.Exists(childrenFile))
            {
                Children = new[]
                {
                    new Child
                    {
                        Id = 1,
                        FirstName= "Peter",
                        LastName= "Smith",
                        HairColor= "Leverpostej",
                        EyeColor="Brown",
                        Age= 5,
                        Weight= 26,
                        Height= 120, 
                        Sex= "M",
                       
                    }
                }.ToList();
                
                WriteChildrenToFile();
                
            }
            else
            {
                string content2 = File.ReadAllText(childrenFile);
                Children = JsonSerializer.Deserialize<List<Child>>(content2);
            }
            
            if (!File.Exists(petsFile))
            {
                Pets=new[]{
                    new Pet
                    {
                        Id = 1,
                        Name = "Cutie",
                        Age= 1
                    }
                }.ToList();
                WritePetsToFile();
            }
            else
            {
                string content3 = File.ReadAllText(petsFile);
                Pets = JsonSerializer.Deserialize<List<Pet>>(content3);
            }

            if (!File.Exists(childInterestFile))
            {
                ChildInterests=new[]{
                new ChildInterest()
                {
                   ChildId=1,
                   InterestId = "Lego"
                   
                }
            }.ToList();
                
                WriteChildInterestToFile();
            }
            else
            {
                string content4 = File.ReadAllText(childInterestFile);
                ChildInterests = JsonSerializer.Deserialize<List<ChildInterest>>(content4);
            }
            
        }
        private void WriteAdultsToFile()
        {
            string adultsAsJson = JsonSerializer.Serialize(Adults,new JsonSerializerOptions{WriteIndented = true});
            File.WriteAllText(adultsFile, adultsAsJson);
        }
        private void WriteChildrenToFile()
        {
            string childrenAsJson = JsonSerializer.Serialize(Children,new JsonSerializerOptions{WriteIndented = true});
            File.WriteAllText(childrenFile, childrenAsJson);
        }

        private void WritePetsToFile()
        {
            string petsAsJson = JsonSerializer.Serialize(Pets,new JsonSerializerOptions{WriteIndented = true});
            File.WriteAllText(petsFile, petsAsJson);
        }
        
        private void WriteChildInterestToFile()
        {
            string childInterestsAsJson = JsonSerializer.Serialize(ChildInterests,new JsonSerializerOptions{WriteIndented = true});
            File.WriteAllText(childInterestFile, childInterestsAsJson);
        }
        public IList<Adult> GetAdults()
        {
            List<Adult> tmp=new List<Adult>(Adults);
            return tmp;
        }
        public IList<Child> GetChildren()
        {
            List<Child> tmp=new List<Child>(Children);
            return tmp;
        }
        public void AddAdult(Adult adult)
        {
            int max = Adults.Max(adult => adult.Id);
            adult.Id = (++max);
            Adults.Add(adult);
            WriteAdultsToFile();
        }

        public void AddChild(Child child)
        {
            int max = Children.Max(child => child.Id);
            child.Id = (++max);
            Children.Add(child);
            WriteChildrenToFile(); 
            
        }
        public void RemoveAdult(Adult adult)
        {
            
            Adults.Remove(adult);
            WriteAdultsToFile();
        }
 
        public void RemoveChild(Child child)
        {
            
            foreach (var interest in ChildInterests.ToList())
            {
                if (child.Id == interest.ChildId)
                {
                    ChildInterests.Remove(interest);
                }
            }

            foreach (var pet in child.Pets.ToList())
            {
                Pets.Remove(pet);
            }
            
            Children.Remove(child);
            WriteChildrenToFile();
            WriteChildInterestToFile();
            WritePetsToFile();
        }
        public IList<Pet> GetPets()
        {
            List<Pet> tmp=new List<Pet>(Pets);
            return tmp;
        }

        public void AddPet(Pet pet)
        {
            int max = Pets.Max(pet => pet.Id);
            pet.Id = (++max);
            Pets.Add(pet);
            WritePetsToFile();
        }

        public void RemovePet(Pet pet)
        {
            Pets.Remove(pet);
            WritePetsToFile();
        }

        public void AddChildInterest(Child child, String interestType)
        {
            
            ChildInterest childInterest=new ChildInterest();
            childInterest.Child = child;
            childInterest.ChildId = child.Id;
            // childInterest.Interest = interest;
            childInterest.InterestId= interestType;
            ChildInterests.Add(childInterest);
            child.ChildInterests.Add(childInterest);
            
            WriteChildrenToFile();
            WriteChildInterestToFile();
            
        }

        public void AddChildPet(Child child, Pet pet)
        {   
           
            AddPet(pet);
            child.Pets.Add(pet);
            WriteChildrenToFile();
        }

        public void UpdateAdult(Adult adult)
        {
            
           Adult adultToUpdate = Adults.First(a => a.Id == adult.Id);
           adult.Update(adultToUpdate);
           WriteAdultsToFile();
        }
        public void UpdateAdult(Child child)
        {
            Child childToUpdate = Children.First(c => c.Id == child.Id);
            child.Update(childToUpdate);
            WriteChildrenToFile();
        }

        public void RemoveAllFamilyMembers(Family family)
        {
            foreach (var adult in family.Adults)
            {
                RemoveAdult(adult);
            }

            foreach (var child in family.Children)
            {
                RemoveChild(child);
            }

            foreach (var pet in family.Pets)
            {
                RemovePet(pet);
            }
        }
    }
}