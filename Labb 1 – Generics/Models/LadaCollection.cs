using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Labb_1___Generics.Models
{
    public class LadaCollection : ICollection<Låda>
    {
        public List<Låda> _list;
        public int Count => _list.Count;

        public bool IsReadOnly => throw new NotImplementedException();

        
        public LadaCollection()
        {
            _list = new List<Låda>();
        }

        public void Add(Låda item)
        {
            if (!Contains(item))
            {
                _list.Add(item);
            }
            else
            {
                Console.WriteLine("Det finns redan en låda");
            }
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(Låda lada)
        {
            bool ret = false;
            foreach (Låda item in _list)
            {
                if (lada.Equals(item))
                {
                    ret = true;
                }
            }
            return ret;
        }

        public void CopyTo(Låda[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        
        public IEnumerator<Låda> GetEnumerator()
        {
            return new LadaEnumerator(this);
        }

        public bool Remove(Låda item)
        {
            bool svar = false;

            for (int i = 0; i < _list.Count; i++)
            {
                Låda låda = _list[i];
                if (låda.Equals(item))
                {
                    _list.RemoveAt(i);
                    svar = true;
                    break;
                }
            }


            return svar;


        }

        public Låda this[int index]
        {
            get { return (Låda)_list[index]; }
            set { _list[index] = value; }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            //throw new NotImplementedException();
            return GetEnumerator();
        }
    }
}
