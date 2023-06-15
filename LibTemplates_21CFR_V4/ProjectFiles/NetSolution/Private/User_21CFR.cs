using System;
using UAManagedCore;

//-------------------------------------------
// WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
//-------------------------------------------

[MapType(NamespaceUri = "LibTemplates_21CFR_V4", Guid = "fa0696734c8c8356ac24bb2c3b892eb5")]
public class User_21CFR : FTOptix.Core.User
{
#region Children properties
    //-------------------------------------------
    // WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
    //-------------------------------------------
    public bool Change_Password_On_Next_Login
    {
        get
        {
            return (bool)Refs.GetVariable("Change_Password_On_Next_Login").Value.Value;
        }
        set
        {
            Refs.GetVariable("Change_Password_On_Next_Login").SetValue(value);
        }
    }
    public IUAVariable Change_Password_On_Next_LoginVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Change_Password_On_Next_Login");
        }
    }
    public bool User_Blocked
    {
        get
        {
            return (bool)Refs.GetVariable("User_Blocked").Value.Value;
        }
        set
        {
            Refs.GetVariable("User_Blocked").SetValue(value);
        }
    }
    public IUAVariable User_BlockedVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("User_Blocked");
        }
    }
    public DateTime Password_Creation_Date
    {
        get
        {
            return (DateTime)Refs.GetVariable("Password_Creation_Date").Value.Value;
        }
        set
        {
            Refs.GetVariable("Password_Creation_Date").SetValue(value);
        }
    }
    public IUAVariable Password_Creation_DateVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Password_Creation_Date");
        }
    }
    public int Invalid_Login_Attempts
    {
        get
        {
            return (int)Refs.GetVariable("Invalid_Login_Attempts").Value.Value;
        }
        set
        {
            Refs.GetVariable("Invalid_Login_Attempts").SetValue(value);
        }
    }
    public IUAVariable Invalid_Login_AttemptsVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Invalid_Login_Attempts");
        }
    }
    public bool User_Active
    {
        get
        {
            return (bool)Refs.GetVariable("User_Active").Value.Value;
        }
        set
        {
            Refs.GetVariable("User_Active").SetValue(value);
        }
    }
    public IUAVariable User_ActiveVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("User_Active");
        }
    }
#endregion
}
