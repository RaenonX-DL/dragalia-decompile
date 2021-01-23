/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine
{
	public interface AttachmentLoader
	{
		// Methods
		RegionAttachment NewRegionAttachment(Skin skin, string name, string path);
		MeshAttachment NewMeshAttachment(Skin skin, string name, string path);
		BoundingBoxAttachment NewBoundingBoxAttachment(Skin skin, string name);
		PathAttachment NewPathAttachment(Skin skin, string name);
		PointAttachment NewPointAttachment(Skin skin, string name);
		ClippingAttachment NewClippingAttachment(Skin skin, string name);
	}
}
