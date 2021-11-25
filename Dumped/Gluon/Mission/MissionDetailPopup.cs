using System;
using Gluon.Mission.ListView;
using UnityEngine;

namespace Gluon.Mission
{
	public class MissionDetailPopup : CommonPopup
	{
		[SerializeField]
		[Header("è©³ç\u00b4°æ\u0083\u0085å\u00a0±")]
		public MissionWidgetDetail detail;

		public Action onPopupClosed;

		private TabCategory category;

		private MissionTableViewData data;

		public MissionSelectPopupBase selectPopup;

		public Action onChallengeButtonCallBack;

		public new static MissionDetailPopup Create(Size size = Size.S, BottomButtons bottomButtons = BottomButtons.CancelOk, bool showBlackLayer = true, bool showStartAnimation = true, bool isErrorPopupCanvas = false)
		{
			return null;
		}

		public void Initialize(MissionTableViewData data, TabCategory category, int index)
		{
		}

		private void SetDuplicatedText(GiftType entityType, int entityId, int entityQuantity, Localize.TextId textId)
		{
		}

		public void InitializeSpan(MissionTableViewData data)
		{
		}

		public void InitializeDetailReward(MissionTableViewData data)
		{
		}

		public override void OnCloseButtonPressed()
		{
		}

		public override void OnCancelButtonPressed()
		{
		}

		public override void OnOkButtonPressed()
		{
		}

		private void CreateConfirmPopup()
		{
		}
	}
}
