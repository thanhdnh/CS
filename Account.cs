class Account
{
  public string username;
  public string phonenumber;
  public string status;
  public override string ToString()
  {
    return $"Account: username={username}, phone number={phonenumber}, status={status}";
  }
}