using System;

namespace Gluon
{
	public class MatchingAutoJoiningPopup : PopupBase
	{
		private const string prefabPath = "UI/Popup/Matching/MatchingAutoJoiningPopup";

		private Action onCancel;

		public static MatchingAutoJoiningPopup Create(Action onCancel)
		{
			return null;
		}

		public void OnCancelButtonPressed()
		{
		}
	}
}
