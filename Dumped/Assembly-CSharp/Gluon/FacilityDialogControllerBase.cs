/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FacilityDialogControllerBase : PopupBase
	{
		// Fields
		[SerializeField]
		protected FacilityDialogContentBase facilityDialogContentBase;
		[SerializeField]
		protected FacilityDialogContent facilityDialogContent;
		protected Facility selectedFacility;
	
		// Constructors
		public FacilityDialogControllerBase();
	
		// Methods
		public virtual bool SetContent(Facility facility, Facility nextFacility = null);
	}
}
