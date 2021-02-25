/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestSelectEventSubPage : QuestSelectEventPageBase, ICustomMessage
	{
		// Fields
		[SerializeField]
		private FlashPlayerManager flashPlayerManager;
		[SerializeField]
		private QuestSelectEventShortCut questSelectEventShortCut;
		[SerializeField]
		private TabBase questMultiTab;
		public QuestSupportCanvas.PlayType playType;
		private int baseQuestGroupId;
		private QuestEventBannerPage bannerPage;
		private QuestSelectInstance.QuestEventData eventData;
		private Dictionary<int, float> scrollValueDic;
		private List<EventMenuCell> eventMenuCellList;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_0
		{
			// Fields
			public QuestCell cell;
	
			// Constructors
			public __c__DisplayClass17_0();
	
			// Methods
			internal void _CreateEventList_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_1
		{
			// Fields
			public QuestCell cell;
	
			// Constructors
			public __c__DisplayClass17_1();
	
			// Methods
			internal void _CreateEventList_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_2
		{
			// Fields
			public QuestCell cell;
	
			// Constructors
			public __c__DisplayClass17_2();
	
			// Methods
			internal void _CreateEventList_b__2();
		}
	
		// Constructors
		public QuestSelectEventSubPage();
	
		// Methods
		protected override void Awake();
		protected override void OnDestroy();
		private void Start();
		public override void OnPageBecomeActive(object data);
		public void OpenDefaultTab(int baseQuestGroupId);
		public void OnSelectedTab(int num);
		public override void OnPageBecomeInActive();
		public override bool IsOnAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1);
		private void CreateEventList(QuestSelectInstance.QuestEventData eventData);
		public void OnBackButtonTouched();
		public void OnMainQuestButtonTouched();
		public void OnMessagReceived(CustomMessageType messageType, object data);
		public override void OnPageEnterAnimationEnded();
	}
}
