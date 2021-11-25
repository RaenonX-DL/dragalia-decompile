using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class StampCarsouseIcons : MonoBehaviour
	{
		public Image[] carsouseImages;

		public Sprite carsouseOn;

		public Sprite carsouseOff;

		public int curPageCarsouse;

		private const int maxPageCarsouse = 3;

		public void SetPageCarsouse(int nowPage)
		{
		}

		public void SetCarsouseIconNum(int num, float mergin)
		{
		}
	}
}
