public class Phones
{
    ulong mobilePhone;
    ulong flatPhone;
    public ulong MobilePhone
    {
        get { return mobilePhone; }
        set
        {
            while (true)
            {
                if (value.ToString().Length < 11 || value.ToString().Length > 11)
                {
                    Console.WriteLine("Мобильный телефон состоит из 11 цифр, без \"+\"");
                    //continue;
                }
                //break;
            }
            if (value != 0)
            {
                ulong mobilePhone = value;
                //mobilePhone = phone.ToString("+# (###) ###-##-##");
            }
            else
            {
                mobilePhone = 0;
            }
        }
    }
    public ulong FlatPhone
    {
        get { return flatPhone; }
        set
        {
            while (true)
            {
                if (value.ToString().Length < 7 || value.ToString().Length > 7)
                {
                    Console.WriteLine("Городской телефон состоит из 7 цифр");
                }
                //break;
            }
            if (value.ToString() != String.Empty)
            {
                ulong flatPhone = Convert.ToUInt32(value);
                //flatPhone = phone.ToString("###-##-##");


                //Console.WriteLine(flatPhone);
            }

            else
            {
                mobilePhone = 0;
            }
        }
    }
    //public Phones(string mobilePhone, string flatPhone)
    //{
    //    MobilePhone = mobilePhone;
    //    FlatPhone = flatPhone;
    //}
    static public bool CheckPhone(string phone, byte phoneType)
    {
        if (phone.Length == phoneType)
        {
            return true;
        }

        return false;
    }
}