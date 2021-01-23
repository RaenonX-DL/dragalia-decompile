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
	public class QuestCarryDataElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private string _CarryGroupName;
		[SerializeField]
		private int _TargetGroupId;
		[SerializeField]
		private int _MaxReceiveCount;
		[SerializeField]
		private int _SortId;
		[SerializeField]
		private string _StartDate;
		[SerializeField]
		private string _EndDate;
		[SerializeField]
		private GiftType _CarryEntityType1;
		[SerializeField]
		private int _CarryEntityId1;
		[SerializeField]
		private int _CarryEntityQuantity1;
		[SerializeField]
		private GiftType _CarryEntityType2;
		[SerializeField]
		private int _CarryEntityId2;
		[SerializeField]
		private int _CarryEntityQuantity2;
		[SerializeField]
		private GiftType _CarryEntityType3;
		[SerializeField]
		private int _CarryEntityId3;
		[SerializeField]
		private int _CarryEntityQuantity3;
	
		// Properties
		public int Id { get; }
		public string CarryGroupName { get; }
		public int TargetGroupId { get; }
		public int MaxReceiveCount { get; }
		public int SortId { get; }
		public string StartDate { get; }
		public string EndDate { get; }
		public GiftType CarryEntityType1 { get; }
		public int CarryEntityId1 { get; }
		public int CarryEntityQuantity1 { get; }
		public GiftType CarryEntityType2 { get; }
		public int CarryEntityId2 { get; }
		public int CarryEntityQuantity2 { get; }
		public GiftType CarryEntityType3 { get; }
		public int CarryEntityId3 { get; }
		public int CarryEntityQuantity3 { get; }
	
		// Constructors
		public QuestCarryDataElement();
	}
}
