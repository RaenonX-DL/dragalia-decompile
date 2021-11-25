using UnityEngine;

namespace Gluon
{
	public class QuestResultRanking : MonoBehaviour
	{
		public class RankingMemberInfo
		{
			public int charaId;

			public int emblemId;

			public string userName;

			public int level;

			public bool isShowYouImage;

			public RankingMemberInfo(int charaId, int emblemId, string userName, int level, bool isShowYouImage)
			{
			}
		}

		[SerializeField]
		private QuestResultRankingPartyMemberCell[] partyMemberCells;

		[SerializeField]
		private RectTransform clearTimeLabelTrans;

		[SerializeField]
		private RectTransform clearTimeNewRecordTrans;

		[SerializeField]
		private RectTransform rankingLabelTrans;

		[SerializeField]
		private RectTransform rankingNewRecordTrans;

		[SerializeField]
		private RectTransform descriptionTrans;

		[SerializeField]
		private RectTransform[] partyCharacters;

		public const float clearTimeNewRecordIconEnterDelayFrame = 32f;

		public const float rankPartyCharacterEnterDelayFrame = 41f;

		public const float rankingNewRecordIconEnterDelayFrame = 44f;

		public const float rankExitDelayFrame = 3f;

		public const float clearExitDelayFrame = 7f;

		public const float rankingNextButtonEnterDelayFrame = 25f;

		public void Initialize()
		{
		}

		private void SetDisp(RectTransform trans, bool value)
		{
		}

		public void StartPartyCharactersEnterAnimation()
		{
		}

		public void StartPartyCharactersExitAnimation()
		{
		}

		private void SlideOutPartyCharacter(RectTransform targetTrans)
		{
		}

		public void SlideInClearTimeLabel()
		{
		}

		public void SlideInRankingLabel()
		{
		}

		public void SlideInDescripiton()
		{
		}

		public void SlideOutClearTimeLabel()
		{
		}

		public void SlideOutRankingLabel()
		{
		}

		public void SlideOutDescripiton()
		{
		}

		private void SlideInLabel(RectTransform targetTrans)
		{
		}

		public void SlideInClearTimeNewRecord()
		{
		}

		public void SlideInRankingNewRecord()
		{
		}

		public void SlideOutClearTimeNewRecord()
		{
		}

		public void SlideOutRankingNewRecord()
		{
		}

		private void SlideInNewRecord(RectTransform targetTrans)
		{
		}

		private void SlideInCharacter(RectTransform targetTrans, float delay)
		{
		}

		private void SlideOutLabel(RectTransform targetTrans)
		{
		}

		private void SlideOutNewRecord(RectTransform targetTrans)
		{
		}

		private void SlideOut(RectTransform targetTrans, float relativeX, float delay = 0f)
		{
		}
	}
}
