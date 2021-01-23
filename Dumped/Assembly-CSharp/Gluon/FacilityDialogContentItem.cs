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
	public class FacilityDialogContentItem : MonoBehaviour
	{
		// Fields
		[SerializeField]
		protected UnityEngine.UI.Text titleLabel;
		[SerializeField]
		private UnityEngine.UI.Text valueLabel;
		[SerializeField]
		protected UnityEngine.UI.Text valueNextLevelLabel;
		[SerializeField]
		protected Color nextLevelColor;
	
		// Constructors
		public FacilityDialogContentItem();
	
		// Methods
		public void SetContent(string title, string value, string valueNextLevel = "", bool isValueUp = true);
	}
}
