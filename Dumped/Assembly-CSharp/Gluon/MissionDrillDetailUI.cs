/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Gluon.Master;
using Gluon.Mission.ListView;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MissionDrillDetailUI : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text missionGroupTitleText;
		[SerializeField]
		private MissionDrillDetailUIFadeParts currentParts;
		[SerializeField]
		private MissionDrillDetailUIFadeParts nextParts;
		[SerializeField]
		private Image challengeButtonImage;
		[SerializeField]
		private float fadeDuration;
		[SerializeField]
		private FlashPlayerManager flashPlayerManager;
		[SerializeField]
		private CanvasGroup stampFlashParentCanvasGroup;
		private MissionDrillDetailUIFadeParts activeParts;
		private FlashPlayer stampFlash;
		private const string stampFlashPath = "Prefabs/OutGame/MissionDrill/pf_NhaamDrillStamp";
		private UIAnimationBase uiAnimation;
	
		// Constructors
		public MissionDrillDetailUI();
	
		// Methods
		private void Start();
		public void Setup(MissionDrillGroupElement missionDrillGroup, MissionTableViewData missionTableViewData, MissionDrillDataElement missionDrillData);
		private void Setup(MissionDrillDetailUIFadeParts parts, MissionDrillGroupElement missionDrillGroup, MissionTableViewData missionTableViewData, MissionDrillDataElement missionDrillData, float alpha);
		private void PrepareFlash();
		public void PlayMissionCompleteAnimation(Sequence sequence, MissionDrillGroupElement missionDrillGroup, MissionTableViewData missionTableViewData, MissionDrillDataElement missionDrillData);
		public void OnChallangeButtonClicked();
		public void PlayEnterAnimation();
		public void PlayExitAnimation();
		public bool IsAnimationRunning();
		[CompilerGenerated]
		private void _PlayMissionCompleteAnimation_b__15_0();
		[CompilerGenerated]
		private void _PlayMissionCompleteAnimation_b__15_1();
	}
}
