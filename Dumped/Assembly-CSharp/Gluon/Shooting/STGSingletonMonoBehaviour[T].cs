/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Shooting
{
	public abstract class STGSingletonMonoBehaviour<T> : MonoBehaviour
		where T : MonoBehaviour
	{
		// Fields
		private static T instance;
	
		// Properties
		public static T Instance { get; }
	
		// Constructors
		protected STGSingletonMonoBehaviour();
	
		// Methods
		protected virtual void Awake();
	}
}
