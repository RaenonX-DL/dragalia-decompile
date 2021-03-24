/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ChargeMarkerManager : SingletonMonoBehaviour<Gluon.ChargeMarkerManager>
	{
		// Fields
		private List<ChargeMarker> _markers;
		private static PrefabData[] _markerPrefabs;
	
		// Properties
		public List<ChargeMarker> MarkerList { get; }
		public int GetActiveMarkerNum { get; }
	
		// Nested types
		private struct PrefabData
		{
			// Fields
			public static readonly string prefabPath;
			public string path;
			public int poolCount;
	
			// Constructors
			static PrefabData();
		}
	
		// Constructors
		public ChargeMarkerManager();
		static ChargeMarkerManager();
	
		// Methods
		private void Start();
		public ChargeMarker CreateMarker(ChargeMarker.eType type);
		public bool IsTargetedByMarker(GameObject obj);
	}
}
