using UnityEngine;
using System.Collections;



public enum Ranking
{
	E,
	D,
	C,
	B,
	A,
	S
};
public class Site  //Miranium site
{
	public Ranking mining;
	public Ranking revenue;
	public Ranking combatSupport;
	public string name; //site indentifier

	public Probe placedProbe;

	public bool reached; // if the player has ever reached this site and placed a probe in it 

	//This things interfere but will add their calculations later
	public int sightSeeingMax;
	public int sightSeeingFound;

	public Site(string name, Ranking mining, Ranking revenue, Ranking combatSupport)
	{
		this.name = name;
		this.mining = mining;
		this.revenue = revenue;
		this.combatSupport = combatSupport;
	}


}
