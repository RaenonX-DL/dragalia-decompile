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
	public class CommonExAbilityCell : MonoBehaviour
	{
		// Fields
		public Image exAbilityIconImage;
		public UnityEngine.UI.Text exAbilityNameText;
		private int exAbilityId;
		private int exAbilityLevel;
		private bool isWeaponExAbility;
	
		// Constructors
		public CommonExAbilityCell();
	
		// Methods
		public void SetupCell(CharaDataElement masterCharaData, bool isWeaponExAbility, int exAbilityLevel);
		public void SetupCell(int exAbilityId, bool isWeaponExAbility, int exAbilityLevel);
		public void OnExAbilityCellPressed();
	}
}
