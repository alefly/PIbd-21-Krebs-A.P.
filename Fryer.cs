using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Fryer
    {
        
        private Oil[] oil;
        private Potato[] potatos;
        private Salt salt;
        public bool ReadyToGo { get { return Check(); } }
        public void Init(int countPotatos)
        {
            oil = new Oil[3];
            potatos = new Potato[countPotatos];

        }


        public void AddOil(Oil o)
        {
            for (int i = 0; i < oil.Length; i++)
            {
                if (oil[i] == null)
                {
                    oil[i] = o;
                    return;
                }
            }
        }

        public void AddSalt(Salt s)
        {
            salt = s;
        }

        public void AddPotato(Potato p)
        {
            for (int i = 0; i < potatos.Length; ++i)
            {
                if (potatos[i] == null)
                {
                    potatos[i] = p;
                }
                return;
            }
        }
        private bool Check()
        {
            if (oil.Length == 0)
            {
                return false;
            }
            if (potatos.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < oil.Length; i++)
            {
                if (oil[i] == null)
                {
                    return false;
                }
            }
            for (int i = 0; i < potatos.Length; ++i)
            {
                if (potatos[i] == null)
                {
                    return false;
                }
            }
            return true;
        }



        public void GetHeat()
        {
            if (!Check())
            {
                return;
            }
            if (oil.Length > 0)
            {
                if (oil[0].Temperature < 100)
                {
                    for (int i = 0; i < oil.Length; i++)
                    {
                        oil[i].GetHeat();
                    }
                }
                bool flag = false;
                switch (oil[0].Temperature)
                {
                    case 20:
                        flag = true;
                        break;
                    case 40:
                        flag = true;
                        break;
                    case 60:
                        flag = true;
                        break;
                    case 80:
                        flag = true;
                        break;
                    case 100:
                        flag = true;
                        break;
                }
                if (flag)
                {
                    for (int i = 0; i < potatos.Length; ++i)
                    {
                        potatos[i].GetHeat();
                    }
                }
            }
            else
            {
                for (int i = 0; i < potatos.Length; i++)
                {
                    potatos[i].GetHeat();
                }
            }
        }


        public bool IsReady()
        {
            for (int i = 0; i < oil.Length; i++)
            {
                if (oil[i].Temperature < 100)
                {
                    return false;
                }
            }
            for (int i = 0; i < potatos.Length; i++)
            {
                if (potatos[i].Has_ready < 10)
                {
                    return false;
                }
            }
            return true;
        }
        public Potato[] GetPotatos()
        {
            return potatos;
        }
        public bool State
        {
            set;
            get;
        }

        public void Cook() {
            if (State)
            {
                GetHeat();
            }
        } 
    }
}
