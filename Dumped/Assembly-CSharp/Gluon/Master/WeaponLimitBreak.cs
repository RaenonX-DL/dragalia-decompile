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
	public class WeaponLimitBreak : IMaster<Gluon.Master.WeaponLimitBreak>
	{
		// Fields
		[SerializeField]
		private WeaponLimitBreakDictionary dict;
	
		// Properties
		public WeaponLimitBreakDictionary Dict { get; }
		public SerializableDictionary<int, WeaponLimitBreakElement> List { get; }
	
		// Constructors
		public WeaponLimitBreak();
	}
}
