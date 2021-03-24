/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using Gluon.Mission.ListView;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MissionDrillTreasure : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private Image openedImage;
		[SerializeField]
		private Image closedImage;
		[SerializeField]
		private Image receivableImage;
		[SerializeField]
		private Button button;
		[SerializeField]
		private FlashPlayerManager flashPlayerManager;
		private string popupTitle;
		private MissionTableViewData missionTableViewData;
		private MissionDrillGroupElement missionDrillGroup;
		private Action onRewardReceived;
		private FlashPlayer flashPlayer;
		private const string pickupTreasureFlashPath = "Prefabs/OutGame/MissionDrill/pf_NhaamDrillTreasureBox";
		private const string completeTreasureFlashPath = "Prefabs/OutGame/MissionDrill/pf_NhaamDrillTreasureBoxComplete";
	
		// Constructors
		public MissionDrillTreasure();
	
		// Methods
		private void PrepareFlash(bool isCompleteReward);
		private void ResetFlash();
		public void Setup(MissionTableViewData missionTableViewData, MissionDrillGroupElement missionDrillGroup, string popupTitle, MissionTableViewData.State state, bool isCompleteReward, Action onRewardReceived);
		public void SetState(MissionTableViewData.State state);
		public void PlayEffect(MissionTableViewData.State state);
		public void SetMissionTableViewData(MissionTableViewData missionTableViewData);
		public MissionTableViewData GetMissionTableViewData();
		public void OnClicked();
		[CompilerGenerated]
		private void _OnClicked_b__19_0();
	}
}
