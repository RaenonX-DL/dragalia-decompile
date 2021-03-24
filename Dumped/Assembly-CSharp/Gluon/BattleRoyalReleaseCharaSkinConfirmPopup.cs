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
	public class BattleRoyalReleaseCharaSkinConfirmPopup : CommonPopup
	{
		// Fields
		public Image skinIcon;
		public UnityEngine.UI.Text topText;
		public GameObject[] skillBaseObjects;
		public Image skillIcon;
		public UnityEngine.UI.Text skillName;
		public UnityEngine.UI.Text shortageMaterialText;
		public GameObject needMaterialBaseObject;
		public UnityEngine.UI.Text needCount;
		public GameObject saleImageObject;
		public UnityEngine.UI.Text beforeCount;
		public UnityEngine.UI.Text afterCount;
		private int specialSkillId;
	
		// Constructors
		public BattleRoyalReleaseCharaSkinConfirmPopup();
	
		// Methods
		public static BattleRoyalReleaseCharaSkinConfirmPopup Create();
		public void InitPopup(int charaSkinId);
		public void InitShopOnlyPopup(int charaSkinId);
		public void OnSkillCellPressed();
	}
}
