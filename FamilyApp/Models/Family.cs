using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace FamilyApp.Models {
public class Family {
    
    public int Id { get; set; }
    public string FamilyName { get; set; }
    [Required]
  //  [ValidStreetName]
    public string StreetName { get; set; }
    [Required]
  //  [ValidHouseNumber]
    public int HouseNumber{ get; set; }
    public List<Adult> Adults { get; set; }
    public List<Child> Children{ get; set; }
    public List<Pet> Pets{ get; set; }

    public Family() {
        Adults = new List<Adult>();     
        Children=new List<Child>();
        Pets=new List<Pet>();
    }
  
}

}