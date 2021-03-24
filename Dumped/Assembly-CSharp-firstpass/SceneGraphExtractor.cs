/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class SceneGraphExtractor
{
	// Fields
	public UnityEngine.Object m_root;
	public List<int> GameObjectIDs;
	public static List<string> MemCategories;
	public static AdditionalMemObjectExtractor UIWidgetExtractor;
	public Dictionary<string, List<int>> MemObjectIDs;

	// Constructors
	public SceneGraphExtractor(UnityEngine.Object root);
	static SceneGraphExtractor();

	// Methods
	private void CountMemObject(UnityEngine.Object obj);
	private void ExtractComponentIDs<T>(GameObject go)
		where T : Component;
	public void ProcessRecursively(GameObject obj);
}

