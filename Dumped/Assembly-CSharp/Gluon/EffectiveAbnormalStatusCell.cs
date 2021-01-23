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
	public class EffectiveAbnormalStatusCell : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private Image effectiveAbnormalStatusImage;
		[SerializeField]
		private UnityEngine.UI.Text effectiveAbnormalStatusText;
		[SerializeField]
		private Image effectiveAbnormalStatus;
	
		// Constructors
		public EffectiveAbnormalStatusCell();
	
		// Methods
		public bool SetContents(AbnormalStatusType type, int registAbnormalRate);
		private Material GetRegistAbnormalRate(int rate);
	}
}
