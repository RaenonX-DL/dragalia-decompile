/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public static class CriAtomExDebug
{
	// Nested types
	public struct ResourcesInfo
	{
		// Fields
		public CriAtomEx.ResourceUsage virtualVoiceUsage;
		public CriAtomEx.ResourceUsage sequenceUsage;
		public CriAtomEx.ResourceUsage sequenceTrackUsage;
		public CriAtomEx.ResourceUsage sequenceTrackItemUsage;
	}

	// Methods
	public static void GetResourcesInfo(out ResourcesInfo resourcesInfo);
	private static extern void criAtomExDebug_GetResourcesInfo(out ResourcesInfo resourcesInfo);
}

