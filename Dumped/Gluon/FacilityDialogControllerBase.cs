using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon
{
	public class FacilityDialogControllerBase : PopupBase
	{
		[SerializeField]
		protected FacilityDialogContentBase facilityDialogContentBase;

		[SerializeField]
		protected FacilityDialogContent facilityDialogContent;

		protected Facility selectedFacility;

		public virtual bool SetContent(Facility facility, [Optional] Facility nextFacility)
		{
			return default(bool);
		}
	}
}
