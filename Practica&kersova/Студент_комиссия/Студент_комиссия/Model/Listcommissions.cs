using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Студент_комиссия.Model
{
    class Listcommissions
    {
        private string namedirection;//название напровления 
        private int colincomihg;//количество мест
        private Incoming[] List;
        
        public Listcommissions(string a, int b, int c) 
        {
            namedirection = a;
            colincomihg = b;
            List = new Incoming[c];
        }
        public Listcommissions(Listcommissions A)
        {
            namedirection = A.namedirection;
            colincomihg = A.colincomihg;
            List = A.List;

        }
        public int kolin()
        {
            return List.Length;
        }

        public string CBnamedirection//напрпвление
        {
            get
            {
                return namedirection;
            }
            set
            {
                namedirection = value;
            }
        }

        public Incoming this[int k]//студенты
        {
            get
            {
                return List[k];

            }
            set
            {
                List[k] = value;
            }
        }
        public string show()
        {
            sort();
            string txt = $"Направление: {namedirection}\n";
            txt += $"Количество мест для поступления:{colincomihg}\n";
            txt += $"Количество поступающих:{List.Length}\n";
            for (int i = 0; i < List.Length; i++)
            {
              
              txt += $"{List[i].show()}";
                
            }

            return txt;
        }
        public string showok()
        {
            sort();
            string txt = $"Поступившие";
            txt += $"Количество поступивших {colincomihg}\n";
            for (int i = 0; i < List.Length; i++)
            {
                if (i < colincomihg)
                {
                    txt += $"{List[i].show()}";
                }
            }
            return txt;
        }
        public string showhet()
        {
            sort();
            string txt = $"Непоступившие";
            txt += $"Количество непоступивших {List.Length-colincomihg}\n";
            for (int i = 0; i < List.Length; i++)
            {
                if(i>colincomihg)
                {
                  txt += $"{List[i].show()}";
                }
            }
            return txt;
        }
        public void sort()
        {
            for(int i=0;i<List.Length;i++)
            {
                int dex = i;
                for(int j=i;j<List.Length;j++)
                {
                    if(List[dex].srball()< List[j].srball())
                    {
                        dex = j;
                    }
                }
                Incoming a = new Incoming(List[i]);
                List[i] = new Incoming(List[dex]);
                List[dex] = new Incoming(a);
            }    
        }

    }
}