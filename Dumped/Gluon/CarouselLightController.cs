using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class CarouselLightController : MonoBehaviour
	{
		[SerializeField]
		private Sprite carsouseOn;

		[SerializeField]
		private Sprite carsouseOff;

		[SerializeField]
		private GridLayoutGroup grid;

		private List<Image> carsouseImages;

		public void Create(int count)
		{
		}

		public void Clear()
		{
		}

		public void SetLight(int index)
		{
		}
	}
}
