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
	public class CombatEventLocationRewardElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _EventId;
		[SerializeField]
		private int _LocationRewardId;
		[SerializeField]
		private GiftType _EntityType;
		[SerializeField]
		private int _EntityId;
		[SerializeField]
		private int _EntityQuantity;
	
		// Properties
		public int Id { get; }
		public int EventId { get; }
		public int LocationRewardId { get; }
		public GiftType EntityType { get; }
		public int EntityId { get; }
		public int EntityQuantity { get; }
	
		// Constructors
		public CombatEventLocationRewardElement();
	}
}
