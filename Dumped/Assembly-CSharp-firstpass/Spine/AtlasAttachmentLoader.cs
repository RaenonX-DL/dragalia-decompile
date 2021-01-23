/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine
{
	public class AtlasAttachmentLoader : AttachmentLoader
	{
		// Fields
		private Atlas[] atlasArray;
	
		// Constructors
		public AtlasAttachmentLoader(params Atlas[] atlasArray);
	
		// Methods
		public RegionAttachment NewRegionAttachment(Skin skin, string name, string path);
		public MeshAttachment NewMeshAttachment(Skin skin, string name, string path);
		public BoundingBoxAttachment NewBoundingBoxAttachment(Skin skin, string name);
		public PathAttachment NewPathAttachment(Skin skin, string name);
		public PointAttachment NewPointAttachment(Skin skin, string name);
		public ClippingAttachment NewClippingAttachment(Skin skin, string name);
		public AtlasRegion FindRegion(string name);
	}
}
