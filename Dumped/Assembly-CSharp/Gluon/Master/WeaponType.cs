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
	public class WeaponType : IMaster<Gluon.Master.WeaponType>
	{
		// Fields
		[SerializeField]
		private WeaponTypeDictionary dict;
	
		// Properties
		public WeaponTypeDictionary Dict { get; }
		public SerializableDictionary<int, WeaponTypeElement> List { get; }
	
		// Constructors
		public WeaponType();
	}
}
