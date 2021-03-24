/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FortBuildGaugeController : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text text;
		[SerializeField]
		public Slider slider;
		private Image[] images;
		private StringBuilder strBuilder;
	
		// Nested types
		public delegate void GaugeChangeDelegate();
	
		// Constructors
		public FortBuildGaugeController();
	
		// Methods
		private void Awake();
		public void Disp(bool flag);
		public void SetRestTime(Facility facility);
		public void SetMaxIncomeRestTime(FacilityViewController facilityVC);
	}
}
