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
	public class QuestScheduleDetailElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _ScheduleGroupId;
		[SerializeField]
		private int _DropBonusPercent;
		[SerializeField]
		private QuestGroupIntervalType _QuestIntervalType;
		[SerializeField]
		private string _StartDate;
		[SerializeField]
		private string _EndDate;
		[SerializeField]
		private int _LimitShopGoodsType;
	
		// Properties
		public int Id { get; }
		public int ScheduleGroupId { get; }
		public int DropBonusPercent { get; }
		public QuestGroupIntervalType QuestIntervalType { get; }
		public string StartDate { get; }
		public string EndDate { get; }
		public int LimitShopGoodsType { get; }
	
		// Constructors
		public QuestScheduleDetailElement();
	}
}
