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
	public class GimmickAreaTrap : IMaster<Gluon.Master.GimmickAreaTrap>
	{
		// Fields
		[SerializeField]
		private GimmickAreaTrapDictionary dict;
	
		// Properties
		public GimmickAreaTrapDictionary Dict { get; }
		public SerializableDictionary<string, GimmickAreaTrapElement> List { get; }
	
		// Constructors
		public GimmickAreaTrap();
	}
}
