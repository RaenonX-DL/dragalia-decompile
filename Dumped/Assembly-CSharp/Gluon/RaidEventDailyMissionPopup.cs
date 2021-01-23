/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class RaidEventDailyMissionPopup : PopupBase
	{
		// Fields
		[SerializeField]
		public CommonIcon icon;
		public RubySupportedText conditionText;
		public RubySupportedText conditionSubText;
		public Toggle doNotDisturbCheck;
		private Action onMissionButtonPressed;
		private Action<bool> onClose;
	
		// Constructors
		public RaidEventDailyMissionPopup();
	
		// Methods
		public static RaidEventDailyMissionPopup Create(MissionDailyDataElement elem, Action onMissionButtonPressed, Action<bool> onClose);
		public void Setup(MissionDailyDataElement elem);
		public void OnCheckMissionButtonPressed();
		public void OnCloseButtonPressed();
	}
}
