/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FLATOUT.Main;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class RaidEventCell : QuestCellBase
	{
		// Fields
		[SerializeField]
		private Image banner;
		[Header]
		[SerializeField]
		private GameObject entryConditionNode;
		[SerializeField]
		private UnityEngine.UI.Text entryConditionText;
		[Header]
		[SerializeField]
		private GameObject timeLockNode;
		[SerializeField]
		private UnityEngine.UI.Text releaseTimeText;
		[Header]
		[SerializeField]
		private GameObject questNameNode;
		[SerializeField]
		private UnityEngine.UI.Text questNameText;
		[SerializeField]
		private Button baseButton;
		[SerializeField]
		protected GameObject newIconRoot;
		[SerializeField]
		protected GameObject newGlowRoot;
		[SerializeField]
		protected RectTransform animationCellTrans;
		[Header]
		[SerializeField]
		public GameObject ultimateLockGO;
		public Transform ultimateFlashNode;
		public GameObject ultimateUnlockTextNode;
		[Header]
		[SerializeField]
		public float readyStateWait;
		public float fullUnlockWait;
		public float ultimateUnlockInterval;
		public float ultimateSyncLoopWait;
		[CompilerGenerated]
		private EventListCtrl _eventListCtrl_k__BackingField;
		protected int questSubType;
		protected List<QuestEventMenuElement> cellData;
		private QuestUtil.QuestState state;
		private Coroutine flashCoroutine;
		private TouchGuardObject touchGuardObj;
		private FlRoot root;
		private const string ultimateUnlockFlashPath = "Prefabs/OutGame/EventQuest/Flash/RaidUltimate/pf_RaidUltimateBannerLock";
		private const string prefsUltimateStatusTemplate = "RaidUltimateStatus_{0}";
	
		// Properties
		public EventListCtrl eventListCtrl { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		public enum RaidUltimateStatus
		{
			Locked = 0,
			OneKeyObtained = 1,
			TwoKeyObtained = 2,
			Unlocked = 3
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass37_0
		{
			// Fields
			public bool isEnded;
	
			// Constructors
			public __c__DisplayClass37_0();
	
			// Methods
			internal void _ExecuteUltimateUnlockFlash_b__1();
			internal bool _ExecuteUltimateUnlockFlash_b__2();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__37_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _ExecuteUltimateUnlockFlash_b__37_0();
		}
	
		[CompilerGenerated]
		private sealed class _ExecuteUltimateUnlockFlash_d__37 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public RaidEventCell __4__this;
			public FlRoot root;
			public RaidUltimateStatus recordedStatus;
			public RaidUltimateStatus currentStatus;
			private __c__DisplayClass37_0 __8__1;
			private FlMotion _rootMotion_5__2;
			private List<FlMotion> _preStableList_5__3;
			private List<FlMotion> _unlockList_5__4;
			private List<string> _unlockRootMotionNameList_5__5;
			private int _i_5__6;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ExecuteUltimateUnlockFlash_d__37(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public RaidEventCell();
	
		// Methods
		private void OnEnable();
		private void UpdateContent();
		public void SetContent(int questSubType, List<QuestEventMenuElement> cellData, QuestUtil.QuestState questState, bool showStateIcon = true);
		public static void GetUltimateUnlockStatus(int eventId, out RaidUltimateStatus recordedStatus, out RaidUltimateStatus currentStatus);
		private void RecordUltimateUnlockStatus(int eventId, RaidUltimateStatus currentStatus);
		private void OnDestroy();
		[IteratorStateMachine]
		private IEnumerator ExecuteUltimateUnlockFlash(FlRoot root, RaidUltimateStatus recordedStatus, RaidUltimateStatus currentStatus);
		public void OnClick();
		public override bool SetGradientShader();
		public override void SetStateIcons();
		[CompilerGenerated]
		private void _SetContent_b__33_0(Material mat);
	}
}
