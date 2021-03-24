/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthUICanvas : AnimationUICanvas
	{
		// Fields
		public GrowthScene scene;
		public Button menuButton;
		public Button itemButton;
		public Button growthCharacterButton;
		public Button growthManaCircleButton;
		public Button growthWeaponButton;
		public Button growthDragonButton;
		public Button growthAmuletButton;
		public GameObject balloon;
		public GameObject growthCharacterMaintenance;
		public GameObject growthManaCircleMaintenance;
		public GameObject growthWeaponMaintenance;
		public GameObject growthDragonMaintenance;
		public GameObject growthAmuletMaintenance;
		public UnityEngine.UI.Text manaNumText;
		public UnityEngine.UI.Text awakeningNumText;
		public UnityEngine.UI.Text rupiNumText;
		public UnityEngine.UI.Text talkName;
		public UnityEngine.UI.Text talkText;
		public Badge weaponBadgeIcon;
		public Badge crestBadgeIcon;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass30_0
		{
			// Fields
			public GrowthUICanvas __4__this;
			public OutGameTopCharaTalkSelector.TalkData talkData;
	
			// Constructors
			public __c__DisplayClass30_0();
	
			// Methods
			internal void _StartBalloonAnimation_b__0();
		}
	
		// Constructors
		public GrowthUICanvas();
	
		// Methods
		private void Start();
		public void OnGrowthCharacterButtonPressed();
		public void OnGrowthManaCircleButtonPressed();
		public void OnGrowthDragonButtonPressed();
		public void OnGrowthWeaponButtonPressed();
		public void OnGrowthAmuletButtonPressed();
		public void OnGrowthCraftButtonPressed();
		public void SetTalkTextString(string text);
		public void SetTalkNameString(string text);
		public void StartBalloonAnimation(OutGameTopCharaTalkSelector.TalkData talkData, bool dontRunCloseAnimation = false, bool ignoreDelay = false);
		public void CheckTutorialLockButton(bool isIgnorePressed = false);
		public void DisableAllButtonExceptGrowthAmulet();
		public void DisableAllButtonExceptManaCircle();
		public void DisableAllButtonExceptCraft();
		public void CheckMaintenance();
		public void UpdateFundsTexts();
		public void UpdateBadge();
	}
}
