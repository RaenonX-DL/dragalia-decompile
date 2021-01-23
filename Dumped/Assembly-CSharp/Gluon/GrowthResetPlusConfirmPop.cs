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
	public class GrowthResetPlusConfirmPop : CommonPopup
	{
		// Fields
		public CraftMaterialCell originCell;
		[SerializeField]
		private UnityEngine.UI.Text rupiAlertText;
		[SerializeField]
		private UnityEngine.UI.Text afterRupiText;
		[SerializeField]
		private UnityEngine.UI.Text beforeRupiText;
		[SerializeField]
		private UnityEngine.UI.Text needRupiText;
		[SerializeField]
		private UnityEngine.UI.Text resetAlertText;
		[SerializeField]
		private UnityEngine.UI.Text messageText;
	
		// Nested types
		public enum ResetPlusType
		{
			None = 0,
			Hp = 1,
			Atk = 2,
			All = 3
		}
	
		// Constructors
		public GrowthResetPlusConfirmPop();
	
		// Methods
		public static GrowthResetPlusConfirmPop Create(bool showBlackLayer = true);
		public void InitPop(ResetPlusType resetType, GrowthBaseType growthBaseType, ulong targetKeyId);
		private void OnCellPressed(CraftMaterialCellData cellData);
	}
}
