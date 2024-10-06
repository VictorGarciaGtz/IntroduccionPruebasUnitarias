using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class TestManagerClassData : IEnumerable<Object[]>
    {
        public IEnumerator<Object[]> GetEnumerator()
        {
            yield return new Object[] { "", 0 };
            yield return new Object[] { "Hola mundo", 2 };
            yield return new Object[] { "Hola mundo este es una prueba de una clase", 9 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
