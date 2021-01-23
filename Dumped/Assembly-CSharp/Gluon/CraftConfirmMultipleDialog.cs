/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CraftConfirmMultipleDialog : PopupBase
	{
		// Fields
		public CommonPopup confirmDialog;
		public UnityEvent okButtonPressed;
		[SerializeField]
		private GameObject quotientWeaponCell;
		[SerializeField]
		private UnityEngine.UI.Text quotientWeaponText;
		[SerializeField]
		private Image quotientWeaponImage;
		[SerializeField]
		private GameObject quotientWeaponSortDecoAttachNode;
		[SerializeField]
		private GameObject reminderWeaponCell;
		[SerializeField]
		private UnityEngine.UI.Text reminderWeaponText;
		[SerializeField]
		private Image reminderWeaponImage;
		[SerializeField]
		private GameObject reminderWeaponSortDecoAttachNode;
		[SerializeField]
		private UnityEngine.UI.Text titleText;
		[SerializeField]
		private UnityEngine.UI.Text infoText;
		[SerializeField]
		private UnityEngine.UI.Text cancelButtonText;
		[SerializeField]
		private UnityEngine.UI.Text okButtonText;
		private const string prefabPath = "Prefabs/OutGame/Growth/Craft/CraftConfirmMultipleDialog";
	
		// Constructors
		public CraftConfirmMultipleDialog();
	
		// Methods
		public static CraftConfirmMultipleDialog Create();
		public void InitSetting(int weaponId, int quantity);
		public void OnOkButtonPressed();
		public void OnCancelButtonPressed();
		[CompilerGenerated]
		private void _OnOkButtonPressed_b__17_0();
	}
}
