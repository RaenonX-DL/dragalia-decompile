/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.GraphicParameter;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SimpleCharacterAnimationEvent : MonoBehaviour
	{
		// Fields
		private SimpleCharacterModel simpleCharacterModel;
		private RenderPartsData renderPartsData;
		private Dictionary<string, EffectObject> effectDict;
		private List<PlayEffectCommand> playEffectCommands;
	
		// Nested types
		private class PlayEffectCommand
		{
			// Fields
			public string effectName;
			public string attachNodeName;
			public int trigger;
	
			// Constructors
			public PlayEffectCommand();
		}
	
		// Constructors
		public SimpleCharacterAnimationEvent();
	
		// Methods
		private void Awake();
		private void OnDestroy();
		private void LateUpdate();
		public void FBXImport_ChangeMesh(string meshpartsName);
		public void ChangeMeshVisibility(string command);
		public void SetFace(string command);
		public void FBXImport_PlayEffect(string commandStr);
		private bool PlayEffect(PlayEffectCommand command);
		public static string GetPlayEffectEffectName(string command);
		public static string GetPlayEffectAttachNodeName(string command);
		public static int GetPlayEffectTrigger(string command);
	}
}
