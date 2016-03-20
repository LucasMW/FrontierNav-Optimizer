using UnityEngine;
using System.Collections;

public enum Type
{
	basic,
	mining,
	research,
	combat,
	booster,
	duplicator
};
public class Probe  
{
	public Type type;
	public uint grade;

	public virtual double MiningMultiplier()
	{
		return 1.0 + (grade - 1) / 10.0;
	}
	public virtual double RevenueMultiplier()
	{
		return 1.0 + (grade - 1) / 10.0;
	}

}
