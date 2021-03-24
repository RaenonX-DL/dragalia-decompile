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
	public class SkeletonJson
	{
		// Fields
		[CompilerGenerated]
		private float _Scale_k__BackingField;
		private AttachmentLoader attachmentLoader;
		private List<LinkedMesh> linkedMeshes;
	
		// Properties
		public float Scale { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		internal class LinkedMesh
		{
			// Fields
			internal string parent;
			internal string skin;
			internal int slotIndex;
			internal MeshAttachment mesh;
	
			// Constructors
			public LinkedMesh(MeshAttachment mesh, string skin, int slotIndex, string parent);
		}
	
		// Constructors
		public SkeletonJson(params Atlas[] atlasArray);
		public SkeletonJson(AttachmentLoader attachmentLoader);
	
		// Methods
		public SkeletonData ReadSkeletonData(string path);
		public SkeletonData ReadSkeletonData(TextReader reader);
		private Attachment ReadAttachment(Dictionary<string, object> map, Skin skin, int slotIndex, string name, SkeletonData skeletonData);
		private void ReadVertices(Dictionary<string, object> map, VertexAttachment attachment, int verticesLength);
		private void ReadAnimation(Dictionary<string, object> map, string name, SkeletonData skeletonData);
		private static void ReadCurve(Dictionary<string, object> valueMap, CurveTimeline timeline, int frameIndex);
		private static float[] GetFloatArray(Dictionary<string, object> map, string name, float scale);
		private static int[] GetIntArray(Dictionary<string, object> map, string name);
		private static float GetFloat(Dictionary<string, object> map, string name, float defaultValue);
		private static int GetInt(Dictionary<string, object> map, string name, int defaultValue);
		private static bool GetBoolean(Dictionary<string, object> map, string name, bool defaultValue);
		private static string GetString(Dictionary<string, object> map, string name, string defaultValue);
		private static float ToColor(string hexString, int colorIndex, int expectedLength = 8);
	}
}
