/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class UVScroll : FastUpdateMonoBehaviour
	{
		// Fields
		public bool enableDirectionVertical;
		public bool enableDirectionHorizontal;
		public float scrollSpeed;
		private Renderer rend;
		[SerializeField]
		private bool isMaterialShared;
		[SerializeField]
		private bool isCreateAddtionalMeshForUV;
		private MeshRenderer orgMeshRenderer;
		private MeshFilter orgMeshFilter;
		private Mesh orgMesh;
		private Vector2[] addtionalUVs;
		private Mesh addtionalUvStream;
		private Vector2 tempVector2;
	
		// Constructors
		public UVScroll();
	
		// Methods
		private void Start();
		private void Update();
	}
}
