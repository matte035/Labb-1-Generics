﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_1___Generics.Models
{
    public class Låda : IEquatable<Låda>
    {
        public int höjd { get; set; }
        public int längd { get; set; }
        public int bredd { get; set; }

        public Låda(int h, int l, int b)
        {
            this.höjd = h;
            this.längd = l;
            this.bredd = b;
        }
       


        public bool Equals(Låda other)
        {
            if (new LadaSameDem().Equals(this, other))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
