/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;
using UnityEngine;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine.Unity.Modules.AttachmentTools
{
	public static class AttachmentCloneExtensions
	{
		// Methods
		private static void CloneVertexAttachment(VertexAttachment src, VertexAttachment dest);
	
		// Extension methods
		public static Attachment GetClone(this Attachment o, bool cloneMeshesAsLinked);
		public static RegionAttachment GetClone(this RegionAttachment o);
		public static ClippingAttachment GetClone(this ClippingAttachment o);
		public static PointAttachment GetClone(this PointAttachment o);
		public static BoundingBoxAttachment GetClone(this BoundingBoxAttachment o);
		public static MeshAttachment GetLinkedClone(this MeshAttachment o, bool inheritDeform = true);
		public static MeshAttachment GetClone(this MeshAttachment o);
		public static PathAttachment GetClone(this PathAttachment o);
		public static MeshAttachment GetLinkedMesh(this MeshAttachment o, string newLinkedMeshName, AtlasRegion region, bool inheritDeform = true);
		public static MeshAttachment GetLinkedMesh(this MeshAttachment o, Sprite sprite, Shader shader, bool inheritDeform = true, Material materialPropertySource = null);
		public static MeshAttachment GetLinkedMesh(this MeshAttachment o, Sprite sprite, Material materialPropertySource, bool inheritDeform = true);
		public static Attachment GetRemappedClone(this Attachment o, Sprite sprite, Material sourceMaterial, bool premultiplyAlpha = true, bool cloneMeshAsLinked = true, bool useOriginalRegionSize = false);
		public static Attachment GetRemappedClone(this Attachment o, AtlasRegion atlasRegion, bool cloneMeshAsLinked = true, bool useOriginalRegionSize = false, float scale = 0.01f);
	}
}
