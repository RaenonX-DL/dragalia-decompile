/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine
{
	public class SkeletonBinary
	{
		// Fields
		public const int BONE_ROTATE = 0;
		public const int BONE_TRANSLATE = 1;
		public const int BONE_SCALE = 2;
		public const int BONE_SHEAR = 3;
		public const int SLOT_ATTACHMENT = 0;
		public const int SLOT_COLOR = 1;
		public const int SLOT_TWO_COLOR = 2;
		public const int PATH_POSITION = 0;
		public const int PATH_SPACING = 1;
		public const int PATH_MIX = 2;
		public const int CURVE_LINEAR = 0;
		public const int CURVE_STEPPED = 1;
		public const int CURVE_BEZIER = 2;
		[CompilerGenerated]
		private float _Scale_k__BackingField;
		private AttachmentLoader attachmentLoader;
		private byte[] buffer;
		private List<SkeletonJson.LinkedMesh> linkedMeshes;
		public static readonly TransformMode[] TransformModeValues;
	
		// Properties
		public float Scale { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		internal class Vertices
		{
			// Fields
			public int[] bones;
			public float[] vertices;
	
			// Constructors
			public Vertices();
		}
	
		// Constructors
		public SkeletonBinary(params Atlas[] atlasArray);
		public SkeletonBinary(AttachmentLoader attachmentLoader);
		static SkeletonBinary();
	
		// Methods
		public SkeletonData ReadSkeletonData(string path);
		public static string GetVersionString(Stream input);
		public SkeletonData ReadSkeletonData(Stream input);
		private Skin ReadSkin(Stream input, SkeletonData skeletonData, string skinName, bool nonessential);
		private Attachment ReadAttachment(Stream input, SkeletonData skeletonData, Skin skin, int slotIndex, string attachmentName, bool nonessential);
		private Vertices ReadVertices(Stream input, int vertexCount);
		private float[] ReadFloatArray(Stream input, int n, float scale);
		private int[] ReadShortArray(Stream input);
		private void ReadAnimation(string name, Stream input, SkeletonData skeletonData);
		private void ReadCurve(Stream input, int frameIndex, CurveTimeline timeline);
		private static sbyte ReadSByte(Stream input);
		private static bool ReadBoolean(Stream input);
		private float ReadFloat(Stream input);
		private static int ReadInt(Stream input);
		private static int ReadVarint(Stream input, bool optimizePositive);
		private string ReadString(Stream input);
		private static void ReadFully(Stream input, byte[] buffer, int offset, int length);
	}
}
