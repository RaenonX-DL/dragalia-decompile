/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestEventTimeAttackBanner : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text myBestTimeMultiText;
		[SerializeField]
		private UnityEngine.UI.Text myBestTimeSoloText;
		[SerializeField]
		private UIAnimationPublisher uiAnimation;
		[SerializeField]
		private ButtonWithSelectedImage howtoButtonReset;
		[SerializeField]
		private ButtonWithSelectedImage rankingRewardButtonReset;
		[SerializeField]
		private ButtonWithSelectedImage rankingButtonReset;
		[SerializeField]
		private ButtonWithSelectedImage tierRewardButtonReset;
		[SerializeField]
		private Image timeAttackLogo;
		[SerializeField]
		private Image rankingDifficultyTypeImage;
		private QuestEventElement questEventData;
		private QuestEventGroupElement questEventGroupData;
		private List<QuestEventMenuElement> questEventMenuDataList;
		private RankingGroupDataElement rankingGroupData;
		private RankingTierRewardElement rankingTierRewardElement;
		private int soloClearTime;
		private int multiClearTime;
		private int webViewQuestId;
		private string logoPath;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass27_0
		{
			// Fields
			public QREventRewardPopup popup;
			public QuestEventTimeAttackBanner __4__this;
	
			// Constructors
			public __c__DisplayClass27_0();
	
			// Methods
			internal void _TimeAttackNetwork_b__0();
		}
	
		[CompilerGenerated]
		private struct _TimeAttackNetwork_d__27 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public QuestEventTimeAttackBanner __4__this;
			private TaskAwaiter<TimeAttackRankingGetDataResponse> __u__1;
			private TaskAwaiter<TimeAttackRankingReceiveTierRewardResponse> __u__2;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _TimeAttackRankingGetData_d__28 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncTaskMethodBuilder<TimeAttackRankingGetDataResponse> __t__builder;
			private TaskAwaiter<TimeAttackRankingGetDataResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _TimeAttackRankingReceiveTierRewardRequest_d__29 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncTaskMethodBuilder<TimeAttackRankingReceiveTierRewardResponse> __t__builder;
			public int questId;
			private TaskAwaiter<TimeAttackRankingReceiveTierRewardResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Constructors
		public QuestEventTimeAttackBanner();
	
		// Methods
		public void SetContent(QuestEventElement qee);
		private void SetContentView();
		public static bool SetEventImageMaterial(Image image, string materialName, bool shouldSetAutoImage = false);
		public void PlayEnterAnimation(Action onFinished, Action onHalfFinished = null);
		public void StartExitAnimation(Action onFinished, Action onHalfFinished = null);
		public void OnTierRewardButton();
		public void OnRankingButton();
		public void OnRankingRewardButton();
		public void OnHowToButton();
		public async void TimeAttackNetwork();
		public async Task<TimeAttackRankingGetDataResponse> TimeAttackRankingGetData();
		public async Task<TimeAttackRankingReceiveTierRewardResponse> TimeAttackRankingReceiveTierRewardRequest(int questId);
		public void QuestEventRewardPopupCreate();
		[CompilerGenerated]
		private void _OnRankingButton_b__24_0();
		[CompilerGenerated]
		private void _OnRankingRewardButton_b__25_0();
		[CompilerGenerated]
		private void _OnHowToButton_b__26_0();
		[CompilerGenerated]
		private void _TimeAttackNetwork_b__27_1();
		[CompilerGenerated]
		private void _QuestEventRewardPopupCreate_b__30_0();
	}
}
