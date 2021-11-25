using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum CustomMessageType
	{
		ShowQuestSelectEventCanvas,
		ReceivedReward,
		ReceivedMission,
		GoToDetailEventList,
		GoToTopEventList,
		GoToSubEventList,
		GoToSupportSelect,
		GoToMatchingRoom,
		ShowQuestList,
		BackToSupportSelect,
		ShowClearParty,
		ShowNormalParty,
		RefreshBoxSummonBadge,
		RefreshExchangeBadge,
		MoveAnimationEndedFromQuestPrepare,
		RemoveCharaVoiceGroup,
		PurchaseDreamSelectItem,
		OnMaterialExchanged,
		AmuletCountCalculated,
		AmuletTradeCompleted,
		InquiryCommentsChanged,
		BoxSummonResultIconTouched,
		GoToMemoryList,
		GoToQuestPrepare,
		GotoSpecialEventTop,
		GoChallengeMissionScene
	}
}
