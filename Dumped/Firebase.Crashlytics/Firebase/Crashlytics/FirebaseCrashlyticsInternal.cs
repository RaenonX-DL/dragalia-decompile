/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Firebase;

// Image 46: Firebase.Crashlytics.dll - Assembly: Firebase.Crashlytics, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Firebase.Crashlytics
{
	internal class FirebaseCrashlyticsInternal : IDisposable
	{
		// Fields
		private HandleRef swigCPtr;
		protected bool swigCMemOwn;
	
		// Properties
		internal bool IsDisposed { get; }
	
		// Constructors
		internal FirebaseCrashlyticsInternal(IntPtr cPtr, bool cMemoryOwn);
	
		// Methods
		internal static HandleRef getCPtr(FirebaseCrashlyticsInternal obj);
		~FirebaseCrashlyticsInternal();
		public virtual void Dispose();
		internal static FirebaseCrashlyticsInternal GetInstance(FirebaseApp app, out InitResult init_result_out);
		internal static FirebaseCrashlyticsInternal GetInstance(FirebaseApp app);
		public void Log(string message);
		public void SetCustomKey(string key, string value);
		public void SetUserId(string id);
		public void LogException(string name, string reason, StackFrames frames);
		public bool IsCrashlyticsCollectionEnabled();
		public void SetCrashlyticsCollectionEnabled(bool enabled);
	}
}
