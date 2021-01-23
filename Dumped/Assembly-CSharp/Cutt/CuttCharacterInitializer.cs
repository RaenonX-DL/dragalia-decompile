/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cutt
{
	public class CuttCharacterInitializer : MonoBehaviour
	{
		// Fields
		[NonSerialized]
		public const int Max = 10;
		private List<string> replacePartyMotionCharaPrefabNameArray;
		[SerializeField]
		public CuttCharacterInitializeData[] initializeDataArray;
		[NonSerialized]
		public CuttCharacterController[] characterController;
		[SerializeField]
		public CuttFtuInitializeData[] ftuInitializeDataArray;
		[SerializeField]
		private string environmentMapAreaLabel;
		private CuttTimelineControl control;
		private bool isInitialized;
		private bool isPlayingInGame;
		private ShaderLodDataObject _shaderLodDataObject;
	
		// Nested types
		public enum CharacterId
		{
			Chara01 = 0,
			Chara02 = 1,
			Chara03 = 2,
			Chara04 = 3,
			Chara05 = 4,
			Chara06 = 5,
			Chara07 = 6,
			Chara08 = 7,
			Chara09 = 8,
			Chara10 = 9
		}
	
		// Constructors
		public CuttCharacterInitializer();
	
		// Methods
		public bool IsInitialized();
		public CuttCharacterController GetCharacterController(int index);
		public void Load(bool isPlayingInGame, GameObject canvasObject);
		public void OnChangeLightProbeParameter();
		private void ReplacePartyCharacter(CuttCharacterInitializeData initData);
		private CuttCharacterController LoadCharacter(CuttCharacterInitializeData initData, GameObject canvasObject, int index, ShaderLodDataObject shaderLodDataObject = null);
		private void OnDestroy();
	}
}
