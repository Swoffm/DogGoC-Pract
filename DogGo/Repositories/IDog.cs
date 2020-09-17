using DogGo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogGo.Repositories
{
    interface IDog
    {
        List<Dog> GetAllDogs();
        List<Dog> GetDogsByOwnerId(int ownerId);

        void AddDog(Dog newDog);

    }
}
