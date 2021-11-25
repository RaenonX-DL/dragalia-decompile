using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

namespace Gluon
{
	public class FacilityCellBase : FastUpdateMonoBehaviour
	{
		[SerializeField]
		protected GameObject iconNew;

		public Facility facility
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void SetNewIcon(bool isNew)
		{
		}

		public virtual bool IsNew()
		{
			return default(bool);
		}

		public virtual List<Facility> GetNewFacilityList()
		{
			return null;
		}
	}
}
