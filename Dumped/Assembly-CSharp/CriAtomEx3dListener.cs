/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class CriAtomEx3dListener : CriDisposable
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
	public CriAtomEx3dListener();

	// Methods
	public override void Dispose();
	private void Dispose(bool disposing);
	public void Update();
	public void ResetParameters();
	public void SetPosition(float x, float y, float z);
	public void SetVelocity(float x, float y, float z);
	public void SetOrientation(float fx, float fy, float fz, float ux, float uy, float uz);
	[Obsolete]
	public void SetDistanceFactor(float distanceFactor);
	public void SetDopplerMultiplier(float dopplerMultiplier);
	public void SetFocusPoint(float x, float y, float z);
	public void SetDistanceFocusLevel(float distanceFocusLevel);
	public void SetDirectionFocusLevel(float directionFocusLevel);
	~CriAtomEx3dListener();
	private static extern IntPtr criAtomEx3dListener_Create(ref Config config, IntPtr work, int work_size);
	private static extern void criAtomEx3dListener_Destroy(IntPtr ex_3d_listener);
	private static extern void criAtomEx3dListener_Update(IntPtr ex_3d_listener);
	private static extern void criAtomEx3dListener_ResetParameters(IntPtr ex_3d_listener);
	private static extern void criAtomEx3dListener_SetPosition(IntPtr ex_3d_listener, ref CriAtomExVector position);
	private static extern void criAtomEx3dListener_SetVelocity(IntPtr ex_3d_listener, ref CriAtomExVector velocity);
	private static extern void criAtomEx3dListener_SetOrientation(IntPtr ex_3d_listener, ref CriAtomExVector front, ref CriAtomExVector top);
	private static extern void criAtomEx3dListener_SetDistanceFactor(IntPtr ex_3d_listener, float distance_factor);
	private static extern void criAtomEx3dListener_SetDopplerMultiplier(IntPtr ex_3d_listener, float doppler_multiplier);
	private static extern void criAtomEx3dListener_SetFocusPoint(IntPtr ex_3d_listener, ref CriAtomExVector focus_point);
	private static extern void criAtomEx3dListener_SetDistanceFocusLevel(IntPtr ex_3d_listener, float distance_focus_level);
	private static extern void criAtomEx3dListener_SetDirectionFocusLevel(IntPtr ex_3d_listener, float direction_focus_level);
}

