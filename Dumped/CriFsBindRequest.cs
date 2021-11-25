using System.Runtime.CompilerServices;

public class CriFsBindRequest : CriFsRequest
{
	public enum BindType
	{
		Cpk,
		Directory,
		File
	}

	public string path
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

	public uint bindId
	{
		[CompilerGenerated]
		get
		{
			return default(uint);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public CriFsBindRequest(BindType type, CriFsBinder targetBinder, CriFsBinder srcBinder, string path)
	{
	}

	public override void Stop()
	{
	}

	public override void Update()
	{
	}

	protected override void Dispose(bool disposing)
	{
	}
}
