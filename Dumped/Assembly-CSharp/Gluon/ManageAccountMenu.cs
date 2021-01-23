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
	public class ManageAccountMenu : CommonPopup
	{
		// Fields
		private const string path = "Prefabs/OutGame/DataTransition/ManageNintendoMenu";
		[SerializeField]
		private UnityEngine.UI.Text MenuTitle;
		[SerializeField]
		private UnityEngine.UI.Text AccountLabel;
		[SerializeField]
		private UnityEngine.UI.Text DeleteAllDataLabel;
		[SerializeField]
		private UnityEngine.UI.Text AccountAreaText;
		[SerializeField]
		private UnityEngine.UI.Text DeleteAllDataAreaText;
		[SerializeField]
		private UnityEngine.UI.Text AccountManageButton;
		[SerializeField]
		private UnityEngine.UI.Text DeleteAllDataButton;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass10_0();
	
			// Methods
			internal void _OnDeleteAllDataButton_b__0();
			internal void _OnDeleteAllDataButton_b__1();
		}
	
		// Constructors
		public ManageAccountMenu();
	
		// Methods
		public static void Create();
		public void OnManageAccountButton();
		public void OnDeleteAllDataButton();
	}
}
