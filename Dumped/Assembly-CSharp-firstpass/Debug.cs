/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public static class Debug
{
	// Fields
	[CompilerGenerated]
	private static Action<string, string> onErrorLog;

	// Properties
	public static bool developerConsoleVisible { get; set; }
	public static bool isDebugBuild { get; }
	public static ILogger unityLogger { get; }
	public static bool IsLogEnable { get; }

	// Events
	public static event Action<string, string> onErrorLog {
		add;
		remove;
	}

	// Methods
	[Conditional]
	public static void Break();
	[Conditional]
	public static void Log(object message);
	[Conditional]
	public static void Log(object message, UnityEngine.Object context);
	[Conditional]
	public static void LogAssertion(object message);
	[Conditional]
	public static void LogAssertion(object message, UnityEngine.Object context);
	[Conditional]
	public static void LogFormat(string format, params object[] args);
	[Conditional]
	public static void LogFormat(UnityEngine.Object context, string format, params object[] args);
	[Conditional]
	public static void LogWarning(object message);
	[Conditional]
	public static void LogWarning(object message, UnityEngine.Object context);
	[Conditional]
	public static void LogWarningFormat(string format, params object[] args);
	public static void LogError(object message);
	public static void LogError(object message, UnityEngine.Object context);
	public static void LogErrorFormat(string format, params object[] args);
	[Conditional]
	public static void LogException(Exception exception);
	[Conditional]
	public static void LogException(Exception exception, UnityEngine.Object context);
	private static bool IsIPv4(string ip);
	private static bool IsIPv6(string ipv6);
	private static bool IsBaaSID(string baasid);
	private static bool IsViewerID(string viewerid);
	private static bool IsUUID(string uuid);
	[Conditional]
	public static void Assert(bool condition);
	[Conditional]
	public static void Assert(bool condition, string message);
	[Conditional]
	public static void Assert(bool condition, object message);
	[Conditional]
	public static void Assert(bool condition, UnityEngine.Object context);
	[Conditional]
	public static void Assert(bool condition, string message, UnityEngine.Object context);
	[Conditional]
	public static void Assert(bool condition, object message, UnityEngine.Object context);
	[Conditional]
	[Obsolete]
	public static void Assert(bool condition, string format, params object[] args);
	[Conditional]
	public static void AssertFormat(bool condition, string format, params object[] args);
	[Conditional]
	public static void AssertFormat(bool condition, UnityEngine.Object context, string format, params object[] args);
	public static void ClearDeveloperConsole();
	public static void DebugBreak();
	public static void DrawLine(Vector3 start, Vector3 end);
	public static void DrawLine(Vector3 start, Vector3 end, Color color);
	public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration);
	public static void DrawLine(Vector3 start, Vector3 end, [DefaultValue] Color color, [DefaultValue] float duration, [DefaultValue] bool depthTest);
	public static void DrawRay(Vector3 start, Vector3 dir);
	public static void DrawRay(Vector3 start, Vector3 dir, Color color);
	public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration);
	public static void DrawRay(Vector3 start, Vector3 dir, [DefaultValue] Color color, [DefaultValue] float duration, [DefaultValue] bool depthTest);
}

