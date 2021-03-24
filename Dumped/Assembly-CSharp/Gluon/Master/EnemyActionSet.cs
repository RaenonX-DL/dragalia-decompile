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
	public class EnemyActionSet : IMaster<Gluon.Master.EnemyActionSet>
	{
		// Fields
		[SerializeField]
		private EnemyActionSetDictionary dict;
	
		// Properties
		public EnemyActionSetDictionary Dict { get; }
		public SerializableDictionary<int, EnemyActionSetElement> List { get; }
	
		// Constructors
		public EnemyActionSet();
	}
}
