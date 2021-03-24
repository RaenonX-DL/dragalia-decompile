/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class CriAtomEx3dSource : CriDisposable
{
	// Fields
	private IntPtr handle;

	// Properties
	public IntPtr nativeHandle { get; }

	// Nested types
	public struct Config
	{
		// Fields
		public int reserved;
	}

	private struct CriAtomExVector
	{
		// Fields
		public float x;
		public float y;
		public float z;
	}

	// Constructors
	public CriAtomEx3dSource();

	// Methods
	public override void Dispose();
	private void Dispose(bool disposing);
	public void Update();
	public void ResetParameters();
	public void SetPosition(float x, float y, float z);
	public void SetVelocity(float x, float y, float z);
	public void SetOrientation(Vector3 front, Vector3 top);
	public void SetConeOrientation(float x, float y, float z);
	public void SetConeParameter(float insideAngle, float outsideAngle, float outsideVolume);
	public void SetMinMaxDistance(float minDistance, float maxDistance);
	public void SetInteriorPanField(float sourceRadius, float interiorDistance);
	public void SetDopplerFactor(float dopplerFactor);
	public void SetVolume(float volume);
	public void SetMaxAngleAisacDelta(float maxDelta);
	public void SetAttenuationDistanceSetting(bool flag);
	public bool GetAttenuationDistanceSetting();
	~CriAtomEx3dSource();
	private static extern IntPtr criAtomEx3dSource_Create(ref Config config, IntPtr work, int work_size);
	private static extern void criAtomEx3dSource_Destroy(IntPtr ex_3d_source);
	private static extern void criAtomEx3dSource_Update(IntPtr ex_3d_source);
	private static extern void criAtomEx3dSource_ResetParameters(IntPtr ex_3d_source);
	private static extern void criAtomEx3dSource_SetPosition(IntPtr ex_3d_source, ref CriAtomExVector position);
	private static extern void criAtomEx3dSource_SetVelocity(IntPtr ex_3d_source, ref CriAtomExVector velocity);
	private static extern void criAtomEx3dSource_SetOrientation(IntPtr ex_3d_source, ref CriAtomExVector front, ref CriAtomExVector top);
	private static extern void criAtomEx3dSource_SetConeOrientation(IntPtr ex_3d_source, ref CriAtomExVector cone_orient);
	private static extern void criAtomEx3dSource_SetConeParameter(IntPtr ex_3d_source, float inside_angle, float outside_angle, float outside_volume);
	private static extern void criAtomEx3dSource_SetMinMaxAttenuationDistance(IntPtr ex_3d_source, float min_distance, float max_distance);
	private static extern void criAtomEx3dSource_SetInteriorPanField(IntPtr ex_3d_source, float source_radius, float interior_distance);
	private static extern void criAtomEx3dSource_SetDopplerFactor(IntPtr ex_3d_source, float doppler_factor);
	private static extern void criAtomEx3dSource_SetVolume(IntPtr ex_3d_source, float volume);
	private static extern void criAtomEx3dSource_SetMaxAngleAisacDelta(IntPtr ex_3d_source, float max_delta);
	private static extern void criAtomEx3dSource_SetAttenuationDistanceSetting(IntPtr ex_3d_source, bool flag);
	private static extern bool criAtomEx3dSource_GetAttenuationDistanceSetting(IntPtr ex_3d_source);
}

