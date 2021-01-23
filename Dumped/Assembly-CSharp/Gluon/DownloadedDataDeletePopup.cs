/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.AssetBundle;
using Cute.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DownloadedDataDeletePopup : CommonPopup
	{
		// Fields
		public UnityEngine.UI.Text allQuestSizeNum;
		public UnityEngine.UI.Text voiceSizeNum;
		public UnityEngine.UI.Text myPage3dSizeNum;
		public UnityEngine.UI.Text totalSizeNum;
		public UnityEngine.UI.Text overlappingSizeNum;
		public GameObject overlappingTextRoot;
		private HashSet<string> allQuestDeleteAssets;
		private HashSet<string> voiceDeleteAssets;
		private HashSet<string> myPage3dDeleteAssets;
		private HashSet<string> myPage3dVoiceDeleteAssets;
		private HashSet<string> totalDeleteAssets;
		public Toggle[] toggleList;
		private long allQuestDeleteSize;
		private long voiceDeleteSize;
		private long myPage3dDeleteSize;
		private long myPage3dVoiceDeleteSize;
		private long totalDeleteSize;
		private long overlappingDeleteSize;
	
		// Nested types
		private enum DeleteType
		{
			AllQuest = 0,
			Voice = 1,
			MyPage3d = 2
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0
		{
			// Fields
			public DownloadedDataDeletePopup popup;
	
			// Constructors
			public __c__DisplayClass19_0();
	
			// Methods
			internal void _CreateDownloadedDataDeletePopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass20_0
		{
			// Fields
			public bool isDone;
	
			// Constructors
			public __c__DisplayClass20_0();
	
			// Methods
			internal void _CheckManifestAndCollectDeleteAssets_b__0(DownloadOperation downloadOperation, DownloadOperation downloadOperationWithoutVoice, DownloadOperation downloadOperationMinimum, bool isBeforePrologue);
			internal bool _CheckManifestAndCollectDeleteAssets_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _CheckManifestAndCollectDeleteAssets_d__20 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public DownloadedDataDeletePopup __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CheckManifestAndCollectDeleteAssets_d__20(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_0
		{
			// Fields
			public HashSet<string> targetQuestAssets;
	
			// Constructors
			public __c__DisplayClass28_0();
	
			// Methods
			internal void _CollectDeleteAsset_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _CollectDeleteAsset_d__28 : IEnumerator<object>
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
			public _CollectDeleteAsset_d__28(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _DeleteDownloadedData_d__29 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public DownloadedDataDeletePopup __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _DeleteDownloadedData_d__29(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public DownloadedDataDeletePopup();
	
		// Methods
		public static DownloadedDataDeletePopup CreateDownloadedDataDeletePopup();
		[IteratorStateMachine]
		public IEnumerator CheckManifestAndCollectDeleteAssets(PopupBase activePopup);
		private void UpdateDeleteSize();
		private void ToggleCheckBox(DeleteType type, bool value);
		private bool IsCheckBoxToggled(DeleteType type);
		public void OnAllQuestToggled(bool arg);
		public void OnVoiceToggled(bool arg);
		public void OnMyPage3dToggled(bool arg);
		public void OnDeleteButtonPressed();
		[IteratorStateMachine]
		private static IEnumerator CollectDeleteAsset(HashSet<string> targetQuestAssets, HashSet<string> reservedQuestAssets);
		[IteratorStateMachine]
		private IEnumerator DeleteDownloadedData();
	}
}
