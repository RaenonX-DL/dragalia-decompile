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
	public class UnitDetailSkillInfoCell : UnitDetailInfoBaseCell
	{
		// Fields
		public static bool startBatch;
		[Header]
		[SerializeField]
		public GameObject weaponElementalNotMatchedNode;
		private bool isWeaponSkillElementalNotMatched;
		[Header]
		[SerializeField]
		private UnityEngine.UI.Text shareCost;
		[SerializeField]
		private GameObject shareObj;
		[SerializeField]
		private GameObject shareSkillLock;
		[SerializeField]
		private GameObject shareSkillOpen;
	
		// Constructors
		public UnitDetailSkillInfoCell();
		static UnitDetailSkillInfoCell();
	
		// Methods
		public override void IconPressed();
		public void SetSkillInfo(AbilityConst.UnitType giftType, int skillId, int skillLevel, int skillMaxLevel, bool isWeaponSkillElementalNotMatched = false);
		public void SetShareSkillInfo(int cost, bool canShareSkill);
	}
}
