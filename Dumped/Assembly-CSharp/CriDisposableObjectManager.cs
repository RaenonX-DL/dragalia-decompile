/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public static class CriDisposableObjectManager
{
	// Fields
	private static List<ObjectRef> refList;

	// Nested types
	public enum ModuleType
	{
		Atom = 0,
		AtomMic = 1,
		Fs = 2,
		FsWeb = 3,
		Mana = 4
	}

	public struct ObjectRef
	{
		// Fields
		public Guid guid;
		public ModuleType type;
		public WeakReference weakRef;

		// Constructors
		public ObjectRef(Guid _guid, WeakReference _weakRef, ModuleType _type);
	}

	// Constructors
	static CriDisposableObjectManager();

	// Methods
	private static int SearchForDisposable(CriDisposable disposable);
	public static void Register(CriDisposable disposable, ModuleType type);
	public static bool Unregister(CriDisposable disposable);
	public static bool IsDisposed(CriDisposable disposable);
	public static void CallOnModuleFinalization(ModuleType type);
	private static int GetNextWithType(ModuleType type);
	public static void DisposeAll(ModuleType type);
}

