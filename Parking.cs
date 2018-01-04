using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
	public class Parking
	{
		
		public Parking(int countStages)
		{
			parkingStages = new List<ClassArray<ITechnique>>(countStages);
			for( int i = 0; i<countStages; i++)
			{
				parkingStages.Add(new ClassArray<ITechnique>(countPlaces, null));
			}
		}

		

		

		/////отрисовка 


		public void Draw(Graphics g)
		{
			DrawMarking(g);
			for (int i = 0; i < countPlaces; i++)
			{
				var plane = parkingStages[currentLevel][i];
				plane.setPosition(5 + i / 5 * 200 + 5, i % 5 * 120 + 15);
				plane.drawBombardir(g);
				
			}
		}

		/// отрисовка разметки парковки


		private void DrawMarking(Graphics g)
		{
			Pen pen = new Pen(Color.Black, 3);
			///границы парковки
			g.DrawString("L" + (currentLevel + 1), new Font("Arial", 30), new SolidBrush(Color.Blue), (countPlaces / 5) * placeSizeWidth - 70, 420);

			g.DrawRectangle(pen, 0, 0, (countPlaces / 5) * placeSizeWidth, 580);
			for (int i = 0; i < countPlaces / 5; i++)
			{
				///отрисовываем, по 5 мест на линии
				for (int j = 0; j < 6; ++j)
				{/// линия разметки места
					g.DrawLine(pen, i * placeSizeWidth, j * placeSizeHeighth, i * placeSizeWidth + 110, j * placeSizeHeighth);
					if (j < 5)
					{
						g.DrawString((i * 5 + j + 1).ToString(), new Font("Arial", 30),
						new SolidBrush(Color.Blue), i * placeSizeWidth + 30, j * placeSizeHeighth + 20);
					}
				}
				g.DrawLine(pen, i * placeSizeWidth, 0, i * placeSizeWidth, 580);
			}
		}
		}
}
