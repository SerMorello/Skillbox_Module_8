public class Phones
{
    string mobilePhone;
    string flatPhone;
    public string MobilePhone
    {
        get { return mobilePhone; }
        set
        {
            if (mobilePhone != String.Empty)
            {
                mobilePhone = string.Format($"{value:+# (###) ###-##-##}");
            }
            else
            {
                mobilePhone = "";
            }
        }
    }
    public string FlatPhone
    {
        get { return flatPhone; }
        set
        {
            if (value != String.Empty)
            {
                flatPhone = string.Format($"{value:###-##-##}");
            }
            else
            {
                flatPhone = "";
            }
        }
    }
    public Phones(string mobilePhone, string flatPhone)
    {
        MobilePhone = mobilePhone;
        FlatPhone = flatPhone;
    }
}