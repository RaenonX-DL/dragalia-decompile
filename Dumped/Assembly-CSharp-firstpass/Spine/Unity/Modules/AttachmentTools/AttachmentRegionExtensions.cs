/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;
using UnityEngine;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine.Unity.Modules.AttachmentTools
{
	public static class AttachmentRegionExtensions
	{
		// Extension methods
		public static AtlasRegion GetRegion(this Attachment attachment);
		public static AtlasRegion GetRegion(this RegionAttachment regionAttachment);
		public static AtlasRegion GetRegion(this MeshAttachment meshAttachment);
		public static void SetRegion(this Attachment attachment, AtlasRegion region, bool updateOffset = true);
		public static void SetRegion(this RegionAttachment attachment, AtlasRegion region, bool updateOffset = true);
		public static void SetRegion(this MeshAttachment attachment, AtlasRegion region, bool updateUVs = true);
		public static RegionAttachment ToRegionAttachment(this Sprite sprite, Material material, float rotation = 0f);
		public static RegionAttachment ToRegionAttachment(this Sprite sprite, AtlasPage page, float rotation = 0f);
		public static RegionAttachment ToRegionAttachmentPMAClone(this Sprite sprite, Shader shader, TextureFormat textureFormat = TextureFormat.RGBA32, bool mipmaps = false, Material materialPropertySource = null, float rotation = 0f);
		public static RegionAttachment ToRegionAttachmentPMAClone(this Sprite sprite, Material materialPropertySource, TextureFormat textureFormat = TextureFormat.RGBA32, bool mipmaps = false, float rotation = 0f);
		public static RegionAttachment ToRegionAttachment(this AtlasRegion region, string attachmentName, float scale = 0.01f, float rotation = 0f);
		public static void SetScale(this RegionAttachment regionAttachment, Vector2 scale);
		public static void SetScale(this RegionAttachment regionAttachment, float x, float y);
		public static void SetPositionOffset(this RegionAttachment regionAttachment, Vector2 offset);
		public static void SetPositionOffset(this RegionAttachment regionAttachment, float x, float y);
		public static void SetRotation(this RegionAttachment regionAttachment, float rotation);
	}
}
