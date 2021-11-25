using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

[AddComponentMenu("CRIWARE/Error Handler")]
public class CriWareErrorHandler : MonoBehaviour
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void ErrorCallbackFunc(string errmsg);

	public bool enableDebugPrintOnTerminal;

	public bool enableForceCrashOnError;

	public bool dontDestroyOnLoad;

	private static int initializationCount;

	public static string errorMessage
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}

	private static void OutputErrorMessage()
	{
	}

	private static void OutputLog(string errmsg)
	{
	}

	private static void ErrorCallbackFromNative(string errmsg)
	{
	}

	private static extern void CRIWARE9E7A5F99();

	private static extern void CRIWAREA00567D1();

	private static extern IntPtr CRIWAREAA6E64CF();

	private static extern void CRIWARE24B8FE60();

	private static extern void CRIWARE6872EBF9(bool sw);

	private static extern void CRIWAREE3C232C9(bool sw);

	private static extern void criWareUnity_SetErrorCallback(ErrorCallbackFunc callback);
}
