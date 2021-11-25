using System.Collections;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GuildTopPage : MonoBehaviour
	{
		[SerializeField]
		[Header("TopField")]
		public RawImage emblemImage;

		public Text guildNameText;

		public Text mottoText;

		public Badge memberListBadge;

		public Transform[] chatNodes;

		public GuildChatView chatViews;

		[SerializeField]
		private GameObject inviteBadge;

		public static bool isShowPrevRoomOnEnter;

		private static RoomList prevRoomData;

		private static bool prevRoomIsFriend;

		public static GuildTopPage Create(Transform parent)
		{
			return null;
		}

		private IEnumerator Start()
		{
			return null;
		}

		private void UpdateBadge()
		{
		}

		private void CheckLoginFlow()
		{
		}

		private void CheckOccupationUpdate()
		{
		}

		private bool CheckOcupationUpdateAndReloadScene()
		{
			return default(bool);
		}

		private void RefreshInfo()
		{
		}

		private void StopPolling()
		{
		}

		private void LoadChatView()
		{
		}

		public void OnMultiButtonPressed()
		{
		}

		public void OnMemberListButtonPressed()
		{
		}

		public void OnOptionButtonPressed()
		{
		}

		public static void ShowRoomEntryConfirmPopup(RoomList roomList, bool isFriend)
		{
		}

		private static void GoPrepareScene(int questId)
		{
		}
	}
}
