/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.EventSystems;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class StandaloneInputModuleCustom : StandaloneInputModule
	{
		// Fields
		public const int LAYER_UI = 5;
	
		// Constructors
		public StandaloneInputModuleCustom();
	
		// Methods
		public PointerEventData GetLastPointerEventDataPublic(int pinterId);
		public bool IsUITouched(int pointerId);
		public int GetActivePointerId();
	}
}
