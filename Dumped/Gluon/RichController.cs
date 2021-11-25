using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon
{
	public class RichController : MonoBehaviour
	{
		public const float OUTLINE_WIDTH_DRAGON = 1f;

		public const float OUTLINE_WIDTH_WEAPON = 1f;

		private static readonly string enableRichShaderPrefs;

		[SerializeField]
		[Tooltip("ã\u0083\u0087ã\u0083\u0095ã\u0082©ã\u0083«ã\u0083\u0088ã\u0081®ã\u0082·ã\u0083¼ã\u0083³ã\u0083\u0087ã\u0083¼ã\u0082¿ã\u0081\u008b")]
		private SceneRichShaderData _defaultSceneRichShaderData;

		private SceneRichShaderData _sceneRichShaderData;

		public SceneRichShaderData sceneRichShaderData => null;

		public bool isDefaultSceneData => default(bool);

		public bool enableOutline
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static bool enableDrawGizmo
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private void SetToonParameter(SceneRichShaderData.ToonShadingData toonShadingData)
		{
		}

		private void SetToonMatcapProjectionParameter(SceneRichShaderData.ToonShadingData toonShadingData)
		{
		}

		public static void SetEnableRichShader(bool isEnable)
		{
		}

		public static bool IsEnableRichShader()
		{
			return default(bool);
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}

		public static string ReplacePath(string path)
		{
			return null;
		}

		public GameObject LoadRichObject(GameObject rootObject, string path, float outlineWidth = 1f, float outlineScale = 1f, bool isOuputInstance = true, [Optional] GameObject externalRichObject)
		{
			return null;
		}

		public void SetupRichModel(GameObject rootObject, [Optional] ShaderLodDataObject shaderLodDataObject)
		{
		}

		public static void CreateRichModel(string path, GameObject baseObject, float outlineWidth = 1f, float outlineScale = 1f, [Optional] ShaderLodDataObject shaderLodDataObject)
		{
		}

		public void SetSceneRichShaderData(SceneRichShaderData srcSceneRichShaderData, bool isSameSceneReset = true)
		{
		}
	}
}
