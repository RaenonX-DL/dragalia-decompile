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
	public class RaidBoostEventCharaCell : MonoBehaviour
	{
		// Fields
		[SerializeField]
		public UnityEngine.UI.Text eventCharaBoostText;
		[SerializeField]
		private EventAbilityCell eventCharaBoostCell;
		[SerializeField]
		private CommonIcon eventCharaIcon;
	
		// Constructors
		public RaidBoostEventCharaCell();
	
		// Methods
		public void SetContent(RaidBoostPopup.RaidBoostModel.RaidEventAbilityChara abilityCharaData);
	}
}
