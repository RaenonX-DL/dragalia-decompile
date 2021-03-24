/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UnityStandardAssets.CrossPlatformInput
{
	public class TiltInput : MonoBehaviour
	{
		// Fields
		public AxisMapping mapping;
		public AxisOptions tiltAroundAxis;
		public float fullTiltAngle;
		public float centreAngleOffset;
		private CrossPlatformInputManager.VirtualAxis m_SteerAxis;
	
		// Nested types
		public enum AxisOptions
		{
			ForwardAxis = 0,
			SidewaysAxis = 1
		}
	
		[Serializable]
		public class AxisMapping
		{
			// Fields
			public MappingType type;
			public string axisName;
	
			// Nested types
			public enum MappingType
			{
				NamedAxis = 0,
				MousePositionX = 1,
				MousePositionY = 2,
				MousePositionZ = 3
			}
	
			// Constructors
			public AxisMapping();
		}
	
		// Constructors
		public TiltInput();
	
		// Methods
		private void OnEnable();
		private void Update();
		private void OnDisable();
	}
}
