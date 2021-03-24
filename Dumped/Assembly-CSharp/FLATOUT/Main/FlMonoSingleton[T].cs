/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main
{
	public abstract class FlMonoSingleton<T> : MonoBehaviour
		where T : FlMonoSingleton<T>
	{
		// Fields
		private static T _instance;
		private static bool _isQuitting;
	
		// Properties
		public static T Instance { get; }
	
		// Constructors
		protected FlMonoSingleton();
		static FlMonoSingleton();
	
		// Methods
		private void Awake();
		private void OnDestroy();
		private void SceneManagerSceneLoaded(Scene arg0, LoadSceneMode arg1);
		private void OnApplicationQuit();
		private static void _Initialize(T instance);
		private static void _Release(T instance);
		private static void _Loaded(T instance);
		public virtual void _OnInitialize();
		public virtual void _OnFinalize();
		public virtual void _OnLoaded();
		public virtual void _Boot();
	}
}
