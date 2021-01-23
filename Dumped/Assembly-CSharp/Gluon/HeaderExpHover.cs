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
	public class HeaderExpHover : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text nextExpText;
		[SerializeField]
		private UnityEngine.UI.Text nextStaminaText;
		[SerializeField]
		private UnityEngine.UI.Text nextCPText;
		[SerializeField]
		private UnityEngine.UI.Text nextExpNum;
		[SerializeField]
		private UnityEngine.UI.Text nextStaminaNum;
		[SerializeField]
		private UnityEngine.UI.Text nextCPNum;
	
		// Constructors
		public HeaderExpHover();
	
		// Methods
		private void Start();
		public void Update();
		public void Reload();
		public void LoadExpData();
		public void LoadStaminaData();
	}
}
