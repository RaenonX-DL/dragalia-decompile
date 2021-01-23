/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.Mission;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Mission.ListView
{
	public class MissionTableViewCell : TableViewCell<MissionTableViewData>
	{
		// Fields
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text missionNameText;
		[Header]
		[SerializeField]
		public MissionWidgetRewardIcon rewardIcon;
		[Header]
		[SerializeField]
		public MissionWidgetAchievement achievement;
		[Header]
		[SerializeField]
		public MissionWidgetRemainingTime remainingTime;
		[SerializeField]
		private GameObject ClearedObj;
		[SerializeField]
		private GameObject ReceivedObj;
		[SerializeField]
		private GameObject widgetRoot;
		[Header]
		[SerializeField]
		private GameObject captionRoot;
		[SerializeField]
		private UnityEngine.UI.Text captionText;
		[Header]
		[SerializeField]
		private UnityEngine.UI.Text noMissionText;
		[SerializeField]
		private GameObject lockBaseObj;
		[SerializeField]
		private UnityEngine.UI.Text lockTitleText;
		[SerializeField]
		private UnityEngine.UI.Text lockInfoText;
		[SerializeField]
		private Image badgeIcon;
		[SerializeField]
		private GameObject challengeButtonObj;
		[SerializeField]
		private ButtonEvent onCellPressed;
		[SerializeField]
		private ButtonEvent onChallengeButtonPressed;
	
		// Nested types
		[Serializable]
		public class ButtonEvent : UnityEvent<int>
		{
			// Constructors
			public ButtonEvent();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_0
		{
			// Fields
			public MissionTableViewData data;
	
			// Constructors
			public __c__DisplayClass18_0();
	
			// Methods
			internal void _UpdateContent_b__0();
		}
	
		// Constructors
		public MissionTableViewCell();
	
		// Methods
		public override void UpdateContent(MissionTableViewData data);
		public void SetMissionName(string name);
		public void OnCellPressed();
		public void OnChallengeButtonPressed();
	}
}
