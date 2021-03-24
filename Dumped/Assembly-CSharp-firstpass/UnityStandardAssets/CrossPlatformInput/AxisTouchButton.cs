/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UnityStandardAssets.CrossPlatformInput
{
	public class AxisTouchButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
	{
		// Fields
		public string axisName;
		public float axisValue;
		public float responseSpeed;
		public float returnToCentreSpeed;
		private AxisTouchButton m_PairedWith;
		private CrossPlatformInputManager.VirtualAxis m_Axis;
	
		// Constructors
		public AxisTouchButton();
	
		// Methods
		private void OnEnable();
		private void FindPairedButton();
		private void OnDisable();
		public void OnPointerDown(PointerEventData data);
		public void OnPointerUp(PointerEventData data);
	}
}
