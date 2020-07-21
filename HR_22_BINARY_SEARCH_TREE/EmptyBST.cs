using System;
using System.Collections.Generic;
using System.Text;

namespace HR_22_BINARY_SEARCH_TREE
{
    public class EmptyBST<D : IComparable> , Tree<D>
    {
        public EmptyBST()
        {

        }

        public Boolean IsEmpty()
        {
            return true;
        }

        public int Cardinality()
        {
            return 0;
        }

        public Boolean Member(D elt)
        {
            return false;
        }

        public NonEmptyBST<D> add(D elt)
        {
            return new NonEmptyBST<D>(elt);
        }
    }
}
