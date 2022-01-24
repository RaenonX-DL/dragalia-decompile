using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class InGameUIMatarialData
	{
		public string iconName
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

		public Material material
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

		public Sprite sprite
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

		public bool isLoaded
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

		private InGameUIMatarialData()
		{
		}

		public InGameUIMatarialData(string path, string iconName, bool isSync = false)
		{
		}

		~InGameUIMatarialData()
		{
		}

		public void Load(string path, string iconName, bool isSync)
		{
		}

		private void Load(string path, string iconName)
		{
		}

		private void LoadSync(string path, string iconName)
		{
		}

		public void Destroy()
		{
		}

		public void Destroy(Material material)
		{
		}

		public void Destroy(Sprite sprite)
		{
		}
	}
}
