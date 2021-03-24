/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class GameInterface
{
	// Fields
	public static GameInterface Instance;
	public static string EnvironmentRootName;
	public static Dictionary<string, string> ObjectNames;
	public static Dictionary<string, double> VisiblePercentages;
	public Dictionary<string, GameObject> KeyNodes;
	public List<Renderer> DisabledRenderers;
	public List<ParticleSystemRenderer> DisabledParticleSystems;

	// Constructors
	public GameInterface();
	static GameInterface();

	// Methods
	public bool Init();
	public void ToggleSwitch(string name, bool on);
	public void ChangePercentage(string name, double val);
	private void DoFilter<T>(List<T> visible, List<T> disabled, float percentage)
		where T : Renderer;
	private bool IsEnvironmentObject(GameObject go);
	public void FilterVisibleObjects(float percentage, float psysPercent);
}

