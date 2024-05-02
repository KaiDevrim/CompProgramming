namespace CodeWars;

using System.Text;

public class ValidIP
{
    public static bool is_valid_IP(string ipAddres)
    {
        var octects = 0;
        var number = 0;
        var opos = 0;
        var kpos = 0;
        var lmao = 0;
        var xpos = new StringBuilder();
        if (ipAddres == "") return false;

        if (ipAddres.Contains(' ')) return false;

        if (ipAddres == "0.0.0.0") return true;

        if (ipAddres.EndsWith('.')) return false;

        if (ipAddres.StartsWith('0')) return false;

        if (ipAddres.StartsWith('.')) return false;
        foreach (var value in ipAddres)
        {
            if (char.IsWhiteSpace(value)) return false;

            if (value == '.')
            {
                octects++;
                if (octects > 3) return false;
                opos = 1;
                kpos = 0;
                lmao++;
                if (lmao > 1) return false;
            }

            if (value != '.')
            {
                lmao = 0;
                if (!int.TryParse(value.ToString(), out number)) return false;

                if (kpos == 0) xpos.Clear();

                kpos++;

                xpos.Append(number.ToString());

                if (int.Parse(xpos.ToString()) > 255) return false;

                if (int.Parse(xpos.ToString()) < 0) return false;

                if (opos == 1)
                {
                    if (number == 0) return false;
                    opos = 0;
                }
            }
        }

        if (octects < 3) return false;
        return true;
    }
}