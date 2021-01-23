/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FLATOUT.Main.Utility;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main
{
	public class FlCommon
	{
		// Fields
		public static readonly float objectTimeMinusValue;
		public static readonly float minAlphaValue;
		public static readonly float timeAccuracy;
	
		// Properties
		public static string AssetName { get; }
		public static string GlobalDataName { get; }
		public static string GlobalDataMediatorPath { get; }
		public static string RootName { get; }
		public static string MotionPrefix { get; }
		public static string ObjectPrefix { get; }
		public static string PlanePrefix { get; }
		public static string TextPrefix { get; }
		public static string ObjectOffsetName { get; }
		public static string CloneString { get; }
		public static string NormalMeshString { get; }
		public static string NineSliceMeshString { get; }
		public static string CustomMeshString { get; }
		public static string OuterTextureString { get; }
		public static string CustomTextureString { get; }
		public static string StencilRefString { get; }
		public static string StencilCompString { get; }
		public static int SortOrderIntervalForObject { get; }
		public static int SortOrderIntervalForPlane { get; }
		public static int SortOrderIntervalForText { get; }
		public static float DefaultCharacterSize { get; }
		public static float DefaultTabSize { get; }
		public static float DefaultLinespaceOffset { get; }
		public static int JoinWordMinNum { get; }
		public static int JoinWordMaxNum { get; }
		public static string TextMainName { get; }
		public static string TextShadowName { get; }
		public static string TextOutlineName { get; }
		public static string TextIconPrefix { get; }
		public static string TextIconSize { get; }
		public static string TextEmpty { get; }
		public static string TextReturn { get; }
		public static char TextHalfSpaceChar { get; }
		public static char TextCommaChar { get; }
		public static char TextPeriodChar { get; }
		public static char TextRichBracketStartChar { get; }
		public static string TextRichBracketStart { get; }
		public static char TextRichBracketEndChar { get; }
		public static string TextRichBracketEnd { get; }
		public static string TextRichEndBracketStart { get; }
		public static string TextColorPrefix { get; }
		public static string TextColorSuffix { get; }
		public static string TextBoldPrefix { get; }
		public static string TextBoldSuffix { get; }
		public static string TextItalicPrefix { get; }
		public static string TextItalicSuffix { get; }
		public static string TextSizePrefix { get; }
		public static string TextSizeSuffix { get; }
		public static string TextSettingPrefix { get; }
		public static string TextSettingLineSpace { get; }
		public static string TextSettingAnchor { get; }
		public static string TextSettingAlign { get; }
		public static string TextSettingTab { get; }
		public static string TextSettingFit { get; }
		public static string TextSettingWrap { get; }
		public static string TextSettingIconOffsetX { get; }
		public static string TextSettingIconOffsetY { get; }
		public static string TextSettingIconOffsetSize { get; }
		public static string TextSettingOffsetX { get; }
		public static string TextSettingOffsetY { get; }
		public static string ShaderNormalPath { get; }
		public static string ShaderAddPath { get; }
		public static string ShaderSubPath { get; }
		public static string ShaderMultiplyPath { get; }
		public static string ShaderHardLightPath { get; }
		public static string ShaderInvertPath { get; }
		public static string ShaderOpaquePath { get; }
		public static string ShaderGrayscalePath { get; }
		public static string ShaderMaskPath { get; }
		public static string ShaderAlphaMaskPath { get; }
		public static string ShaderStencilMaskPath { get; }
		public static string ShaderStencilAlphaMaskPath { get; }
		public static string ShaderObjectMaskPath { get; }
		public static string ShaderObjectAlphaMaskPath { get; }
		public static string ShaderNormal3DPath { get; }
		public static string ShaderAdd3DPath { get; }
		public static string ShaderEditorPath { get; }
		public static string ShaderNormalBlurPath { get; }
		public static string ShaderAddBlurPath { get; }
		public static string ShaderMultiplyBlurPath { get; }
		public static string ShaderGrayscaleBlurPath { get; }
		public static string ShaderMainString { get; }
		public static string ShaderA8String { get; }
		public static string ShaderNoTexAlphaString { get; }
		public static string ShaderNoTexAlphaNormalPath { get; }
		public static string ShaderNoTexAlphaNormalBlurPath { get; }
		public static string ShaderNoTexAlphaAddPath { get; }
		public static string ShaderNoTexAlphaAddBlurPath { get; }
		public static string ShaderNoTexAlphaMultiplyPath { get; }
		public static string ShaderNoTexAlphaMultiplyBlurPath { get; }
		public static string ShaderNoTexAlphaGrayscalePath { get; }
		public static string ShaderNoTexAlphaGrayscaleBlurPath { get; }
		public static string ShaderTextNormalPath { get; }
		public static string ShaderTextAddPath { get; }
		public static string ShaderTextMultiplyPath { get; }
		public static string ShaderTextGrayscalePath { get; }
		public static string ShaderTextIconNormalPath { get; }
		public static string ShaderTextIconAddPath { get; }
		public static string ShaderTextIconMultiplyPath { get; }
		public static string ShaderTextIconGrayscalePath { get; }
		public static string ShaderParamMainTex { get; }
		public static string ShaderParamAlphaTex { get; }
		public static string ShaderParamMultiplyColor { get; }
		public static string ShaderParamOffset { get; }
		public static string ShaderParamUVColorOffset { get; }
		public static string ShaderParamUVAlphaOffset { get; }
		public static string ShaderParamUVColorRepeat { get; }
		public static string ShaderParamUVAlphaRepeat { get; }
		public static string ShaderParamStencilRef { get; }
		public static string ShaderParamStencilComp { get; }
		public static string ShaderParamBlurOffsetX { get; }
		public static string ShaderParamBlurOffsetY { get; }
		public static string ShaderParamBlurQuality { get; }
		public static string ShaderParamBlurOffsetListX { get; }
		public static string ShaderParamBlurOffsetListY { get; }
		public static string ShaderParamBlurWeightList { get; }
		public static string TextureColorSuffix { get; }
		public static string TextureAlphaSuffix { get; }
		public static string CustomModelFolderName { get; }
		public static string PrimitiveMeshAssetRootPath { get; }
		public static string PrimitiveMeshRootPath { get; }
		public static string PrimitiveMeshCubePath { get; }
		public static string PrimitiveMeshCylinderPath { get; }
		public static string PrimitiveMeshRingPath { get; }
		public static string PrimitiveMeshSpherePath { get; }
		public static string PrimitiveMeshPlanePath { get; }
	
		// Constructors
		public FlCommon();
		static FlCommon();
	
		// Methods
		public static FlShaderTypes GetShaderTypeFromBlend(FlBlendModeTypes blendModeType);
		public static FlShaderTypes GetShaderTypeFromBlend(FlBlendModeTypes blendModeType, bool blur);
		private static FlShaderTypes GetShaderTypeFromBlendBase(FlBlendModeTypes blendModeType, bool blur);
		public static bool IsSameColor(Color src, Color dst);
		public static void AddColor(ref Color src, Color dst);
		public static void MultiplyColor(ref Color src, Color dst);
		public static bool IsSameVector(Vector3 src, Vector3 dst);
		public static Vector2 ReverseVec2(Vector2 value, Vector2 multiply);
		public static Color[] CreateColorList(int count, Color defautlValue);
		public static void LimitValue(ref float value, float min, float max);
		public static float LimitValue(float value, float min, float max);
		public static void LimitValue(ref int value, int min, int max);
		public static int LimitValue(int value, int min, int max);
		public static float GetAbsValue(float value);
		public static float GetSign(float value);
		public static void MultiplyVector2(ref Vector2 src, Vector2 dst);
		public static void MultiplyVector3(ref Vector3 src, Vector3 dst);
		public static int GetDigit(float value);
		public static Vector2 Rotate2DPosition(Vector2 positon, Vector2 centerPosition, float degree);
		public static string GetNumberString(int value, int digit);
		public static void ReplaceString(string replaceString, ref string originalString);
		public static bool IsEmptyString(string targetString);
		public static Vector3 CalculateShearPosition(Vector3 original, Vector3 offset, float cosX, float sinX, float cosY, float sinY, float scaleX, float scaleY);
		public static void FillPlane(Mesh mesh, float percent, FlMeshInfoParameter meshInfoPram, FlFillType fillType);
		public static void GetOrthogonalProjectionVector(Vector3 firstVector, Vector3 secondVector, ref Vector3 result);
		public static Vector3 CalculateTextOffset(TextMesh textMesh, float leftAlignOffset, float centerAlignOffset, float rightAlignOffset, float upperAnchorOffset, float middleAnchorOffset, float lowerAnchorOffset, TextAnchor anchor, Vector2 range);
		public static void CopyTextMeshValue(TextMesh srcTextMesh, TextMesh destTextMesh);
		public static void SetMeshRendererDefaultValue(MeshRenderer srcMeshRenderer);
		public static void CopyMeshRendererValue(MeshRenderer srcMeshRenderer, MeshRenderer destMeshRenderer);
		public static string ConvertRichTextToNormal(string srcText);
		public static string RemoveStringFromText(string srcText, string prefixString);
		public static string GetRichTextContent(string srcText, string prefixString);
		public static void GetTextSetting(string srcText, ref float linespace, ref TextAlignment align, ref TextAnchor anchor, ref Vector2 offset, ref Vector2 iconOffset, ref float iconSizeOffset, ref float tabSize, ref bool fit, ref bool wrap);
		public static string GetTextValue(string srcText, string prefixString);
		public static TextAlignment GetTextAlignmentFromString(string srcString);
		public static TextAnchor GetTextAnchorFromString(string srcString);
		public static Vector2 FixUV(Vector2 value);
		public static GameObject GetChildObject(GameObject parenObject, int index);
		public static GameObject GetChildObject(GameObject parenObject, string name);
		public static bool CheckParentVisibleInHierarchy(FlMotion motion);
		public static bool CheckParentVisibleInHierarchy(FlObjectBase objectBase);
		public static bool CheckParentVisibleInHierarchy(FlBase flbase);
		public static int GetLayerIndex(string layerName);
		public static string GetLayerName(int layerIndex);
		public static void SetLayer(GameObject rootObject, int layerIndex);
		public static void SetLayerFromName(GameObject rootObject, string name);
		public static void ComputeGaussianBlurList(float quality, float amount, int precision, ref float[] offsetListX, ref float[] offsetListY, ref float[] weightList);
		public static Mesh CreateMesh(string name, Vector2 size, Vector2 offset, Vector2 uvPosition, Vector2 uvSize, bool uvRotated);
		public static Mesh CreateNinesliceMesh(string name, Vector2 size, Vector2 offset, Vector2 uvPosition, Vector2 uvSize, bool uvRotated, Vector4 sliceRange);
		public static void UpdateNinesliceVertexPositionList(Vector2 originalSize, Vector2 scale, Vector4 sliceValue, Vector3 offset, ref Vector3[] _vertexPositionList);
		public static Mesh CloneMesh(Mesh baseMesh);
		public static void FixMeshColorAndUV2AndUV3(Mesh targetMesh);
		public static Mesh GetPrimitiveMesh(FlPrimitiveMeshTypes primitiveMeshType);
		public static void FixMeshSize(Mesh baseMesh, Vector2 imageSize, float marginTop, float marginButtom, float marginRight, float marginLeft, bool keepAspect);
		public static void OffsetMesh(Mesh baseMesh, Vector3 positionOffset, Vector3 rotateOffset, Vector3 scaleOffset);
		public static void InvertMeshNormal(Mesh baseMesh);
		public static void FixMeshUV(Mesh baseMesh, Vector2 uvOffset, Vector2 uvSize, bool rotated, Vector2 packImageSize, Vector2 imageSize, float marginTop, float marginButtom, float marginRight, float marginLeft);
		public static void OffsetMeshUV(Mesh baseMesh, Vector2 uvOffset, Vector2 uvSize);
		public static T FindComponent<T>(GameObject rootObject, string path, bool fullMatch = false)
			where T : Component;
		public static T FindInstance<T>(FlRoot flRoot, GameObject rootObject, string path, bool fullMatch = false)
			where T : FlBase;
		public static List<T> FindInstancesInChildren<T>(FlRoot flRoot, GameObject rootObject)
			where T : FlBase;
		public static T FindUIInstance<T>(FlRoot flRoot, GameObject rootObject, string path, bool fullMatch = false)
			where T : FlUIBase;
		public static T FindAndInitUIInstance<T>(FlRoot flRoot, GameObject rootObject, string path, bool fullMatch = false)
			where T : FlUIBase, new();
		public static GameObject FindGameObject(GameObject rootObject, string path, bool fullMatch = false);
		private static GameObject FindGameObjectLoop(GameObject rootObject, string name, int searchDepth, bool fullMatch);
		public static void AttachObject(GameObject targetObject, GameObject parentObject, Vector3 positionOffset, Vector3 rotateOffset, Vector3 scaleOffset);
		public static void GetFixScreenPosition(Vector3 screenPosition, ref Vector3 target);
		public static void GetScreenPosition(Vector3 fixScreenPosition, ref Vector3 target);
		public static Vector3 GetWorldPositionFromScreen(Vector3 screenPosition, Camera camera);
		public static void GetWorldPositionFromScreen(Vector3 screenPosition, Camera camera, ref Vector3 worldPosition);
		public static FlUIInputDirectionTypes GetInputDirectionType(Vector3 direction, bool isEightDirection);
		public static Vector3 GetInputDirectionVector(FlUIInputDirectionTypes directionType);
	}
}
