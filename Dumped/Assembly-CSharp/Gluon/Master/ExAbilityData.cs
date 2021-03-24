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
	public class ExAbilityData : IMaster<Gluon.Master.ExAbilityData>
	{
		// Fields
		[SerializeField]
		private ExAbilityDataDictionary dict;
	
		// Properties
		public ExAbilityDataDictionary Dict { get; }
		public SerializableDictionary<int, ExAbilityDataElement> List { get; }
	
		// Constructors
		public ExAbilityData();
	}
}
