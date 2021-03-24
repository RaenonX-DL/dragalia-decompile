/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using SerializableCollections;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	public class AbilityCrest : IMaster<Gluon.Master.AbilityCrest>
	{
		// Fields
		[SerializeField]
		private AbilityCrestDictionary dict;
	
		// Properties
		public AbilityCrestDictionary Dict { get; }
		public SerializableDictionary<int, AbilityCrestElement> List { get; }
	
		// Constructors
		public AbilityCrest();
	}
}
