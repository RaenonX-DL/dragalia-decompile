/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using SerializableCollections;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	public class FortAreaMap : IMaster<Gluon.Master.FortAreaMap>
	{
		// Fields
		[SerializeField]
		private FortAreaMapDictionary dict;
	
		// Properties
		public FortAreaMapDictionary Dict { get; }
		public SerializableDictionary<int, FortAreaMapElement> List { get; }
	
		// Constructors
		public FortAreaMap();
	}
}
