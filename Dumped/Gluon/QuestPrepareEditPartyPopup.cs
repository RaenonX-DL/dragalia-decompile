using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestPrepareEditPartyPopup : PopupBase
	{
		public Button clearPartyButton;

		[SerializeField]
		private Button disableClearPartyButton;

		public Button normalPartyButton;

		public QuestPrepareScene questPrepareScene
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected override void Start()
		{
		}

		private void SetClearPartyEnable(bool enable)
		{
		}

		public void OnClearPartyButtonTouched()
		{
		}

		public void OnNormalPartyButtonTouched()
		{
		}

		private void OnCharactersExchangeByJumping()
		{
		}

		public void OnAutoPartyButtonTouched()
		{
		}

		public void OnCharaPartyButtonTouched()
		{
		}

		public void OnBgTouched()
		{
		}
	}
}
