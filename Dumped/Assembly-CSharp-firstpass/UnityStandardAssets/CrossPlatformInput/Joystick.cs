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
	public class Joystick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
	{
		// Fields
		public int MovementRange;
		public AxisOption axesToUse;
		public string horizontalAxisName;
		public string verticalAxisName;
		private Vector3 m_StartPos;
		private bool m_UseX;
		private bool m_UseY;
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;
	
		// Nested types
		public enum AxisOption
		{
			Both = 0,
			OnlyHorizontal = 1,
			OnlyVertical = 2
		}
	
		// Constructors
		public Joystick();
	
		// Methods
		private void OnEnable();
		private void Start();
		private void UpdateVirtualAxes(Vector3 value);
		private void CreateVirtualAxes();
		public void OnDrag(PointerEventData data);
		public void OnPointerUp(PointerEventData data);
		public void OnPointerDown(PointerEventData data);
		private void OnDisable();
	}
}
