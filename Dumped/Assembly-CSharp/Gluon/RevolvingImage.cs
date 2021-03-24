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
	public class RevolvingImage : BaseMeshEffect
	{
		// Fields
		[Header]
		[SerializeField]
		private float perspective;
		private UIVertex v;
		private float revolve;
		private Material backMaterial;
		private Sprite backSprite;
		private float duration;
		private float lapse;
		private bool doing;
		private bool done;
		private Image image;
	
		// Constructors
		public RevolvingImage();
	
		// Methods
		public void Initialize();
		private void Update();
		public override void ModifyMesh(VertexHelper vh);
		private void Refresh();
		public void StartRevolve(Material material, float time);
		public void StartRevolve(Sprite sprite, float time);
	}
}
