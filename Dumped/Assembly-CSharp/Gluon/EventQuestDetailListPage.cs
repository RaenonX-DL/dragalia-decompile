/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EventQuestDetailListPage : PageBase, ICustomMessage
	{
		// Fields
		[SerializeField]
		private Transform contentTransfrom;
		[SerializeField]
		private float enterAnimationDuration;
		public AnimationListOneCol listAnimation;
		private int eventId;
		private Clb01EventLocationElement eventLocation;
		private List<QuestEventMenuElement> eventData;
		private Dictionary<int, float> scrollValueDic;
		private Action<EventQuestDetailListPage, Clb01EventLocationElement> onPageBecomeActive;
		private Action<EventQuestDetailListPage, CombatEventLocationElement> onPageBecomeActiveCombat;
		private bool isArena;
		public const int arenaEventId = 21403;
		public const int arenaLocationId = 6;
	
		// Properties
		public EventQuestScene eventQuestScene { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass20_0
		{
			// Fields
			public int eventId;
			public EventQuestDetailListPage __4__this;
	
			// Constructors
			public __c__DisplayClass20_0();
	
			// Methods
			internal bool _LoadData_b__2(QuestEventMenuElement x);
			internal bool _LoadData_b__0(QuestEventMenuElement x);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<QuestEventMenuElement, int> __9__20_3;
			public static Func<QuestEventMenuElement, int> __9__20_1;
			public static Func<QuestEventMenuElement, int> __9__21_1;
			public static Comparison<List<QuestEventMenuElement>> __9__22_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _LoadData_b__20_3(QuestEventMenuElement x);
			internal int _LoadData_b__20_1(QuestEventMenuElement x);
			internal int _LoadData_b__21_1(QuestEventMenuElement x);
			internal int _CreateList_b__22_0(List<QuestEventMenuElement> a, List<QuestEventMenuElement> b);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0
		{
			// Fields
			public int eventId;
			public CombatEventLocationElement location;
	
			// Constructors
			public __c__DisplayClass21_0();
	
			// Methods
			internal bool _LoadData_b__0(QuestEventMenuElement x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass28_0();
	
			// Methods
			internal void _CreateQuestOpenPopup_b__0();
		}
	
		// Constructors
		public EventQuestDetailListPage();
	
		// Methods
		protected override void Awake();
		protected override void OnDestroy();
		public void Initialize(Action<EventQuestDetailListPage, Clb01EventLocationElement> onPageBecomeActive);
		public void InitializeCombat(Action<EventQuestDetailListPage, CombatEventLocationElement> onPageBecomeActive);
		public override void OnPageBecomeActive(object data);
		public override void OnPageBecomeInActive();
		public void LoadData(int eventId, Clb01EventLocationElement location);
		public void LoadData(int eventId, CombatEventLocationElement location);
		private void CreateList();
		public override void StartEnterAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		public override void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		public override bool IsOnAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1);
		public bool ClickTargetQuestCell(int eventQuestId);
		public void OnMessagReceived(CustomMessageType messageType, object data);
		private void CreateQuestOpenPopup(List<QuestEventMenuElement> givenCellDataList);
	}
}
