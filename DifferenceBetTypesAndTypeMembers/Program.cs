using System;

public class Customer
{
    #region Fields
    private int _id;
    private string _FirstName;
    private string _LastName;
    #endregion

    #region Properties
    public int Id
    {
        get { return _id; } 
        set { _id = value; }
    }
    public string FirstName
    {
        get { return _FirstName; }
        set { _FirstName = value; }
    }
    public string LastName
    {
        get { return _LastName; }
        set { _LastName = value; }
    }
    #endregion

    #region Methods
    public string GetFullName() //method
    {
        return this.FirstName + " " + this.LastName;
    }
    #endregion
}