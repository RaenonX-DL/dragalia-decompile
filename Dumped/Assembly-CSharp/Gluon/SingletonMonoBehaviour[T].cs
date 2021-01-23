/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SingletonMonoBehaviour<T> : MonoBehaviour
		where T : MonoBehaviour
	{
		// Fields
		private static T _instance;
		protected bool _isRedy;
	
		// Properties
		public static T instance { get; }
		public bool isRedy { get; }
	
		// Constructors
		public SingletonMonoBehaviour();
		static SingletonMonoBehaviour();
	
		// Methods
		public static void CreateInstance();
		public static bool IsInstanceEmpty();
		protected virtual void Awake();
		protected virtual void OnDestroy();
	}
}
