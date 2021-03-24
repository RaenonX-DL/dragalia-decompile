/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthCrestLimitBreakResultPopup : CommonPopup
	{
		// Fields
		public CommonUnitIcon unitIcon;
		public UnityEngine.UI.Text beforeLimitBreakText;
		public UnityEngine.UI.Text afterLimitBreakText;
		public Transform cellParentTransform;
		public GameObject[] abilityUIObjects;
		public Action popAnimationEndedCallBack;
		private GrowthUnitEnhanceModel model;
		private const string cellPrefabPath = "Prefabs/OutGame/Growth/GrowthUnitEnhance/GrowthUnitEnhanceSkillAbilityInfoCell";
	
		// Constructors
		public GrowthCrestLimitBreakResultPopup();
	
		// Methods
		public static GrowthCrestLimitBreakResultPopup Create();
		public void InitPopup(GrowthUnitEnhanceModel model, int beforeParam, bool isUpdateAbility);
		private void AddAbilityInfo(int abilityId);
		public override void StartShowAnimation(UnityEvent onCompleted = null);
		[CompilerGenerated]
		private void _StartShowAnimation_b__11_0();
	}
}
