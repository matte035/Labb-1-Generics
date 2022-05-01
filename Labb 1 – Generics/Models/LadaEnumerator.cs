using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Labb_1___Generics.Models
{
    // behöver propities och en constructor någonstans.
    public class LadaEnumerator : IEnumerator<Låda>
    {
        public LadaCollection _lådorCollection;

        private int curIndex;
        private Låda curLåda;
        public LadaEnumerator(LadaCollection ladaCollection)
        {
            _lådorCollection = ladaCollection;
            curIndex = 1;
            curLåda = default(Låda);

        }

        public Låda Current
        {
            get { return curLåda; }
        }

        object IEnumerator.Current
        {
            get { return curLåda; }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            if (curIndex>=_lådorCollection.Count)
            {
                return false;
                
            }
            else
            {
                curLåda = _lådorCollection[curIndex];
                return true;
            }

        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
