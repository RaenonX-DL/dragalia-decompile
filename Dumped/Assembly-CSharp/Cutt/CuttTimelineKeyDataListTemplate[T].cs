/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cutt
{
	[Serializable]
	public class CuttTimelineKeyDataListTemplate<T> : ICuttTimelineKeyDataList
		where T : CuttTimelineKey
	{
		// Fields
		[SerializeField]
		private CuttTimelineKeyDataListAttr _attribute;
		public List<T> thisList;
		private int _lastFindIndex;
	
		// Properties
		public CuttTimelineKeyDataListAttr attribute { get; set; }
		public CuttTimelineKey this[int index] { get => default; set {} }
		public int Count { get; }
		public int depthCounter { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _ToEnumerable_d__17 : IEnumerable<CuttTimelineKey>, IEnumerator<CuttTimelineKey>
		{
			// Fields
			private int __1__state;
			private CuttTimelineKey __2__current;
			private int __l__initialThreadId;
			public CuttTimelineKeyDataListTemplate<T> __4__this;
			private int _i_5__2;
	
			// Properties
			CuttTimelineKey IEnumerator<Cutt.CuttTimelineKey>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ToEnumerable_d__17(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
			[DebuggerHidden]
			IEnumerator<CuttTimelineKey> IEnumerable<CuttTimelineKey>.GetEnumerator();
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c<T> __9;
			public static Converter<T, CuttTimelineKey> __9__20_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal CuttTimelineKey _ToList_b__20_0(T x);
		}
	
		// Constructors
		public CuttTimelineKeyDataListTemplate();
	
		// Methods
		public bool HasAttribute(CuttTimelineKeyDataListAttr attr);
		public void Insert(int index, CuttTimelineKey item);
		public void Add(CuttTimelineKey item);
		public void Clear();
		public bool Remove(CuttTimelineKey item);
		public void RemoveAt(int index);
		public IEnumerator<CuttTimelineKey> GetEnumerator();
		[IteratorStateMachine]
		public IEnumerable<CuttTimelineKey> ToEnumerable();
		public CuttTimelineKey At(int index);
		public CuttTimelineKey[] ToArray();
		public List<CuttTimelineKey> ToList();
		public FindKeyResult FindKeyCached(int frame, bool forceRefind);
		public FindKeyResult FindCurrentKey(int frame);
		private void BinSearch(out FindKeyResult ret, int frame, int indexS, int indexE, int listSize);
		public void FindKeyLinear(out CuttTimelineKey curKey, out CuttTimelineKey nextKey, int curFrame);
		public FindKeyResult FindCurrentKeyNeighbor(int frame, int baseIndex);
	}
}
