using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.FormsWithInformation
{
    public class Discount
    {
        int discountId;
        string nameOfAnimal;

        public Discount(int disc, string name)
        {
            this.discountId = disc;
            this.nameOfAnimal = name;
        }
    }
}
