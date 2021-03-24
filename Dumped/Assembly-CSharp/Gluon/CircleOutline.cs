/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[AddComponentMenu]
	public class CircleOutline : Outline
	{
		// Fields
		[SerializeField]
		private bool useGraphicRedAsAlpha;
		private const int quality = 8;
		private List<UIVertex> list;
	
		// Constructors
		public CircleOutline();
	
		// Methods
		public override void ModifyMesh(VertexHelper vh);
		protected void ModifyVertices();
		protected void ApplyShadow(int start, int end, float x, float y);
	}
}
