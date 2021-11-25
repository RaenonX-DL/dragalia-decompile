using System;
using UnityEngine;

namespace GooglePlayGames.Android
{
	internal class AndroidTaskUtils
	{
		private class TaskOnCompleteProxy<T> : AndroidJavaProxy
		{
			private Action<T> mCallback;

			public TaskOnCompleteProxy(Action<T> callback)
			{
			}

			public void onComplete(T result)
			{
			}
		}

		private class TaskOnSuccessProxy<T> : AndroidJavaProxy
		{
			private Action<T> mCallback;

			private Action<AndroidJavaObject> mCallback2;

			private bool mDisposeResult;

			public TaskOnSuccessProxy(Action<T> callback, bool disposeResult)
			{
			}

			public void onSuccess(T result)
			{
			}
		}

		private class TaskOnFailedProxy : AndroidJavaProxy
		{
			private Action<AndroidJavaObject> mCallback;

			public TaskOnFailedProxy(Action<AndroidJavaObject> callback)
			{
			}

			public void onFailure(AndroidJavaObject exception)
			{
			}
		}

		private AndroidTaskUtils()
		{
		}

		public static void AddOnSuccessListener<T>(AndroidJavaObject task, Action<T> callback)
		{
		}

		public static void AddOnSuccessListener<T>(AndroidJavaObject task, bool disposeResult, Action<T> callback)
		{
		}

		public static void AddOnFailureListener(AndroidJavaObject task, Action<AndroidJavaObject> callback)
		{
		}

		public static void AddOnCompleteListener<T>(AndroidJavaObject task, Action<T> callback)
		{
		}
	}
}
