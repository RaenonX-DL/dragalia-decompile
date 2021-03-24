/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CustomInputField : InputField
	{
		// Fields
		private Action onEditCallback;
		private Action onEndEditCallback;
	
		// Constructors
		public CustomInputField();
	
		// Methods
		public void InitSetting(Action onEditCallback = null, Action onEndEditCallback = null);
		private void Update();
		private void OnEdit(string inputText);
		private void OnEndEdit(string inputText);
		public bool IsEditMessage();
		public void Clear();
		[CompilerGenerated]
		private void _InitSetting_b__2_0(string inputText);
	}
}
