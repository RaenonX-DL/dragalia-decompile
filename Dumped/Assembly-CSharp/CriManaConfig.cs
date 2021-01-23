/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

[Serializable]
public class CriManaConfig
{
	// Fields
	public int numberOfDecoders;
	public int numberOfMaxEntries;
	public readonly bool graphicsMultiThreaded;
	public PCH264PlaybackConfig pcH264PlaybackConfig;
	public VitaH264PlaybackConfig vitaH264PlaybackConfig;
	public WebGLConfig webglConfig;

	// Nested types
	[Serializable]
	public class PCH264PlaybackConfig
	{
		// Fields
		public bool useH264Playback;

		// Constructors
		public PCH264PlaybackConfig();
	}

	[Serializable]
	public class VitaH264PlaybackConfig
	{
		// Fields
		public bool useH264Playback;
		public int maxWidth;
		public int maxHeight;
		public bool getMemoryFromTexture;

		// Constructors
		public VitaH264PlaybackConfig();
	}

	[Serializable]
	public class WebGLConfig
	{
		// Fields
		public string webworkerPath;
		public int heapSize;

		// Constructors
		public WebGLConfig();
	}

	// Constructors
	public CriManaConfig();
}

