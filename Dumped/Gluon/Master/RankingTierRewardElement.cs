using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class RankingTierRewardElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _GroupId;

		[SerializeField]
		private int _TierNo;

		[SerializeField]
		private string _RankingDifficultyText;

		[SerializeField]
		private string _RankingDifficultyImage;

		[SerializeField]
		private string _RankingRewardDetailText;

		[SerializeField]
		private float _ClearTimeLower;

		[SerializeField]
		private float _ClearTimeUpper;

		[SerializeField]
		private int _QuestId;

		[SerializeField]
		private GiftType _RankingRewardEntityType;

		[SerializeField]
		private int _RankingRewardEntityId;

		[SerializeField]
		private int _RankingRewardEntityQuantity;

		public int Id => default(int);

		public int GroupId => default(int);

		public int TierNo => default(int);

		public string RankingDifficultyText => null;

		public string RankingDifficultyImage => null;

		public string RankingRewardDetailText => null;

		public float ClearTimeLower => default(float);

		public float ClearTimeUpper => default(float);

		public int QuestId => default(int);

		public GiftType RankingRewardEntityType => default(GiftType);

		public int RankingRewardEntityId => default(int);

		public int RankingRewardEntityQuantity => default(int);
	}
}
