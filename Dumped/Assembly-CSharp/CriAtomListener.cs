/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

[AddComponentMenu]
public class CriAtomListener : MonoBehaviour
{
	// Fields
	[CompilerGenerated]
	private static CriAtomListener _activeListener_k__BackingField;
	[CompilerGenerated]
	private static CriAtomEx3dListener _sharedNativeListener_k__BackingField;
	public bool activateListenerOnEnable;
	private Vector3 lastPosition;

	// Properties
	public static CriAtomListener activeListener { [CompilerGenerated] get; [CompilerGenerated] private set; }
	public static CriAtomEx3dListener sharedNativeListener { [CompilerGenerated] get; [CompilerGenerated] private set; }

	// Constructors
	public CriAtomListener();

	// Methods
	public static void CreateSharedNativeListener();
	public static void DestroySharedNativeListener();
	private void OnEnable();
	private void OnDisable();
	private void LateUpdate();
	public void ActivateListener();
}

