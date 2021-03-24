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
	public class CharaUniqueCombo : IMaster<Gluon.Master.CharaUniqueCombo>
	{
		// Fields
		[SerializeField]
		private CharaUniqueComboDictionary dict;
	
		// Properties
		public CharaUniqueComboDictionary Dict { get; }
		public SerializableDictionary<int, CharaUniqueComboElement> List { get; }
	
		// Constructors
		public CharaUniqueCombo();
	}
}
