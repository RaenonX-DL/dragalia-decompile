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
	public class GrowthManaCircleReleaseMaterialIcon : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private CommonIcon icon;
		[SerializeField]
		private Image requiredLabels;
		[SerializeField]
		private UnityEngine.UI.Text requiredNumText;
		[SerializeField]
		private Image havingLabels;
		[SerializeField]
		private UnityEngine.UI.Text havingNumText;
		[SerializeField]
		private UnityEngine.UI.Text havingText;
		[SerializeField]
		private Image tradeIcons;
		private readonly Color insufficientTextColor;
		private readonly Color insufficientRequiredColor;
		private readonly Color insufficientHavingColor;
		private readonly Color sufficientRequiredColor;
		private readonly Color sufficientHavingColor;
	
		// Constructors
		public GrowthManaCircleReleaseMaterialIcon();
	
		// Methods
		public void SetData(GrowthManaCircleManaPieceData pieceData, int requiredMP, int currentMP);
	}
}
