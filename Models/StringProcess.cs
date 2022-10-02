using Microsoft.AspNetCore.Mvc;
namespace BaiTap_B6.Models;
public class StringProcess
{
    public string RemoveReaminingWhiteSpace(string strInput)
    {
        string strResult = "";
        strInput = strInput.Trim();
        while(strInput.IndexOf("  ")>0)
        {
            strInput = strInput.Replace("  "," ");
        }
        strResult = strInput;
        return strResult;
    }
    public string LowerToUper(string strInput)
    {
        string strResult = "";
        return strResult;

    }
    
}