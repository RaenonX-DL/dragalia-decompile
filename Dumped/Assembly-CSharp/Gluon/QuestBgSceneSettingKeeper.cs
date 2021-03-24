/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestBgSceneSettingKeeper : MonoBehaviour
	{
		// Fields
		[Header]
		public bool fog;
		public FogMode fogMode;
		public Color fogColor;
		public float fogStartDistance;
		public float fogEndDistance;
		[Header]
		public float dofFocalSize;
		public float dofFocalLength;
		public float dofSmoothness;
		[Header]
		public float dofQpFocalSize;
		public float dofQpFocalLength;
		public float dofQpSmoothness;
		[Header]
		public Cubemap reflectionCubeMap;
		public float intensityMultiplier;
	
		// Constructors
		public QuestBgSceneSettingKeeper();
	
		// Methods
		private void SaveCurrentFogSetting();
		public void ReflectSavedSetting(PostEffect pe = null, bool isUseQuestPrepareSetting = false);
	}
}
