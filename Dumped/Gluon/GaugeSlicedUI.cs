using UnityEngine;

namespace Gluon
{
	public class GaugeSlicedUI : MonoBehaviour
	{
		private float widthPixel;

		public float initWidthPixel;

		public float initWidth;

		public float ofsx;

		[SerializeField]
		private Transform trLeft;

		[SerializeField]
		private Transform trMid;

		[SerializeField]
		private Transform trRight;

		private float wLeft;

		private float wMid;

		private float wRight;

		private float ppu;

		public float Width
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public void Initialize()
		{
		}

		private void SetWidth(float value)
		{
		}
	}
}
