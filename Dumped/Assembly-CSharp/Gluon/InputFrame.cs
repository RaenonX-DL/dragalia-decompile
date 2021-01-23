/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class InputFrame : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text title;
		[SerializeField]
		private Button[] numberButton;
		[SerializeField]
		private UnityEngine.UI.Text[] numberText;
		private List<string> ids;
		private readonly string blank;
		public UnityAction<List<string>> onNumberButtonPressed;
	
		// Properties
		public List<string> IdList { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0
		{
			// Fields
			public int num;
			public InputFrame __4__this;
	
			// Constructors
			public __c__DisplayClass8_0();
	
			// Methods
			internal void _Initialize_b__0();
		}
	
		// Constructors
		public InputFrame();
	
		// Methods
		public void Initialize();
		private void OnNumberButtonPressed(int num);
		private void SetNumber();
		public void Clear();
		public void DeleteOne();
		public int GetInputNumber();
	}
}
