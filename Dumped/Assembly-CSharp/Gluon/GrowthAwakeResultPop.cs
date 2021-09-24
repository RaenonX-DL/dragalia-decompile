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
	public class GrowthAwakeResultPop : CommonPopup
	{
		// Fields
		public GameObject iconBeforeAfterRoot;
		public Image breforeIcon;
		public Image afterIcon;
		public GameObject iconSingleRoot;
		public Image singleIcon;
		public UnityEngine.UI.Text beforeLevel;
		public UnityEngine.UI.Text afterLevel;
		public UnityEngine.UI.Text beforeHp;
		public UnityEngine.UI.Text afterHp;
		public UnityEngine.UI.Text beforeAtk;
		public UnityEngine.UI.Text afterAtk;
		public UnityEngine.UI.Text beforePower;
		public UnityEngine.UI.Text afterPower;
		public UnityEngine.UI.Text beforeManacircle;
		public UnityEngine.UI.Text afterManacircle;
		[SerializeField]
		private UnityEngine.UI.Text statusLevelText;
		[SerializeField]
		private UnityEngine.UI.Text statusHpText;
		[SerializeField]
		private UnityEngine.UI.Text statusAtkText;
		[SerializeField]
		private UnityEngine.UI.Text statusPowerText;
		[SerializeField]
		private UnityEngine.UI.Text statusManacircleText;
	
		// Nested types
		public class BeforeData
		{
			// Fields
			public int rarity;
			public int limitLevel;
			public int hpValue;
			public int atkValue;
			public int powerValue;
			public int manacircleCount;
			public int maxManacircleValue;
			public int storyIndex;
	
			// Constructors
			public BeforeData();
		}
	
		// Constructors
		public GrowthAwakeResultPop();
	
		// Methods
		public static GrowthAwakeResultPop Create(bool showBlackLayer = true);
		public void InitPop(ulong unitKeyId);
		public void InitPopForPlatinumCrystal(ulong unitKeyId, BeforeData beforeData, GrowthManaCircleManaPieceData[] manaPieceDataList);
		private void InitText();
	}
}
