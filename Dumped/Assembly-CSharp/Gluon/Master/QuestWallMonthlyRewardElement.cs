/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using Gluon;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class QuestWallMonthlyRewardElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _TotalWallLevel;
		[SerializeField]
		private int _RewardStageNum;
		[SerializeField]
		private string _RewardImage;
		[SerializeField]
		private int _IsShowBadge;
		[SerializeField]
		private GiftType _RewardEntityType;
		[SerializeField]
		private int _RewardEntityId;
		[SerializeField]
		private int _RewardEntityQuantity;
		[SerializeField]
		private string _ReceiveStartDate;
		[SerializeField]
		private string _ReceiveEndDate;
	
		// Properties
		public int Id { get; }
		public int TotalWallLevel { get; }
		public int RewardStageNum { get; }
		public string RewardImage { get; }
		public int IsShowBadge { get; }
		public GiftType RewardEntityType { get; }
		public int RewardEntityId { get; }
		public int RewardEntityQuantity { get; }
		public string ReceiveStartDate { get; }
		public string ReceiveEndDate { get; }
	
		// Constructors
		public QuestWallMonthlyRewardElement();
	}
}
