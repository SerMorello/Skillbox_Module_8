using System.Text.RegularExpressions;
public class Phones
{
    string mobilePhone;
    string flatPhone;

    public string MobilePhone
    {
        get { return mobilePhone; }
        set
        {
            value = EditPhoneNumber(value);

            while (!CheckPhone(value, 11))
            {
                Console.WriteLine("Мобильный телефон состоит из 11 цифр, без \"+\"");
                value = Console.ReadLine();

            }

            if (value != string.Empty)
            {
                ulong phone = Convert.ToUInt64(value);
                mobilePhone = phone.ToString("+# (###) ###-##-##");
            }
            else
            {
                mobilePhone = value;
            }
        }
    }
    public string FlatPhone
    {
        get { return flatPhone; }
        set
        {
            value = EditPhoneNumber(value);

            while (!CheckPhone(value, 7))
            {
                Console.WriteLine("Городской телефон состоит из 7 цифр");
                value = Console.ReadLine();
            }

            if (value != String.Empty)
            {
                uint phone = Convert.ToUInt32(value);
                flatPhone = phone.ToString("###-##-##");
            }
            else
            {
                mobilePhone = value;
            }
        }
    }

    static private bool CheckPhone(string phone, byte phoneType)
    {
        if (phone.Length == phoneType || phone == string.Empty)
        {
            return true;
        }

        return false;
    }
    static string EditPhoneNumber(string phoneNumber)
    {
        string pattern = @"\D";
        Regex rg = new Regex(pattern);
        phoneNumber = rg.Replace(phoneNumber, "");
        return phoneNumber;
    }
}