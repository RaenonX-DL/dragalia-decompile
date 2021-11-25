using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class MatchingPartyMenuPopup : PopupBase
	{
		[SerializeField]
		[Header("Callbacks")]
		public UnityEvent autoPartyButtonPressed;

		[SerializeField]
		[Header("Callbacks")]
		public UnityEvent charaPartyButtonPressed;

		[SerializeField]
		[Header("Callbacks")]
		public UnityEvent bgButtonPressed;

		public void OnAutoPartyButtonPressed()
		{
		}

		public void OnCharaPartyButtonPressed()
		{
		}

		public void OnBgButtonPressed()
		{
		}
	}
}
