using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestSelectSummaryPopup : PopupBase
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
		private Text chapterPrefixText;

		[SerializeField]
		private Text chapterPostfixText;

		[SerializeField]
		private Text chapterPostfixTextEn;

		[SerializeField]
		private GameObject chapterTextObj;

		[SerializeField]
		private GameObject chapterTextObjEn;

		public static QuestSelectSummaryPopup Create(int questGroupId)
		{
			return null;
		}

		public void Initialize(int questGroupId)
		{
		}
	}
}
