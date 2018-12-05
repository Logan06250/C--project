﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{    
    /// <summary>
     /// Classe de l'espace de nétoyage (plonge)
     /// </summary>
    class CleanningRoom
    {
        public List<Ustensil> dirtyUstensil { get; set; }
        public WashingMachine washingMachine { get; set; }
        public DishWasher dishWasher { get; set; }

        public CleanningRoom()
        {
            washingMachine = new WashingMachine();
            dishWasher = new DishWasher();
        }
    }
}
