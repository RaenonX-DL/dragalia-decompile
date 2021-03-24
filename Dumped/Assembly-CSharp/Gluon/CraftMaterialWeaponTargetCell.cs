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
	public class CraftMaterialWeaponTargetCell : MonoBehaviour
	{
		// Fields
		public Image icon;
		public Transform carftTagIconTransform;
		public GameObject sortDecoAttachNode;
		public Action<int> iconPressCallBack;
		private int weaponId;
		private int limitbreak;
	
		// Constructors
		public CraftMaterialWeaponTargetCell();
	
		// Methods
		public void SetIcon(int weaponId);
		public void SetCraftTag(bool isShow);
		public void SetLimitBreak(int limitbreak);
		public void OnIconPressed();
		public void OnIconLongPressed();
	}
}
