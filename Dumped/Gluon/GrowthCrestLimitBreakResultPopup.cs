using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthCrestLimitBreakResultPopup : CommonPopup
	{
		public CommonUnitIcon unitIcon;

		public Text beforeLimitBreakText;

		public Text afterLimitBreakText;

		public Transform cellParentTransform;

		public GameObject[] abilityUIObjects;

		public Action popAnimationEndedCallBack;

		private GrowthUnitEnhanceModel model;

		private const string cellPrefabPath = "Prefabs/OutGame/Growth/GrowthUnitEnhance/GrowthUnitEnhanceSkillAbilityInfoCell";

		public static GrowthCrestLimitBreakResultPopup Create()
		{
			return null;
		}

		public void InitPopup(GrowthUnitEnhanceModel model, int beforeParam, bool isUpdateAbility)
		{
		}

		private void AddAbilityInfo(int abilityId)
		{
		}

		public override void StartShowAnimation([Optional] UnityEvent onCompleted)
		{
		}
	}
}
