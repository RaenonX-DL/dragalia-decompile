/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.AssetBundle
{
	public class DefaultLocalAssetLoader : ILocalAssetLoader
	{
		// Nested types
		[CompilerGenerated]
		private sealed class _LoadAsyncCoroutine_d__7 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public string path;
			public Action<UnityEngine.Object> onLoaded;
			private ResourceRequest _request_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadAsyncCoroutine_d__7(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _LoadAsyncCoroutine_d__8<T> : IEnumerator<object>
			where T : UnityEngine.Object
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public string path;
			public Action<T> onLoaded;
			private ResourceRequest _request_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadAsyncCoroutine_d__8(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _LoadAsyncCoroutine_d__12 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public string path;
			public Action<bool, UnityEngine.Object> onLoaded;
			private ResourceRequest _request_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadAsyncCoroutine_d__12(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _LoadAsyncCoroutine_d__13<T> : IEnumerator<object>
			where T : UnityEngine.Object
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public string path;
			public Action<bool, T> onLoaded;
			private ResourceRequest _request_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadAsyncCoroutine_d__13(int __1__state);
	
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
		public UnityEngine.Object Load(string path);
		public T Load<T>(string path)
			where T : UnityEngine.Object;
		public T LoadAssetWithName<T>(string path, string name)
			where T : UnityEngine.Object;
		public UnityEngine.Object[] LoadAssetWithSubAssets(string path);
		public void LoadAsync(string path, Action<UnityEngine.Object> onLoaded);
		public void LoadAsync<T>(string path, Action<T> onLoaded)
			where T : UnityEngine.Object;
		public void LoadAssetWithNameAsync<T>(string path, string name, Action<T> onLoaded)
			where T : UnityEngine.Object;
		[IteratorStateMachine]
		private IEnumerator LoadAsyncCoroutine(string path, Action<UnityEngine.Object> onLoaded);
		[IteratorStateMachine]
		private IEnumerator LoadAsyncCoroutine<T>(string path, Action<T> onLoaded)
			where T : UnityEngine.Object;
		public void LoadAsync(string path, Action<bool, UnityEngine.Object> onLoaded);
		public void LoadAsync<T>(string path, Action<bool, T> onLoaded)
			where T : UnityEngine.Object;
		public void LoadAssetWithNameAsync<T>(string path, string name, Action<bool, T> onLoaded)
			where T : UnityEngine.Object;
		[IteratorStateMachine]
		private IEnumerator LoadAsyncCoroutine(string path, Action<bool, UnityEngine.Object> onLoaded);
		[IteratorStateMachine]
		private IEnumerator LoadAsyncCoroutine<T>(string path, Action<bool, T> onLoaded)
			where T : UnityEngine.Object;
	}
}
