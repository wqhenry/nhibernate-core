//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: v1.1.4322
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

using System;

namespace NHibernate.DomainModel
{

 /// <summary>
 /// POJO for Sortable
 /// </summary>
 /// <remark>
 /// This class is autogenerated
 /// </remark>
 [Serializable]
 public class Sortable : IComparable
 {

	#region Fields
	/// <summary>
	/// Holder for id
	/// </summary>
	private Int32 _id;
	
	/// <summary>
	/// Holder for name
	/// </summary>
	private String _name;
	
	#endregion

	#region Constructors
	/// <summary>
	/// Default constructor for class Sortable
	/// </summary>
	public Sortable()
	{
	}
	
	/// <summary>
	/// Constructor for class Sortable
	/// </summary>
	/// <param name="name">Initial name value</param>
	public Sortable(String name)
	{
		this._name = name;
	}
	
	#endregion
	
	#region Properties
	/// <summary>
	/// Get/set for id
	/// </summary>
	public Int32 id
	{
		get
		{
			return this._id;
		}
		set
		{
			this._id = value;
		}
	}
	
	/// <summary>
	/// Get/set for name
	/// </summary>
	public String name
	{
		get
		{
			return this._name;
		}
		set
		{
			this._name = value;
		}
	}
	
	#endregion

	 #region IComparable Members

	 public int CompareTo(object obj)
	 {
			 return name.CompareTo( ( (Sortable) obj).name );
	 }

	 #endregion
 }
}