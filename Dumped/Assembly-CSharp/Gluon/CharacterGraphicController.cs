/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterGraphicController : MonoBehaviour
	{
		// Fields
		[SerializeField]
		[Tooltip]
		private List<Renderer> _ignoreMainRenderers;
	
		// Constructors
		public CharacterGraphicController();
	
		// Methods
		public bool IsIgnoreMainRenderer(Renderer renderer);
	}
}
