/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class CriAtomExSoundObject : CriDisposable
{
	// Fields
	private IntPtr handle;

	// Properties
	public IntPtr nativeHandle { get; }

	// Nested types
	private struct Config
	{
		// Fields
		public bool enableVoiceLimitScope;
		public bool enableCategoryCueLimitScope;
	}

	// Constructors
	public CriAtomExSoundObject(bool enableVoiceLimitScope, bool enableCategoryCueLimitScope);

	// Methods
	public override void Dispose();
	public void AddPlayer(CriAtomExPlayer player);
	public void DeletePlayer(CriAtomExPlayer player);
	public void DeleteAllPlayers();
	~CriAtomExSoundObject();
	private static extern IntPtr criAtomExSoundObject_Create(ref Config config, IntPtr work, int work_size);
	private static extern void criAtomExSoundObject_Destroy(IntPtr soundObject);
	private static extern void criAtomExSoundObject_AddPlayer(IntPtr soundObject, IntPtr player);
	private static extern void criAtomExSoundObject_DeletePlayer(IntPtr soundObject, IntPtr player);
	private static extern void criAtomExSoundObject_DeleteAllPlayers(IntPtr soundObject);
}

