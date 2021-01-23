/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class utest : IDisposable
{
	// Fields
	public bool m_enable;
	public float m_renderOrdinaryPercentage;
	public float m_renderParticlePercentage;

	// Nested types
	public class FontSetter : IDisposable
	{
		// Fields
		private int m_oldSize;

		// Constructors
		public FontSetter();

		// Methods
		public void Dispose();
	}

	// Constructors
	public utest();

	// Methods
	public void Dispose();
	public void OnLevelWasLoaded();
	public void OnGUI();
	private bool Gui_ShowCloseButton();
	private void Gui_ShowToggles();
	private void Gui_ShowLogs();
	private bool Gui_ChangeByPercentSlider(ref float percentage, int disabledCount);
}

