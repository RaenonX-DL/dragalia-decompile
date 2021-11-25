using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class MatchingTypeSelectPopup : PopupBase
	{
		[SerializeField]
		[Header("Callbacks")]
		public UnityEvent publicButtonPressed;

		[SerializeField]
		public UnityEvent privateButtonPressed;

		[SerializeField]
		public UnityEvent bgButtonPressed;

		[SerializeField]
		private RectTransform rectTransTouchLayer;

		public UnityEvent gpsSearchButtonPressed;

		[SerializeField]
		private GpsLocationUseAgreementToggle useLocationInfoAgreementToggle;

		protected override void Start()
		{
		}

		private IEnumerator FitSize()
		{
			return null;
		}

		public void OnPublicButtonPressed()
		{
		}

		public void OnPrivateButtonPressed()
		{
		}

		public void OnGpsMatchingButtonPressed()
		{
		}

		public void OnBgButtonPressed()
		{
		}
	}
}
