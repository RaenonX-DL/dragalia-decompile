/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FacilityDialogContentBase : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private Image icon;
		[SerializeField]
		private UnityEngine.UI.Text title;
		[SerializeField]
		private UnityEngine.UI.Text level;
		[SerializeField]
		private UnityEngine.UI.Text afterLevel;
		[SerializeField]
		private UnityEngine.UI.Text description;
		[SerializeField]
		private float offsetY;
	
		// Constructors
		public FacilityDialogContentBase();
	
		// Methods
		public void SetContent(Facility facility, Facility nextFacility = null);
		public void SetContent(Facility facility, string titleStr, int levelValue, string descriptionStr);
	}
}
