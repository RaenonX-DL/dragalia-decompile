/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

[AddComponentMenu]
public class CriWareErrorHandler : MonoBehaviour
{
	// Fields
	public bool enableDebugPrintOnTerminal;
	public bool enableForceCrashOnError;
	public bool dontDestroyOnLoad;
	[CompilerGenerated]
	private static string _errorMessage_k__BackingField;
	private static int initializationCount;

	// Properties
	public static string errorMessage { [CompilerGenerated] get; [CompilerGenerated] set; }

	// Nested types
	[UnmanagedFunctionPointer]
	public delegate void ErrorCallbackFunc(string errmsg);

	// Constructors
	public CriWareErrorHandler();
	static CriWareErrorHandler();

	// Methods
	private void Awake();
	private void OnEnable();
	private void OnDisable();
	private void Start();
	private void Update();
	private void OnDestroy();
	private static void OutputErrorMessage();
	private static void OutputLog(string errmsg);
	[MonoPInvokeCallback]
	private static void ErrorCallbackFromNative(string errmsg);
	private static extern void CRIWARE9E7A5F99();
	private static extern void CRIWAREA00567D1();
	private static extern IntPtr CRIWAREAA6E64CF();
	private static extern void CRIWARE24B8FE60();
	private static extern void CRIWARE6872EBF9(bool sw);
	private static extern void CRIWAREE3C232C9(bool sw);
	private static extern void criWareUnity_SetErrorCallback(ErrorCallbackFunc callback);
}

