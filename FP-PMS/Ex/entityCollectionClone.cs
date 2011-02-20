using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FP_PMS.Ex
{
    public static class entityCollectionClone
    {
        public static BindingList<T> CollectionClone<T>(BindingList<T> thingsToClone) 
        {
            return new BindingList<T>(thingsToClone.Select(entityClone.Clone).ToList());
        }
    }
}
