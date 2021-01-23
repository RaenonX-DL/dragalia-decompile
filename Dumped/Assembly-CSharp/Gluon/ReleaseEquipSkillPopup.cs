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
	public class ReleaseEquipSkillPopup : CommonPopup
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text charaLevelCountText;
		[SerializeField]
		private UnityEngine.UI.Text manaCircleCountText;
		[SerializeField]
		private GameObject materialBaseObject;
		[SerializeField]
		private Image materialIcon;
		[SerializeField]
		private UnityEngine.UI.Text materialNameText;
		[SerializeField]
		private UnityEngine.UI.Text materialCountText;
		[SerializeField]
		private GameObject errorTextObject;
		private int targetCharaId;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0
		{
			// Fields
			public bool isReloadManaCircle;
			public ReleaseEquipSkillPopup __4__this;
	
			// Constructors
			public __c__DisplayClass11_0();
	
			// Methods
			internal void _OnManaCirclePressed_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0
		{
			// Fields
			public CommonPopup popup;
			public Action okCallBack;
	
			// Constructors
			public __c__DisplayClass14_0();
	
			// Methods
			internal void _ShowGoOtherSceneComfirmPopup_b__0();
			internal void _ShowGoOtherSceneComfirmPopup_b__1();
		}
	
		// Constructors
		public ReleaseEquipSkillPopup();
	
		// Methods
		public static ReleaseEquipSkillPopup Create();
		public void SetupPopup(int targetCharaId);
		public void OnCharaLevelPressed();
		public void OnManaCirclePressed();
		public void OnMaterialIconPressed();
		public void OnMaterialIconLongPressed();
		public void ShowGoOtherSceneComfirmPopup(string showTextStr, Action okCallBack);
		[CompilerGenerated]
		private void _OnCharaLevelPressed_b__10_0();
		[CompilerGenerated]
		private void _OnCharaLevelPressed_b__10_1();
		[CompilerGenerated]
		private void _OnManaCirclePressed_b__11_0();
		[CompilerGenerated]
		private void _OnManaCirclePressed_b__11_1();
		[CompilerGenerated]
		private void _OnMaterialIconPressed_b__12_0();
		[CompilerGenerated]
		private void _OnMaterialIconPressed_b__12_1();
	}
}
