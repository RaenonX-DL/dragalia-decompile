/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

[AddComponentMenu]
public class CriWareInitializer : MonoBehaviour
{
	// Fields
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

	// Constructors
	public CriWareInitializer();
	static CriWareInitializer();

	// Methods
	private void Awake();
	private void OnEnable();
	private void Start();
	private void Update();
	public void Initialize();
	public void Shutdown();
	private void OnDestroy();
	public static bool IsInitialized();
	public static void AddAudioEffectInterface(IntPtr effect_interface);
	public static bool InitializeFileSystem(CriFsConfig config);
	public static bool InitializeAtom(CriAtomConfig config);
	public static bool InitializeMana(CriManaConfig config);
	[Obsolete]
	public static bool InitializeDecrypter(CriWareDecrypterConfig config);
}

