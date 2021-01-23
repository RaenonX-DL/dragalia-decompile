/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FirstCharaSelectPopup : PopupBase
	{
		// Fields
		[SerializeField]
		private FirstCharaSelectController tableView;
		private SummonScene scene;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<FirstCharaSelectData> __9__3_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _SetContent_b__3_0(FirstCharaSelectData a, FirstCharaSelectData b);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0
		{
			// Fields
			public FirstCharaSelectPopup __4__this;
			public int id;
			public Action __9__1;
	
			// Constructors
			public __c__DisplayClass4_0();
	
			// Methods
			internal void _OnClickButton_b__0();
			internal void _OnClickButton_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0
		{
			// Fields
			public Action onFinished;
	
			// Constructors
			public __c__DisplayClass5_0();
	
			// Methods
			internal void _ClosePopup_b__0();
		}
	
		// Constructors
		public FirstCharaSelectPopup();
	
		// Methods
		public static FirstCharaSelectPopup Create(SummonScene scene);
		public void SetContent();
		public void OnClickButton(int id);
		public void ClosePopup(Action onFinished = null);
		public static bool IsSelectCharacterAllPartyIn();
	}
}
