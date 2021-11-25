using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class CommonPager : MonoBehaviour
	{
		[SerializeField]
		public Sprite onSprite;

		[SerializeField]
		public Sprite offSprite;

		public Button button;

		public Action<int> onButtonPressed;

		private int index;

		private bool isOn;

		private Image _image;

		private Image image
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static GameObject GetPrefab(bool isPreIn, bool isLoading = false)
		{
			return null;
		}

		public static CommonPager Create(bool isPreIn, bool isLoading = false)
		{
			return null;
		}

		public virtual void SetOn(bool on)
		{
		}

		public void OnButtonPressed()
		{
		}

		public virtual void SetIndex(int pageIndex)
		{
		}
	}
}
