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
	public class Clb01EventItem : IMaster<Gluon.Master.Clb01EventItem>
	{
		// Fields
		[SerializeField]
		private Clb01EventItemDictionary dict;
	
		// Properties
		public Clb01EventItemDictionary Dict { get; }
		public SerializableDictionary<int, Clb01EventItemElement> List { get; }
	
		// Constructors
		public Clb01EventItem();
	}
}
