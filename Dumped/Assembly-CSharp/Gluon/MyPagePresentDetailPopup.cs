/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MyPagePresentDetailPopup : CommonPopup
	{
		// Fields
		public MyPagePresentListPopup presentListPopup;
		[SerializeField]
		private CommonIcon itemIcon;
		[SerializeField]
		private UnityEngine.UI.Text itemNameText;
		[SerializeField]
		private UnityEngine.UI.Text discriptionText;
		[SerializeField]
		private UnityEngine.UI.Text DateText;
		private MyPagePresentListCellData cellData;
		private const string prefabPath = "Prefabs/OutGame/Present/MyPagePresentDetailPopup";
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0
		{
			// Fields
			public MyPagePresentListCellData data;
			public MyPagePresentDetailPopup __4__this;
	
			// Constructors
			public __c__DisplayClass8_0();
	
			// Methods
			internal void _InitSetting_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_1
		{
			// Fields
			public List<MyPagePresentListCellData> cellDataList;
			public __c__DisplayClass8_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass8_1();
	
			// Methods
			internal void _InitSetting_b__1();
		}
	
		// Constructors
		public MyPagePresentDetailPopup();
	
		// Methods
		public static MyPagePresentDetailPopup Create();
		public void InitSetting(MyPagePresentListCellData data);
		public void OnItemButtonLongPressed();
	}
}
