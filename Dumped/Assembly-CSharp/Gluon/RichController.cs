/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class RichController : MonoBehaviour
	{
		// Fields
		public const float OUTLINE_WIDTH_DRAGON = 1f;
		public const float OUTLINE_WIDTH_WEAPON = 1f;
		private static readonly string enableRichShaderPrefs;
		[SerializeField]
		[Tooltip]
		private SceneRichShaderData _defaultSceneRichShaderData;
		private SceneRichShaderData _sceneRichShaderData;
		[CompilerGenerated]
		private bool _enableOutline_k__BackingField;
		[CompilerGenerated]
		private static bool _enableDrawGizmo_k__BackingField;
	
		// Properties
		public SceneRichShaderData sceneRichShaderData { get; }
		public bool isDefaultSceneData { get; }
		public bool enableOutline { [CompilerGenerated] get; [CompilerGenerated] set; }
		public static bool enableDrawGizmo { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public RichController();
		static RichController();
	
		// Methods
		private void SetToonParameter(SceneRichShaderData.ToonShadingData toonShadingData);
		private void SetToonMatcapProjectionParameter(SceneRichShaderData.ToonShadingData toonShadingData);
		public static void SetEnableRichShader(bool isEnable);
		public static bool IsEnableRichShader();
		private void Awake();
		private void Start();
		private void LateUpdate();
		public static string ReplacePath(string path);
		public GameObject LoadRichObject(GameObject rootObject, string path, float outlineWidth = 1f, float outlineScale = 1f, bool isOuputInstance = true);
		public void SetupRichModel(GameObject rootObject, ShaderLodDataObject shaderLodDataObject = null);
		public static void CreateRichModel(string path, GameObject baseObject, float outlineWidth = 1f, float outlineScale = 1f, ShaderLodDataObject shaderLodDataObject = null);
		public void SetSceneRichShaderData(SceneRichShaderData srcSceneRichShaderData, bool isSameSceneReset = true);
	}
}
