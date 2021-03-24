/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UnityStandardAssets.CrossPlatformInput
{
	[RequireComponent]
	public class TouchPad : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
	{
		// Fields
		public AxisOption axesToUse;
		public ControlStyle controlStyle;
		public string horizontalAxisName;
		public string verticalAxisName;
		public float Xsensitivity;
		public float Ysensitivity;
		private bool m_UseX;
		private bool m_UseY;
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;
		private bool m_Dragging;
		private int m_Id;
		private Vector2 m_PreviousTouchPos;
		private Vector3 m_Center;
		private Image m_Image;
	
		// Nested types
		public enum AxisOption
		{
			Both = 0,
			OnlyHorizontal = 1,
			OnlyVertical = 2
		}
	
		public enum ControlStyle
		{
			Absolute = 0,
			Relative = 1,
			Swipe = 2
		}
	
		// Constructors
		public TouchPad();
	
		// Methods
		private void OnEnable();
		private void Start();
		private void CreateVirtualAxes();
		private void UpdateVirtualAxes(Vector3 value);
		public void OnPointerDown(PointerEventData data);
		private void Update();
		public void OnPointerUp(PointerEventData data);
		private void OnDisable();
	}
}
