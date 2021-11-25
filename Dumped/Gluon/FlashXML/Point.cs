using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Gluon.FlashXML
{
	[XmlRoot]
	public class Point
	{
		[XmlAttribute]
		public float x
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[XmlAttribute]
		public float y
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
