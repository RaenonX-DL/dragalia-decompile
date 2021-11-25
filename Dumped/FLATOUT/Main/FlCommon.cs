using System.Collections.Generic;
using FLATOUT.Main.Utility;
using UnityEngine;

namespace FLATOUT.Main
{
	public class FlCommon
	{
		public static readonly float objectTimeMinusValue;

		public static readonly float minAlphaValue;

		public static readonly float timeAccuracy;

		public static string AssetName => null;

		public static string GlobalDataName => null;

		public static string GlobalDataMediatorPath => null;

		public static string RootName => null;

		public static string MotionPrefix => null;

		public static string ObjectPrefix => null;

		public static string PlanePrefix => null;

		public static string TextPrefix => null;

		public static string ObjectOffsetName => null;

		public static string CloneString => null;

		public static string NormalMeshString => null;

		public static string NineSliceMeshString => null;

		public static string CustomMeshString => null;

		public static string OuterTextureString => null;

		public static string CustomTextureString => null;

		public static string StencilRefString => null;

		public static string StencilCompString => null;

		public static int SortOrderIntervalForObject => default(int);

		public static int SortOrderIntervalForPlane => default(int);

		public static int SortOrderIntervalForText => default(int);

		public static float DefaultCharacterSize => default(float);

		public static float DefaultTabSize => default(float);

		public static float DefaultLinespaceOffset => default(float);

		public static int JoinWordMinNum => default(int);

		public static int JoinWordMaxNum => default(int);

		public static string TextMainName => null;

		public static string TextShadowName => null;

		public static string TextOutlineName => null;

		public static string TextIconPrefix => null;

		public static string TextIconSize => null;

		public static string TextEmpty => null;

		public static string TextReturn => null;

		public static char TextHalfSpaceChar => default(char);

		public static char TextCommaChar => default(char);

		public static char TextPeriodChar => default(char);

		public static char TextRichBracketStartChar => default(char);

		public static string TextRichBracketStart => null;

		public static char TextRichBracketEndChar => default(char);

		public static string TextRichBracketEnd => null;

		public static string TextRichEndBracketStart => null;

		public static string TextColorPrefix => null;

		public static string TextColorSuffix => null;

		public static string TextBoldPrefix => null;

		public static string TextBoldSuffix => null;

		public static string TextItalicPrefix => null;

		public static string TextItalicSuffix => null;

		public static string TextSizePrefix => null;

		public static string TextSizeSuffix => null;

		public static string TextSettingPrefix => null;

		public static string TextSettingLineSpace => null;

		public static string TextSettingAnchor => null;

		public static string TextSettingAlign => null;

		public static string TextSettingTab => null;

		public static string TextSettingFit => null;

		public static string TextSettingWrap => null;

		public static string TextSettingIconOffsetX => null;

		public static string TextSettingIconOffsetY => null;

		public static string TextSettingIconOffsetSize => null;

		public static string TextSettingOffsetX => null;

		public static string TextSettingOffsetY => null;

		public static string ShaderNormalPath => null;

		public static string ShaderAddPath => null;

		public static string ShaderSubPath => null;

		public static string ShaderMultiplyPath => null;

		public static string ShaderHardLightPath => null;

		public static string ShaderInvertPath => null;

		public static string ShaderOpaquePath => null;

		public static string ShaderGrayscalePath => null;

		public static string ShaderMaskPath => null;

		public static string ShaderAlphaMaskPath => null;

		public static string ShaderStencilMaskPath => null;

		public static string ShaderStencilAlphaMaskPath => null;

		public static string ShaderObjectMaskPath => null;

		public static string ShaderObjectAlphaMaskPath => null;

		public static string ShaderNormal3DPath => null;

		public static string ShaderAdd3DPath => null;

		public static string ShaderEditorPath => null;

		public static string ShaderNormalBlurPath => null;

		public static string ShaderAddBlurPath => null;

		public static string ShaderMultiplyBlurPath => null;

		public static string ShaderGrayscaleBlurPath => null;

		public static string ShaderMainString => null;

		public static string ShaderA8String => null;

		public static string ShaderNoTexAlphaString => null;

		public static string ShaderNoTexAlphaNormalPath => null;

		public static string ShaderNoTexAlphaNormalBlurPath => null;

		public static string ShaderNoTexAlphaAddPath => null;

		public static string ShaderNoTexAlphaAddBlurPath => null;

		public static string ShaderNoTexAlphaMultiplyPath => null;

		public static string ShaderNoTexAlphaMultiplyBlurPath => null;

		public static string ShaderNoTexAlphaGrayscalePath => null;

		public static string ShaderNoTexAlphaGrayscaleBlurPath => null;

		public static string ShaderTextNormalPath => null;

		public static string ShaderTextAddPath => null;

		public static string ShaderTextMultiplyPath => null;

		public static string ShaderTextGrayscalePath => null;

		public static string ShaderTextIconNormalPath => null;

		public static string ShaderTextIconAddPath => null;

		public static string ShaderTextIconMultiplyPath => null;

		public static string ShaderTextIconGrayscalePath => null;

		public static string ShaderParamMainTex => null;

		public static string ShaderParamAlphaTex => null;

		public static string ShaderParamMultiplyColor => null;

		public static string ShaderParamOffset => null;

		public static string ShaderParamUVColorOffset => null;

		public static string ShaderParamUVAlphaOffset => null;

		public static string ShaderParamUVColorRepeat => null;

		public static string ShaderParamUVAlphaRepeat => null;

		public static string ShaderParamStencilRef => null;

		public static string ShaderParamStencilComp => null;

		public static string ShaderParamBlurOffsetX => null;

		public static string ShaderParamBlurOffsetY => null;

		public static string ShaderParamBlurQuality => null;

		public static string ShaderParamBlurOffsetListX => null;

		public static string ShaderParamBlurOffsetListY => null;

		public static string ShaderParamBlurWeightList => null;

		public static string TextureColorSuffix => null;

		public static string TextureAlphaSuffix => null;

		public static string CustomModelFolderName => null;

		public static string PrimitiveMeshAssetRootPath => null;

		public static string PrimitiveMeshRootPath => null;

		public static string PrimitiveMeshCubePath => null;

		public static string PrimitiveMeshCylinderPath => null;

		public static string PrimitiveMeshRingPath => null;

		public static string PrimitiveMeshSpherePath => null;

		public static string PrimitiveMeshPlanePath => null;

		public static FlShaderTypes GetShaderTypeFromBlend(FlBlendModeTypes blendModeType)
		{
			return default(FlShaderTypes);
		}

		public static FlShaderTypes GetShaderTypeFromBlend(FlBlendModeTypes blendModeType, bool blur)
		{
			return default(FlShaderTypes);
		}

		private static FlShaderTypes GetShaderTypeFromBlendBase(FlBlendModeTypes blendModeType, bool blur)
		{
			return default(FlShaderTypes);
		}

		public static bool IsSameColor(Color src, Color dst)
		{
			return default(bool);
		}

		public static void AddColor(ref Color src, Color dst)
		{
		}

		public static void MultiplyColor(ref Color src, Color dst)
		{
		}

		public static bool IsSameVector(Vector3 src, Vector3 dst)
		{
			return default(bool);
		}

		public static Vector2 ReverseVec2(Vector2 value, Vector2 multiply)
		{
			return default(Vector2);
		}

		public static Color[] CreateColorList(int count, Color defautlValue)
		{
			return null;
		}

		public static void LimitValue(ref float value, float min, float max)
		{
		}

		public static float LimitValue(float value, float min, float max)
		{
			return default(float);
		}

		public static void LimitValue(ref int value, int min, int max)
		{
		}

		public static int LimitValue(int value, int min, int max)
		{
			return default(int);
		}

		public static float GetAbsValue(float value)
		{
			return default(float);
		}

		public static float GetSign(float value)
		{
			return default(float);
		}

		public static void MultiplyVector2(ref Vector2 src, Vector2 dst)
		{
		}

		public static void MultiplyVector3(ref Vector3 src, Vector3 dst)
		{
		}

		public static int GetDigit(float value)
		{
			return default(int);
		}

		public static Vector2 Rotate2DPosition(Vector2 positon, Vector2 centerPosition, float degree)
		{
			return default(Vector2);
		}

		public static string GetNumberString(int value, int digit)
		{
			return null;
		}

		public static void ReplaceString(string replaceString, ref string originalString)
		{
		}

		public static bool IsEmptyString(string targetString)
		{
			return default(bool);
		}

		public static Vector3 CalculateShearPosition(Vector3 original, Vector3 offset, float cosX, float sinX, float cosY, float sinY, float scaleX, float scaleY)
		{
			return default(Vector3);
		}

		public static void FillPlane(Mesh mesh, float percent, FlMeshInfoParameter meshInfoPram, FlFillType fillType)
		{
		}

		public static void GetOrthogonalProjectionVector(Vector3 firstVector, Vector3 secondVector, ref Vector3 result)
		{
		}

		public static Vector3 CalculateTextOffset(TextMesh textMesh, float leftAlignOffset, float centerAlignOffset, float rightAlignOffset, float upperAnchorOffset, float middleAnchorOffset, float lowerAnchorOffset, TextAnchor anchor, Vector2 range)
		{
			return default(Vector3);
		}

		public static void CopyTextMeshValue(TextMesh srcTextMesh, TextMesh destTextMesh)
		{
		}

		public static void SetMeshRendererDefaultValue(MeshRenderer srcMeshRenderer)
		{
		}

		public static void CopyMeshRendererValue(MeshRenderer srcMeshRenderer, MeshRenderer destMeshRenderer)
		{
		}

		public static string ConvertRichTextToNormal(string srcText)
		{
			return null;
		}

		public static string RemoveStringFromText(string srcText, string prefixString)
		{
			return null;
		}

		public static string GetRichTextContent(string srcText, string prefixString)
		{
			return null;
		}

		public static void GetTextSetting(string srcText, ref float linespace, ref TextAlignment align, ref TextAnchor anchor, ref Vector2 offset, ref Vector2 iconOffset, ref float iconSizeOffset, ref float tabSize, ref bool fit, ref bool wrap)
		{
		}

		public static string GetTextValue(string srcText, string prefixString)
		{
			return null;
		}

		public static TextAlignment GetTextAlignmentFromString(string srcString)
		{
			return default(TextAlignment);
		}

		public static TextAnchor GetTextAnchorFromString(string srcString)
		{
			return default(TextAnchor);
		}

		public static Vector2 FixUV(Vector2 value)
		{
			return default(Vector2);
		}

		public static GameObject GetChildObject(GameObject parenObject, int index)
		{
			return null;
		}

		public static GameObject GetChildObject(GameObject parenObject, string name)
		{
			return null;
		}

		public static bool CheckParentVisibleInHierarchy(FlMotion motion)
		{
			return default(bool);
		}

		public static bool CheckParentVisibleInHierarchy(FlObjectBase objectBase)
		{
			return default(bool);
		}

		public static bool CheckParentVisibleInHierarchy(FlBase flbase)
		{
			return default(bool);
		}

		public static int GetLayerIndex(string layerName)
		{
			return default(int);
		}

		public static string GetLayerName(int layerIndex)
		{
			return null;
		}

		public static void SetLayer(GameObject rootObject, int layerIndex)
		{
		}

		public static void SetLayerFromName(GameObject rootObject, string name)
		{
		}

		public static void ComputeGaussianBlurList(float quality, float amount, int precision, ref float[] offsetListX, ref float[] offsetListY, ref float[] weightList)
		{
		}

		public static Mesh CreateMesh(string name, Vector2 size, Vector2 offset, Vector2 uvPosition, Vector2 uvSize, bool uvRotated)
		{
			return null;
		}

		public static Mesh CreateNinesliceMesh(string name, Vector2 size, Vector2 offset, Vector2 uvPosition, Vector2 uvSize, bool uvRotated, Vector4 sliceRange)
		{
			return null;
		}

		public static void UpdateNinesliceVertexPositionList(Vector2 originalSize, Vector2 scale, Vector4 sliceValue, Vector3 offset, ref Vector3[] _vertexPositionList)
		{
		}

		public static Mesh CloneMesh(Mesh baseMesh)
		{
			return null;
		}

		public static void FixMeshColorAndUV2AndUV3(Mesh targetMesh)
		{
		}

		public static Mesh GetPrimitiveMesh(FlPrimitiveMeshTypes primitiveMeshType)
		{
			return null;
		}

		public static void FixMeshSize(Mesh baseMesh, Vector2 imageSize, float marginTop, float marginButtom, float marginRight, float marginLeft, bool keepAspect)
		{
		}

		public static void OffsetMesh(Mesh baseMesh, Vector3 positionOffset, Vector3 rotateOffset, Vector3 scaleOffset)
		{
		}

		public static void InvertMeshNormal(Mesh baseMesh)
		{
		}

		public static void FixMeshUV(Mesh baseMesh, Vector2 uvOffset, Vector2 uvSize, bool rotated, Vector2 packImageSize, Vector2 imageSize, float marginTop, float marginButtom, float marginRight, float marginLeft)
		{
		}

		public static void OffsetMeshUV(Mesh baseMesh, Vector2 uvOffset, Vector2 uvSize)
		{
		}

		public static T FindComponent<T>(GameObject rootObject, string path, bool fullMatch = false) where T : Component
		{
			return null;
		}

		public static T FindInstance<T>(FlRoot flRoot, GameObject rootObject, string path, bool fullMatch = false) where T : FlBase
		{
			return null;
		}

		public static List<T> FindInstancesInChildren<T>(FlRoot flRoot, GameObject rootObject) where T : FlBase
		{
			return null;
		}

		public static T FindUIInstance<T>(FlRoot flRoot, GameObject rootObject, string path, bool fullMatch = false) where T : FlUIBase
		{
			return null;
		}

		public static T FindAndInitUIInstance<T>(FlRoot flRoot, GameObject rootObject, string path, bool fullMatch = false) where T : FlUIBase, new()
		{
			return null;
		}

		public static GameObject FindGameObject(GameObject rootObject, string path, bool fullMatch = false)
		{
			return null;
		}

		private static GameObject FindGameObjectLoop(GameObject rootObject, string name, int searchDepth, bool fullMatch)
		{
			return null;
		}

		public static void AttachObject(GameObject targetObject, GameObject parentObject, Vector3 positionOffset, Vector3 rotateOffset, Vector3 scaleOffset)
		{
		}

		public static void GetFixScreenPosition(Vector3 screenPosition, ref Vector3 target)
		{
		}

		public static void GetScreenPosition(Vector3 fixScreenPosition, ref Vector3 target)
		{
		}

		public static Vector3 GetWorldPositionFromScreen(Vector3 screenPosition, Camera camera)
		{
			return default(Vector3);
		}

		public static void GetWorldPositionFromScreen(Vector3 screenPosition, Camera camera, ref Vector3 worldPosition)
		{
		}

		public static FlUIInputDirectionTypes GetInputDirectionType(Vector3 direction, bool isEightDirection)
		{
			return default(FlUIInputDirectionTypes);
		}

		public static Vector3 GetInputDirectionVector(FlUIInputDirectionTypes directionType)
		{
			return default(Vector3);
		}
	}
}
