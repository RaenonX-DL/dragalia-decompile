/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace GooglePlayGames.Android
{
	internal class AndroidTaskUtils
	{
		// Nested types
		private class TaskOnCompleteProxy<T> : AndroidJavaProxy
		{
			// Fields
			private Action<T> mCallback;
	
			// Constructors
			public TaskOnCompleteProxy(Action<T> callback);
	
			// Methods
			public void onComplete(T result);
		}
	
		private class TaskOnSuccessProxy<T> : AndroidJavaProxy
		{
			// Fields
			private Action<T> mCallback;
			private Action<AndroidJavaObject> mCallback2;
			private bool mDisposeResult;
	
			// Constructors
			public TaskOnSuccessProxy(Action<T> callback, bool disposeResult);
	
			// Methods
			public void onSuccess(T result);
		}
	
		private class TaskOnFailedProxy : AndroidJavaProxy
		{
			// Fields
			private Action<AndroidJavaObject> mCallback;
	
			// Constructors
			public TaskOnFailedProxy(Action<AndroidJavaObject> callback);
	
			// Methods
			public void onFailure(AndroidJavaObject exception);
		}
	
		// Constructors
		private AndroidTaskUtils();
	
		// Methods
		public static void AddOnSuccessListener<T>(AndroidJavaObject task, Action<T> callback);
		public static void AddOnSuccessListener<T>(AndroidJavaObject task, bool disposeResult, Action<T> callback);
		public static void AddOnFailureListener(AndroidJavaObject task, Action<AndroidJavaObject> callback);
		public static void AddOnCompleteListener<T>(AndroidJavaObject task, Action<T> callback);
	}
}
