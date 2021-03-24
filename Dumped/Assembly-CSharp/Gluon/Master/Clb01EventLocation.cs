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
	[Serializable]
	public class Clb01EventLocation : IMasterGroupElement
	{
		// Fields
		[SerializeField]
		private Clb01EventLocationDictionary dict;
	
		// Properties
		public Clb01EventLocationDictionary Dict { get; }
		public SerializableDictionary<int, Clb01EventLocationElement> List { get; }
	
		// Constructors
		public Clb01EventLocation();
	}
}
