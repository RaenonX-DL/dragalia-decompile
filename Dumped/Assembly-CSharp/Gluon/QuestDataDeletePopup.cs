/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UniRx.Async;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestDataDeletePopup : CommonPopup
	{
		// Fields
		public UnityEngine.UI.Text allQuestSizeNum;
		public UnityEngine.UI.Text clearedQuestSizeNum;
		public UnityEngine.UI.Text descText;
		private HashSet<string> clearedQuestAssets;
		private HashSet<string> allQuestAssets;
		private const int yieldStep = 3;
		private DeleteType deleteType;
	
		// Nested types
		private enum DeleteType
		{
			ClearedQuest = 0,
			AllQuest = 1
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0
		{
			// Fields
			public QuestDataDeletePopup popup;
	
			// Constructors
			public __c__DisplayClass8_0();
	
			// Methods
			internal void _CreateQuestDataDeletePopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _CollectDeleteAssets_d__9 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestDataDeletePopup __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CollectDeleteAssets_d__9(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0
		{
			// Fields
			public HashSet<string> targetQuestAssets;
	
			// Constructors
			public __c__DisplayClass15_0();
	
			// Methods
			internal void _CollectDeleteAsset_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _CollectDeleteAsset_d__15 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public HashSet<string> targetQuestAssets;
			public HashSet<string> reservedQuestAssets;
			private ParallelJob _job_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CollectDeleteAsset_d__15(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_0
		{
			// Fields
			public HashSet<string> targetQuestAssets;
			public CommonPopup popup;
			public QuestDataDeletePopup __4__this;
	
			// Nested types
			private struct __DeleteQuestData_b__1_d : IAsyncStateMachine
			{
				// Fields
				public int __1__state;
				public AsyncVoidMethodBuilder __t__builder;
				public __c__DisplayClass16_0 __4__this;
				private UniTask.Awaiter __u__1;
	
				// Methods
				private void MoveNext();
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine);
			}
	
			// Constructors
			public __c__DisplayClass16_0();
	
			// Methods
			internal void _DeleteQuestData_b__0();
			internal async void _DeleteQuestData_b__1();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__16_2;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _DeleteQuestData_b__16_2();
		}
	
		[CompilerGenerated]
		private sealed class _DeleteQuestData_d__16 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestDataDeletePopup __4__this;
			public DeleteType type;
			private __c__DisplayClass16_0 __8__1;
			private ParallelJob _job_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _DeleteQuestData_d__16(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public QuestDataDeletePopup();
	
		// Methods
		public static QuestDataDeletePopup CreateQuestDataDeletePopup();
		[IteratorStateMachine]
		public IEnumerator CollectDeleteAssets();
		private void SetDeleteSize(long allQuestSize, long clearedQuestSize);
		private void SetDeleteType(DeleteType type);
		public void OnAllQuestToggled(bool arg);
		public void OnClearedQuestToggled(bool arg);
		public void OnDeleteButtonPressed();
		[IteratorStateMachine]
		private static IEnumerator CollectDeleteAsset(HashSet<string> targetQuestAssets, HashSet<string> reservedQuestAssets);
		[IteratorStateMachine]
		private IEnumerator DeleteQuestData(DeleteType type);
	}
}
