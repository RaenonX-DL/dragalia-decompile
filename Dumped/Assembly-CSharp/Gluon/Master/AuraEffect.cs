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
	public class AuraEffect : IMaster<Gluon.Master.AuraEffect>
	{
		// Fields
		[SerializeField]
		private AuraEffectDictionary dict;
	
		// Properties
		public AuraEffectDictionary Dict { get; }
		public SerializableDictionary<int, AuraEffectElement> List { get; }
	
		// Constructors
		public AuraEffect();
	}
}
