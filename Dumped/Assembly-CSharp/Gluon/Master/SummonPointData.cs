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
	public class SummonPointData : IMaster<Gluon.Master.SummonPointData>
	{
		// Fields
		[SerializeField]
		private SummonPointDataDictionary dict;
	
		// Properties
		public SummonPointDataDictionary Dict { get; }
		public SerializableDictionary<int, SummonPointDataElement> List { get; }
	
		// Constructors
		public SummonPointData();
	}
}
