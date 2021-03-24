/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class BattleRoyalCharaSkinPickupElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _BattleRoyalCharaId;
		[SerializeField]
		private int _SummonId;
		[SerializeField]
		private string _PickupStartDate;
		[SerializeField]
		private string _PickupEndDate;
	
		// Properties
		public int Id { get; }
		public int BattleRoyalCharaId { get; }
		public int SummonId { get; }
		public string PickupStartDate { get; }
		public string PickupEndDate { get; }
	
		// Constructors
		public BattleRoyalCharaSkinPickupElement();
	}
}
