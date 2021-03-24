/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Gluon.Master;
using Gluon.Mission;
using Gluon.Mission.ListView;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MissionDrillDetailUIFadeParts : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private Image missionIcon;
		[SerializeField]
		private UnityEngine.UI.Text missionTitleText;
		[SerializeField]
		private CommonIcon rewardIcon;
		[SerializeField]
		private MissionWidgetAchievement achievementWidget;
		[SerializeField]
		private GameObject missionContentRoot;
		[SerializeField]
		private GameObject missionBackground;
		[SerializeField]
		private GameObject completeBackground;
		[SerializeField]
		private GameObject allCompleteBackground;
		[SerializeField]
		private CanvasGroup canvasGroup;
		private MissionTableViewData missionTableViewData;
		private MissionDrillDataElement missionDrillData;
		private MissionDrillGroupElement missionDrillGroup;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0
		{
			// Fields
			public MissionDrillGroupElement missionDrillGroup;
	
			// Constructors
			public __c__DisplayClass12_0();
	
			// Methods
			internal bool _Setup_b__0(MissionDrillGroupElement e);
		}
	
		// Constructors
		public MissionDrillDetailUIFadeParts();
	
		// Methods
		public void Setup(MissionTableViewData missionTableViewData, MissionDrillGroupElement missionDrillGroup, MissionDrillDataElement missionDrillData, float alpha);
		public void OnDetailButtonClicked();
		public void OnChallangeButtonClicked();
		public void OnRewardIconClicked();
		public void PlayFadeInAnimation(Sequence sequence, float duration);
	}
}
