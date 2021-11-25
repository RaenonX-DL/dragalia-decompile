using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestSelectTrailerPopup : PopupBase
	{
		[SerializeField]
		private Text chapterText;

		[SerializeField]
		private Text chapterTextEn;

		[SerializeField]
		private Text chapterTitleText;

		[SerializeField]
		private Text trailerText;

		[SerializeField]
		private Image trailerImage;

		[SerializeField]
		private Text popupTitleText;

		[SerializeField]
		private Text closeButtonText;

		[SerializeField]
		private Text chapterPrefixText;

		[SerializeField]
		private Text chapterPostfixText;

		[SerializeField]
		private Text chapterTextPart2;

		[SerializeField]
		private Text chapterPostfixTextEn;

		[SerializeField]
		private Text chapterTextPart2En;

		[SerializeField]
		private GameObject chapterTextObj;

		[SerializeField]
		private GameObject chapterTextObjEn;

		private const string trailerImagePath = "Images/OutGame/Quest/Trailer/Quest_Jikai_Preview_{0}";

		public static QuestSelectTrailerPopup Create(int questGroupId, bool half)
		{
			return null;
		}

		public void Initialize(int questGroupId, bool half)
		{
		}

		private void OnLoaded(Material mat)
		{
		}
	}
}
