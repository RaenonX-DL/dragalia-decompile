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
	public class LoginBonusData : IMaster<Gluon.Master.LoginBonusData>
	{
		// Fields
		[SerializeField]
		private LoginBonusDataDictionary dict;
	
		// Properties
		public LoginBonusDataDictionary Dict { get; }
		public SerializableDictionary<int, LoginBonusDataElement> List { get; }
	
		// Constructors
		public LoginBonusData();
	}
}
