class Account
{
  public string username;
  public string phonenumber;
  public string status;
  public Account(string username, string phonenumber, string status){
    this.username = username;
    this.phonenumber = phonenumber;
    this.status = status;
  }
  public override string ToString()
  {
    return $"Account: username={username}, phone number={phonenumber}, status={status}";
  }
}