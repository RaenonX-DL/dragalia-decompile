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
	public class BattleRoyalDungeonItemElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private string _PrefabName;
		[SerializeField]
		private int _Param;
		[SerializeField]
		private int _TakenEffectTrigger;
		[SerializeField]
		private string _TakenSE;
	
		// Properties
		public int Id { get; }
		public string PrefabName { get; }
		public int Param { get; }
		public int TakenEffectTrigger { get; }
		public string TakenSE { get; }
	
		// Constructors
		public BattleRoyalDungeonItemElement();
	}
}
