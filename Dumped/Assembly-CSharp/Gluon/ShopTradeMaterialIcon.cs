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
	public class ShopTradeMaterialIcon : MonoBehaviour
	{
		// Fields
		[SerializeField]
		public CommonIcon icon;
		public UnityEngine.UI.Text useCount;
		public Image bottomCountPlate;
		[Header]
		[SerializeField]
		public GameObject amuletDeco;
		public GameObject amuletCover;
		[Header]
		[SerializeField]
		public GameObject countMask;
		[Header]
		[SerializeField]
		private Image[] limitBreakImages;
		private UnityEngine.UI.Text[] displayTextList;
		private Color insufficientCountColor;
		private Color insufficientCountPlateColor;
		private Color insufficientCountPlateColorBottom;
		private Color normalCountPlateColorBottom;
		private Color normalCountColor;
		private Color normalPlateColor;
	
		// Constructors
		public ShopTradeMaterialIcon();
	
		// Methods
		private void Awake();
		public void SetMaterial(int id, int useCount, GiftType giftType = GiftType.MATERIAL, int limitBreakCount = 0, ulong keyId = 0, bool shouldTurnInsufficient = false);
		public void SetMaterialUseCount(int useCount, bool isSufficient);
		private void SetLimitBreakImage(int limitBreakCount);
	}
}
