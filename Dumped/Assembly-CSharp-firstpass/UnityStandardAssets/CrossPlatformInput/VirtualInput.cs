/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UnityStandardAssets.CrossPlatformInput
{
	public abstract class VirtualInput
	{
		// Fields
		[CompilerGenerated]
		private Vector3 _virtualMousePosition_k__BackingField;
		protected Dictionary<string, CrossPlatformInputManager.VirtualAxis> m_VirtualAxes;
		protected Dictionary<string, CrossPlatformInputManager.VirtualButton> m_VirtualButtons;
		protected List<string> m_AlwaysUseVirtual;
	
		// Properties
		public Vector3 virtualMousePosition { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		protected VirtualInput();
	
		// Methods
		public bool AxisExists(string name);
		public bool ButtonExists(string name);
		public void RegisterVirtualAxis(CrossPlatformInputManager.VirtualAxis axis);
		public void RegisterVirtualButton(CrossPlatformInputManager.VirtualButton button);
		public void UnRegisterVirtualAxis(string name);
		public void UnRegisterVirtualButton(string name);
		public CrossPlatformInputManager.VirtualAxis VirtualAxisReference(string name);
		public void SetVirtualMousePositionX(float f);
		public void SetVirtualMousePositionY(float f);
		public void SetVirtualMousePositionZ(float f);
		public abstract float GetAxis(string name, bool raw);
		public abstract bool GetButton(string name);
		public abstract bool GetButtonDown(string name);
		public abstract bool GetButtonUp(string name);
		public abstract void SetButtonDown(string name);
		public abstract void SetButtonUp(string name);
		public abstract void SetAxisPositive(string name);
		public abstract void SetAxisNegative(string name);
		public abstract void SetAxisZero(string name);
		public abstract void SetAxis(string name, float value);
		public abstract Vector3 MousePosition();
	}
}
