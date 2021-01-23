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

namespace Cute.Core
{
	public class UpdateDispatcher : MonoBehaviour
	{
		// Fields
		private const int startListCount = 16;
		private static UpdateDispatcher instance;
		private IUpdatable[] list;
		private int tail;
		private static bool isQuit;
		private Dictionary<IUpdatable, int> indexList;
		private bool dirty;
	
		// Properties
		private static UpdateDispatcher Instance { get; }
	
		// Constructors
		public UpdateDispatcher();
		static UpdateDispatcher();
	
		// Methods
		private void Update();
		private void OnApplicationQuit();
		public static void AddItem(IUpdatable item);
		private void AddItemInternal(IUpdatable item);
		public static void RemoveItem(IUpdatable item);
		private void RemoveItemInternal(IUpdatable item);
		public static new Coroutine StartCoroutine(IEnumerator coroutine);
		public static new void StopCoroutine(Coroutine coroutine);
	}
}
