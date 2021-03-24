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
	public class MyPageBGM : IMaster<Gluon.Master.MyPageBGM>
	{
		// Fields
		[SerializeField]
		private MyPageBGMDictionary dict;
	
		// Properties
		public MyPageBGMDictionary Dict { get; }
		public SerializableDictionary<int, MyPageBGMElement> List { get; }
	
		// Constructors
		public MyPageBGM();
	}
}
