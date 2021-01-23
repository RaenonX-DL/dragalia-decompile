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
	public class WeaponBodyRarity : IMaster<Gluon.Master.WeaponBodyRarity>
	{
		// Fields
		[SerializeField]
		private WeaponBodyRarityDictionary dict;
	
		// Properties
		public WeaponBodyRarityDictionary Dict { get; }
		public SerializableDictionary<int, WeaponBodyRarityElement> List { get; }
	
		// Constructors
		public WeaponBodyRarity();
	}
}
