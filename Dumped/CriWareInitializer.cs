using System;
using UnityEngine;

[AddComponentMenu("CRIWARE/Library Initializer")]
public class CriWareInitializer : MonoBehaviour
{
	public bool initializesFileSystem;

	public CriFsConfig fileSystemConfig;

	public bool initializesAtom;

	public CriAtomConfig atomConfig;

	public bool initializesMana;

	public CriManaConfig manaConfig;

	public bool useDecrypter;

	public CriWareDecrypterConfig decrypterConfig;

	public bool dontInitializeOnAwake;

	public bool dontDestroyOnLoad;

	private static int initializationCount;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Initialize()
	{
	}

	public void Shutdown()
	{
	}

	private void OnDestroy()
	{
	}

	public static bool IsInitialized()
	{
		return default(bool);
	}

	public static void AddAudioEffectInterface(IntPtr effect_interface)
	{
	}

	public static bool InitializeFileSystem(CriFsConfig config)
	{
		return default(bool);
	}

	public static bool InitializeAtom(CriAtomConfig config)
	{
		return default(bool);
	}

	public static bool InitializeMana(CriManaConfig config)
	{
		return default(bool);
	}

	[Obsolete]
	public static bool InitializeDecrypter(CriWareDecrypterConfig config)
	{
		return default(bool);
	}
}
