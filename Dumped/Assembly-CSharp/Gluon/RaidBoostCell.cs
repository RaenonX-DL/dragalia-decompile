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
	public class RaidBoostCell : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public RawImage icon;
		public UnityEngine.UI.Text itemName;
		public UnityEngine.UI.Text processText;
		public Slider slider;
		public Transform flashAttachNode;
		private RaidBoostPopup.RaidBoostModel.CellData data;
	
		// Constructors
		public RaidBoostCell();
	
		// Methods
		public void SetupByData(RaidBoostPopup.RaidBoostModel.CellData data);
		public void OnDetailButtonPressed();
	}
}
