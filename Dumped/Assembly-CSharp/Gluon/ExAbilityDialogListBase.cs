/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[Serializable]
	public class ExAbilityDialogListBase : MonoBehaviour
	{
		// Fields
		public Image charaIcon;
		public Image blackBase;
		public CommonExAbilityCell[] exAbilityCells;
		public UnityEngine.UI.Text notLearnMessage;
		public Image[] duplicateCharaIcons;
	
		// Constructors
		public ExAbilityDialogListBase();
	
		// Methods
		private void Start();
		public void SetupListBase(int charaId, int charaRarity);
		public void GrayOutListBase(List<CommonCharaExAbilityData.UnitData> abilityDuplicateUnit);
	}
}
