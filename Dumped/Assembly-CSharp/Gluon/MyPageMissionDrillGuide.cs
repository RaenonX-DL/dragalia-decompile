/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MyPageMissionDrillGuide : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text titleText;
		[SerializeField]
		private Badge badge;
		[SerializeField]
		private Button button;
		[SerializeField]
		private UnityEngine.UI.Text challengeText;
		[SerializeField]
		private Transform challengeTextAnchor;
		private MissionDrillDataElement missionData;
	
		// Constructors
		public MyPageMissionDrillGuide();
	
		// Methods
		public void Setup(int missionId, bool existsReceivableReward, bool enabledButton);
		public void OnMissionChallengeButtonPressed();
	}
}
