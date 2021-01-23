/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GuildChatTableViewController : TableViewController<Gluon.GuildChatModel.ChatTableViewData>
	{
		// Fields
		public Transform invisibleNode;
		private GuildChatTableViewCell sizingCell;
		private Dictionary<Guid, Vector2> cellHeightTable;
		private Coroutine updateSizeCoroutine;
		private Coroutine updateWaitAnimationCoroutine;
		private int defaultCreateCellCount;
		private readonly Vector2 scrollToBottomOffset;
		private const float cellApperSpace = 10f;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _UpdateByDataCoroutine_d__12 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GuildChatTableViewController __4__this;
			public List<GuildChatModel.ChatTableViewData> dataList;
			public bool isNew;
			public bool isChatoBottom;
			public bool isFirst;
			public Action onFinshed;
			private int _i_5__2;
			private GuildChatModel.ChatTableViewData _data_5__3;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _UpdateByDataCoroutine_d__12(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _UpdateBottomChatCell_d__17 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GuildChatTableViewController __4__this;
			private int _cnt_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _UpdateBottomChatCell_d__17(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Predicate<GuildChatModel.ChatTableViewData> __9__18_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _IsExistHideData_b__18_0(GuildChatModel.ChatTableViewData data);
		}
	
		// Constructors
		public GuildChatTableViewController();
	
		// Methods
		protected override void Awake();
		private void CreateDummyCells(int createCount);
		protected override float GetCellHeightAtIndex(int index);
		public void UpdateByData(List<GuildChatModel.ChatTableViewData> data, bool isNew, bool isChatoBottom, bool isFirst, Action onFinshed);
		[IteratorStateMachine]
		private IEnumerator UpdateByDataCoroutine(List<GuildChatModel.ChatTableViewData> dataList, bool isNew, bool isChatoBottom, bool isFirst, Action onFinshed);
		private void UpdateScroll(bool isNew, bool isChatoBottom, bool isFirst);
		public float GetHeightFromBottomToHere();
		public bool IsViewingLatestChat(float space);
		public void HideAnimationWaitCell();
		[IteratorStateMachine]
		private IEnumerator UpdateBottomChatCell();
		private bool IsExistHideData();
		private void CheckAllCellHideState();
		private void CheckCellHideState(GuildChatTableViewCell cell, float limit);
		private void ResetHideCell();
	}
}
