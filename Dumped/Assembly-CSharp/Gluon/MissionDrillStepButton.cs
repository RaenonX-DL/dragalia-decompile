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
	public class MissionDrillStepButton : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text stepText;
		[SerializeField]
		private Button button;
		[SerializeField]
		private FlashPlayerManager flashPlayerManager;
		[SerializeField]
		private Transform unlockFlashParent;
		private FlashPlayer unlockFlashPlayer;
		private const string unlockFlashPath = "Prefabs/OutGame/MissionDrill/pf_NhaamDrillStepButtonUnlock";
	
		// Constructors
		public MissionDrillStepButton();
	
		// Methods
		public void Setup(int step, bool isLock);
		public void EnableButton();
		private void PrepareFlash();
		public void PlayEffect();
	}
}
