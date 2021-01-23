/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CommonSortButton : MonoBehaviour
	{
		// Fields
		[SerializeField]
		public UnityEngine.UI.Text filterOnOffText;
		public UnityEngine.UI.Text sortTypeText;
		public GameObject upwardImageGO;
		public GameObject downwardImageGO;
		public GameObject filterLineGO;
		public GameObject sortLineGO;
		public UnityEvent onButtonPressed;
		[SerializeField]
		private Transform filterColonTransform;
		[SerializeField]
		private Transform sortColonTransform;
	
		// Constructors
		public CommonSortButton();
	
		// Methods
		public void OnButtonPressed();
		public void DisableFilter();
		public void DisableSort();
		public void SetSortButtonDisplayText(bool isFilterOn, string orderText, bool isAscending);
		public void UpdateSortColonText();
	}
}
