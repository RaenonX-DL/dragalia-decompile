/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Mission.ListView;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MissionDrillStepProgressUIRewardParts : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private GameObject pickupLabel;
		[SerializeField]
		private GameObject completeLabel;
		[SerializeField]
		private GameObject rewardContentRoot;
		[SerializeField]
		private GameObject stepCompleteContentRoot;
		[SerializeField]
		private CommonIcon rewardIcon;
		[SerializeField]
		private UnityEngine.UI.Text nextPickupRewardText;
		private MissionTableViewData missionData;
	
		// Constructors
		public MissionDrillStepProgressUIRewardParts();
	
		// Methods
		public void SetupPickupReward(string text, MissionTableViewData missionData);
		public void SetupCompleteReward(string text, MissionTableViewData missionData);
		public void SetupStepComplete();
		private void Setup(string text, MissionTableViewData missionData);
		public void OnRewardIconClicked();
	}
}
