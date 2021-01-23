/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class CriAtomExWaveVoicePool : CriAtomExVoicePool
{
	// Constructors
	public CriAtomExWaveVoicePool(int numVoices, int maxChannels, int maxSamplingRate, bool streamingFlag, uint identifier = 0);

	// Methods
	private static extern IntPtr criAtomExVoicePool_AllocateWaveVoicePool(ref VoicePoolConfig config, IntPtr work, int work_size);
}

