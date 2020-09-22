using DogGo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogGo.Repositories
{
    public interface IDogRepository
    {
       //public List<Dog> GetAllDogs();
        public List<Dog> GetDogsByOwnerId(int ownerId);


        //public void AddDog(Dog newDog);

    }
}
