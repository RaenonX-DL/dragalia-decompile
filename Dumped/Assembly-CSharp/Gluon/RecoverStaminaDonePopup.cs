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
	public class RecoverStaminaDonePopup : PopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		public GameObject[] iconFrames;
		public CommonIcon[] icons;
		public UnityEngine.UI.Text commentText;
		public UnityEngine.UI.Text titleText;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text beforeStaminaText;
		public UnityEngine.UI.Text afterStaminaText;
		public UnityEngine.UI.Text beforeStoneText;
		public UnityEngine.UI.Text afterStoneText;
		public GameObject stoneLineGO;
		public UnityEngine.UI.Text staminaTabText;
		public UnityEngine.UI.Text stoneText;
		public GameObject freeStoneGO;
		public GameObject paidStoneGO;
	
		// Constructors
		public RecoverStaminaDonePopup();
	
		// Methods
		public static RecoverStaminaDonePopup Create(int beforeStamina, int afterStamina, bool isMulti, int beforeStone = -1, int afterStone = -1, EntityData[] usedItem = null);
		private void Setup(int beforeStamina, int afterStamina, bool isMulti, int beforeStone = -1, int afterStone = -1, EntityData[] usedItem = null);
		public void OnCloseButtonPressed();
	}
}
