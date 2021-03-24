/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Firebase;

// Image 49: Firebase.Crashlytics.dll - Assembly: Firebase.Crashlytics, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Firebase.Crashlytics
{
	internal class AndroidImpl : Impl
	{
		// Fields
		private FirebaseCrashlyticsInternal crashlyticsInternal;
		private readonly FirebaseApp firebaseApp;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Log_c__AnonStorey0
		{
			// Fields
			internal string message;
			internal AndroidImpl _this;
	
			// Constructors
			public _Log_c__AnonStorey0();
	
			// Methods
			internal void __m__0();
		}
	
		[CompilerGenerated]
		private sealed class _SetCustomKey_c__AnonStorey1
		{
			// Fields
			internal string key;
			internal string value;
			internal AndroidImpl _this;
	
			// Constructors
			public _SetCustomKey_c__AnonStorey1();
	
			// Methods
			internal void __m__0();
		}
	
		[CompilerGenerated]
		private sealed class _SetUserId_c__AnonStorey2
		{
			// Fields
			internal string identifier;
			internal AndroidImpl _this;
	
			// Constructors
			public _SetUserId_c__AnonStorey2();
	
			// Methods
			internal void __m__0();
		}
	
		[CompilerGenerated]
		private sealed class _LogException_c__AnonStorey3
		{
			// Fields
			internal LoggedException loggedException;
			internal StackFrames frames;
			internal AndroidImpl _this;
	
			// Constructors
			public _LogException_c__AnonStorey3();
	
			// Methods
			internal void __m__0();
		}
	
		[CompilerGenerated]
		private sealed class _SetCrashlyticsCollectionEnabled_c__AnonStorey4
		{
			// Fields
			internal bool enabled;
			internal AndroidImpl _this;
	
			// Constructors
			public _SetCrashlyticsCollectionEnabled_c__AnonStorey4();
	
			// Methods
			internal void __m__0();
		}
	
		// Constructors
		internal AndroidImpl();
	
		// Methods
		~AndroidImpl();
		private void Dispose();
		public override bool IsSDKInitialized();
		private void LogOperationFailedWarningDueToShutdown(string operation);
		private T CallInternalMethod<T>(Func<T> methodCall, string operation, T errorValue = default);
		private void CallInternalMethod(Action methodCall, string operation);
		public override void Log(string message);
		public override void SetCustomKey(string key, string value);
		public override void SetUserId(string identifier);
		public override void LogException(Exception exception);
		public override bool IsCrashlyticsCollectionEnabled();
		public override void SetCrashlyticsCollectionEnabled(bool enabled);
		[CompilerGenerated]
		private bool _IsCrashlyticsCollectionEnabled_m__0();
	}
}
