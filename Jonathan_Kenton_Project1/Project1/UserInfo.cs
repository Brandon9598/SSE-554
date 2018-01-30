using System;

public class UserInfo
{
    public string UserName;
    public string StreetAddress;
    public string CityStateZip;

    public UserInfo(string UserName, string StreetAddress, string CityStateZip)
	{
        this.UserName = UserName;
        this.StreetAddress = StreetAddress;
        this.CityStateZip = CityStateZip;
    }
}
