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
	public class MissionPeriodDataElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private string _Text;
		[SerializeField]
		private int _SortId;
		[SerializeField]
		private int _CompleteValue;
		[SerializeField]
		private int _ProgressFlag;
		[SerializeField]
		private MissionTransportType _MissionTransportType;
		[SerializeField]
		private int _TransportValue;
		[SerializeField]
		private GiftType _EntityType;
		[SerializeField]
		private int _EntityId;
		[SerializeField]
		private int _EntityQuantity;
		[SerializeField]
		private int _EntityBuildupCount;
		[SerializeField]
		private int _EntityLimitBreakCount;
		[SerializeField]
		private int _EntityEquipableCount;
		[SerializeField]
		private int _QuestGroupId;
		[SerializeField]
		private int _CampaignId;
		[SerializeField]
		private int _NeedCompleteMissionId;
		[SerializeField]
		private int _NeedClearQuestId;
		[SerializeField]
		private int _BlankViewQuestStoryId;
		[SerializeField]
		private int _BlankViewQuestId;
	
		// Properties
		public int Id { get; }
		public string Text { get; }
		public int SortId { get; }
		public int CompleteValue { get; }
		public int ProgressFlag { get; }
		public MissionTransportType MissionTransportType { get; }
		public int TransportValue { get; }
		public GiftType EntityType { get; }
		public int EntityId { get; }
		public int EntityQuantity { get; }
		public int EntityBuildupCount { get; }
		public int EntityLimitBreakCount { get; }
		public int EntityEquipableCount { get; }
		public int QuestGroupId { get; }
		public int CampaignId { get; }
		public int NeedCompleteMissionId { get; }
		public int NeedClearQuestId { get; }
		public int BlankViewQuestStoryId { get; }
		public int BlankViewQuestId { get; }
	
		// Constructors
		public MissionPeriodDataElement();
	}
}
