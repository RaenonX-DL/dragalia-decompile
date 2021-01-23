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
	public class Badge : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text numText;
		[SerializeField]
		private Image bgImage;
		[SerializeField]
		private Image alertImage;
		[SerializeField]
		public int maxNumber;
		[SerializeField]
		public bool showPlusOverMax;
		public CircleOutline outline;
		private Color normalOutlineColor;
		private Color normalTextColor;
		private Color disabledOutlineColor;
		private Color disabledTextColor;
	
		// Constructors
		public Badge();
	
		// Methods
		private void Awake();
		public void SetNumber(int number);
		public void SetMark(bool visible);
		public void SetEnabled(bool enabled);
	}
}
