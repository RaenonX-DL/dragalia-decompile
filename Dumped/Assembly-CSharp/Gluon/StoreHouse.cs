/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class StoreHouse
	{
		// Fields
		private List<StoreHouseFacility> _storedFacilities;
	
		// Properties
		public List<StoreHouseFacility> storedFacilities { get; }
	
		// Nested types
		public class StoreHouseFacility
		{
			// Fields
			public int facilityId;
			public List<Facility> facilities;
	
			// Nested types
			[Serializable]
			[CompilerGenerated]
			private sealed class __c
			{
				// Fields
				public static readonly __c __9;
				public static Predicate<Facility> __9__2_0;
	
				// Constructors
				static __c();
				public __c();
	
				// Methods
				internal bool _IsNew_b__2_0(Facility facility);
			}
	
			// Constructors
			public StoreHouseFacility();
	
			// Methods
			public bool IsNew();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0
		{
			// Fields
			public Facility facility;
	
			// Constructors
			public __c__DisplayClass11_0();
	
			// Methods
			internal bool _AddFacility_b__0(StoreHouseFacility storedFacility);
		}
	
		// Constructors
		public StoreHouse();
	
		// Methods
		public void ClearAll();
		public int GetAllFacilityCount();
		public int GetFacilityCount(int plantId);
		public int GetFacilityCount(FortPlantType type);
		public void RemoveFacility(Facility facility);
		public int GetFacilityTotalLevel();
		public List<StoreHouseFacility> GetFacilityList(FortMenuGroupType type);
		public void AddFacility(Facility facility);
		public bool HasNewFacility(FortMenuGroupType groupType);
		public void SetNewFlag(ulong buildId, bool isNew);
	}
}
