/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
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
	public class MissionDrillStepProgressUI : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private MissionDrillTreasure originalTreasure;
		[SerializeField]
		private RectTransform treasureParent;
		[SerializeField]
		private MissionDrillTreasure completeTreasure;
		[SerializeField]
		private Image progressBarIcon;
		[SerializeField]
		private Image progressBarImage;
		[SerializeField]
		private UnityEngine.UI.Text progressText;
		[SerializeField]
		private bool isShowCompleteRewardOnly;
		[SerializeField]
		private MissionDrillStepProgressUIRewardParts rewardParts;
		[SerializeField]
		private float progressAnimationDuration;
		[SerializeField]
		private FlashPlayerManager flashPlayerManager;
		[SerializeField]
		private int lastMissionPositionOffset;
		private FlashPlayer fadeFlashPlayer;
		[SerializeField]
		private Transform fadeFlashParent;
		private const string fadeFlashPath = "Prefabs/OutGame/MissionDrill/pf_NhaamDrillRewardChange";
		private Stack<MissionDrillTreasure> treasurePool;
		private List<MissionDrillTreasure> treasures;
		private bool isCompleteReward;
		private List<MissionTableViewData> missionTableViewDataList;
		private MissionDrillDataElement missionDrillData;
		private MissionDrillGroupElement missionDrillGroup;
		private string nextPickupRewardTextFormat;
		private UIAnimationBase uiAnimation;
		private string progressTextFormat;
		private Action onRewardReceived;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<MissionTableViewData, bool> __9__25_0;
			public static Func<MissionTableViewData, bool> __9__26_0;
			public static Func<MissionTableViewData, bool> __9__34_0;
			public static Func<MissionTableViewData, bool> __9__34_1;
			public static Func<MissionTableViewData, bool> __9__34_2;
			public static Func<MissionTableViewData, bool> __9__34_3;
			public static Func<MissionTableViewData, bool> __9__34_11;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _Setup_b__25_0(MissionTableViewData e);
			internal bool _SetupTreasure_b__26_0(MissionTableViewData e);
			internal bool _PlayMissionCompleteAnimation_b__34_0(MissionTableViewData e);
			internal bool _PlayMissionCompleteAnimation_b__34_1(MissionTableViewData e);
			internal bool _PlayMissionCompleteAnimation_b__34_2(MissionTableViewData e);
			internal bool _PlayMissionCompleteAnimation_b__34_3(MissionTableViewData e);
			internal bool _PlayMissionCompleteAnimation_b__34_11(MissionTableViewData e);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass27_0
		{
			// Fields
			public int currentMissionStep;
	
			// Constructors
			public __c__DisplayClass27_0();
	
			// Methods
			internal bool _GetProgressRatio_b__0(MissionTableViewData e);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass30_0
		{
			// Fields
			public int currentMissionStep;
			public MissionTableViewData nextPickupRewardMission;
	
			// Constructors
			public __c__DisplayClass30_0();
	
			// Methods
			internal bool _SetupReward_b__0(MissionTableViewData e);
			internal bool _SetupReward_b__1(MissionTableViewData e);
			internal bool _SetupReward_b__2(MissionTableViewData e);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass34_0
		{
			// Fields
			public MissionDrillStepProgressUI __4__this;
			public int treasureIndex;
			public List<MissionTableViewData> nextMissionTableViewDataList;
			public MissionDrillDataElement nextMissionDrillData;
			public MissionTableViewData currentMissionData;
			public MissionTableViewData completeMissionData;
	
			// Constructors
			public __c__DisplayClass34_0();
	
			// Methods
			internal void _PlayMissionCompleteAnimation_b__4(float ratio);
			internal void _PlayMissionCompleteAnimation_b__5();
			internal bool _PlayMissionCompleteAnimation_b__6(MissionDrillDataElement e);
			internal bool _PlayMissionCompleteAnimation_b__7(MissionDrillDataElement e);
			internal void _PlayMissionCompleteAnimation_b__8();
			internal void _PlayMissionCompleteAnimation_b__9();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass34_1
		{
			// Fields
			public int missionId;
	
			// Constructors
			public __c__DisplayClass34_1();
	
			// Methods
			internal bool _PlayMissionCompleteAnimation_b__10(MissionTableViewData e);
		}
	
		// Constructors
		public MissionDrillStepProgressUI();
	
		// Methods
		private void Start();
		public void Setup(List<MissionTableViewData> missionTableViewDataList, MissionDrillGroupElement missionDrillGroup, MissionDrillDataElement currentMissionDrillData, string progressTextFormat, string nextPickupRewardTextFormat, bool isUnlockedGroup, Action onRewardReceived);
		private void SetupTreasure(List<MissionTableViewData> missionTableViewDataList, int totalMissionNum);
		private float GetProgressRatio(List<MissionTableViewData> missionTableViewDataList, int currentMissionStep);
		private void SetupProgressBar(List<MissionTableViewData> missionTableViewDataList, int currentMissionStep);
		private void UpdateProgress(float progress);
		private void SetupReward(MissionDrillStepProgressUIRewardParts targetParts, List<MissionTableViewData> missionTableViewDataList, MissionTableViewData completeMissionData, int currentMissionStep, bool isUnlockedGroup);
		private void CreateTreasure(MissionTableViewData missionTableViewData, float ratio, MissionTableViewData.State state);
		private Vector3 GetPositionOnProgressBar(float ratio);
		private void PrepareFlash();
		public void PlayMissionCompleteAnimation(Sequence sequence, List<MissionTableViewData> nextMissionTableViewDataList, MissionDrillDataElement nextMissionDrillData);
		public void PlayEnterAnimation();
		public void PlayExitAnimation();
		public bool IsAnimationRunning();
	}
}
