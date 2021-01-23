/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;
using UnityEngine;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine.Unity.Modules.AttachmentTools
{
	public static class AtlasUtilities
	{
		// Fields
		internal const TextureFormat SpineTextureFormat = TextureFormat.RGBA32;
		internal const float DefaultMipmapBias = -0.5f;
		internal const bool UseMipMaps = false;
		internal const float DefaultScale = 0.01f;
		private static Dictionary<AtlasRegion, Texture2D> CachedRegionTextures;
		private static List<Texture2D> CachedRegionTexturesList;
	
		// Constructors
		static AtlasUtilities();
	
		// Methods
		public static void GetRepackedAttachments(List<Attachment> sourceAttachments, List<Attachment> outputAttachments, Material materialPropertySource, out Material outputMaterial, out Texture2D outputTexture, int maxAtlasSize = 1024, int padding = 2, TextureFormat textureFormat = TextureFormat.RGBA32, bool mipmaps = false, string newAssetName = "Repacked Attachments", bool clearCache = false);
		public static void ClearCache();
		private static bool IsRenderable(Attachment a);
		private static Rect UVRectToTextureRect(Rect uvRect, int texWidth, int texHeight);
		private static Rect TextureRectToUVRect(Rect textureRect, int texWidth, int texHeight);
		private static AtlasRegion UVRectToAtlasRegion(Rect uvRect, string name, AtlasPage page, float offsetX, float offsetY, bool rotate);
		private static float InverseLerp(float a, float b, float value);
	
		// Extension methods
		public static AtlasRegion ToAtlasRegion(this Texture2D t, Material materialPropertySource, float scale = 0.01f);
		public static AtlasRegion ToAtlasRegion(this Texture2D t, Shader shader, float scale = 0.01f, Material materialPropertySource = null);
		public static AtlasRegion ToAtlasRegionPMAClone(this Texture2D t, Material materialPropertySource, TextureFormat textureFormat = TextureFormat.RGBA32, bool mipmaps = false);
		public static AtlasRegion ToAtlasRegionPMAClone(this Texture2D t, Shader shader, TextureFormat textureFormat = TextureFormat.RGBA32, bool mipmaps = false, Material materialPropertySource = null);
		public static AtlasPage ToSpineAtlasPage(this Material m);
		public static AtlasRegion ToAtlasRegion(this Sprite s, AtlasPage page);
		public static AtlasRegion ToAtlasRegion(this Sprite s, Material material);
		public static AtlasRegion ToAtlasRegionPMAClone(this Sprite s, Shader shader, TextureFormat textureFormat = TextureFormat.RGBA32, bool mipmaps = false, Material materialPropertySource = null);
		public static AtlasRegion ToAtlasRegionPMAClone(this Sprite s, Material materialPropertySource, TextureFormat textureFormat = TextureFormat.RGBA32, bool mipmaps = false);
		internal static AtlasRegion ToAtlasRegion(this Sprite s, bool isolatedTexture = false);
		public static Skin GetRepackedSkin(this Skin o, string newName, Material materialPropertySource, out Material outputMaterial, out Texture2D outputTexture, int maxAtlasSize = 1024, int padding = 2, TextureFormat textureFormat = TextureFormat.RGBA32, bool mipmaps = false);
		public static Skin GetRepackedSkin(this Skin o, string newName, Shader shader, out Material outputMaterial, out Texture2D outputTexture, int maxAtlasSize = 1024, int padding = 2, TextureFormat textureFormat = TextureFormat.RGBA32, bool mipmaps = false, Material materialPropertySource = null, bool clearCache = false);
		public static Sprite ToSprite(this AtlasRegion ar, float pixelsPerUnit = 100f);
		public static Texture2D ToTexture(this AtlasRegion ar, bool applyImmediately = true, TextureFormat textureFormat = TextureFormat.RGBA32, bool mipmaps = false);
		private static Texture2D ToTexture(this Sprite s, bool applyImmediately = true, TextureFormat textureFormat = TextureFormat.RGBA32, bool mipmaps = false);
		private static Texture2D GetClone(this Texture2D t, bool applyImmediately = true, TextureFormat textureFormat = TextureFormat.RGBA32, bool mipmaps = false);
		private static Rect SpineUnityFlipRect(this Rect rect, int textureHeight);
		private static Rect GetUnityRect(this AtlasRegion region);
		private static Rect GetUnityRect(this AtlasRegion region, int textureHeight);
		private static Rect GetSpineAtlasRect(this AtlasRegion region, bool includeRotate = true);
		private static Texture2D GetMainTexture(this AtlasRegion region);
		private static void ApplyPMA(this Texture2D texture, bool applyImmediately = true);
	}
}
