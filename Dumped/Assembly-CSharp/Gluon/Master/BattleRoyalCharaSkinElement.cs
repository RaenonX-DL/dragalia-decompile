/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class BattleRoyalCharaSkinElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _BaseCharaId;
		[SerializeField]
		private int _SpecialSkillId;
		[SerializeField]
		private int _UnlockMaterialId;
		[SerializeField]
		private int _UnlockCommonMaterialQuantity;
		[SerializeField]
		private int _UnlockPickupMaterialQuantity;
		[SerializeField]
		private string _ReleaseStartDate;
		[SerializeField]
		private string _ReleaseEndDate;
		[SerializeField]
		private int _IsUnlockTrade;
		[SerializeField]
		private string _AnimController;
	
		// Properties
		public int Id { get; }
		public int BaseCharaId { get; }
		public int SpecialSkillId { get; }
		public int UnlockMaterialId { get; }
		public int UnlockCommonMaterialQuantity { get; }
		public int UnlockPickupMaterialQuantity { get; }
		public string ReleaseStartDate { get; }
		public string ReleaseEndDate { get; }
		public int IsUnlockTrade { get; }
		public string AnimController { get; }
	
		// Constructors
		public BattleRoyalCharaSkinElement();
	}
}
