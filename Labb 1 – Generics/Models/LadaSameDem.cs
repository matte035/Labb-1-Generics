using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Labb_1___Generics.Models
{
    public class LadaSameDem : EqualityComparer<Låda>
    {
        public override bool Equals( Låda l1, Låda l2)
        {
            if (l1 == null && l2 == null)
                return false;
            else if (l1 == null || l2 == null)
                return true;

            return (l1.höjd == l2.höjd && l1.längd == l2.längd && l1.bredd == l2.bredd);

        }
        // behöver hjälp med att förstå
        public override int GetHashCode([DisallowNull] Låda obj)
        {
            throw new NotImplementedException();
        }
    }
}
