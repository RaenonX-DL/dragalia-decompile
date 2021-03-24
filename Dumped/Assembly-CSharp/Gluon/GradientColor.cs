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
	public class GradientColor : BaseMeshEffect
	{
		// Fields
		private UIVertex v;
		private Color32 topColor;
		private Color32 bottomColor;
	
		// Properties
		public Color32 TopColor { get; set; }
		public Color32 BottomColor { get; set; }
	
		// Constructors
		public GradientColor();
	
		// Methods
		public override void ModifyMesh(VertexHelper vh);
		private void Refresh();
		private void SetTopColor(Color32 col);
		private void SetBottomColor(Color32 col);
	}
}
