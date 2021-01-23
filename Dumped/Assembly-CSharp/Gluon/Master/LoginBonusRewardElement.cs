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
	public class LoginBonusRewardElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _Gid;
		[SerializeField]
		private int _Day;
		[SerializeField]
		private GiftType _EntityType;
		[SerializeField]
		private int _EntityId;
		[SerializeField]
		private int _EntityQuantity;
		[SerializeField]
		private int _EntityLevel;
		[SerializeField]
		private int _EntityLimitBreakCount;
		[SerializeField]
		private int _EntityBuildupCount;
		[SerializeField]
		private int _EntityEquipableCount;
		[SerializeField]
		private string _AnimationSetting;
	
		// Properties
		public int Id { get; }
		public int Gid { get; }
		public int Day { get; }
		public GiftType EntityType { get; }
		public int EntityId { get; }
		public int EntityQuantity { get; }
		public int EntityLevel { get; }
		public int EntityLimitBreakCount { get; }
		public int EntityBuildupCount { get; }
		public int EntityEquipableCount { get; }
		public string AnimationSetting { get; }
	
		// Constructors
		public LoginBonusRewardElement();
	}
}
