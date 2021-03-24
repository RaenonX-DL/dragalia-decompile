/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SummonOddsPopupTotalBlock : MonoBehaviour
	{
		// Fields
		[SerializeField]
		public UnityEngine.UI.Text sumText;
		public UnityEngine.UI.Text charaSumText;
		public UnityEngine.UI.Text dragonSumText;
		public UnityEngine.UI.Text amuletSumText;
		public GameObject charaLine;
		public GameObject dragonLine;
		public GameObject amuletLine;
		private Rarity rarity;
		private bool isPickup;
	
		// Constructors
		public SummonOddsPopupTotalBlock();
	
		// Methods
		public void Setup(OddsRate data, Rarity rarity, bool isPickup);
		private void SetupSubBunch(OddsUnitDetail[] oddsList, GameObject normalLine);
	}
}
