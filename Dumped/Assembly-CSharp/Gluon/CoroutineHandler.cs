﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CoroutineHandler : MonoBehaviour
	{
		// Fields
		protected static CoroutineHandler _instance;
	
		// Properties
		public static CoroutineHandler instance { get; }
	
		// Constructors
		public CoroutineHandler();
	
		// Methods
		public static void DestoryInstance();
		public static Coroutine StartStaticCoroutine(IEnumerator coroutine);
	}
}
