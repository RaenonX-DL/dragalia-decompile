using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class CarouselCellBase : MonoBehaviour
	{
		public enum WheelChapterSize
		{
			Front,
			Middle,
			Back,
			Max
		}

		private float baseRot;

		private float wheelRot;

		private float wheelWidth;

		private RectTransform rectTransForm;

		private int index;

		[SerializeField]
		protected List<GameObject> cells;

		protected float elementsScale;

		[SerializeField]
		private Image[] centerFrame;

		public virtual void Initialize<T>(int index, T data, float carouselWidth)
		{
		}

		public void SetBaseRot(float rot)
		{
		}

		public float GetBaseRot()
		{
			return default(float);
		}

		public float GetWheelRot()
		{
			return default(float);
		}

		public RectTransform GetRectTransForm()
		{
			return null;
		}

		public int GetIndex()
		{
			return default(int);
		}

		public void SetScale(float scale)
		{
		}

		public Vector3 SetWheelRot(float rot)
		{
			return default(Vector3);
		}

		public void SetSize(WheelChapterSize size)
		{
		}
	}
}
