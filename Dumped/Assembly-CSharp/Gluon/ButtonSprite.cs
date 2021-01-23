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
	[RequireComponent]
	public class ButtonSprite : MonoBehaviour
	{
		// Fields
		public Image onImage;
		public Image offImage;
	
		// Nested types
		public enum ButtonState
		{
			Normal = 0,
			Disabled = 1
		}
	
		// Constructors
		public ButtonSprite();
	
		// Methods
		public void SetButtonImage(ButtonState toState);
	}
}
