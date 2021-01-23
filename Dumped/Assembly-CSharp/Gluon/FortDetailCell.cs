/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FortDetailCell : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private Image icon;
		[SerializeField]
		private UnityEngine.UI.Text facilityName;
		[SerializeField]
		private FacilityDialogContent facilityDialogContent;
	
		// Constructors
		public FortDetailCell();
	
		// Methods
		public void SetContentProduction(AtgenProductionRp production, MaterialHarvester.HarvestType type);
		public void SetContentWeapon(AtgenParamBonus weaponParam);
		public void SetContentElement(AtgenElementBonus elementParam);
		public void SetContentAllBonus(AtgenAllBonus allBonus);
		public void SetContentDragonBoost(AtgenDragonBonus dragonBoost, bool isSetAllPrameters = false);
		public void SetContentDragonBoostTime(AtgenDragonTimeBonus dragonBoostTime);
		private void LoadIconPrefab(string path);
	}
}
