using Cute.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class SuggestionBoxPopup : PopupBase
	{
		private const string prefabPath = "Prefabs/OutGame/SuggestionBox/SuggestionBoxPopup";

		[SerializeField]
		private Text titleText;

		[SerializeField]
		private Button okButton;

		[SerializeField]
		private Text okText;

		[SerializeField]
		private Button closeButton;

		[SerializeField]
		private Text closeText;

		[SerializeField]
		private InputField suggestionInput;

		[SerializeField]
		private Text inputPlaceHolder;

		[SerializeField]
		private Text inputCharText;

		[SerializeField]
		private Text maxCharText;

		[SerializeField]
		private Text selectCategoryText;

		private const int maxChar = 200;

		private int selectCategoryListIndex;

		public static SuggestionBoxPopup Create()
		{
			return null;
		}

		public void InitSetting()
		{
		}

		public void OnCloseButtonPressed()
		{
		}

		public void OnOkButtonPressed()
		{
		}

		private bool IsInputTextValid(string inputText)
		{
			return default(bool);
		}

		public static string ConvertInvalidText(string inputText)
		{
			return null;
		}

		public void OnValueChangedSuggestion(string text)
		{
		}

		public void OnEndEditSuggestion(string text)
		{
		}

		private void SetInputChar(int count)
		{
		}

		public static void RequestSuggestionGetCategoryList(UnityAction successCallback)
		{
		}

		private void RequestSuggestionSet(string message, int cateoryId, UnityAction successCallback)
		{
		}

		private static void CalledAfterLoginChecked(UnityAction successCallback)
		{
		}

		private static void OnError(ErrorType errorType, int resultCode)
		{
		}

		public void OnCategorySelectButtonPressed()
		{
		}
	}
}
