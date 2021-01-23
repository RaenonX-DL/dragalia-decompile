/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using Gluon;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class RankingTierRewardElement : IMasterElement
	{
		// Fields
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
		private int _ClearTimeLower;
		[SerializeField]
		private int _ClearTimeUpper;
		[SerializeField]
		private int _QuestId;
		[SerializeField]
		private GiftType _RankingRewardEntityType;
		[SerializeField]
		private int _RankingRewardEntityId;
		[SerializeField]
		private int _RankingRewardEntityQuantity;
	
		// Properties
		public int Id { get; }
		public int GroupId { get; }
		public int TierNo { get; }
		public string RankingDifficultyText { get; }
		public string RankingDifficultyImage { get; }
		public string RankingRewardDetailText { get; }
		public int ClearTimeLower { get; }
		public int ClearTimeUpper { get; }
		public int QuestId { get; }
		public GiftType RankingRewardEntityType { get; }
		public int RankingRewardEntityId { get; }
		public int RankingRewardEntityQuantity { get; }
	
		// Constructors
		public RankingTierRewardElement();
	}
}
