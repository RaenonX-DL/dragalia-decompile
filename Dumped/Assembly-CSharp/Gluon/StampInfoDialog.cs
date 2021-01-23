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
	public class StampInfoDialog : MonoBehaviour
	{
		// Fields
		public Image stampImage;
		public UnityEngine.UI.Text stampName;
		public UnityEngine.UI.Text stampInfo;
		public Button okButton;
		public Button closeButton;
	
		// Constructors
		public StampInfoDialog();
	
		// Methods
		public void SetupDialog(int stampId, UnityAction closeAction);
	}
}
