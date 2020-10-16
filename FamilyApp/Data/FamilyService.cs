using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using FamilyApp.Models;

namespace FamilyApp.Data
{
    public class FamilyService :IFamilyService
    {
        
        private string familiesFile = "families.json";
        

        public IList<Family> Families { get;  set; }


        public FamilyService()
        {

            if (!File.Exists(familiesFile))
            {
                Families = new[]
                {
                    new Family
                    {
                        Id = 1,
                        FamilyName = "First",
                        StreetName = "Street1",
                        HouseNumber = 1
                    }
                }.ToList();
                WriteFamiliesToFile();
            }
            else
            {

                string content = File.ReadAllText(familiesFile);
                Families = JsonSerializer.Deserialize<List<Family>>(content);
            }

        }

        
        private void WriteFamiliesToFile()
        {
            string familiesAsJson = JsonSerializer.Serialize(Families,new JsonSerializerOptions{WriteIndented = true});
            File.WriteAllText(familiesFile, familiesAsJson);
        }

        
        public IList<Family> GetFamilies()
        {
            List<Family> tmp=new List<Family>(Families);
            return tmp;
        }

        public void AddFamily(Family family)
        {
            if (Families.Where(f => f.FamilyName.Equals(family.FamilyName,StringComparison.OrdinalIgnoreCase)).ToList().Any())
            {
                throw new Exception("Family name is already taken");
            }
            
            if (Families.Where(f => f.StreetName.Equals(family.StreetName,StringComparison.OrdinalIgnoreCase)).ToList().Any()
            &&Families.Where(f => f.HouseNumber==family.HouseNumber).ToList().Any())
            {
                throw new Exception("Address has been occupied by another family.");
            }
            
            int max = Families.Max(family => family.Id);
            family.Id = (++max);
            Families.Add(family);
            WriteFamiliesToFile();
         
        }

        public void RemoveFamily(Family family)
        {
            Families.Remove(family);
            WriteFamiliesToFile();
        }
        
        public void AddAdultToFamily(Family family,Adult adult)
            {
                family.Adults.Add(adult);
                WriteFamiliesToFile();
            }
        
        
        public void AddChildToFamily(Family family,Child child)
        {
            family.Children.Add(child);
                WriteFamiliesToFile();
        }
        
        public void AddPetToFamily(Family family, Pet pet)
        {
            family.Pets.Add(pet);
            WriteFamiliesToFile();
        }
        public IList<Adult> GetAdultsInFamily(Family family)
        {

            return family.Adults;
         
        }

        public IList<Child> GetChildrenInFamily(Family family)
        {
            return family.Children;
        }

        public IList<Pet> GetPetsInFamily(Family family)
        {
            return family.Pets;
        }

        public void RemoveAdultFromFamily(Adult adult)
        {
 
            foreach (var family in GetFamilies().ToList())
            {
                foreach (var ad in family.Adults.ToList())
                {
                    if (adult.Id == ad.Id)
                    {
                        family.Adults.Remove(adult);
                    }
                }
            }
            WriteFamiliesToFile();
        }
        
        public void RemoveChildFromFamily(Child child)
        {
            foreach (var family in GetFamilies().ToList())
            {
                foreach (var ch in family.Children.ToList())
                {
                    if (child.Id == ch.Id)
                    {
                        family.Children.Remove(child);
                    }
                }
            }
            
            WriteFamiliesToFile();
        }
        
        public void RemovePetFromFamily(Pet pet)
        {
            foreach (var family in GetFamilies().ToList())
            {
                foreach (var pt in family.Pets.ToList())
                {
                    if (pet.Id == pt.Id)
                    {
                        family.Pets.Remove(pet);
                    }
                }
            }
            WriteFamiliesToFile();
        }
        
    }
}