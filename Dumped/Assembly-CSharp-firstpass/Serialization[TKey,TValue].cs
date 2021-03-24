/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

[Serializable]
public class Serialization<TKey, TValue> : ISerializationCallbackReceiver
{
	// Fields
	[SerializeField]
	private List<TKey> keys;
	[SerializeField]
	private List<TValue> values;
	private Dictionary<TKey, TValue> target;

	// Constructors
	public Serialization(Dictionary<TKey, TValue> target);

	// Methods
	public Dictionary<TKey, TValue> ToDictionary();
	public void OnBeforeSerialize();
	public void OnAfterDeserialize();
}

