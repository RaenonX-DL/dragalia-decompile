using Cute.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class LinkNintendoAccountMenu : CommonPopup
	{
		private const string path = "Prefabs/OutGame/DataTransition/LinkNintendoAccountMenu";

		private const string titleScene = "Title";

		private const string loadIndexScene = "LoadIndex";

		private UnityAction onCompleted;

		[SerializeField]
		private Text DataTransitionText;

		[SerializeField]
		private Text NotNow;

		[SerializeField]
		private Text TransitionByNA;

		[SerializeField]
		private Text Title;

		public static void Create(UnityAction onCompleted, string transactionText)
		{
		}

		private static LinkNintendoAccountMenu CreateWithPrefabPath(string prefabPath, UnityAction onCompleted)
		{
			return null;
		}

		public void OnCloseButton()
		{
		}

		public void OnFAQButton()
		{
		}

		public void OnAccountButton()
		{
		}

		private void CreateSwitchNintendoAccountSucceedPopup()
		{
		}

		private void CreateAlreadyLinkToNAPopup()
		{
		}

		private void OnError(ErrorType type, int code)
		{
		}

		public void CreateTransitionAlreadyDonePopup()
		{
		}

		private void CreateLinkNintendoAccountSucceedPopup()
		{
		}

		private void CreateLinkNintendoAccountInGameSucceedPopup()
		{
		}

		private static void GetEulaVersion(UnityAction onCompleted)
		{
		}

		private void OpenLoadingPopup()
		{
		}

		private void CloseLoadingPopup()
		{
		}
	}
}
