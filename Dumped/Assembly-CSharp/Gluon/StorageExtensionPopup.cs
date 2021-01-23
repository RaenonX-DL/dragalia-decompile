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
	public class StorageExtensionPopup : CommonPopup
	{
		// Fields
		[Header]
		[SerializeField]
		private UnityEngine.UI.Text ownedStoneCountText;
		[SerializeField]
		private UnityEngine.UI.Text ownedPaidStoneCountText;
		[SerializeField]
		private UnityEngine.UI.Text commentText;
		[SerializeField]
		private UnityEngine.UI.Text[] onButtonPriceTexts;
		[Header]
		[SerializeField]
		private GameObject insufficientGO;
		[SerializeField]
		private GameObject purchaseStoneImage;
		[SerializeField]
		private GameObject usePaidStoneImage;
		public GameObject insufficientStonePriceGO;
		public GameObject insufficientPaidStonePriceGO;
		public GameObject normalStonePriceGO;
		public GameObject normalPaidStonePriceGO;
		[Header]
		[SerializeField]
		private Button stoneButton;
		private Action<bool> onOk;
	
		// Nested types
		public enum StorageType
		{
			Weapon = 0,
			Dragon = 1,
			Amulet = 2
		}
	
		// Constructors
		public StorageExtensionPopup();
	
		// Methods
		public static StorageExtensionPopup Create(StorageType type, Action<bool> onOk);
		private void InitByType(StorageType type, Action<bool> onOk);
		public void OnStoneButtonPressed(bool isPaidStone);
		[CompilerGenerated]
		private void _InitByType_b__15_0();
		[CompilerGenerated]
		private void _InitByType_b__15_1();
	}
}
