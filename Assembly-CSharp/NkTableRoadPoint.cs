using System;
using TsLibs;

public class NkTableRoadPoint : NrTableBase
{
	public NkTableRoadPoint(string strURL) : base(strURL)
	{
	}

	public override bool ParseDataFromNDT(TsDataReader dr)
	{
		return NrTSingleton<GxRoadPointManager>.Instance.ParseDataFromNDT(dr);
	}
}
