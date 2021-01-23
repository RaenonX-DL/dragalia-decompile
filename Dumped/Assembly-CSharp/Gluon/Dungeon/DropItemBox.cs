/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.Event;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon
{
	public class DropItemBox : DungeonObjectBase
	{
		// Fields
		public float dropTime;
		public string openEffectName;
		public int openEffectTrigger;
		protected DropItemUI.Parameter itemParam;
		protected DropItemUI.Parameter itemParamItem;
		protected DropItemUI.Parameter itemParamWeapon;
		protected DropItemUI.Parameter itemParamMoney;
		protected DropItemUI.Parameter itemParamMaterial;
		protected DropItemUI.Parameter itemParamDungeonItem;
		protected DropItemUI.Parameter itemParamManaPoint;
		protected DropItemUI.Parameter itemParamRaidEventItem;
		protected DropItemUI.Parameter itemParamMazeEventItem;
		protected DropItemUI.Parameter itemParamOtherEventItem;
		private const int BombId = 3001;
		protected bool hitted;
		protected bool isCharaTalk;
		private GameObject bombObj;
		private int limitNum;
		private float numRatio;
		protected bool isRare;
		protected GameObject rareObj;
		protected GameObject normalObj;
		protected bool isStartTimeIniitialize;
		protected Action disppearCallback;
		protected static readonly List<string> treasureBoxNameList;
		protected static readonly List<string> treasureBoxRareSuffixList;
		private static readonly Dictionary<string, string> seTbl;
	
		// Properties
		public bool Hitted { get; }
	
		// Nested types
		public enum TreasureBoxKind
		{
			None = -1,
			Default = 0,
			EggHunt = 1,
			EnumMax = 2
		}
	
		public enum TreasureRareKind
		{
			Normal = 0,
			Rare = 1,
			EnumMax = 2
		}
	
		[CompilerGenerated]
		private sealed class _DropItem_d__36 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public DropItemBox __4__this;
			public GameObject target;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _DropItem_d__36(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _Disppear_d__41 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public DropItemBox __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Disppear_d__41(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public DropItemBox();
		static DropItemBox();
	
		// Methods
		public static string GetTreasureBoxName(TreasureBoxKind boxKind, TreasureRareKind rareKind);
		protected TreasureBoxKind GetTreasureBoxKind(string name);
		protected override void Awake();
		protected override void Start();
		public override void OnCollided(GameObject target, CollisionHitAttribute data);
		private void OnCollided(GameObject target, bool fromEvent);
		[IteratorStateMachine]
		protected virtual IEnumerator DropItem(GameObject target);
		private void Drop(DropItemUI.Parameter param);
		private Quaternion CalcHitRotation(GameObject target);
		protected void PlaySE(GameObject target);
		[IteratorStateMachine]
		private IEnumerator Disppear();
		protected virtual List<EntityData> GetEntityData();
		protected DropItemElement.Type GetEntityDataTypeToDropItemType(EntityData data, out int num, out int limit);
		public override void OnEvent(DungeonObject eventObject, GameObject target);
	}
}
