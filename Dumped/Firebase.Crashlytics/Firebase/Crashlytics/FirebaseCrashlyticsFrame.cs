/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 46: Firebase.Crashlytics.dll - Assembly: Firebase.Crashlytics, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Firebase.Crashlytics
{
	public class FirebaseCrashlyticsFrame : IDisposable
	{
		// Fields
		private HandleRef swigCPtr;
		protected bool swigCMemOwn;
	
		// Properties
		public string library { get; set; }
		public string symbol { get; set; }
		public string fileName { get; set; }
		public string lineNumber { get; set; }
	
		// Constructors
		internal FirebaseCrashlyticsFrame(IntPtr cPtr, bool cMemoryOwn);
		public FirebaseCrashlyticsFrame();
	
		// Methods
		internal static HandleRef getCPtr(FirebaseCrashlyticsFrame obj);
		~FirebaseCrashlyticsFrame();
		public virtual void Dispose();
	}
}
