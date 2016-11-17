using Nancy;
using Pets.Objects;
using System.Collections.Generic;

namespace Pets
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["add_new_pet.cshtml"];
      Get["/view_all_pets"] = _ => {
      List<Pet> allPets = Pet.GetAll();
      return View["view_all_pets.cshtml", allPets];
    };
    Get["view_all_pets/{id}"] = parameters => {
      Pet name = Pet.Find(parameters.id);
      return View["/view_all_pets.cshtml", name];
    };

      Post["/pet_added"] = _ => {
        Pet newPet = new Pet (Request.Form["name"])
        newPet.Save();
        return View["pet_added.cshtml", newPet];
      };
      Post["/food"] = _ => {
        Pet ourPet = new Pet (Request.Form["pet"]) 
      }
      Post["/{action}"] = parameters => {
        Pet newPet = new Pet (Request.Form["food"], Request.Form["attention"], Request.Form["sleep"]);
        newFood +=1;
        return View["view_all_pets", allPets];
      };
    }
  }
}
