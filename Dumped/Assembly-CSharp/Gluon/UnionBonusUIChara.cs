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
	public class UnionBonusUIChara : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private Image charaIcon;
		[SerializeField]
		private UnionBonusUIAbility abilityUIBase;
		[SerializeField]
		private float unionBonusHeight;
		[Header]
		[SerializeField]
		private Image unionIcon;
		[SerializeField]
		private UnityEngine.UI.Text unionBonusName;
	
		// Constructors
		public UnionBonusUIChara();
	
		// Methods
		public void Setup(UnionBonusPopup.UnionBonusInfo unionBonusInfo);
		public void Setup(UnionAbilityElement unionBonus);
	}
}
