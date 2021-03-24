/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EventAbilityCell : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private Image icon;
		[SerializeField]
		private UnityEngine.UI.Text nameText;
		private int dataId;
	
		// Constructors
		public EventAbilityCell();
	
		// Methods
		public void SetAbilityInfo(AbilityDataElement ade);
		public void OnCellPressed();
	}
}
