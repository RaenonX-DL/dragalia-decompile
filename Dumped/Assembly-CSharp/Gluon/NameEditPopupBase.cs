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
	public abstract class NameEditPopupBase : CommonPopup
	{
		// Fields
		[Header]
		[SerializeField]
		public InputField inputField;
		public UnityEngine.UI.Text countText;
		public UnityEngine.UI.Text inputPlaceHolder;
		private const int textLimit = 20;
		public const int textInputAllowance = 40;
	
		// Constructors
		protected NameEditPopupBase();
	
		// Methods
		protected abstract string GetInputFieldDefaultText();
		protected void InitInputField();
		protected string GetTrimmedString(string s);
		protected int GetTextLength(string s);
		protected void SetCountText();
		[CompilerGenerated]
		private void _InitInputField_b__6_0(string inputText);
		[CompilerGenerated]
		private void _InitInputField_b__6_1(string inputText);
	}
}
