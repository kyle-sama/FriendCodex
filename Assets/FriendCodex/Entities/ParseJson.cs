using UnityEngine;
using System.Collections;
using System.Text;
using System.IO;
using LitJson;

namespace AssemblyCSharp.Entities
{
public class ParseJson : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
/*
 *  to read from file
 * ProcessTypes (loadJsonFile("filename");
 * no extension for filename needed
*/
	private TypeNameTools tools;

	public ParseJson()
	{
		tools = new TypeNameTools ();
	}
	public string loadJsonFile(string fileName)
	{
		string line;
		string file = "";
		StreamReader theReader = new StreamReader(fileName, Encoding.Default);
		
		using (theReader)
		{
			// While there's lines left in the text file, do this:
			do
			{
				line = theReader.ReadLine();
				
				if (line != null)
				{
					//Add  all lines to the file string
					file+=line;
				}
			}
			while (line != null);
			
			// Done reading, close the reader and return true to broadcast success    
			theReader.Close();
			
		}
		//Print out file to console
		Debug.Log (file);
		return file;
	}

	public void ProcessTypes(string jsonString)
	{
		JsonData jsontypes = JsonMapper.ToObject(jsonString);
		
		for(int i = 0; i<jsontypes["Types"].Count; i++)
		{
			FriendType friendType= new FriendType();
			//Get current type as string and convert to enum
			friendType.TypeName = tools.StringToEnum[(jsontypes["Types"][i]["type"].ToString()).ToLower()];
			
			//Get list of types strong against, convert each to enum
			for(int j = 0; j<jsontypes["Types"][i]["strong_against"].Count; j++)
			{
				friendType.StrongAgainst.Add(tools.StringToEnum[jsontypes["Types"][i]["strong_against"][j].ToString().ToLower()]);
			}
			
			//Get list of types weak against, convert each to enum
			for(int j = 0; j<jsontypes["Types"][i]["weak_against"].Count; j++)
			{
				friendType.WeakAgainst.Add(tools.StringToEnum [jsontypes["Types"][i]["weak_against"][j].ToString().ToLower()]);
			}
			
		}
	}
	
	}
}