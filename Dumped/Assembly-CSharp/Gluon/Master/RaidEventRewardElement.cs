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
	public class RaidEventRewardElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _RaidEventItemId;
		[SerializeField]
		private int _RaidEventItemQuantity;
		[SerializeField]
		private int _IsShowBadge;
		[SerializeField]
		private GiftType _RewardEntityType;
		[SerializeField]
		private int _RewardEntityId;
		[SerializeField]
		private int _RewardEntityQuantity;
	
		// Properties
		public int Id { get; }
		public int RaidEventItemId { get; }
		public int RaidEventItemQuantity { get; }
		public int IsShowBadge { get; }
		public GiftType RewardEntityType { get; }
		public int RewardEntityId { get; }
		public int RewardEntityQuantity { get; }
	
		// Constructors
		public RaidEventRewardElement();
	}
}
