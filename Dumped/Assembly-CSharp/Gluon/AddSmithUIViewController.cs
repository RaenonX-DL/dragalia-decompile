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
	public class AddSmithUIViewController : FortLeftSideUIViewController
	{
		// Fields
		[SerializeField]
		private Button addButton;
		[SerializeField]
		private UnityEngine.UI.Text text;
		private FortModel model;
	
		// Constructors
		public AddSmithUIViewController();
	
		// Methods
		protected virtual void Awake();
		public void UpdateContent();
		public void SetButtonEnable(bool flag);
	}
}
