/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class BRItemPopPoint : MonoBehaviour
	{
		// Fields
		[SerializeField]
		[Tooltip]
		private int groupId;
		public BattleRoyalDungeonItemSet itemSet;
		public BattleRoyalDungeonItem poppedItem;
		private int pointId;
	
		// Properties
		public int GroupId { get; }
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<BattleRoyalDungeonItem, bool> __9__9_0;
			public static Func<BattleRoyalDungeonItem, Guid> __9__9_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _PopItem_b__9_0(BattleRoyalDungeonItem a);
			internal Guid _PopItem_b__9_1(BattleRoyalDungeonItem a);
		}
	
		// Constructors
		public BRItemPopPoint();
	
		// Methods
		private void Awake();
		private void Update();
		public void PopItem();
		public static BattleRoyalDungeonItem PopItem(BattleRoyalDungeonItemSet itemSet, BRItemId id, Vector3 pos, bool isSync);
	}
}
