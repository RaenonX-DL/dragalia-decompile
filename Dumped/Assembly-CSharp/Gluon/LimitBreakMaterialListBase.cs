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
	public class LimitBreakMaterialListBase : CommonIconListBase
	{
		// Fields
		public UnityAction cancelButtonCallBack;
		public UnityAction limitBreakButtonCallBack;
		public UnityEngine.UI.Text listTitleText;
		public Button limitBreakButton;
		public Image limitBreakButtonImage;
		public Sprite buttonOnSprite;
		public Material buttonOnMaterial;
		public Sprite buttonOffSprite;
		public Material buttonOffMaterial;
		public GameObject effectBlackObj;
		[SerializeField]
		private UnityEngine.UI.Text limitBreakText;
	
		// Constructors
		public LimitBreakMaterialListBase();
	
		// Methods
		private void Start();
		public void CancelButtonPressed();
		public void limitBreakButtonPressed();
		public void limitBreakButtonLock();
		public void limitBreakButtonUnLock();
	}
}
