/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.AssetBundle;
using UnityEngine.Events;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class TitleDownloadHelper : SingletonMonoBehaviour<Gluon.TitleDownloadHelper>
	{
		// Fields
		public string manifestPath;
		public string manifestVersion;
		public bool exceptVoiceOnFullDownload;
		public const string UseAssetBundlePrefs = "UseAssetBundle";
		public const string UseLocalAssetBundlePrefs = "UseLocalAssetBundle";
		private DownloadOperation manifestDownloadOperation;
		private Action<DownloadOperation, DownloadOperation, DownloadOperation, bool> onCheckCompleted;
		private Action onManifestDownloadedCallback;
		private const string developBranch = "develop";
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0
		{
			// Fields
			public TitleDownloadHelper __4__this;
			public Action onManifestDownloaded;
			public Action<long> deletedSizeCallback;
			public UnityAction __9__1;
	
			// Constructors
			public __c__DisplayClass14_0();
	
			// Methods
			internal void _DownloadManifest_b__0(DownloadErrorType type, string error);
			internal void _DownloadManifest_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _OnManifestDownloadedCoroutine_d__16 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public TitleDownloadHelper __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _OnManifestDownloadedCoroutine_d__16(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass20_0
		{
			// Fields
			public CommonPopup popup;
			public UnityAction onDownloadFailed;
	
			// Constructors
			public __c__DisplayClass20_0();
	
			// Methods
			internal void _CreateDownloadErrorPopup_b__0();
			internal void _CreateDownloadErrorPopup_b__1();
		}
	
		// Constructors
		public TitleDownloadHelper();
	
		// Methods
		protected override void Awake();
		public void ReadyDownload(Action<DownloadOperation, DownloadOperation, DownloadOperation, bool> onCompleted, Action<long> deletedSizeCallback = null);
		public void InitAssetBundleConfig();
		private void SetProductSettings(out string assetbundlePath);
		public void CheckDownload(Action onManifestDownloadedCallback = null, bool fullDownload = false, Action<long> deletedSizeCallback = null);
		public void DownloadManifest(Action onManifestDownloaded, Action<long> deletedSizeCallback = null);
		private void OnManifestDownloaded();
		[IteratorStateMachine]
		private IEnumerator OnManifestDownloadedCoroutine();
		private void CheckUnlockedFortAssets();
		private void CheckAfterPrologueAssets();
		private void CheckBeforeProloguelAssets();
		private void CreateDownloadErrorPopup(DownloadErrorType type, UnityAction onDownloadFailed);
		private void InvokeOnCheckCompleted(DownloadOperation downloadOperation, DownloadOperation downloadOperationWithoutVoice, DownloadOperation downloadOperationMinimum, bool isBeforePrologure);
		[CompilerGenerated]
		private void _CheckDownload_b__13_0();
	}
}
