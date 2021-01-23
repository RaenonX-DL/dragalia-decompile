/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class BRItemManager : MonoBehaviour
	{
		// Fields
		private Dictionary<BattleRoyalDungeonItem, GameObject> prefabDict;
		[CompilerGenerated]
		private List<BRItemBase> _AliveItems_k__BackingField;
	
		// Properties
		public List<BRItemBase> AliveItems { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		private class TypeComparer : IEqualityComparer<BattleRoyalDungeonItem>
		{
			// Constructors
			public TypeComparer();
	
			// Methods
			public bool Equals(BattleRoyalDungeonItem x, BattleRoyalDungeonItem y);
			public int GetHashCode(BattleRoyalDungeonItem obj);
		}
	
		[CompilerGenerated]
		private sealed class _CreateItemsCoroutine_d__9 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public uint seed;
			public List<BRItemParam> createItemParams;
			public BRItemManager __4__this;
			public Vector3 pos;
			public float radius;
			private RandomXorshift _random_5__2;
			private List<BRItemParam> __7__wrap2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CreateItemsCoroutine_d__9(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			private void __m__Finally1();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<BattleRoyalDungeonItem, bool> __9__20_0;
			public static Func<BattleRoyalDungeonItem, Guid> __9__20_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _GetLotteryItem_b__20_0(BattleRoyalDungeonItem a);
			internal Guid _GetLotteryItem_b__20_1(BattleRoyalDungeonItem a);
		}
	
		// Constructors
		public BRItemManager();
	
		// Methods
		private void Start();
		public void CreateItem(BRItemParam param, Vector3 pos, bool isSync);
		public void CreateItems(List<BRItemParam> createItemParams, Vector3 pos);
		[IteratorStateMachine]
		private IEnumerator CreateItemsCoroutine(List<BRItemParam> createItemParams, Vector3 pos, float radius, uint seed);
		private void CreateItemCore(GameObject go, BRItemParam param, Vector3 startPos, Vector3 endPos, bool ignoreSeFx);
		public void DeleteItem(BRItemBase item);
		public void DeleteAllItems();
		private void LoadPrefabs();
		private void AddPool(BattleRoyalDungeonItem type, int ct);
		private void ReleaseItemInstance(GameObject obj);
		private void SendCreateRandomPopItemEvent(List<BRItemParam> createItemParams, Vector3 pos, float radius, uint seed);
		private void SendCreateSilentPopItemEvent(BRItemParam param, Vector3 pos);
		public void OnReceiveEvent(BRCreateItemEvent recvEvent);
		public BRItemBase FindBRItem(BRItemId id);
		public static BattleRoyalDungeonItem GetLotteryItem(int groupId);
	}
}
