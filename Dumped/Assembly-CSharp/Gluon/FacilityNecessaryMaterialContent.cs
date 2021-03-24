/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FacilityNecessaryMaterialContent : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private IconWithCountLabel[] iconWithLabels;
		[SerializeField]
		private UnityEngine.UI.Text currentMoneyLabel;
		[SerializeField]
		private UnityEngine.UI.Text leftMoneyLabel;
	
		// Constructors
		public FacilityNecessaryMaterialContent();
	
		// Methods
		public void SetIconWithLabel(Facility facility);
		public void SetCurrentMoney(long value);
		public void SetLeftMoney(long value);
	}
}
