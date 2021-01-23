/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[Serializable]
	public class FacilitySaveData
	{
		// Fields
		public int fortLevel;
		[CompilerGenerated]
		private List<FacilitySerialized> _facilities_k__BackingField;
		[CompilerGenerated]
		private List<FacilitySerialized> _facilitiesInStoreHouse_k__BackingField;
	
		// Properties
		public List<FacilitySerialized> facilities { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public List<FacilitySerialized> facilitiesInStoreHouse { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public FacilitySaveData();
	
		// Methods
		public string GetJson();
		public void AddFacility(Facility facility, Vector3 position, bool isStoreHouse = false);
	}
}
