using System;

public class CriAtomExSoundObject : CriDisposable
{
	private struct Config
	{
		public bool enableVoiceLimitScope;

		public bool enableCategoryCueLimitScope;
	}

	private IntPtr handle;

	public IntPtr nativeHandle => default(IntPtr);

	public CriAtomExSoundObject(bool enableVoiceLimitScope, bool enableCategoryCueLimitScope)
	{
	}

	public override void Dispose()
	{
	}

	public void AddPlayer(CriAtomExPlayer player)
	{
	}

	public void DeletePlayer(CriAtomExPlayer player)
	{
	}

	public void DeleteAllPlayers()
	{
	}

	~CriAtomExSoundObject()
	{
	}

	private static extern IntPtr criAtomExSoundObject_Create(ref Config config, IntPtr work, int work_size);

	private static extern void criAtomExSoundObject_Destroy(IntPtr soundObject);

	private static extern void criAtomExSoundObject_AddPlayer(IntPtr soundObject, IntPtr player);

	private static extern void criAtomExSoundObject_DeletePlayer(IntPtr soundObject, IntPtr player);

	private static extern void criAtomExSoundObject_DeleteAllPlayers(IntPtr soundObject);
}
