/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using FLATOUT.Main;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestWallBanner : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private CommonIcon rewardIcon;
		[SerializeField]
		private UnityEngine.UI.Text totalLevel;
		[SerializeField]
		private Image logo;
		[SerializeField]
		private ButtonWithSelectedImage rewardButtonWithSelectedImage;
		[SerializeField]
		private ButtonWithSelectedImage detailButtonWithSelectedImage;
		[SerializeField]
		private ButtonWithSelectedImage questWallHowToReset;
		[SerializeField]
		private UnityEngine.UI.Text rewardDestriptionText;
		[SerializeField]
		private GameObject pickupImage;
		[SerializeField]
		private GameObject nextPickupParent;
		[SerializeField]
		private AnimationUIAutoPublisher animationPublisher;
		private int groupId;
		private FlRoot effectFlash;
		private GameObject flashEffect;
		private const int detailId = 20000;
	
		// Nested types
		[CompilerGenerated]
		private struct _WallGetMonthlyRewardRequest_d__20 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public QuestWallBanner __4__this;
			private TaskAwaiter<WallGetMonthlyRewardResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Constructors
		public QuestWallBanner();
	
		// Methods
		public void SetContents(int groupId);
		public void SetMotionPause();
		public void SetMotionPlay();
		public void OnRewardButtonClick();
		public void OnQuestDetail();
		public void OnHowToButtonTouched();
		private async void WallGetMonthlyRewardRequest();
		private void RewardButtonResetPressedState();
		private void OnError(ErrorType errorType, int resultCode);
		public void PlayEnterAnimation(Action onFinished);
		public void PlayExitAnimation(Action onFinished);
		[CompilerGenerated]
		private void _SetMotionPause_b__15_0();
		[CompilerGenerated]
		private void _SetMotionPause_b__15_1();
		[CompilerGenerated]
		private void _SetMotionPause_b__15_2();
		[CompilerGenerated]
		private void _OnQuestDetail_b__18_0();
		[CompilerGenerated]
		private void _OnHowToButtonTouched_b__19_0();
		[CompilerGenerated]
		private void _WallGetMonthlyRewardRequest_b__20_0(ErrorType errorType, int resultCode);
	}
}
