/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MyPagePresentAllReceiveConfirmPopup : CommonPopup
	{
		// Fields
		public MyPagePresentListPopup presentListPopup;
		[SerializeField]
		private MyPagePresentGroupListController groupListController;
		private List<MyPagePresentGroupListCellData> groupCellDataList;
		private const string prefabPath = "Prefabs/OutGame/Present/MyPagePresentAllReceiveConfirmPopup";
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0
		{
			// Fields
			public List<MyPagePresentListCellData> presentCellDataList;
			public MyPagePresentAllReceiveConfirmPopup __4__this;
			public UnityAction __9__1;
	
			// Constructors
			public __c__DisplayClass5_0();
	
			// Methods
			internal void _InitSetting_b__0();
			internal void _InitSetting_b__1();
		}
	
		// Constructors
		public MyPagePresentAllReceiveConfirmPopup();
	
		// Methods
		public static MyPagePresentAllReceiveConfirmPopup Create();
		public void InitSetting(List<MyPagePresentListCellData> presentCellDataList);
	}
}
