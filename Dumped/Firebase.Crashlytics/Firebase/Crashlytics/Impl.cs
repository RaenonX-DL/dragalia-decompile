/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 49: Firebase.Crashlytics.dll - Assembly: Firebase.Crashlytics, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Firebase.Crashlytics
{
	internal class Impl
	{
		// Fields
		private static readonly string LogString;
		private static readonly string SetKeyValueString;
		private static readonly string SetUserIdentifierString;
		private static readonly string LogExceptionString;
		private static readonly string IsCrashlyticsCollectionEnabledString;
		private static readonly string SetCrashlyticsCollectionEnabledString;
	
		// Constructors
		public Impl();
		static Impl();
	
		// Methods
		public static Impl Make();
		public virtual bool IsSDKInitialized();
		public virtual void Log(string message);
		public virtual void SetCustomKey(string key, string value);
		public virtual void SetUserId(string identifier);
		public virtual void LogException(Exception exception);
		public virtual bool IsCrashlyticsCollectionEnabled();
		public virtual void SetCrashlyticsCollectionEnabled(bool enabled);
	}
}
