/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FacilityDialogContent : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private FacilityDialogContentItem item1;
		[SerializeField]
		private FacilityDialogContentItem item2;
		[SerializeField]
		private FacilityDialogContentItem item3;
		[SerializeField]
		private FacilityDialogContentItem itemDragonBoost;
		[SerializeField]
		private GameObject noItemSpacer;
		private const int productionSpeedNumberDigit = 4;
	
		// Constructors
		public FacilityDialogContent();
	
		// Methods
		public bool SetContent(Facility facility, Facility nextLevelFacility = null);
		public void SetContentProduction(float maxTime, float max, bool isLevelUp = false, float nextLevelMaxTime = 0f, float nextLevelMax = 0f);
		public void SetContentProductionWithoutProduceMaxTime(float maxTime, float max, bool isLevelUp = false, float nextLevelMaxTime = 0f, float nextLevelMax = 0f);
		public void SetContentDragonFruits(float maxTime, float max, int appearLv, bool isLevelUp = false, float nextLevelMaxTime = 0f, float nextLevelMax = 0f, int nextAppearLv = 0);
		public void SetContentCharaBoost(bool isBoostAll, float hp, float attack, float defense, bool isLevelUp = false, float nextLevelHP = 0f, float nextLevelAttack = 0f, float nextLevelDefense = 0f);
		public void SetContentDragonBoost(float value, bool isLevelUp = false, float nextLevelValue = 0f);
		public void SetContentDragonBoostAllPrameters(AtgenDragonBonus dragonBoost);
		public void SetContentDragonBoostTime(float value, bool isLevelUp = false, float nextLevelValue = 0f);
		private string GetProduceMaxTimeText(float time);
		private string GetBattleText(bool isBoostAll, float value);
		private string GetDragonTimeText(float value);
		private string GetDragonBoostText(float value);
	}
}
