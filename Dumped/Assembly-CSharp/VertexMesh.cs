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

public class VertexMesh : BaseMeshEffect
{
	// Fields
	[Header]
	[SerializeField]
	public List<Vector3> offsets;

	// Constructors
	public VertexMesh();

	// Methods
	public override void ModifyMesh(VertexHelper vh);
	public void ModifyVertices(List<UIVertex> vertexList);
}

