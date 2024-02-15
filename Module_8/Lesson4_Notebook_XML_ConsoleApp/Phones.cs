public class Phones
{
    string mobilePhone;
    string flatPhone;
    public string MobilePhone
    {
        get { return mobilePhone; }
        set
        {
            mobilePhone = string.Format($"{value:+# (###) ###-##-##}");
        }
    }
    public string FlatPhone
    {
        get { return flatPhone;}
        set
        {
            flatPhone = string.Format($"{value:###-##-##}");
        }
    }
}