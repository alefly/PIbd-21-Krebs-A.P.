using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
	class ClassArray<T> where T : ITechnique
	{
		private T[] places;
		
		private T defaultValue;
		
		public ClassArray(int sizes, T defVal)
		{
		defaultValue = defVal;
		places = new T[sizes];
		for(int i = 0;i < places.Lenght; i++)
		{
		places[i] = defaultValue;
		}
		}

		public static int operator +(ClassArray<T> p, T plane)
		{
			
			for (int i = 0; i < p.places.Count; i++)
			{
				if (p.CheckFreePlace(i))
				{
					p.places[i] = plane;
					return i;
				}
			}
			return -1;
		}

		public static T operator -(ClassArray<T> p, int index)
		{
			if (p.places.ContainsKey(index))
			{
				T plane = p.places[index];
				p.places[index] = p.defaultValue;
				return plane;
			}
			return p.defaultValue;
		}

		private bool CheckFreePlace(int index)
		{
			if(index < 0 || index > places.Lenght)
			{
			return false;
			}
			if(places[index] == null)
			{ 
			return true;
			}
			if(places[index].Equals(dafaultValue))
			{
			return false;
			}
		}

	}
}
