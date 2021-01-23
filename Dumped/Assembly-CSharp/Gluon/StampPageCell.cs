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
	public class StampPageCell : MonoBehaviour
	{
		// Fields
		public UnityEngine.UI.Text stampName;
		public GameObject iconsObject;
		[SerializeField]
		public StampPageButtonEvent buttonPressed;
		[SerializeField]
		public StampPageButtonEvent buttonLongPressed;
		private StampPageIcon[] pageIcons;
	
		// Constructors
		public StampPageCell();
	
		// Methods
		private void Awake();
		public void UpdateContent(StampPageData data);
		public void OnButtonPressed(int iconIndex);
		public void OnButtonLongPressed(int iconIndex);
	}
}
