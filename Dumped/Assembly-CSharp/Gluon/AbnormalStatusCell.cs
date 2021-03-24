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
	public class AbnormalStatusCell : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private Image abnormalStatusImage;
		[SerializeField]
		private UnityEngine.UI.Text abnormalStatusText;
	
		// Constructors
		public AbnormalStatusCell();
	
		// Methods
		public bool SetContents(AbnormalStatusType type);
	}
}
