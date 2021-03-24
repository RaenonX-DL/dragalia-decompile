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
	public class SummonResultStatusPlate : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text itemName;
		public UnityEngine.UI.Text levelNow;
		public UnityEngine.UI.Text levelMax;
		public UnityEngine.UI.Text hpVal;
		public UnityEngine.UI.Text atkVal;
		public UnityEngine.UI.Text powerVal;
		public UnityEngine.UI.Text skillText;
		[Header]
		[SerializeField]
		public GameObject exAbilityGO;
		[Header]
		[SerializeField]
		public GameObject normalStatusPanelGO;
		public GameObject moonStatusPanelGO;
		public UnityEngine.UI.Text moonDescriptionText;
		[Header]
		[SerializeField]
		public GameObject amuletStatusPanelGO;
		public UnityEngine.UI.Text amuletName;
		public UnitDetailAbilityInfoCell[] amuletAbilities;
		[Header]
		[SerializeField]
		public CommonIcon icon;
	
		// Constructors
		public SummonResultStatusPlate();
	
		// Methods
		public UnitDetailModel CreateUnitDetailModel(SummonResultItemData data);
		public void SetupByResultItemData(SummonResultItemData data);
	}
}
