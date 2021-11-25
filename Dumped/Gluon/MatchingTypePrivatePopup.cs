using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class MatchingTypePrivatePopup : PopupBase
	{
		[SerializeField]
		public UnityEvent privateButtonPressed;

		[SerializeField]
		public UnityEvent bgButtonPressed;

		[SerializeField]
		private RectTransform rectTransTouchLayer;

		public UnityEvent gpsSearchButtonPressed;

		[SerializeField]
		private GpsLocationUseAgreementToggle useLocationInfoAgreementToggle;

		[SerializeField]
		private ButtonWithSelectedImage gpsSearchButtonSelectedState;

		[SerializeField]
		private ButtonWithSelectedImage privateRoomButtonSelectedState;

		[HideInInspector]
		public int questId;

		protected override void Start()
		{
		}

		private IEnumerator FitSize()
		{
			return null;
		}

		public void OnPrivateButtonPressed()
		{
		}

		public void OnGpsMatchingButtonPressed()
		{
		}

		public void ResetPrivateRoomCreateButtonState()
		{
		}

		public void ResetGpsSearchButtonState()
		{
		}

		public void OnBgButtonPressed()
		{
		}
	}
}
