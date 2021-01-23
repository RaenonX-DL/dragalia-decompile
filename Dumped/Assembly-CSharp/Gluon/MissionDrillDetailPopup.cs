/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using Gluon.Mission;
using Gluon.Mission.ListView;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MissionDrillDetailPopup : CommonPopup
	{
		// Fields
		private const string prefabPath = "Prefabs/OutGame/MissionDrill/MissionDrillDetailPopup";
		[SerializeField]
		private UnityEngine.UI.Text nameText;
		[SerializeField]
		private Image missionIcon;
		[SerializeField]
		private UnityEngine.UI.Text descriptionText;
		[SerializeField]
		private MissionWidgetAchievement achievementWidget;
		[SerializeField]
		private CommonIcon rewardIcon;
		[SerializeField]
		private UnityEngine.UI.Text rewardNameText;
		[SerializeField]
		private UnityEngine.UI.Text rubyText;
		private MissionTableViewData missionTableViewData;
		private Action onRewardReceivedCallback;
		private Action onChallengeButtonPressed;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0
		{
			// Fields
			public UnityAction onClose;
	
			// Constructors
			public __c__DisplayClass11_0();
	
			// Methods
			internal void _Create_b__0();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__15_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _CreateConfirmPopup_b__15_1();
		}
	
		// Constructors
		public MissionDrillDetailPopup();
	
		// Methods
		public static MissionDrillDetailPopup Create(MissionTableViewData missionTableViewData, MissionDrillGroupElement missionDrillGroup, MissionDrillDataElement missionDrillData, UnityAction onClose, Action onChallengeButtonPressed, Action onRewardReceivedCallback);
		public void Setup(MissionTableViewData missionTableViewData, MissionDrillGroupElement missionDrillGroup, MissionDrillDataElement missionDrillData, Action onChallengeButtonPressed, Action onRewardReceivedCallback);
		public void OnCloseButtonClicked();
		public void OnOkButtonClicked();
		private void CreateConfirmPopup();
		[CompilerGenerated]
		private void _CreateConfirmPopup_b__15_0();
	}
}
