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
	public class TotalDamageEventHistoryCell : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text totalDamageValueText;
		[SerializeField]
		private UnityEngine.UI.Text dateText;
		[SerializeField]
		private GameObject movingObject;
		[SerializeField]
		private SimpleAnimationCell animationCell;
		private static readonly int aggregatePeriodDays;
	
		// Constructors
		public TotalDamageEventHistoryCell();
		static TotalDamageEventHistoryCell();
	
		// Methods
		public void Setup(long totalDamage, long dateTime);
		public void SetupAnimation(int delayIndex);
	}
}
