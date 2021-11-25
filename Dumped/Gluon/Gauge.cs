using Cute.Core;
using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class Gauge : FastUpdateMonoBehaviour
	{
		public RectTransform barRect;

		[SerializeField]
		private RectTransform barRectCover;

		[SerializeField]
		[Space]
		public bool useMask;

		[SerializeField]
		public bool immediateChange;

		[SerializeField]
		public float value;

		[SerializeField]
		public float changeDelta;

		[SerializeField]
		public bool canOver100;

		[SerializeField]
		public bool changeHeight;

		[SerializeField]
		[Space]
		[Header("Callbacks")]
		public UnityEvent valueChangeCompleted;

		private RectTransform myRect;

		private Vector3 initialPosition;

		private Vector3 initialBarPosition;

		private float maxWidth;

		private float maxHeight;

		public float displayValue;

		private void Awake()
		{
		}

		public void SetValueImmediate(float arg)
		{
		}

		private void CompleteValueChange()
		{
		}

		public override void FastUpdate()
		{
		}

		private void ShrinkBar()
		{
		}
	}
}
