/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EventFacilityRewardPopup : PopupBase
	{
		// Fields
		[SerializeField]
		private CommonIcon icon;
		[SerializeField]
		private UnityEngine.UI.Text titleText;
		[SerializeField]
		private UnityEngine.UI.Text contentText;
	
		// Constructors
		public EventFacilityRewardPopup();
	
		// Methods
		public static EventFacilityRewardPopup CreatePopup(Transform parentTransform, bool isEvent, int fortPlantId = 0);
		private void Init(bool isEvent, int fortPlantId = 0);
		public static bool MatchConvertedFacility(AtgenQuestStoryRewardList curReward, out int fortId, out string fortName);
	}
}
