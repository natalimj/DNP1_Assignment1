using System.Collections.Generic;
using FamilyApp.Models;

namespace FamilyApp.Data
{
    public interface IFamilyService
    {
        IList<Family> GetFamilies();
        void AddFamily(Family family);
        void RemoveFamily(Family family);
        void AddAdultToFamily(Family family, Adult adult);
        void AddChildToFamily(Family family, Child child);
        void AddPetToFamily(Family family, Pet pet);
        IList<Adult> GetAdultsInFamily(Family family);
        IList<Child> GetChildrenInFamily(Family family);
        IList<Pet> GetPetsInFamily(Family family);
        public void RemoveAdultFromFamily(Adult adult);
        public void RemoveChildFromFamily(Child child);
        public void RemovePetFromFamily(Pet pet);
     
    }
}