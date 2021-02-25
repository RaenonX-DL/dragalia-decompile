/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.AssetBundle;
using Cute.Cri;
using FLATOUT.Main;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SummonUpdatedScene : SceneBase
	{
		// Fields
		public Camera mainCamera;
		[SerializeField]
		private Transform overlayParent;
		private SummonUpdatedCanvas mainCanvas;
		private static string movieFileName;
		private MoviePlayerHandle movie;
		private GameObject summonUpdatedEffect;
		private bool isMovieSkip;
		private static int summonId;
		private static PlatinumLegendOpeningSetting platinumLegendOpeningSetting;
		private GameObject platinumLegendOpening;
		private FlMotion platinumLegendOpeningMotion;
		private EffectObject bgEffect;
		private string prevLabel;
		private const int bgEffectShowTrigger = 8;
		private const float bgEffectPosY = 200f;
		private const float bgEffectScale = 100f;
		private const string prefabDir = "Prefabs/OutGame/SummonUpdated/";
		private const string moviePathPrefix = "SummonUpdated/SummonUpdate_";
		private const string prefsKeyLatestSummonUpdatedDateKey = "LatestSummonUpdatedDate";
		private const string platinumLegendSettingPrefix = "PlatinumLegendOpeningSetting/PlatinumLegendOpeningSetting_";
		private const string prefsKeyLatestPlatinumLegendSummonUpdatedDateKey = "LatestPlatinumLegendSummonUpdatedDate";
		private const string bgEffectGroupId = "EFF_SMN";
		private const string bgEffectId = "EFF_SMN_029";
		private const string seGroupId = "SUMMON_PLATINUM";
		private const string oldPrefsKeyLatestSummonUpdatedKey = "LatestSummonUpdated";
		private const string oldPrefsKeyLatestPlatinumLegendSummonUpdatedKey = "LatestPlatinumLegendSummonUpdated";
		[SerializeField]
		private float delayTime;
		private bool isFinish;
		private bool isInitialized;
		private HashSet<string> downloadAssets;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__30_0;
			public static Func<bool> __9__30_1;
			public static Func<bool> __9__30_2;
			public static Func<bool> __9__30_4;
			public static Func<bool> __9__30_5;
			public static Func<bool> __9__32_2;
			public static Func<SummonDataElement, string> __9__34_0;
			public static Func<SummonDataElement, int> __9__34_1;
			public static Func<SummonGroupElement, string> __9__35_0;
			public static Func<SummonGroupElement, int> __9__35_1;
			public static UnityAction __9__43_2;
			public static Action<DownloadErrorType, string> __9__43_0;
			public static Func<bool> __9__43_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _WaitPrevSceneExit_b__30_0();
			internal bool _WaitPrevSceneExit_b__30_1();
			internal bool _WaitPrevSceneExit_b__30_2();
			internal bool _WaitPrevSceneExit_b__30_4();
			internal bool _WaitPrevSceneExit_b__30_5();
			internal bool _PlayPlatinumLegendSummonOpening_b__32_2();
			internal string _CheckSummonUpdate_b__34_0(SummonDataElement x);
			internal int _CheckSummonUpdate_b__34_1(SummonDataElement x);
			internal string _CheckPlatinumLegendSummonUpdate_b__35_0(SummonGroupElement x);
			internal int _CheckPlatinumLegendSummonUpdate_b__35_1(SummonGroupElement x);
			internal void _DownloadMovieAssets_b__43_0(DownloadErrorType type, string error);
			internal void _DownloadMovieAssets_b__43_2();
			internal bool _DownloadMovieAssets_b__43_1();
		}
	
		[CompilerGenerated]
		private sealed class _WaitPrevSceneExit_d__30 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public SummonUpdatedScene __4__this;
			private bool _isSummonUpdated_5__2;
			private bool _isPlatinumLegendSummonUpdated_5__3;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitPrevSceneExit_d__30(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass31_0
		{
			// Fields
			public bool isEnd;
			public SummonUpdatedScene __4__this;
	
			// Constructors
			public __c__DisplayClass31_0();
	
			// Methods
			internal void _PlaySummonUpdateMovie_b__0();
			internal bool _PlaySummonUpdateMovie_b__1();
			internal bool _PlaySummonUpdateMovie_b__2();
			internal bool _PlaySummonUpdateMovie_b__3();
		}
	
		[CompilerGenerated]
		private sealed class _PlaySummonUpdateMovie_d__31 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public SummonUpdatedScene __4__this;
			private __c__DisplayClass31_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlaySummonUpdateMovie_d__31(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _PlayPlatinumLegendSummonOpening_d__32 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public SummonUpdatedScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayPlatinumLegendSummonOpening_d__32(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _GotoLottery_d__41 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _GotoLottery_d__41(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _DownloadMovieAssets_d__43 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public SummonUpdatedScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _DownloadMovieAssets_d__43(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public SummonUpdatedScene();
		static SummonUpdatedScene();
	
		// Methods
		private void Start();
		[IteratorStateMachine]
		private new IEnumerator WaitPrevSceneExit();
		[IteratorStateMachine]
		private IEnumerator PlaySummonUpdateMovie();
		[IteratorStateMachine]
		private IEnumerator PlayPlatinumLegendSummonOpening();
		public static bool IsSummonUpdate(out int encounterStoryId);
		private static bool CheckSummonUpdate(string prevLatestSummonDataCommenceDate, out int encounterStoryId);
		public static bool CheckPlatinumLegendSummonUpdate(string prevLatestSummonGroupCommenceDate);
		public void OnSkip();
		private void GotoNextPage();
		private static bool IsGotoUnitStory(int encounterStoryId);
		public static void GotoUnitStory(int encounterStoryId);
		private void GotoMyPage();
		[IteratorStateMachine]
		private IEnumerator GotoLottery();
		[IteratorStateMachine]
		public IEnumerator DownloadMovieAssets();
		public static bool ExistsMovieAsset(string path);
		private void SetSummonUpdatedEffect();
		private void SetPlatinumLegendOpening();
		private void SetPlatinumLegendOpeningPickup(FlPlane flPlane, PlatinumLegendOpeningSetting.ShowPickup setting);
		private void ClearMovie();
		private void OnDestroy();
		[CompilerGenerated]
		private bool _WaitPrevSceneExit_b__30_3();
		[CompilerGenerated]
		private bool _PlayPlatinumLegendSummonOpening_b__32_0();
		[CompilerGenerated]
		private bool _PlayPlatinumLegendSummonOpening_b__32_1();
	}
}
