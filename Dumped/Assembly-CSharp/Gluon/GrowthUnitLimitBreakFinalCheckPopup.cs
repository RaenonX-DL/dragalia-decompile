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
	public class GrowthUnitLimitBreakFinalCheckPopup : CommonPopup
	{
		// Fields
		public GameObject originCell;
		public Transform cellParentTransform;
		public GameObject materialScrollObject;
		public GameObject dewUIObject;
		public UnityEngine.UI.Text needDewText;
		public UnityEngine.UI.Text beforeDewText;
		public UnityEngine.UI.Text afterDewText;
		public GameObject rupiUIObject;
		public UnityEngine.UI.Text needRupiText;
		public UnityEngine.UI.Text beforeRupiText;
		public UnityEngine.UI.Text afterRupiText;
		public GameObject[] itemBaseObjects;
		public Image itemIcon;
		public UnityEngine.UI.Text beforeReleaseCount;
		public UnityEngine.UI.Text afterReleaseCount;
	
		// Constructors
		public GrowthUnitLimitBreakFinalCheckPopup();
	
		// Methods
		public static GrowthUnitLimitBreakFinalCheckPopup Create();
		public void InitPopup(GrowthUnitEnhanceModel model, int limitBreakCount, int useItemCount);
	}
}
