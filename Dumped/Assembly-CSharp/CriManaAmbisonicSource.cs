/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class CriManaAmbisonicSource : MonoBehaviour
{
	// Fields
	private CriAtomEx3dSource atomEx3DsourceForAmbisonics;
	private Vector3 ambisonicSourceOrientationFront;
	private Vector3 ambisonicSourceOrientationTop;
	private Vector3 lastEulerOfAmbisonicSource;

	// Constructors
	public CriManaAmbisonicSource();

	// Methods
	private void Update();
	private void OnEnable();
	private void ForceUpdateAmbisonicSourceOrientation();
	private void UpdateAmbisonicSourceOrientation();
	private void RoatateAmbisonicSourceOrientationByTransformOfChild(ref Vector3 input_euler);
}

