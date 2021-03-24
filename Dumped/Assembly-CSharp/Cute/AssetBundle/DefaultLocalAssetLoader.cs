/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.AssetBundle
{
	public class DefaultLocalAssetLoader : ILocalAssetLoader
	{
		// Nested types
		[CompilerGenerated]
		private sealed class _LoadAsyncCoroutine_d__4<T> : IEnumerator<object>
			where T : UnityEngine.Object
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public string assetName;
			public Action<T> onLoaded;
			private ResourceRequest _request_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadAsyncCoroutine_d__4(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _UnloadAllAssets_d__7 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _UnloadAllAssets_d__7(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _LoadAsyncCoroutine_d__11<T> : IEnumerator<object>
			where T : UnityEngine.Object
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public string assetName;
			public Action<bool, T> onLoaded;
			private ResourceRequest _request_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadAsyncCoroutine_d__11(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public DefaultLocalAssetLoader();
	
		// Methods
		public virtual T Load<T>(string assetName, int generation)
			where T : UnityEngine.Object;
		public virtual UnityEngine.Object[] LoadAllAssets(string assetBundleName, int generation);
		public virtual void LoadScene(string assetName, int generation);
		public virtual void LoadAsync<T>(string assetName, Action<T> onLoaded, int generation)
			where T : UnityEngine.Object;
		[IteratorStateMachine]
		protected virtual IEnumerator LoadAsyncCoroutine<T>(string assetName, Action<T> onLoaded)
			where T : UnityEngine.Object;
		public virtual void LoadAsync<T>(string assetName, Action<bool, T> onLoaded, int generation)
			where T : UnityEngine.Object;
		public virtual void LoadSceneAsync(string assetName, Action<bool> onFinished, int generation);
		[IteratorStateMachine]
		public virtual IEnumerator UnloadAllAssets(int generation);
		public virtual void Unload(string assetName);
		public virtual string GetRawAssetPath(string filename, out bool isPrein);
		public virtual bool Exists(string assetName);
		[IteratorStateMachine]
		protected virtual IEnumerator LoadAsyncCoroutine<T>(string assetName, Action<bool, T> onLoaded)
			where T : UnityEngine.Object;
		protected static bool ExistsScene(string assetName);
		protected static string MakeScenePath(string assetName);
	}
}
