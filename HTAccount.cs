using System.Collections;
class HTAccount
{
  Hashtable info = new Hashtable();
  public HTAccount(string username, string phonenumber, string status)
  {
    info["username"] = username;
    info["phonenumber"] = phonenumber;
    info.Add("status", status);
  }
  public override string ToString()
  {
    return $"Account: username={info["username"]}, phone number={info["phonenumber"]}, status={info["status"]}";
  }
}