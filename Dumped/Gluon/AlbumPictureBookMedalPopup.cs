using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class AlbumPictureBookMedalPopup : PopupBase, ICustomMessage
	{
		[SerializeField]
		private Text popupTitle;

		[SerializeField]
		private AlbumPictureBookMedalController albumPictureBookMedalController;

		[SerializeField]
		private AlbumPictureBookMedalGroupController albumPictureBookMedalListController;

		private UnityAction onGoChallengeMissionSceneCallback;

		public static AlbumPictureBookMedalPopup Create()
		{
			return null;
		}

		protected void Awake()
		{
		}

		public void SetContent(MedalPopupType type, int charaId = -1)
		{
		}

		public void SetGoChallengeMissionSceneCallback(UnityAction onCallback)
		{
		}

		public void OnMessagReceived(CustomMessageType messageType, object data)
		{
		}

		protected override void OnDestroy()
		{
		}
	}
}
