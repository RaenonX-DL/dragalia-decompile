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
	public class UnitEquipPageAbilityCrest : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public Image[] abilityCrestIcon;
		public Graphic[] unionIcon;
		public UnityEngine.UI.Text[] abilityCrestNameText;
		public Transform[] abilityCrestDecoNode;
		public GameObject[] noAbilityCrestIconGO;
		[SerializeField]
		private UnityEngine.UI.Text abilityCrestTitleText;
	
		// Constructors
		public UnitEquipPageAbilityCrest();
	
		// Methods
		public void SetupEquipPage();
		private void SetEquipAmuletInfo();
		private void SetCrestUnionIcon(Graphic unionIcon, int crestId);
	}
}
