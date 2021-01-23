/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class CriAfxMcDspInitializer : MonoBehaviour
{
	// Fields
	private const string scriptVersionString = "1.00.00";
	private const int scriptVersionNumber = 16777216;
	public const string pluginName = "criafx_mcdsp";

	// Constructors
	public CriAfxMcDspInitializer();

	// Methods
	private void Awake();
	public static void AddInterfaces();
	private static extern IntPtr criAfxMcDSPAE600_GetInterfaceWithVersion();
	private static extern IntPtr criAfxMcDSPFutzBox_GetInterfaceWithVersion();
	private static extern IntPtr criAfxMcDSPML4000ML1_GetInterfaceWithVersion();
	private static extern IntPtr criAfxMcDSPSA2_GetInterfaceWithVersion();
}

