using Cute.Http;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class StoryNameEntryPopup : CommonPopup
	{
		public InputField nameInput;

		public Text inputPlaceHolder;

		public Text infoText;

		public Text infoText2;

		public Text infoText3;

		public GameObject closeButtonEffect;

		public GameObject okButtonEffect;

		public GameObject cancelButtonEffect;

		public UnityAction<string> nameChangeCallBack;

		public Sprite profileTitleSprite;

		public Sprite profileFrameSprite;

		public Material profileMaterial;

		private const string storyPrefabPath = "Prefabs/OutGame/Story/StoryNameEntryPopup";

		private const string profilePrefabPath = "Prefabs/OutGame/Profile/ProfileNameEntryPopup";

		private bool isPressedOkButton;

		private string newPlayerName;

		private bool isEditName;

		private Tweener backKeyTween;

		private float delayTimeForActivateInputFieldByBackKey;

		private const int maxInputCharacterLimit = 10;

		private const int inputCharacterLimitAllowance = 60;

		public static StoryNameEntryPopup Create()
		{
			return null;
		}

		public void InitSetting(string nowName = "")
		{
		}

		protected override void Start()
		{
		}

		private void SendNameChangeMessage()
		{
		}

		public override void OnOkButtonPressed()
		{
		}

		public override void OnCloseButtonPressed()
		{
		}

		private void RequestNameChange(string changeName, UnityAction successCallback)
		{
		}

		public void OnError(ErrorType errorType, int resultCode)
		{
		}

		private void ShowCompleteDialog()
		{
		}

		private void SetupProfileUI()
		{
		}

		protected override void OnDestroy()
		{
		}
	}
}
