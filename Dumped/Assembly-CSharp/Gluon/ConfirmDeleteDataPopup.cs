/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ConfirmDeleteDataPopup : CommonPopup
	{
		// Fields
		[SerializeField]
		private Button confirmButton;
		[SerializeField]
		private InputField birthYearInputField;
		[SerializeField]
		private UnityEngine.UI.Text Title;
		[SerializeField]
		private UnityEngine.UI.Text ContentText;
		[SerializeField]
		private UnityEngine.UI.Text Hint;
		private const string path = "Prefabs/OutGame/DataTransition/ConfirmDeleteDataPopup";
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0
		{
			// Fields
			public CommonPopup popup;
			public ConfirmDeleteDataPopup __4__this;
	
			// Constructors
			public __c__DisplayClass8_0();
	
			// Methods
			internal void _Confirm_b__0();
			internal void _Confirm_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_1
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass8_1();
	
			// Methods
			internal void _Confirm_b__2();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static UnityAction __9__11_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _DeleteAllDataDone_b__11_0();
		}
	
		// Constructors
		public ConfirmDeleteDataPopup();
	
		// Methods
		public static void Create();
		protected override void Start();
		public void Confirm();
		private void DeleteAllData();
		private void OnSuccess(UserWithdrawalResponse res);
		private void DeleteAllDataDone();
		[CompilerGenerated]
		private void _Start_b__7_0(string text);
	}
}
