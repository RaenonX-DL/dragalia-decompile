/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using Gluon.Mission;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EventCommonButtonCtrl : MonoBehaviour, ICustomMessage
	{
		// Fields
		public const string buildRewardImageNormalName = "Btn_Build_01_Normal";
		public const string buildRewardImagePressedName = "Btn_Build_01_Pressed";
		[SerializeField]
		private EventQuestPageBase currentPage;
		[SerializeField]
		private LayoutType layoutType;
		[SerializeField]
		private Button missionButton;
		[SerializeField]
		private Badge missionButtonBadge;
		[SerializeField]
		private Image pickupMissionBadge;
		[SerializeField]
		private Button rewardButton;
		[SerializeField]
		private Badge rewardButtonBadge;
		[SerializeField]
		public Button summonButton;
		[SerializeField]
		private Badge summonButtonBadge;
		[SerializeField]
		private Button metalButton;
		[SerializeField]
		private Badge metalButtonBadge;
		[SerializeField]
		private Button buildMetalButton;
		[SerializeField]
		private Badge buildMetalButtonBadge;
		[SerializeField]
		private Image buildRewardImageNormal;
		[SerializeField]
		private Image buildRewardImagePressed;
		[SerializeField]
		private Button collectNormalQuestButton;
		[SerializeField]
		private Button exchangeButton;
		[SerializeField]
		private Badge exchangeButtonBadge;
		[SerializeField]
		private Button castleStoryButton;
		private bool isInited;
		[CompilerGenerated]
		private bool _ShouldEnable_k__BackingField;
	
		// Properties
		public bool ShouldEnable { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		private enum LayoutType
		{
			Button3 = 0,
			Button4 = 1
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<BoxSummonDataElement, bool> __9__32_0;
			public static Func<EventTradeGroupElement, bool> __9__44_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _CheckSummonButtonBadge_b__32_0(BoxSummonDataElement item);
			internal bool _ShouldShowRaidTradeButton_b__44_0(EventTradeGroupElement p);
		}
	
		// Constructors
		public EventCommonButtonCtrl();
	
		// Methods
		private void Awake();
		private void OnEnable();
		private void OnDisable();
		private void Start();
		private void CheckBadge();
		public void CheckSummonButtonBadge();
		private void UpdateExchangeButtonBadge();
		private void UpdateMissionBadge();
		public void OnRewardButtonTouched();
		public void OnSummonButtonTouched();
		public void OnMetalButtonTouched();
		public void OnBuildMetalButtonTouched();
		public void OnExchangeButtonTouched();
		public void OnCollectNormalButtonTouched();
		public void OnMissionButtonTouched();
		public void OnMessagReceived(CustomMessageType messageType, object data);
		public void OnCastleStoryButtonTouched();
		private bool ShouldShowRaidTradeButton();
		[CompilerGenerated]
		private void _OnMetalButtonTouched_b__37_0();
		[CompilerGenerated]
		private void _OnBuildMetalButtonTouched_b__38_0();
		[CompilerGenerated]
		private void _OnBuildMetalButtonTouched_b__38_1();
		[CompilerGenerated]
		private void _OnMissionButtonTouched_b__41_0(MissionSelectPopup popup);
		[CompilerGenerated]
		private void _OnMissionButtonTouched_b__41_1();
	}
}
