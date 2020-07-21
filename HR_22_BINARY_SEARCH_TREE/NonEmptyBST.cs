using System;

namespace HR_22_BINARY_SEARCH_TREE
{
    public class NonEmptyBST<D : IComparable> , Tree<D>
    {
        D data // data equivalente a root en tree
        Tree<D> left;
        Tree<D> right;
        public NonEmptyBST(D elt)
        {
            data = elt;
            left = new EmptyBST<D>();
            right = new EmptyBST<D>();
        }

        public NonEmptyBST(D elt, Tree<D> leftTree, Tree<D> rightTree)
        {
            data = elt;
            left = leftTree;
            right = rightTree;
        }

        public Boolean IsEmpty()
        {
            return false;
        }

        public int Cardinality()
        {
            return 1 + left.Cardinality() + right.Cardinality();
        }

        public Boolean Member(D elt)
        {
            if (data == elt)
            {
                return true;
            }
            else
            {
                if (elt.compareTo(data) < 0)
                {
                    return left.Member(elt);
                }
                else
                {
                    return right.Member(elt);
                }
            }
        }

        public NonEmptyBST<D> add(D elt)
        {
            if (data == elt)
            {
                return this;
            }
            else
            {
                if (elt.compareTo(data) < 0)
                {
                    return new NonEmptyBST(data, left.add(elt), right);
                }
                else
                {
                    return new NonEmptyBST(data, left, right.add(elt));
                }
            }
        }
    }
}