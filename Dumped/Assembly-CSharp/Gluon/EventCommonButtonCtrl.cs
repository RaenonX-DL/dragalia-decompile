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

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

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
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<BoxSummonDataElement, bool> __9__25_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _CheckSummonButtonBadge_b__25_0(BoxSummonDataElement item);
		}
	
		// Constructors
		public EventCommonButtonCtrl();
	
		// Methods
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
		[CompilerGenerated]
		private void _OnMetalButtonTouched_b__30_0();
		[CompilerGenerated]
		private void _OnBuildMetalButtonTouched_b__31_0();
		[CompilerGenerated]
		private void _OnBuildMetalButtonTouched_b__31_1();
		[CompilerGenerated]
		private void _OnMissionButtonTouched_b__34_0(MissionSelectPopup popup);
		[CompilerGenerated]
		private void _OnMissionButtonTouched_b__34_1();
	}
}
