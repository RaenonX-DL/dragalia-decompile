/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class VisibleUIObjectSpriteRenderer : MonoBehaviour
	{
		// Fields
		private Transform trs;
		private SpriteRenderer spriteRenderer;
		private bool isActive;
	
		// Constructors
		public VisibleUIObjectSpriteRenderer();
	
		// Methods
		public void Initialize(bool visible = false, GameObject obj = null);
		public bool IsVisible(bool inHierarchy = true);
		public void Visible(bool value);
	}
}
