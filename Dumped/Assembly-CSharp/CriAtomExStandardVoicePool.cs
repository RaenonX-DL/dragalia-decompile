/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class CriAtomExStandardVoicePool : CriAtomExVoicePool
{
	// Constructors
	public CriAtomExStandardVoicePool(int numVoices, int maxChannels, int maxSamplingRate, bool streamingFlag, uint identifier = 0);

	// Methods
	private static extern IntPtr criAtomExVoicePool_AllocateStandardVoicePool(ref VoicePoolConfig config, IntPtr work, int work_size);
}

