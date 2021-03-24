/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MenuOtherPopup : CommonPopup
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text variousNotationText;
		[SerializeField]
		private UnityEngine.UI.Text accountManageText;
		[SerializeField]
		private UnityEngine.UI.Text creditText;
		[SerializeField]
		private UnityEngine.UI.Text purchaceInfoText;
		[SerializeField]
		private UnityEngine.UI.Text optoutText;
		[SerializeField]
		private UnityEngine.UI.Text returnTitleText;
		public MenuPopup menuPopup;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static UnityAction __9__11_0;
			public static UnityAction __9__12_0;
			public static UnityAction __9__15_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _DoAccountManage_b__11_0();
			internal void _CreateAlreadyLinkToNAPopup_b__12_0();
			internal void _OnReturnTitleButtonPressed_b__15_1();
		}
	
		// Constructors
		public MenuOtherPopup();
	
		// Methods
		public static MenuOtherPopup Create();
		public void InitSetting();
		public void OnVariousNotationButtonPressed();
		public void OnAccountManageButtonPressed();
		public static void DoAccountManage();
		private static void CreateAlreadyLinkToNAPopup();
		public void OnPurchaceInfoButtonPressed();
		public void OnOptoutButtonPressed();
		public void OnReturnTitleButtonPressed();
		[CompilerGenerated]
		private void _OnVariousNotationButtonPressed_b__9_0();
		[CompilerGenerated]
		private void _OnReturnTitleButtonPressed_b__15_0();
	}
}
