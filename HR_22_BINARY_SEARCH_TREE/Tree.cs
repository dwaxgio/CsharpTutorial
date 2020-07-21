using System;
using System.Collections.Generic;
using System.Text;

namespace HR_22_BINARY_SEARCH_TREE
{
    public interface Tree<D : IComparable> 
    {
        public Boolean IsEmpty();
        public int Cardinality();

        public Boolean Member(D elt);
        public NonEmptyBST<D> add(D elt);
    }
}
