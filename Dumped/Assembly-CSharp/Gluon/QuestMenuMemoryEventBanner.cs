/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestMenuMemoryEventBanner : EventMenuCell
	{
		// Fields
		[SerializeField]
		public UnityEngine.UI.Text plantLvText;
		public UnityEngine.UI.Text maxPlantLvText;
		public UnityEngine.UI.Text[] coloredTexts;
		public UnityEngine.UI.Text englishPlantLvText;
		public UnityEngine.UI.Text[] otherLanguageTexts;
		public GameObject normalNewGO;
		public Type type;
		private int eventId;
		private long updateToMarkingDate;
		private const string newPrefTemplate = "__MemoryEventCheckDate_{0}";
	
		// Nested types
		public enum Type
		{
			Active = 0,
			NonActive = 1
		}
	
		[CompilerGenerated]
		private struct _OnCellTouched_d__13 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public QuestMenuMemoryEventBanner __4__this;
			private object __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0
		{
			// Fields
			public bool done;
			public QuestMenuMemoryEventBanner __4__this;
			public Action onDone;
	
			// Constructors
			public __c__DisplayClass14_0();
	
			// Methods
			internal void _CheckAndDownload_b__0();
			internal void _CheckAndDownload_b__1();
			internal bool _CheckAndDownload_b__2();
		}
	
		[CompilerGenerated]
		private sealed class _CheckAndDownload_d__14 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestMenuMemoryEventBanner __4__this;
			public Action onDone;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CheckAndDownload_d__14(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private struct __OnCellTouched_b__13_0_d : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public QuestMenuMemoryEventBanner __4__this;
			private TaskAwaiter<MemoryEventActivateResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Constructors
		public QuestMenuMemoryEventBanner();
	
		// Methods
		public void SetContent(int eventId);
		public static bool ShouldMemoryEventBannerMarkNew(EventDataElement eventData, ref long updateToMarkingDate);
		public override async void OnCellTouched();
		[IteratorStateMachine]
		private IEnumerator CheckAndDownload(Action onDone);
		private static void GetAssetHashSet(int eventId, out HashSet<string> hashSet, out HashSet<string> withoutVoiceHashSet);
		private static void DeleteAllOtherMemoryEventAsset(int excludeEventId);
		[CompilerGenerated]
		private void _SetContent_b__11_0(Material mat);
		[CompilerGenerated]
		private async void _OnCellTouched_b__13_0();
		[CompilerGenerated]
		private void _OnCellTouched_b__13_1();
	}
}
