using System.Runtime.CompilerServices;

namespace Gluon
{
	public struct MapCell
	{
		public Facility facility;

		public int enableLevel
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

		public int posY
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

		public bool isPutted
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public MapCell(int level, int y, bool putted)
		{
		}
	}
}
