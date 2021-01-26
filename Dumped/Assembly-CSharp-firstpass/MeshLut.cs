﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class MeshLut
{
	// Fields
	private Dictionary<int, MeshData> _lut;

	// Constructors
	public MeshLut();

	// Methods
	public bool AddMesh(GameObject go);
	public void WriteMesh(int instID, UsCmd cmd);
	public void ClearLut();
}
