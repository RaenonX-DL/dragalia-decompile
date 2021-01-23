/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class TextEffect : UIBehaviour, IMeshModifier
	{
		// Fields
		[SerializeField]
		private EffectType type;
		[SerializeField]
		private float unitLiftY;
		[SerializeField]
		private float rotateAngle;
		private const int vertexNumPerCharacter = 6;
		private List<UIVertex> vertexStream;
	
		// Nested types
		public enum EffectType
		{
			CurveArrange = 0,
			Rotate = 1
		}
	
		// Constructors
		public TextEffect();
	
		// Methods
		public void ModifyMesh(Mesh mesh);
		public void ModifyMesh(VertexHelper verts);
		private void ModifyBytype(ref List<UIVertex> stream);
		private void CurveArrange(ref List<UIVertex> stream);
		private void Rotate(ref List<UIVertex> stream);
	}
}
