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
	public class MissionAlbumData : IMaster<Gluon.Master.MissionAlbumData>
	{
		// Fields
		[SerializeField]
		private MissionAlbumDataDictionary dict;
	
		// Properties
		public MissionAlbumDataDictionary Dict { get; }
		public SerializableDictionary<int, MissionAlbumDataElement> List { get; }
	
		// Constructors
		public MissionAlbumData();
	}
}
