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
	public class UserLevel : IMaster<Gluon.Master.UserLevel>
	{
		// Fields
		[SerializeField]
		private UserLevelDictionary dict;
	
		// Properties
		public UserLevelDictionary Dict { get; }
		public SerializableDictionary<int, UserLevelElement> List { get; }
	
		// Constructors
		public UserLevel();
	}
}
