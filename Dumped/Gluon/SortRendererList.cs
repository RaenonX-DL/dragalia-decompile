using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class SortRendererList : List<Renderer>
	{
		public int sortingOrder
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int sortingOrderOffset
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isEntryMaterial
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isManagerDestroy
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Dictionary<Material, Material> instanceMaterialsDictionary
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public void CreateInstanceMatearial(int setRenderQueue, bool isEntry, bool isDestroy)
		{
		}

		public void Destroy()
		{
		}

		public void SetVisible(bool enable)
		{
		}

		public void SetShader(Shader shader)
		{
		}

		public bool RemoveRenderer(Renderer r)
		{
			return default(bool);
		}
	}
}
