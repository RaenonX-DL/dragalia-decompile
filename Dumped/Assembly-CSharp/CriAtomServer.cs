/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class CriAtomServer : MonoBehaviour
{
	// Fields
	private static CriAtomServer _instance;
	public Action<bool> onApplicationPausePreProcess;
	public Action<bool> onApplicationPausePostProcess;

	// Properties
	public static CriAtomServer instance { get; }

	// Constructors
	public CriAtomServer();
	static CriAtomServer();

	// Methods
	public static void CreateInstance();
	public static void DestroyInstance();
	private void Awake();
	private void OnEnable();
	private void OnDisable();
	private void OnApplicationPause(bool appPause);
	private void ProcessApplicationPause(bool appPause);
}

