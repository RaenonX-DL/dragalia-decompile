/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

// Image 43: Firebase.App.dll - Assembly: Firebase.App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Firebase
{
	internal class FutureVoid : FutureBase
	{
		// Fields
		private HandleRef swigCPtr;
		private static Dictionary<int, Action> Callbacks;
		private static int CallbackIndex;
		private static object CallbackLock;
		private IntPtr callbackData;
		private SWIG_CompletionDelegate SWIG_CompletionCB;
	
		// Nested types
		public delegate void Action();
	
		internal delegate void SWIG_CompletionDelegate(int index);
	
		[CompilerGenerated]
		private sealed class _GetTask_c__AnonStorey0
		{
			// Fields
			internal FutureVoid fu;
			internal TaskCompletionSource<int> tcs;
	
			// Constructors
			public _GetTask_c__AnonStorey0();
	
			// Methods
			internal void __m__0();
		}
	
		// Constructors
		internal FutureVoid(IntPtr cPtr, bool cMemoryOwn);
		static FutureVoid();
	
		// Methods
		~FutureVoid();
		public override void Dispose();
		public static Task GetTask(FutureVoid fu);
		private void ThrowIfDisposed();
		public void SetOnCompletionCallback(Action userCompletionCallback);
		private void SetCompletionData(IntPtr data);
		[MonoPInvokeCallback]
		private static void SWIG_CompletionDispatcher(int key);
		internal IntPtr SWIG_OnCompletion(SWIG_CompletionDelegate cs_callback, int cs_key);
		public void SWIG_FreeCompletionData(IntPtr data);
	}
}
