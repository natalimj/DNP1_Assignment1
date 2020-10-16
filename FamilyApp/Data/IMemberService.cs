using System;
using System.Collections.Generic;
using FamilyApp.Models;

namespace FamilyApp.Data
{
    public interface IMemberService
    {
        IList<Adult> GetAdults();
        void AddAdult(Adult adult);
        void RemoveAdult(Adult adult);
        void UpdateAdult(Adult adult);
         IList<Child> GetChildren();
         void AddChild(Child child);
         void RemoveChild(Child child);
        IList<Pet> GetPets();
        void AddPet(Pet pet);
        void RemovePet(Pet pet);
        void AddChildInterest(Child child, String interestType);
        void AddChildPet(Child child, Pet pet);
        void RemoveAllFamilyMembers(Family family);

    }
}