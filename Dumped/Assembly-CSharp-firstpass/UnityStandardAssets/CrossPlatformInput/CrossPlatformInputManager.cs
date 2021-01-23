/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UnityStandardAssets.CrossPlatformInput
{
	public static class CrossPlatformInputManager
	{
		// Fields
		private static VirtualInput activeInput;
		private static VirtualInput s_TouchInput;
		private static VirtualInput s_HardwareInput;
	
		// Properties
		public static Vector3 mousePosition { get; }
	
		// Nested types
		public enum ActiveInputMethod
		{
			Hardware = 0,
			Touch = 1
		}
	
		public class VirtualAxis
		{
			// Fields
			[CompilerGenerated]
			private string _name_k__BackingField;
			private float m_Value;
			[CompilerGenerated]
			private bool _matchWithInputManager_k__BackingField;
	
			// Properties
			public string name { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public bool matchWithInputManager { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public float GetValue { get; }
			public float GetValueRaw { get; }
	
			// Constructors
			public VirtualAxis(string name);
			public VirtualAxis(string name, bool matchToInputSettings);
	
			// Methods
			public void Remove();
			public void Update(float value);
		}
	
		public class VirtualButton
		{
			// Fields
			[CompilerGenerated]
			private string _name_k__BackingField;
			[CompilerGenerated]
			private bool _matchWithInputManager_k__BackingField;
			private int m_LastPressedFrame;
			private int m_ReleasedFrame;
			private bool m_Pressed;
	
			// Properties
			public string name { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public bool matchWithInputManager { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public bool GetButton { get; }
			public bool GetButtonDown { get; }
			public bool GetButtonUp { get; }
	
			// Constructors
			public VirtualButton(string name);
			public VirtualButton(string name, bool matchToInputSettings);
	
			// Methods
			public void Pressed();
			public void Released();
			public void Remove();
		}
	
		// Constructors
		static CrossPlatformInputManager();
	
		// Methods
		public static void SwitchActiveInputMethod(ActiveInputMethod activeInputMethod);
		public static bool AxisExists(string name);
		public static bool ButtonExists(string name);
		public static void RegisterVirtualAxis(VirtualAxis axis);
		public static void RegisterVirtualButton(VirtualButton button);
		public static void UnRegisterVirtualAxis(string name);
		public static void UnRegisterVirtualButton(string name);
		public static VirtualAxis VirtualAxisReference(string name);
		public static float GetAxis(string name);
		public static float GetAxisRaw(string name);
		private static float GetAxis(string name, bool raw);
		public static bool GetButton(string name);
		public static bool GetButtonDown(string name);
		public static bool GetButtonUp(string name);
		public static void SetButtonDown(string name);
		public static void SetButtonUp(string name);
		public static void SetAxisPositive(string name);
		public static void SetAxisNegative(string name);
		public static void SetAxisZero(string name);
		public static void SetAxis(string name, float value);
		public static void SetVirtualMousePositionX(float f);
		public static void SetVirtualMousePositionY(float f);
		public static void SetVirtualMousePositionZ(float f);
	}
}
