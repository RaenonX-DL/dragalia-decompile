using System.Collections;
using UnityEngine;

namespace Gluon
{
	public class CommonSliderAccelerateRepeater : MonoBehaviour
	{
		[SerializeField]
		private CommonSliderSelection sliderSelection;

		[SerializeField]
		private PointerEventHandler plusButtonEventHandler;

		[SerializeField]
		private PointerEventHandler minusButtonEventHandler;

		[SerializeField]
		private float touchDurationDefault;

		[SerializeField]
		private float touchDurationMin;

		[SerializeField]
		private int longPressAddValueMax;

		[SerializeField]
		private int longPressAddSpeed;

		private int longPressAddValue;

		private Coroutine countCoroutine;

		private void Start()
		{
		}

		public void UseCountButtonPressed(int countInc)
		{
		}

		public void UseCountButtonLongPressed(int countInc)
		{
		}

		private IEnumerator CountSpeedCoroutine(bool isPlus)
		{
			return null;
		}

		public void OnSliderValueChanged(float val)
		{
		}

		private void LongPressEnded()
		{
		}
	}
}
