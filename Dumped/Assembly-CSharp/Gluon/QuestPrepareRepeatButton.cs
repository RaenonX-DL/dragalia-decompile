/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestPrepareRepeatButton : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private Button repeatButton;
		[SerializeField]
		private Image repeatNonInteractableTarget;
		[SerializeField]
		private Image repeatButtonDisableMark;
		[SerializeField]
		private GameObject repeatSettingDefaultText;
		[SerializeField]
		private GameObject repeatSettingRepeatText;
		[SerializeField]
		private GameObject repeatSettingOnText;
		[SerializeField]
		private GameObject repeatSettingOffText;
		private bool isEnableAuto;
		private bool isEnableRepeatQuest;
		private bool isEnableRepeat;
		private bool isEnableTransformToggle;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass16_0();
	
			// Methods
			internal void _OnMissionNotCompletedButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass17_0();
	
			// Methods
			internal void _OnInvalidRepeatButtonPressed_b__0();
		}
	
		// Constructors
		public QuestPrepareRepeatButton();
	
		// Methods
		private void Start();
		public void InitRepeatButton(int questId);
		private void DisableButton();
		public void UpdateRepeatButton();
		public void OnRepeatButtonPressed();
		public void OnMissionNotCompletedButtonPressed();
		public void OnInvalidRepeatButtonPressed();
		[CompilerGenerated]
		private void _OnRepeatButtonPressed_b__15_0();
		[CompilerGenerated]
		private void _OnRepeatButtonPressed_b__15_1();
	}
}
