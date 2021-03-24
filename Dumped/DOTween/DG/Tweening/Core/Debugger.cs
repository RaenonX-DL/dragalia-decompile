/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;

// Image 42: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace DG.Tweening.Core
{
	public static class Debugger
	{
		// Fields
		public static int logPriority;
	
		// Methods
		public static void Log(object message);
		public static void LogWarning(object message);
		public static void LogError(object message);
		public static void LogReport(object message);
		public static void LogInvalidTween(Tween t);
		public static void LogNestedTween(Tween t);
		public static void LogNullTween(Tween t);
		public static void LogNonPathTween(Tween t);
		public static void LogMissingMaterialProperty(string propertyName);
		public static void LogRemoveActiveTweenError(string propertyName);
		public static void SetLogPriority(LogBehaviour logBehaviour);
	}
}
