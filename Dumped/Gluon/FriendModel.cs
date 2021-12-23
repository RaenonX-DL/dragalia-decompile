using System;
using Cute.Http;
using UnityEngine.Events;

namespace Gluon
{
	public class FriendModel
	{
		public enum PanelType
		{
			None,
			Top,
			FriendList,
			FriendSearch,
			ApplyingList,
			ApprovalWaitList,
			SupportSetting
		}

		public const int inputIdLength = 11;

		public const int showLimitDay = 10;

		public int friendNum;

		public UnityAction<string, Footer.MenuTab> onFooterButtonPressed;

		public UnityAction<UnityAction> changeSceneCallback;

		private readonly int searchListUpdateIntervalSec;

		private long _searchListLastUpdateUnixTime;

		public int currentSupportCharacterID;

		private ulong currentSupportDragonKeyID;

		private ulong currentSupportWeaponBodyID;

		private ulong currentSupportAmuletID1;

		private ulong currentSupportAmuletID2;

		private ulong currentSupportAmuletID3;

		private ulong currentSupportAmuletID4;

		private ulong currentSupportAmuletID5;

		private ulong currentSupportAmuletID6;

		private ulong currentSupportAmuletID7;

		private ulong currentSupportTalismanID;

		private static FriendModel instance;

		public PanelType currentPanel;

		public PanelType nextPanel;

		public const string prefabPath = "Prefabs/OutGame/Friend/";

		public long searchListLastUpdateUnixTime
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}

		public static FriendModel Instance => null;

		public static int GetNewFriendCount()
		{
			return default(int);
		}

		public static int GetNewApprovalWaitCount()
		{
			return default(int);
		}

		public static bool IsNewApplyFriend(ulong viewer_id)
		{
			return default(bool);
		}

		public static bool IsNewFriend(ulong viewer_id)
		{
			return default(bool);
		}

		public static void DeleteInstance()
		{
		}

		private FriendModel()
		{
		}

		static FriendModel()
		{
		}

		public void RequestFriendList(Action successCallback)
		{
		}

		public void RequestAppryingList(Action successCallback)
		{
		}

		public void RequestApprovalWaitList(Action successCallback)
		{
		}

		public void RequestUpdateResetNewFriend(ulong[] friendIds, Action successCallback)
		{
		}

		public void RequestUpdateResetNewFriendApply(Action successCallback)
		{
		}

		public void RequestSetSupportChara(Action successCallback)
		{
		}

		public void RequestGetSupportChara(Action successCallback)
		{
		}

		public void RequestRecommendedList(Action successCallback)
		{
		}

		public void OnError(ErrorType errorType, int resultCode)
		{
		}

		public string GetFriendNumText()
		{
			return null;
		}

		public ulong GetEquipId(FriendSupportSettingView.Type type)
		{
			return default(ulong);
		}

		public void SetEquipId(FriendSupportSettingView.Type type, ulong value)
		{
		}

		public void SetAmuletId(int index, ulong value)
		{
		}

		private void RestWeaponSlot(ulong value)
		{
		}
	}
}
