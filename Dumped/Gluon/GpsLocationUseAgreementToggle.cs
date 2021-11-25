using System;
using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class GpsLocationUseAgreementToggle : MonoBehaviour
	{
		[SerializeField]
		private Toggle useLocationInfoAgreementToggle;

		[SerializeField]
		private Button gpsMatchingButton;

		[SerializeField]
		public string prefsKeyLocationInfoUseGDPRAgreed;

		private Coroutine matchingButtonTask;

		private const int needParentAgreementAge = 15;

		private void Awake()
		{
		}

		private void ShowUseLocationCautionPopup(UnityAction action)
		{
		}

		private void ShowUseLocationFailNoNAPopup()
		{
		}

		private void ShowUseLocationConfirmPopup(UnityAction agreeAction, UnityAction denyAction)
		{
		}

		private void ShowUseLocationResultPopup(UnityAction action)
		{
		}

		public void OnUseLocationInfoAgreementToggleChanged(bool value)
		{
		}

		private void OnLocationPermissionDenied()
		{
		}

		private bool IsRequireGDPRAgreementRegion()
		{
			return default(bool);
		}

		private bool IsRequireGDPRAgreementAge()
		{
			return default(bool);
		}

		private void SetGpsLocationUseCheck(bool isChecked)
		{
		}

		public void OnGpsMatchingButtonPressed(Action action, [Optional] Action failedAction)
		{
		}

		private IEnumerator DoMatchingButtonAction(Action action, Action failedAction)
		{
			return null;
		}
	}
}
