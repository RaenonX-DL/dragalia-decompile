using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	[Serializable]
	public class FacilitySaveData
	{
		public int fortLevel;

		public List<FacilitySerialized> facilities
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public List<FacilitySerialized> facilitiesInStoreHouse
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string GetJson()
		{
			return null;
		}

		public void AddFacility(Facility facility, Vector3 position, bool isStoreHouse = false)
		{
		}
	}
}
