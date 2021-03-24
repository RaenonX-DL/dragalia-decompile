/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 43: Firebase.App.dll - Assembly: Firebase.App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Firebase
{
	internal class AppUtilPINVOKE
	{
		// Fields
		protected static SWIGExceptionHelper swigExceptionHelper;
		protected static SWIGStringHelper swigStringHelper;
	
		// Nested types
		protected class SWIGExceptionHelper
		{
			// Fields
			private static ExceptionDelegate applicationDelegate;
			private static ExceptionDelegate arithmeticDelegate;
			private static ExceptionDelegate divideByZeroDelegate;
			private static ExceptionDelegate indexOutOfRangeDelegate;
			private static ExceptionDelegate invalidCastDelegate;
			private static ExceptionDelegate invalidOperationDelegate;
			private static ExceptionDelegate ioDelegate;
			private static ExceptionDelegate nullReferenceDelegate;
			private static ExceptionDelegate outOfMemoryDelegate;
			private static ExceptionDelegate overflowDelegate;
			private static ExceptionDelegate systemDelegate;
			private static ExceptionArgumentDelegate argumentDelegate;
			private static ExceptionArgumentDelegate argumentNullDelegate;
			private static ExceptionArgumentDelegate argumentOutOfRangeDelegate;
	
			// Nested types
			public delegate void ExceptionDelegate(string message);
	
			public delegate void ExceptionArgumentDelegate(string message, string paramName);
	
			// Constructors
			static SWIGExceptionHelper();
			public SWIGExceptionHelper();
	
			// Methods
			public static extern void SWIGRegisterExceptionCallbacks_AppUtil(ExceptionDelegate applicationDelegate, ExceptionDelegate arithmeticDelegate, ExceptionDelegate divideByZeroDelegate, ExceptionDelegate indexOutOfRangeDelegate, ExceptionDelegate invalidCastDelegate, ExceptionDelegate invalidOperationDelegate, ExceptionDelegate ioDelegate, ExceptionDelegate nullReferenceDelegate, ExceptionDelegate outOfMemoryDelegate, ExceptionDelegate overflowDelegate, ExceptionDelegate systemExceptionDelegate);
			public static extern void SWIGRegisterExceptionCallbacksArgument_AppUtil(ExceptionArgumentDelegate argumentDelegate, ExceptionArgumentDelegate argumentNullDelegate, ExceptionArgumentDelegate argumentOutOfRangeDelegate);
			[MonoPInvokeCallback]
			private static void SetPendingApplicationException(string message);
			[MonoPInvokeCallback]
			private static void SetPendingArithmeticException(string message);
			[MonoPInvokeCallback]
			private static void SetPendingDivideByZeroException(string message);
			[MonoPInvokeCallback]
			private static void SetPendingIndexOutOfRangeException(string message);
			[MonoPInvokeCallback]
			private static void SetPendingInvalidCastException(string message);
			[MonoPInvokeCallback]
			private static void SetPendingInvalidOperationException(string message);
			[MonoPInvokeCallback]
			private static void SetPendingIOException(string message);
			[MonoPInvokeCallback]
			private static void SetPendingNullReferenceException(string message);
			[MonoPInvokeCallback]
			private static void SetPendingOutOfMemoryException(string message);
			[MonoPInvokeCallback]
			private static void SetPendingOverflowException(string message);
			[MonoPInvokeCallback]
			private static void SetPendingSystemException(string message);
			[MonoPInvokeCallback]
			private static void SetPendingArgumentException(string message, string paramName);
			[MonoPInvokeCallback]
			private static void SetPendingArgumentNullException(string message, string paramName);
			[MonoPInvokeCallback]
			private static void SetPendingArgumentOutOfRangeException(string message, string paramName);
		}
	
		public class SWIGPendingException
		{
			// Fields
			[ThreadStatic]
			private static Exception pendingException;
			private static int numExceptionsPending;
	
			// Properties
			public static bool Pending { get; }
	
			// Constructors
			static SWIGPendingException();
	
			// Methods
			public static void Set(Exception e);
			public static Exception Retrieve();
		}
	
		protected class SWIGStringHelper
		{
			// Fields
			private static SWIGStringDelegate stringDelegate;
	
			// Nested types
			public delegate string SWIGStringDelegate(string message);
	
			// Constructors
			static SWIGStringHelper();
			public SWIGStringHelper();
	
			// Methods
			public static extern void SWIGRegisterStringCallback_AppUtil(SWIGStringDelegate stringDelegate);
			[MonoPInvokeCallback]
			private static string CreateString(string cString);
		}
	
		// Constructors
		static AppUtilPINVOKE();
	
		// Methods
		public static extern void delete_FutureBase(HandleRef jarg1);
		public static extern int FutureBase_status(HandleRef jarg1);
		public static extern int FutureBase_error(HandleRef jarg1);
		public static extern string FutureBase_error_message(HandleRef jarg1);
		public static extern IntPtr FutureVoid_SWIG_OnCompletion(HandleRef jarg1, FutureVoid.SWIG_CompletionDelegate jarg2, int jarg3);
		public static extern void FutureVoid_SWIG_FreeCompletionData(HandleRef jarg1, IntPtr jarg2);
		public static extern void delete_FutureVoid(HandleRef jarg1);
		public static extern string FirebaseApp_NameInternal_get(HandleRef jarg1);
		public static extern IntPtr FirebaseApp_CreateInternal__SWIG_0();
		internal static extern void FirebaseApp_ReleaseReferenceInternal(HandleRef jarg1);
		internal static extern int FirebaseApp_GetLogLevelInternal();
		internal static extern void FirebaseApp_RegisterLibraryInternal(string jarg1, string jarg2);
		public static extern void FirebaseApp_AppSetDefaultConfigPath(string jarg1);
		public static extern string FirebaseApp_DefaultName_get();
		public static extern void PollCallbacks();
		public static extern void AppEnableLogCallback(bool jarg1);
		public static extern void SetEnabledAllAppCallbacks(bool jarg1);
		public static extern void SetEnabledAppCallbackByName(string jarg1, bool jarg2);
		public static extern bool GetEnabledAppCallbackByName(string jarg1);
		public static extern void SetLogFunction(LogUtil.LogMessageDelegate jarg1);
		public static extern int CheckAndroidDependencies();
		public static extern IntPtr FixAndroidDependencies();
		internal static extern void InitializePlayServicesInternal();
		internal static extern void TerminatePlayServicesInternal();
		public static extern IntPtr FutureVoid_SWIGUpcast(IntPtr jarg1);
	}
}
