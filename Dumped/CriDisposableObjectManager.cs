using System;
using System.Collections.Generic;

public static class CriDisposableObjectManager
{
	public enum ModuleType
	{
		Atom,
		AtomMic,
		Fs,
		FsWeb,
		Mana
	}

	public struct ObjectRef
	{
		public Guid guid;

		public ModuleType type;

		public WeakReference weakRef;

		public ObjectRef(Guid _guid, WeakReference _weakRef, ModuleType _type)
		{
		}
	}

	private static List<ObjectRef> refList;

	private static int SearchForDisposable(CriDisposable disposable)
	{
		return default(int);
	}

	public static void Register(CriDisposable disposable, ModuleType type)
	{
	}

	public static bool Unregister(CriDisposable disposable)
	{
		return default(bool);
	}

	public static bool IsDisposed(CriDisposable disposable)
	{
		return default(bool);
	}

	public static void CallOnModuleFinalization(ModuleType type)
	{
	}

	private static int GetNextWithType(ModuleType type)
	{
		return default(int);
	}

	public static void DisposeAll(ModuleType type)
	{
	}
}
