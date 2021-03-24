/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

[AddComponentMenu]
public class CriManaMovieController : CriManaMovieMaterial
{
	// Fields
	public Renderer target;
	public bool useOriginalMaterial;
	private Material originalMaterial;

	// Constructors
	public CriManaMovieController();

	// Methods
	protected override void Start();
	protected override void Update();
	protected override void OnDestroy();
	protected override void OnMaterialAvailableChanged();
}

