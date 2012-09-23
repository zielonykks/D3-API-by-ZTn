﻿using System.Runtime.Serialization;

namespace ZTn.BNet.D3.Items
{
    [DataContract]
    public class ItemValueRange
    {
        public static readonly ItemValueRange Zero = new ItemValueRange(0);
        public static readonly ItemValueRange One = new ItemValueRange(1);

        #region >> Properties

        [DataMember]
        public double min;
        [DataMember]
        public double max;

        #endregion

        #region >> Constructors

        public ItemValueRange()
        {
        }

        public ItemValueRange(double value)
        {
            this.min = value;
            this.max = value;
        }

        public ItemValueRange(double min, double max)
        {
            this.min = min;
            this.max = max;
        }

        #endregion

        #region >> Operators

        public static ItemValueRange operator +(ItemValueRange left, ItemValueRange right)
        {
            if (left == null)
                return right;
            else if (right == null)
                return left;
            else
                return new ItemValueRange(left.min + right.min, left.max + right.max);
        }

        public static ItemValueRange operator -(ItemValueRange left, ItemValueRange right)
        {
            if (left == null)
                return ItemValueRange.Zero - right;
            else if (right == null)
                return left;
            else
                return new ItemValueRange(left.min - right.min, left.max - right.max);
        }

        public static ItemValueRange operator *(ItemValueRange left, ItemValueRange right)
        {
            if (left == null)
                return Zero;
            else if (right == null)
                return Zero;
            else
                return new ItemValueRange(left.min * right.min, left.max * right.max);
        }

        #endregion
    }
}
