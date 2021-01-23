/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public static class CriAtomExPlaybackDebug
{
	// Methods
	public static bool GetParameter(CriAtomExPlayback playback, CriAtomEx.Parameter parameterId, out float value);
	public static bool GetParameter(CriAtomExPlayback playback, CriAtomEx.Parameter parameterId, out uint value);
	public static bool GetParameter(CriAtomExPlayback playback, CriAtomEx.Parameter parameterId, out int value);
	public static bool GetAisacControl(CriAtomExPlayback playback, uint controlId, out float value);
	public static bool GetAisacControl(CriAtomExPlayback playback, string controlName, out float value);
	private static extern int criAtomExPlayback_GetParameterFloat32(uint id, int parameterId, out float value);
	private static extern int criAtomExPlayback_GetParameterUint32(uint id, int parameterId, out uint value);
	private static extern int criAtomExPlayback_GetParameterSint32(uint id, int parameterId, out int value);
	private static extern int criAtomExPlayback_GetAisacControlById(uint id, uint controlId, out float value);
	private static extern int criAtomExPlayback_GetAisacControlByName(uint id, string controlName, out float value);
}

