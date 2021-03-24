/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SerializableCollections;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Master
{
	public abstract class IMasterGroup<T, U, E> : IMasterGroupBase
		where T : IMasterGroupElement, new()
		where U : IMasterGroupBase, new()
		where E : SerializableDictionary<int, T>, new()
	{
		// Fields
		private static U instance;
		[SerializeField]
		private E dict;
	
		// Properties
		public static U Instance { get; private set; }
	
		// Constructors
		protected IMasterGroup();
	
		// Methods
		public T Get(int id);
		public List<int> GetIdList();
		public List<T> GetAllInstances();
		protected virtual void OnEnable();
		public static void Clear();
	}
}
