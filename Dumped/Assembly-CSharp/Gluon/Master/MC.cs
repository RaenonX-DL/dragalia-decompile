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
	public class MC : IMasterGroupElement
	{
		// Fields
		[SerializeField]
		private MCDictionary dict;
	
		// Properties
		public MCDictionary Dict { get; }
		public SerializableDictionary<int, MCElement> List { get; }
	
		// Constructors
		public MC();
	}
}
